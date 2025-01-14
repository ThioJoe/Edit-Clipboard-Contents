using Microsoft.SqlServer.Management.HadrData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation;
using System.IO;
using Windows.Storage.Streams;
using System.Threading;

#nullable enable

namespace EditClipboardContents;

// See: https://learn.microsoft.com/en-us/uwp/api/windows.applicationmodel.datatransfer.clipboard?view=winrt-26100

public partial class HistoryForm : Form
{
    public static SortableBindingList<HistoryItemInfo> HistoryItems = new SortableBindingList<HistoryItemInfo>();
    public static bool IsHistoryEnabled => Windows.ApplicationModel.DataTransfer.Clipboard.IsHistoryEnabled();
    public static int HistoryItemCount = 0;
    public static string CurrentActiveHistoryItemGUID = "";
    public HistoryItemInfo? CurrentlyShownHistoryItem = null;

    private static Color defaultCellForeColor;

    // Alias for DPI scaling compensation
    int dpi(int value) => MainForm.CompensateDPIStatic(value);

    public HistoryForm()
    {
        InitializeComponent();
        defaultCellForeColor = dataGridViewHistory.DefaultCellStyle.ForeColor;

        InitializeDataGridView();

        Windows.ApplicationModel.DataTransfer.Clipboard.HistoryEnabledChanged += OnHistoryEnabledChanged;
        dataGridViewHistory.MouseWheel += new MouseEventHandler(dataGridViewClipboard_MouseWheel);

        // Get initial status
        OnHistoryEnabledChanged(null, null);

        RefreshClipboardHistory();
    }

    private async void RefreshClipboardHistory()
    {
        // Gets the history items from the clipboard
        ClipboardHistoryItemsResult result = await ConvertToTask(Windows.ApplicationModel.DataTransfer.Clipboard.GetHistoryItemsAsync());
        IReadOnlyList<ClipboardHistoryItem> historyItemsRaw = result.Items;
        // Take note of the current selected item so we can reselect it after refreshing
        List<string> IdsToSelectAfter = GetSelectedHistoryItems().Select(x => x.Id).ToList();

        try
        {
            // Suspends the layout and painting of the control
            dataGridViewHistory.SuspendLayout();
            dataGridViewHistory.Visible = false;  // Hide the grid while updating

            // Create a new list without clearing the old one first
            var newHistoryItems = new SortableBindingList<HistoryItemInfo>();
            int count = 0;
            foreach ( var item in historyItemsRaw )
            {
                newHistoryItems.Add(ConstructHistoryItem(item, count));
                count++;
            }
            HistoryItemCount = count;

            // Only update the DataSource if it's different
            if ( dataGridViewHistory.DataSource == null || !HistoryItems.SequenceEqual(newHistoryItems) )
            {
                // Set the new binding list all at once
                HistoryItems = newHistoryItems;
                dataGridViewHistory.DataSource = HistoryItems;
            }

            UpdateActiveHistoryItem();

            // Reselect the last selected item
            if ( IdsToSelectAfter.Count > 0 )
            {
                dataGridViewHistory.ClearSelection();
                foreach ( DataGridViewRow row in dataGridViewHistory.Rows )
                {
                    HistoryItemInfo item = (HistoryItemInfo)row.DataBoundItem;
                    if ( IdsToSelectAfter.Contains(item.Id) )
                    {
                        row.Selected = true;
                    }
                }
            }
        }
        finally
        {
            // Always ensure we resume the layout and show the grid
            dataGridViewHistory.Visible = true;
            dataGridViewHistory.ResumeLayout();
        }
    }

    private string GetActiveHistoryItemGUID()
    {
        var dataObj = System.Windows.Forms.Clipboard.GetDataObject();
        string guid = "";
        // Get the formats from the data object
        string[] formats = dataObj.GetFormats();

        // Check if the data object contains the GUID of the active history item
        if ( formats.Contains("ClipboardHistoryItemId") )
        {
            // Get the data and check its type
            var data = dataObj.GetData("ClipboardHistoryItemId");
            if ( data is string idString )
            {
                guid = idString;
            }
            else if ( data is MemoryStream memoryStream )
            {
                memoryStream.Position = 0; // Reset position to the beginning
                using ( StreamReader reader = new StreamReader(memoryStream, Encoding.Unicode) )
                {
                    guid = reader.ReadToEnd();
                }
                guid = guid.Trim('\0'); // Remove any trailing null characters
            }
        }
        CurrentActiveHistoryItemGUID = guid;

        return guid;
    }

