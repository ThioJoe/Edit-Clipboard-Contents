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
using System.Windows.Forms;
using System.IO;

#nullable enable

namespace EditClipboardContents;

// See: https://learn.microsoft.com/en-us/uwp/api/windows.applicationmodel.datatransfer.clipboard?view=winrt-26100

public partial class HistoryForm : Form
{
    public static SortableBindingList<HistoryItemInfo> HistoryItems = new SortableBindingList<HistoryItemInfo>();
    public static bool IsHistoryEnabled => Windows.ApplicationModel.DataTransfer.Clipboard.IsHistoryEnabled();
    public static int HistoryItemCount = 0;
    public static string CurrentActiveHistoryItemGUID = "";

    private static Color defaultCellForeColor;

    // Alias for DPI scaling compensation
    int dpi(int value) => MainForm.CompensateDPIStatic(value);

    public HistoryForm()
    {
        InitializeComponent();
        defaultCellForeColor = dataGridViewHistory.DefaultCellStyle.ForeColor;

        InitializeDataGridView();

        Windows.ApplicationModel.DataTransfer.Clipboard.HistoryEnabledChanged += OnHistoryEnabledChanged;

        // Get initial status
        OnHistoryEnabledChanged(null, null);

        RefreshClipboardHistory();
    }

    private async void RefreshClipboardHistory()
    {
        ClipboardHistoryItemsResult result = await ConvertToTask(Windows.ApplicationModel.DataTransfer.Clipboard.GetHistoryItemsAsync());
        IReadOnlyList<ClipboardHistoryItem> historyItemsRaw = result.Items;

        HistoryItems.Clear();
        int count = 0;
        foreach ( var item in historyItemsRaw )
        {
            HistoryItems.Add(ConstructHistoryItem(item, count));
            count++;
        }

        HistoryItemCount = count;
        dataGridViewHistory.DataSource = HistoryItems;

        UpdateActiveHistoryItem();
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
            if ( data is string )
            {
                guid = (string)data;
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
        dataGridViewHistory.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = nameof(HistoryItemInfo.Id), Name = colName.UniqueID, HeaderText = "ID", Visible = false });
        dataGridViewHistory.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = nameof(HistoryItemInfo.OriginalIndex), Name = colName.Index, HeaderText = "#", Width = dpi(25)});
        dataGridViewHistory.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = nameof(HistoryItemInfo.TextContent), Name = colName.TextPreview, HeaderText = "Text Preview" });

        // Set options for the DataGridView
        dataGridViewHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dataGridViewHistory.RowHeadersWidth = dpi(20);

        // Selection change event handler to update the details on the side for the selected history item
        dataGridViewHistory.SelectionChanged += (sender, e) =>
        {
            if ( dataGridViewHistory.SelectedRows.Count > 0 )
            {
                DataGridViewRow selectedRow = dataGridViewHistory.SelectedRows[0];
                HistoryItemInfo item = (HistoryItemInfo)selectedRow.DataBoundItem;
                labelIndex.Text = item.OriginalIndex.ToString();
                labelAvailableFormats.Text = string.Join("\n", item.AvailableFormats);
                labelHistoryGUID.Text = item.Id;
                textBoxHistoryContents.Text = item.TextContent;
            }
        };

        //dataGridViewHistory.DataSource = HistoryItems; // Do not do this here, wait until we have the data, otherwise it will show hidden columns despite Visible = false
    }

    private void UpdateActiveHistoryItem()
    {
        string activeHistoryId = GetActiveHistoryItemGUID();

        // Set the color of the active history item to green, the rest default
        foreach ( DataGridViewRow row in dataGridViewHistory.Rows )
        {
            HistoryItemInfo item = (HistoryItemInfo)row.DataBoundItem;
            if ( item.Id == activeHistoryId )
            {
                row.DefaultCellStyle.ForeColor = Color.Green;
            }
            else
            {
                row.DefaultCellStyle.ForeColor = defaultCellForeColor;
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

    private static HistoryItemInfo GetSelectedHistoryObject()
    {

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

    public class HistoryItemInfo
    {
        public string Id { get; set; } = "";
        public int OriginalIndex { get; set; } = -1;
        public Dictionary<string, object> Properties { get; set; } = [];
        public string TextContent { get; set; } = "";
        public List<string> AvailableFormats { get; set; } = [];
        public ClipboardHistoryItem? OriginalObject { get; set; } = null;
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

    // -------------------------- GUI Event Handlers --------------------------

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
        var selectedRow = dataGridViewHistory.SelectedRows[0];
        HistoryItemInfo? selectedHistoryItemInfo = (HistoryItemInfo)selectedRow.DataBoundItem;

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
    }

    private void buttonDeleteHistoryItem_Click(object sender, EventArgs e)
    {

    }
}