    private void InitializeDataGridView()
    {
        dataGridViewHistory.AutoGenerateColumns = false;
        dataGridViewHistory.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = nameof(HistoryItemInfo.OriginalIndex), Name = colName.Index, HeaderText = "", Width = dpi(25) });
        dataGridViewHistory.Columns.Add(new DataGridViewTextBoxColumn { Name = colName.Active, HeaderText = "Active", Width = dpi(40)});
        dataGridViewHistory.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = nameof(HistoryItemInfo.FormatCount), Name = colName.FormatCount, HeaderText = "# Formats", Width = dpi(60) });
        dataGridViewHistory.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = nameof(HistoryItemInfo.Id), Name = colName.UniqueID, HeaderText = "ID", Visible = false });
        dataGridViewHistory.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = nameof(HistoryItemInfo.TextContent), Name = colName.TextPreview, HeaderText = "Text Preview" });

        // Datagridview options
        dataGridViewHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dataGridViewHistory.RowHeadersVisible = false;
        dataGridViewHistory.Columns[colName.FormatCount].HeaderCell.Style.WrapMode = DataGridViewTriState.False;
        //dataGridViewHistory.ShowCellToolTips = false;

        // Alignment - Headers
        dataGridViewHistory.Columns[colName.Active].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
        dataGridViewHistory.Columns[colName.Index].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
        dataGridViewHistory.Columns[colName.FormatCount].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
        dataGridViewHistory.Columns[colName.TextPreview].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomLeft;
        // Alignment - Cells
        dataGridViewHistory.Columns[colName.Active].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dataGridViewHistory.Columns[colName.FormatCount].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        // Individual column settings
        dataGridViewHistory.Columns[colName.TextPreview].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        dataGridViewHistory.Columns[colName.Active].ToolTipText = "Whether a history item is the current active clipboard item.";
        dataGridViewHistory.Columns[colName.FormatCount].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

        // Add event handlers
        dataGridViewHistory.SelectionChanged += OnGridSelectionChange;

        // Do not do this here, wait until we have the data, otherwise it will show hidden columns despite Visible = false
        //dataGridViewHistory.DataSource = HistoryItems; 

        dataGridViewHistory.PerformLayout();
    }


    private void OnGridSelectionChange(object? sender , EventArgs e)
    {
        pictureBoxFormatContents.Visible = false;
        textBoxHistoryContents.Visible = true;

        if ( dataGridViewHistory.SelectedRows.Count > 0 )
        {
            DataGridViewRow selectedRow = dataGridViewHistory.SelectedRows[0];
            HistoryItemInfo item = (HistoryItemInfo)selectedRow.DataBoundItem;
            labelIndex.Text = item.OriginalIndex.ToString();
            labelHistoryGUID.Text = item.Id;
            //textBoxHistoryContents.Text = item.TextContent; // This will automatically be handled when we set the selection

            CurrentlyShownHistoryItem = item;

            // Populate the list view with available formats
            listViewAvailableFormats.Items.Clear();
            foreach ( string format in item.AvailableFormats )
            {
                listViewAvailableFormats.Items.Add(format);
            }

            // Select the first item in the list view
            if ( item.AvailableFormats.Count > 0 )
            {
                listViewAvailableFormats.Items[0].Selected = true;
                UpdateFormatContentDisplay();
            }

            buttonDeleteHistoryItem.Enabled = true;
            buttonSetActiveHistoryItem.Enabled = true;
        }
        else
        {
            labelIndex.Text = "";
            //labelAvailableFormats.Text = "";
            labelHistoryGUID.Text = "";
            textBoxHistoryContents.Text = "";
            listViewAvailableFormats.Items.Clear();

            CurrentlyShownHistoryItem = null;

            buttonDeleteHistoryItem.Enabled = false;
            buttonSetActiveHistoryItem.Enabled = false;
        }
    }

    private void UpdateActiveHistoryItem()
    {
        string activeHistoryId = GetActiveHistoryItemGUID();

        // Set the color of the active history item to green and text to checkmark, the rest default
        foreach ( DataGridViewRow row in dataGridViewHistory.Rows )
        {
            HistoryItemInfo item = (HistoryItemInfo)row.DataBoundItem;
            if ( item.Id == activeHistoryId )
            {
                row.DefaultCellStyle.ForeColor = Color.Green;
                row.Cells[colName.Active].Value = MyStrings.Check;
            }
            else
            {
                row.DefaultCellStyle.ForeColor = defaultCellForeColor;
                row.Cells[colName.Active].Value = "";
            }
        }
    }

    public static HistoryItemInfo ConstructHistoryItem(ClipboardHistoryItem item, int index)
    {
        var content = item.Content;
        var properties = new Dictionary<string, object>();

        foreach ( var property in content.Properties )
        {
            properties[property.Key] = property.Value;
        }

        var clipboardItem = new HistoryItemInfo
        {
            Id = item.Id,
            Properties = properties,
            AvailableFormats = content.AvailableFormats.ToList(),
            OriginalIndex = index,
            OriginalObject = item
        };

        if ( content.Contains(StandardDataFormats.Text) )
        {
            clipboardItem.TextContent = ConvertToTask(content.GetTextAsync()).GetAwaiter().GetResult();
        }
        else
        {
            clipboardItem.TextContent = "";
        }

        return clipboardItem;
    }

    private List<HistoryItemInfo> GetSelectedHistoryItems()
    {
        var itemList = new List<HistoryItemInfo>();

        // Get the current selected item in the grid view
        DataGridViewSelectedRowCollection selectedRows = dataGridViewHistory.SelectedRows;

        if ( selectedRows == null || selectedRows.Count <= 0) {
            return itemList;
        }

        foreach ( DataGridViewRow row in selectedRows )
        {
            HistoryItemInfo? selectedHistoryItemInfo = (HistoryItemInfo)row.DataBoundItem;
            if ( selectedHistoryItemInfo != null )
            {
                itemList.Add(selectedHistoryItemInfo);
            }
        }

        // Order by index
        itemList = itemList.OrderBy(x => x.OriginalIndex).ToList();

        return itemList;
    }

    private void UpdateFormatContentDisplay()
    {
        pictureBoxFormatContents.Visible = false;
        textBoxHistoryContents.Visible = true;

        if ( listViewAvailableFormats.SelectedItems.Count <= 0 )
            return;

        string selectedFormat = listViewAvailableFormats.SelectedItems[0].Text;
        if ( selectedFormat == null || CurrentlyShownHistoryItem == null )
            return;

        ClipboardHistoryItem? historyObj = CurrentlyShownHistoryItem.OriginalObject;
        if ( historyObj == null )
            return;

        if ( !historyObj.Content.Contains(selectedFormat) )
            return;

        // -------------------------- Get the data --------------------------

        if ( selectedFormat == StandardDataFormats.Bitmap )
        {
            labelHeaderContents.Text = $"{selectedFormat} - Format Contents:";
            textBoxHistoryContents.Text = "";

            RandomAccessStreamReference bitmapData = ConvertToTask(historyObj.Content.GetBitmapAsync()).GetAwaiter().GetResult();

            // Open the stream with proper WinRT async handling
            var openOperation = bitmapData.OpenReadAsync();
            ManualResetEvent waitHandle = new ManualResetEvent(false);
            openOperation.Completed = (asyncInfo, asyncStatus) =>
            {
                waitHandle.Set();
            };
            waitHandle.WaitOne();

            IRandomAccessStream stream = openOperation.GetResults();
            var memStream = new MemoryStream();

            IInputStream inputStream = stream.GetInputStreamAt(0);
            DataReader reader = new DataReader(inputStream);

            var loadOperation = reader.LoadAsync((uint)stream.Size);
            waitHandle.Reset();  // Reuse the wait handle
            loadOperation.Completed = (asyncInfo, asyncStatus) =>
            {
                waitHandle.Set();
            };
            waitHandle.WaitOne();

            byte[] bytes = new byte[stream.Size];
            reader.ReadBytes(bytes);
            memStream.Write(bytes, 0, bytes.Length);
            memStream.Position = 0;

            pictureBoxFormatContents.Image = Image.FromStream(memStream);

            pictureBoxFormatContents.Visible = true;
            textBoxHistoryContents.Visible = false;
        }
        else
        {
            labelHeaderContents.Text = $"{selectedFormat} - Format Contents As Text:";

            object data = ConvertToTask(historyObj.Content.GetDataAsync(selectedFormat)).GetAwaiter().GetResult();
            if ( data != null )
            {
                if ( data is IRandomAccessStream streamContent )
                {
                    IInputStream inputStream = streamContent.GetInputStreamAt(0);
                    DataReader reader = new DataReader(inputStream);

                    // Create manual wait handle for the load operation
                    DataReaderLoadOperation loadOperation = reader.LoadAsync((uint)streamContent.Size);
                    ManualResetEvent waitHandle = new ManualResetEvent(false);
                    loadOperation.Completed = (asyncInfo, asyncStatus) =>
                    {
                        waitHandle.Set();
                    };
                    waitHandle.WaitOne();

                    byte[] bytes = new byte[streamContent.Size];
                    reader.ReadBytes(bytes);

                    string guidString = Encoding.Unicode.GetString(bytes);
                    textBoxHistoryContents.Text = guidString;

                    reader.Dispose();
                    inputStream.Dispose();
                }
                else if ( data is RandomAccessStreamReference streamRef )
                {
                    var openOperation = streamRef.OpenReadAsync();
                    ManualResetEvent waitHandle = new ManualResetEvent(false);
                    openOperation.Completed = (asyncInfo, asyncStatus) =>
                    {
                        waitHandle.Set();
                    };
                    waitHandle.WaitOne();

                    IRandomAccessStream stream = openOperation.GetResults();
                    IInputStream inputStream = stream.GetInputStreamAt(0);
                    DataReader reader = new DataReader(inputStream);

                    var loadOperation = reader.LoadAsync((uint)stream.Size);
                    waitHandle.Reset();
                    loadOperation.Completed = (asyncInfo, asyncStatus) =>
                    {
                        waitHandle.Set();
                    };
                    waitHandle.WaitOne();

                    byte[] bytes = new byte[stream.Size];
                    reader.ReadBytes(bytes);

                    string guidString = Encoding.Unicode.GetString(bytes);
                    textBoxHistoryContents.Text = guidString;

                    reader.Dispose();
                    inputStream.Dispose();
                    stream.Dispose();
                }
                else
                {
                    textBoxHistoryContents.Text = data.ToString();
                }
            }
        }
    }

    private static Task<T> ConvertToTask<T>(IAsyncOperation<T> operation)
    {
        var tcs = new TaskCompletionSource<T>();
        operation.Completed = (op, status) =>
        {
            if ( status == AsyncStatus.Completed )
            {
                tcs.SetResult(op.GetResults());
            }
            else if ( status == AsyncStatus.Error )
            {
                tcs.SetException(op.ErrorCode);
            }
            else if ( status == AsyncStatus.Canceled )
            {
                tcs.SetCanceled();
            }
        };
        return tcs.Task;
    }

    private static class MyStrings
    {
        public const string Check = "✔";
    }

    public class HistoryItemInfo
    {
        public string Id { get; set; } = "";
        public int OriginalIndex { get; set; } = -1;
        public Dictionary<string, object> Properties { get; set; } = [];
        public string TextContent { get; set; } = "";
        public List<string> AvailableFormats { get; set; } = [];
        public ClipboardHistoryItem? OriginalObject { get; set; } = null;
        public int FormatCount => AvailableFormats.Count;
    }

    // -------------------------- Event Handlers --------------------------

    private void OnHistoryEnabledChanged(object? sender, object? e)
    {
        if ( IsHistoryEnabled )
        {
            labelHistoryStatus.Text = "Clipboard History Enabled";
            labelHistoryStatus.ForeColor = Color.Green;
        }
        else
        {
            labelHistoryStatus.Text = "Clipboard History Disabled";
            labelHistoryStatus.ForeColor = Color.Red;
        }
    }

    private void OnFormatsListViewSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
    {
        UpdateFormatContentDisplay();
    }

    // -------------------------- GUI Button Event Handlers --------------------------

    private void buttonRefreshHistory_Click(object sender, EventArgs e)
    {
        if (IsHistoryEnabled)
        { 
            RefreshClipboardHistory();
        }
        else
        {
            MessageBox.Show("Clipboard History is not enabled. Please enable it first by pressing:\nWin + V.");
        }
    }

    private void buttonSetActiveHistoryItem_Click(object sender, EventArgs e)
    {
        // Get the current selected item in the grid view
        List<HistoryItemInfo> historyList = GetSelectedHistoryItems();

        if ( historyList.Count > 1 )
        {
            MessageBox.Show("You can only make a single history item the active clipboard item. Select only 1.", "Too Many Selections", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
        else if ( historyList.Count == 0 ) // The button should be disabled if none selected, but put a return just in case
        {
            return;
        }

        // There should be exactly 1 item at this point
        HistoryItemInfo selectedHistoryItemInfo = historyList[0];

        ClipboardHistoryItem? historyObj = null;
        if ( selectedHistoryItemInfo != null ) { 
            historyObj = selectedHistoryItemInfo.OriginalObject;
        }

        if ( historyObj != null )
        {
            Windows.ApplicationModel.DataTransfer.Clipboard.SetHistoryItemAsContent(historyObj);
        }

        // Ensure the history item is set as the active item
        UpdateActiveHistoryItem();
        RefreshClipboardHistory();
    }

    private void buttonDeleteHistoryItem_Click(object sender, EventArgs e)
    {
        // Get the current selected item in the grid view
        List<HistoryItemInfo> historyList = GetSelectedHistoryItems();

        if ( historyList.Count == 0 )
        {
            return;
        }

        // Take note of the item after last selected item so we can set that as the new selected item after deletion
        string IdToSelectAfter;
        int indexAfterlastSelectedIndex = historyList.Last().OriginalIndex + 1;
        HistoryItemInfo? selectedItem = HistoryItems.FirstOrDefault(x => x.OriginalIndex == indexAfterlastSelectedIndex);

        if ( selectedItem == null )
        {
            IdToSelectAfter = "";
        }
        else
        {
            IdToSelectAfter = selectedItem.Id;
        }

        // Loops through the selected history items and deletes them all
        foreach ( HistoryItemInfo historyItem in historyList )
        {
            if ( historyItem.OriginalObject != null )
            {
                Windows.ApplicationModel.DataTransfer.Clipboard.DeleteItemFromHistory(historyItem.OriginalObject);
            }
        }

        // Disable GUI update of the history list while deleting to avoid flickering
        dataGridViewHistory.SuspendLayout();

        // Refresh the history list
        RefreshClipboardHistory();

        // Reselect the last selected item
        foreach ( DataGridViewRow row in dataGridViewHistory.Rows )
        {
            HistoryItemInfo item = (HistoryItemInfo)row.DataBoundItem;
            if ( item.Id == IdToSelectAfter )
            {
                dataGridViewHistory.ClearSelection();
                row.Selected = true;
                break;
            }
        }

        dataGridViewHistory.ResumeLayout();
    }

    private void dataGridViewClipboard_MouseWheel(object sender, MouseEventArgs e)
    {
        dataGridMouseScrollSelector(sender, e, dataGridViewHistory);
    }

    private void dataGridMouseScrollSelector(object sender, MouseEventArgs e, DataGridView currentDataGridView)
    {
        if ( ((HandledMouseEventArgs)e).Handled == true )
        {
            return;
        }

        // Determine direction: -1 for up, 1 for down
        int direction = e.Delta > 0 ? -1 : 1;

        // Get current selected row index
        int currentIndex = dataGridViewHistory.CurrentCell?.RowIndex ?? -1;

        if ( currentIndex != -1 )
        {
            // Calculate new index
            int newIndex = currentIndex + direction;

            // Ensure new index is within bounds
            int rowCount = dataGridViewHistory.Rows.Count;
            if ( newIndex < 0 )
            {
                newIndex = 0;
            }
            else if ( newIndex >= rowCount )
            {
                newIndex = rowCount - 1;
            }

            // If the index has changed, update selection
            if ( newIndex != currentIndex || newIndex <= dataGridViewHistory.Rows.Count )
            {
                int focusedCellIndex = dataGridViewHistory.CurrentCell?.ColumnIndex ?? 0;

                dataGridViewHistory.ClearSelection();
                dataGridViewHistory.Rows[newIndex].Selected = true;
                dataGridViewHistory.CurrentCell = dataGridViewHistory.Rows[newIndex].Cells[focusedCellIndex];

                // Scroll to the new index, but only if it's not already visible
                if ( newIndex < dataGridViewHistory.FirstDisplayedScrollingRowIndex
                    || newIndex >= dataGridViewHistory.FirstDisplayedScrollingRowIndex + dataGridViewHistory.DisplayedRowCount(false) )
                {
                    dataGridViewHistory.FirstDisplayedScrollingRowIndex = newIndex;
                }
            }
        }

        // Mark as handled because the event might get fired multiple times per scroll
        ((HandledMouseEventArgs)e).Handled = true;
    }
}
