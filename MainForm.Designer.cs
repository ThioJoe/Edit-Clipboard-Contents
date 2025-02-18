﻿namespace EditClipboardContents
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dataGridViewClipboard = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip_dataGridView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenu_copySingleCell = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenu_copySelectedCurrentColumnOnly = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenu_copySelectedRows = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenu_copySelectedRowsNoHeader = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenu_copyColumn = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenu_copyColumnNoHeader = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuMainFile = new System.Windows.Forms.MenuItem();
            this.menuFile_ExportSelectedAsRawHex = new System.Windows.Forms.MenuItem();
            this.menuFile_ExportSelectedAsFile = new System.Windows.Forms.MenuItem();
            this.menuFile_ExportSelectedStruct = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuFile_ImportBackupFolder = new System.Windows.Forms.MenuItem();
            this.menuFile_ImportBackupZip = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuFile_ExportAllFolder = new System.Windows.Forms.MenuItem();
            this.menuFile_ExportAllZip = new System.Windows.Forms.MenuItem();
            this.menuMainEdit = new System.Windows.Forms.MenuItem();
            this.menuEdit_CopyObjectInfoAsText = new System.Windows.Forms.MenuItem();
            this.menuEdit_CopyHexAsText = new System.Windows.Forms.MenuItem();
            this.menuEdit_CopyEditedHexAsText = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuEdit_CopyEntireTable = new System.Windows.Forms.MenuItem();
            this.menuEdit_CopySelectedRows = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuEdit_ClearClipboard = new System.Windows.Forms.MenuItem();
            this.menuEdit_RefreshDataTable = new System.Windows.Forms.MenuItem();
            this.menuItemOptions = new System.Windows.Forms.MenuItem();
            this.menuOptions_ShowStructFormatting = new System.Windows.Forms.MenuItem();
            this.menuOptions_IncludeRowHeaders = new System.Windows.Forms.MenuItem();
            this.menuOptions_ShowLargeHex = new System.Windows.Forms.MenuItem();
            this.menuOptions_TableModeMenu = new System.Windows.Forms.MenuItem();
            this.menuOptions_PreFormatted = new System.Windows.Forms.MenuItem();
            this.menuOptions_TabSeparation = new System.Windows.Forms.MenuItem();
            this.menuOptions_CommaSeparation = new System.Windows.Forms.MenuItem();
            this.menuOptions_RetryMode = new System.Windows.Forms.MenuItem();
            this.menuTools = new System.Windows.Forms.MenuItem();
            this.menuTools_LoadBinaryDataToSelected = new System.Windows.Forms.MenuItem();
            this.menuTools_ExportRegisteredFormats = new System.Windows.Forms.MenuItem();
            this.menuItemHelp = new System.Windows.Forms.MenuItem();
            this.menuHelp_About = new System.Windows.Forms.MenuItem();
            this.menuHelp_WhyTakingLong = new System.Windows.Forms.MenuItem();
            this.menuHelp_DebugInfo = new System.Windows.Forms.MenuItem();
            this.menuItemDebug = new System.Windows.Forms.MenuItem();
            this.menuDebug_TestButton = new System.Windows.Forms.MenuItem();
            this.menuDebug_MakeSig = new System.Windows.Forms.MenuItem();
            this.menuDebug_TooltipDimensionsMode = new System.Windows.Forms.MenuItem();
            this.menuDebug_CopyRTFStructInfo = new System.Windows.Forms.MenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonTimedRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonFetchManualFormat = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAddFormat = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSaveEdited = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonExportSelected = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonShowHistoryForm = new System.Windows.Forms.ToolStripButton();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.labelLoading = new System.Windows.Forms.Label();
            this.splitContainerBottom = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel_MiddleControls = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxAutoViewMode = new System.Windows.Forms.CheckBox();
            this.buttonApplyEdit = new System.Windows.Forms.Button();
            this.dropdownContentsViewMode = new System.Windows.Forms.ComboBox();
            this.buttonIncreaseIndexNumber = new System.Windows.Forms.Button();
            this.buttonDecreaseIndexNumber = new System.Windows.Forms.Button();
            this.buttonResetEdit = new System.Windows.Forms.Button();
            this.buttonResetOrder = new System.Windows.Forms.Button();
            this.panel_MiddleControlsText = new System.Windows.Forms.Panel();
            this.labelSynthesizedTypeWarn = new System.Windows.Forms.Label();
            this.labelCustomFormatNameID = new System.Windows.Forms.Label();
            this.labelViewMode = new System.Windows.Forms.Label();
            this.splitterContainer_InnerTextBoxes = new EditClipboardContents.MySplitContainer();
            this.richTextBoxContents = new System.Windows.Forms.RichTextBox();
            this.splitContainerHex = new System.Windows.Forms.SplitContainer();
            this.richTextBox_HexPlaintext = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel_HexEditOptions = new System.Windows.Forms.FlowLayoutPanel();
            this.dropdownHexToTextEncoding = new System.Windows.Forms.ComboBox();
            this.labelHexToPlaintextEncoding = new System.Windows.Forms.Label();
            this.checkBoxPlainTextEditing = new System.Windows.Forms.CheckBox();
            this.labelPendingChanges = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelTestCount = new System.Windows.Forms.Label();
            this.labelTestMiscellaneous = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClipboard)).BeginInit();
            this.contextMenuStrip_dataGridView.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBottom)).BeginInit();
            this.splitContainerBottom.Panel1.SuspendLayout();
            this.splitContainerBottom.Panel2.SuspendLayout();
            this.splitContainerBottom.SuspendLayout();
            this.tableLayoutPanel_MiddleControls.SuspendLayout();
            this.panel_MiddleControlsText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitterContainer_InnerTextBoxes)).BeginInit();
            this.splitterContainer_InnerTextBoxes.Panel1.SuspendLayout();
            this.splitterContainer_InnerTextBoxes.Panel2.SuspendLayout();
            this.splitterContainer_InnerTextBoxes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerHex)).BeginInit();
            this.splitContainerHex.Panel1.SuspendLayout();
            this.splitContainerHex.Panel2.SuspendLayout();
            this.splitContainerHex.SuspendLayout();
            this.flowLayoutPanel_HexEditOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewClipboard
            // 
            this.dataGridViewClipboard.AllowUserToAddRows = false;
            this.dataGridViewClipboard.AllowUserToDeleteRows = false;
            this.dataGridViewClipboard.AllowUserToResizeRows = false;
            this.dataGridViewClipboard.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewClipboard.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewClipboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClipboard.ContextMenuStrip = this.contextMenuStrip_dataGridView;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewClipboard.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewClipboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewClipboard.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewClipboard.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewClipboard.Name = "dataGridViewClipboard";
            this.dataGridViewClipboard.ReadOnly = true;
            this.dataGridViewClipboard.RowHeadersWidth = 62;
            this.dataGridViewClipboard.Size = new System.Drawing.Size(1554, 313);
            this.dataGridViewClipboard.TabIndex = 0;
            this.dataGridViewClipboard.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridViewClipboard_CellBeginEdit);
            this.dataGridViewClipboard.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClipboard_CellClick);
            this.dataGridViewClipboard.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClipboard_CellDoubleClick);
            this.dataGridViewClipboard.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClipboard_CellEndEdit);
            this.dataGridViewClipboard.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewClipboard_CellMouseDown);
            this.dataGridViewClipboard.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewClipboard_ColumnHeaderMouseClick);
            this.dataGridViewClipboard.SelectionChanged += new System.EventHandler(this.dataGridViewClipboard_SelectionChanged);
            this.dataGridViewClipboard.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(this.dataGridViewClipboard_SortCompare);
            this.dataGridViewClipboard.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewClipboard_KeyDown);
            this.dataGridViewClipboard.MouseEnter += new System.EventHandler(this.dataGridViewClipboard_MouseEnter);
            // 
            // contextMenuStrip_dataGridView
            // 
            this.contextMenuStrip_dataGridView.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip_dataGridView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextMenu_copySingleCell,
            this.contextMenu_copySelectedCurrentColumnOnly,
            this.contextMenu_copySelectedRows,
            this.contextMenu_copySelectedRowsNoHeader,
            this.contextMenu_copyColumn,
            this.contextMenu_copyColumnNoHeader});
            this.contextMenuStrip_dataGridView.Name = "contextMenuStrip_dataGridView";
            this.contextMenuStrip_dataGridView.Size = new System.Drawing.Size(346, 196);
            this.contextMenuStrip_dataGridView.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_dataGridView_Opening);
            // 
            // contextMenu_copySingleCell
            // 
            this.contextMenu_copySingleCell.Name = "contextMenu_copySingleCell";
            this.contextMenu_copySingleCell.Size = new System.Drawing.Size(345, 32);
            this.contextMenu_copySingleCell.Text = "Copy Single Cell";
            this.contextMenu_copySingleCell.Visible = false;
            this.contextMenu_copySingleCell.Click += new System.EventHandler(this.contextMenu_copyCell_Click);
            // 
            // contextMenu_copySelectedCurrentColumnOnly
            // 
            this.contextMenu_copySelectedCurrentColumnOnly.Name = "contextMenu_copySelectedCurrentColumnOnly";
            this.contextMenu_copySelectedCurrentColumnOnly.Size = new System.Drawing.Size(345, 32);
            this.contextMenu_copySelectedCurrentColumnOnly.Text = "Copy Selected - Single Column";
            this.contextMenu_copySelectedCurrentColumnOnly.Visible = false;
            this.contextMenu_copySelectedCurrentColumnOnly.Click += new System.EventHandler(this.contextMenu_copySelectedCurrentColumnOnly_Click);
            // 
            // contextMenu_copySelectedRows
            // 
            this.contextMenu_copySelectedRows.Name = "contextMenu_copySelectedRows";
            this.contextMenu_copySelectedRows.Size = new System.Drawing.Size(345, 32);
            this.contextMenu_copySelectedRows.Text = "Copy Selected Rows";
            this.contextMenu_copySelectedRows.Visible = false;
            this.contextMenu_copySelectedRows.Click += new System.EventHandler(this.contextMenu_copyRowData_Click);
            // 
            // contextMenu_copySelectedRowsNoHeader
            // 
            this.contextMenu_copySelectedRowsNoHeader.Name = "contextMenu_copySelectedRowsNoHeader";
            this.contextMenu_copySelectedRowsNoHeader.Size = new System.Drawing.Size(345, 32);
            this.contextMenu_copySelectedRowsNoHeader.Text = "Copy Selected Rows (No Header)";
            this.contextMenu_copySelectedRowsNoHeader.Visible = false;
            this.contextMenu_copySelectedRowsNoHeader.Click += new System.EventHandler(this.contextMenu_copySelectedRowsNoHeader_Click);
            // 
            // contextMenu_copyColumn
            // 
            this.contextMenu_copyColumn.Name = "contextMenu_copyColumn";
            this.contextMenu_copyColumn.Size = new System.Drawing.Size(345, 32);
            this.contextMenu_copyColumn.Text = "Copy Entire Column";
            this.contextMenu_copyColumn.Visible = false;
            this.contextMenu_copyColumn.Click += new System.EventHandler(this.contextMenu_copyColumn_Click);
            // 
            // contextMenu_copyColumnNoHeader
            // 
            this.contextMenu_copyColumnNoHeader.Name = "contextMenu_copyColumnNoHeader";
            this.contextMenu_copyColumnNoHeader.Size = new System.Drawing.Size(345, 32);
            this.contextMenu_copyColumnNoHeader.Text = "Copy Entire Column (No Header)";
            this.contextMenu_copyColumnNoHeader.Visible = false;
            this.contextMenu_copyColumnNoHeader.Click += new System.EventHandler(this.contextMenu_copyColumnNoHeader_Click);
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuMainFile,
            this.menuMainEdit,
            this.menuItemOptions,
            this.menuTools,
            this.menuItemHelp,
            this.menuItemDebug});
            // 
            // menuMainFile
            // 
            this.menuMainFile.Index = 0;
            this.menuMainFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuFile_ExportSelectedAsRawHex,
            this.menuFile_ExportSelectedAsFile,
            this.menuFile_ExportSelectedStruct,
            this.menuItem6,
            this.menuItem7,
            this.menuItem5});
            this.menuMainFile.Text = "File";
            // 
            // menuFile_ExportSelectedAsRawHex
            // 
            this.menuFile_ExportSelectedAsRawHex.Index = 0;
            this.menuFile_ExportSelectedAsRawHex.Text = "Export Selected As Raw Hex";
            this.menuFile_ExportSelectedAsRawHex.Click += new System.EventHandler(this.menuFile_ExportSelectedAsRawHex_Click);
            // 
            // menuFile_ExportSelectedAsFile
            // 
            this.menuFile_ExportSelectedAsFile.Index = 1;
            this.menuFile_ExportSelectedAsFile.Text = "Export Selected As File";
            this.menuFile_ExportSelectedAsFile.Click += new System.EventHandler(this.menuFile_ExportSelectedAsFile_Click);
            // 
            // menuFile_ExportSelectedStruct
            // 
            this.menuFile_ExportSelectedStruct.Index = 2;
            this.menuFile_ExportSelectedStruct.Text = "Export Selected Object Info";
            this.menuFile_ExportSelectedStruct.Click += new System.EventHandler(this.menuFile_ExportSelectedStruct_Click);
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 3;
            this.menuItem6.Text = "-";
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 4;
            this.menuItem7.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuFile_ImportBackupFolder,
            this.menuFile_ImportBackupZip});
            this.menuItem7.Text = "Import Backup...";
            // 
            // menuFile_ImportBackupFolder
            // 
            this.menuFile_ImportBackupFolder.Index = 0;
            this.menuFile_ImportBackupFolder.Text = "From Folder";
            this.menuFile_ImportBackupFolder.Click += new System.EventHandler(this.menuFile_ImportBackupFolder_Click);
            // 
            // menuFile_ImportBackupZip
            // 
            this.menuFile_ImportBackupZip.Index = 1;
            this.menuFile_ImportBackupZip.Text = "From Zip";
            this.menuFile_ImportBackupZip.Click += new System.EventHandler(this.menuFile_ImportBackupZip_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 5;
            this.menuItem5.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuFile_ExportAllFolder,
            this.menuFile_ExportAllZip});
            this.menuItem5.Text = "Backup All...";
            // 
            // menuFile_ExportAllFolder
            // 
            this.menuFile_ExportAllFolder.Index = 0;
            this.menuFile_ExportAllFolder.Text = "To Folder";
            this.menuFile_ExportAllFolder.Click += new System.EventHandler(this.menuFile_ExportAllFolder_Click);
            // 
            // menuFile_ExportAllZip
            // 
            this.menuFile_ExportAllZip.Index = 1;
            this.menuFile_ExportAllZip.Text = "As Zip";
            this.menuFile_ExportAllZip.Click += new System.EventHandler(this.menuFile_ExportAllZip_Click);
            // 
            // menuMainEdit
            // 
            this.menuMainEdit.Index = 1;
            this.menuMainEdit.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuEdit_CopyObjectInfoAsText,
            this.menuEdit_CopyHexAsText,
            this.menuEdit_CopyEditedHexAsText,
            this.menuItem3,
            this.menuEdit_CopyEntireTable,
            this.menuEdit_CopySelectedRows,
            this.menuItem2,
            this.menuEdit_ClearClipboard,
            this.menuEdit_RefreshDataTable});
            this.menuMainEdit.Text = "Edit";
            // 
            // menuEdit_CopyObjectInfoAsText
            // 
            this.menuEdit_CopyObjectInfoAsText.Index = 0;
            this.menuEdit_CopyObjectInfoAsText.Text = "Copy Object Info As Text";
            this.menuEdit_CopyObjectInfoAsText.Click += new System.EventHandler(this.menuEdit_CopyObjectInfoAsText_Click);
            // 
            // menuEdit_CopyHexAsText
            // 
            this.menuEdit_CopyHexAsText.Index = 1;
            this.menuEdit_CopyHexAsText.Text = "Copy Hex Data As Text";
            this.menuEdit_CopyHexAsText.Click += new System.EventHandler(this.menuEdit_CopyHexAsText_Click);
            // 
            // menuEdit_CopyEditedHexAsText
            // 
            this.menuEdit_CopyEditedHexAsText.Enabled = false;
            this.menuEdit_CopyEditedHexAsText.Index = 2;
            this.menuEdit_CopyEditedHexAsText.Text = "Copy Edited Hex As Text";
            this.menuEdit_CopyEditedHexAsText.Click += new System.EventHandler(this.menuEdit_CopyEditedHexAsText_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 3;
            this.menuItem3.Text = "-";
            // 
            // menuEdit_CopyEntireTable
            // 
            this.menuEdit_CopyEntireTable.Index = 4;
            this.menuEdit_CopyEntireTable.Text = "Copy All Table Data";
            this.menuEdit_CopyEntireTable.Click += new System.EventHandler(this.menuEdit_CopyEntireTable_Click);
            // 
            // menuEdit_CopySelectedRows
            // 
            this.menuEdit_CopySelectedRows.Index = 5;
            this.menuEdit_CopySelectedRows.Text = "Copy Selected Table Rows";
            this.menuEdit_CopySelectedRows.Click += new System.EventHandler(this.menuEdit_CopySelectedRows_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 6;
            this.menuItem2.Text = "-";
            // 
            // menuEdit_ClearClipboard
            // 
            this.menuEdit_ClearClipboard.Index = 7;
            this.menuEdit_ClearClipboard.Text = "Clear Clipboard";
            this.menuEdit_ClearClipboard.Click += new System.EventHandler(this.menuEdit_ClearClipboard_Click);
            // 
            // menuEdit_RefreshDataTable
            // 
            this.menuEdit_RefreshDataTable.Index = 8;
            this.menuEdit_RefreshDataTable.Text = "Refresh Data Table";
            this.menuEdit_RefreshDataTable.Visible = false;
            this.menuEdit_RefreshDataTable.Click += new System.EventHandler(this.menuEdit_RefreshDataTable_Click);
            // 
            // menuItemOptions
            // 
            this.menuItemOptions.Index = 2;
            this.menuItemOptions.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuOptions_ShowStructFormatting,
            this.menuOptions_IncludeRowHeaders,
            this.menuOptions_ShowLargeHex,
            this.menuOptions_TableModeMenu,
            this.menuOptions_RetryMode});
            this.menuItemOptions.Text = "Options";
            // 
            // menuOptions_ShowStructFormatting
            // 
            this.menuOptions_ShowStructFormatting.Checked = true;
            this.menuOptions_ShowStructFormatting.Index = 0;
            this.menuOptions_ShowStructFormatting.Text = "Show Text Formatting For Object Info";
            this.menuOptions_ShowStructFormatting.Click += new System.EventHandler(this.menuOptions_ShowStructFormatting_Click);
            // 
            // menuOptions_IncludeRowHeaders
            // 
            this.menuOptions_IncludeRowHeaders.Checked = true;
            this.menuOptions_IncludeRowHeaders.Index = 1;
            this.menuOptions_IncludeRowHeaders.Text = "Include Headers When Copying Table";
            this.menuOptions_IncludeRowHeaders.Click += new System.EventHandler(this.menuOptions_IncludeRowHeaders_Click);
            // 
            // menuOptions_ShowLargeHex
            // 
            this.menuOptions_ShowLargeHex.Index = 2;
            this.menuOptions_ShowLargeHex.Text = "Show Hex For Large Files";
            this.menuOptions_ShowLargeHex.Click += new System.EventHandler(this.menuItemShowLargeHex_Click);
            // 
            // menuOptions_TableModeMenu
            // 
            this.menuOptions_TableModeMenu.Index = 3;
            this.menuOptions_TableModeMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuOptions_PreFormatted,
            this.menuOptions_TabSeparation,
            this.menuOptions_CommaSeparation});
            this.menuOptions_TableModeMenu.Text = "Table Copying Mode";
            // 
            // menuOptions_PreFormatted
            // 
            this.menuOptions_PreFormatted.Checked = true;
            this.menuOptions_PreFormatted.Index = 0;
            this.menuOptions_PreFormatted.Text = "Pre-Formatted";
            this.menuOptions_PreFormatted.Click += new System.EventHandler(this.menuOptions_PreFormatted_Click);
            // 
            // menuOptions_TabSeparation
            // 
            this.menuOptions_TabSeparation.Index = 1;
            this.menuOptions_TabSeparation.Text = "Single-Tab Separation";
            this.menuOptions_TabSeparation.Click += new System.EventHandler(this.menuOptions_TabSeparation_Click);
            // 
            // menuOptions_CommaSeparation
            // 
            this.menuOptions_CommaSeparation.Index = 2;
            this.menuOptions_CommaSeparation.Text = "Comma Separation";
            this.menuOptions_CommaSeparation.Click += new System.EventHandler(this.menuOptions_CommaSeparation_Click);
            // 
            // menuOptions_RetryMode
            // 
            this.menuOptions_RetryMode.Index = 4;
            this.menuOptions_RetryMode.Text = "Enable Retrying Failed Value Fetches";
            this.menuOptions_RetryMode.Click += new System.EventHandler(this.menuOptions_RetryMode_Click);
            // 
            // menuTools
            // 
            this.menuTools.Index = 3;
            this.menuTools.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuTools_LoadBinaryDataToSelected,
            this.menuTools_ExportRegisteredFormats});
            this.menuTools.Text = "Tools";
            // 
            // menuTools_LoadBinaryDataToSelected
            // 
            this.menuTools_LoadBinaryDataToSelected.Index = 0;
            this.menuTools_LoadBinaryDataToSelected.Text = "Import File As Binary Data For Selected Format";
            this.menuTools_LoadBinaryDataToSelected.Click += new System.EventHandler(this.menuTools_LoadBinaryDataToSelected_Click);
            // 
            // menuTools_ExportRegisteredFormats
            // 
            this.menuTools_ExportRegisteredFormats.Index = 1;
            this.menuTools_ExportRegisteredFormats.Text = "Export List Of All Registered Formats";
            this.menuTools_ExportRegisteredFormats.Click += new System.EventHandler(this.menuTools_ExportRegisteredFormats_Click);
            // 
            // menuItemHelp
            // 
            this.menuItemHelp.Index = 4;
            this.menuItemHelp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuHelp_About,
            this.menuHelp_WhyTakingLong,
            this.menuHelp_DebugInfo});
            this.menuItemHelp.Text = "Help";
            // 
            // menuHelp_About
            // 
            this.menuHelp_About.Index = 0;
            this.menuHelp_About.Text = "About";
            this.menuHelp_About.Click += new System.EventHandler(this.menuHelp_About_Click);
            // 
            // menuHelp_WhyTakingLong
            // 
            this.menuHelp_WhyTakingLong.Index = 1;
            this.menuHelp_WhyTakingLong.Text = "Why Is It Taking So Long?";
            this.menuHelp_WhyTakingLong.Click += new System.EventHandler(this.menuHelp_WhyTakingLong_Click);
            // 
            // menuHelp_DebugInfo
            // 
            this.menuHelp_DebugInfo.Index = 2;
            this.menuHelp_DebugInfo.Text = "Debug Info";
            this.menuHelp_DebugInfo.Click += new System.EventHandler(this.menuHelp_DebugInfo_Click);
            // 
            // menuItemDebug
            // 
            this.menuItemDebug.Index = 5;
            this.menuItemDebug.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuDebug_TestButton,
            this.menuDebug_MakeSig,
            this.menuDebug_TooltipDimensionsMode,
            this.menuDebug_CopyRTFStructInfo});
            this.menuItemDebug.Text = "[Debugging]";
            this.menuItemDebug.Visible = false;
            // 
            // menuDebug_TestButton
            // 
            this.menuDebug_TestButton.Index = 0;
            this.menuDebug_TestButton.Text = "Test Misc";
            this.menuDebug_TestButton.Click += new System.EventHandler(this.menuDebug_TestButton_Click);
            // 
            // menuDebug_MakeSig
            // 
            this.menuDebug_MakeSig.Index = 1;
            this.menuDebug_MakeSig.Text = "Make Signatures Json From Wiki Table";
            this.menuDebug_MakeSig.Click += new System.EventHandler(this.menuDebug_MakeSig_Click);
            // 
            // menuDebug_TooltipDimensionsMode
            // 
            this.menuDebug_TooltipDimensionsMode.Index = 2;
            this.menuDebug_TooltipDimensionsMode.Text = "Tooltips Show Dimensions Mode";
            this.menuDebug_TooltipDimensionsMode.Click += new System.EventHandler(this.menuDebug_TooltipDimensionsMode_Click);
            // 
            // menuDebug_CopyRTFStructInfo
            // 
            this.menuDebug_CopyRTFStructInfo.Index = 3;
            this.menuDebug_CopyRTFStructInfo.Text = "Copy Object Data With RTF Formatting";
            this.menuDebug_CopyRTFStructInfo.Click += new System.EventHandler(this.menuDebug_CopyRTFStructInfo_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(42, 42);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonRefresh,
            this.toolStripButtonTimedRefresh,
            this.toolStripButtonFetchManualFormat,
            this.toolStripButtonDelete,
            this.toolStripButtonAddFormat,
            this.toolStripButtonSaveEdited,
            this.toolStripButtonExportSelected,
            this.toolStripButtonShowHistoryForm});
            this.toolStrip1.Location = new System.Drawing.Point(10, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 22, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1554, 51);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonRefresh
            // 
            this.toolStripButtonRefresh.AutoSize = false;
            this.toolStripButtonRefresh.AutoToolTip = false;
            this.toolStripButtonRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRefresh.Image = global::EditClipboardContents.Properties.Resources.fluent_refresh_48;
            this.toolStripButtonRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRefresh.Name = "toolStripButtonRefresh";
            this.toolStripButtonRefresh.Size = new System.Drawing.Size(48, 48);
            this.toolStripButtonRefresh.Text = "Reload From Clipboard";
            this.toolStripButtonRefresh.ToolTipText = "Reload From Clipboard";
            this.toolStripButtonRefresh.Click += new System.EventHandler(this.toolStripButtonRefresh_Click);
            // 
            // toolStripButtonTimedRefresh
            // 
            this.toolStripButtonTimedRefresh.AutoSize = false;
            this.toolStripButtonTimedRefresh.AutoToolTip = false;
            this.toolStripButtonTimedRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonTimedRefresh.Image = global::EditClipboardContents.Properties.Resources.timed_refresh_48;
            this.toolStripButtonTimedRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonTimedRefresh.Name = "toolStripButtonTimedRefresh";
            this.toolStripButtonTimedRefresh.Size = new System.Drawing.Size(48, 48);
            this.toolStripButtonTimedRefresh.Text = "Reload from clipboard after a specified number of seconds";
            this.toolStripButtonTimedRefresh.ToolTipText = "Reload from clipboard after a specified number of seconds";
            this.toolStripButtonTimedRefresh.Click += new System.EventHandler(this.toolStripButtonTimedRefresh_Click);
            // 
            // toolStripButtonFetchManualFormat
            // 
            this.toolStripButtonFetchManualFormat.AutoSize = false;
            this.toolStripButtonFetchManualFormat.AutoToolTip = false;
            this.toolStripButtonFetchManualFormat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFetchManualFormat.Image = global::EditClipboardContents.Properties.Resources.fluent_magnifying_48;
            this.toolStripButtonFetchManualFormat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFetchManualFormat.Name = "toolStripButtonFetchManualFormat";
            this.toolStripButtonFetchManualFormat.Size = new System.Drawing.Size(48, 48);
            this.toolStripButtonFetchManualFormat.Text = "Manually fetch or re-fetch a specific format by name or ID";
            this.toolStripButtonFetchManualFormat.ToolTipText = "Manually fetch or re-fetch a specific format by name or ID";
            this.toolStripButtonFetchManualFormat.Click += new System.EventHandler(this.toolStripButtonFetchManualFormat_Click);
            // 
            // toolStripButtonDelete
            // 
            this.toolStripButtonDelete.AutoSize = false;
            this.toolStripButtonDelete.AutoToolTip = false;
            this.toolStripButtonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDelete.Image = global::EditClipboardContents.Properties.Resources.fluent_X_48;
            this.toolStripButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDelete.Name = "toolStripButtonDelete";
            this.toolStripButtonDelete.Size = new System.Drawing.Size(48, 48);
            this.toolStripButtonDelete.Text = "Delete Selected Item From Clipboard";
            this.toolStripButtonDelete.ToolTipText = "Delete Selected Item From Clipboard";
            this.toolStripButtonDelete.Click += new System.EventHandler(this.toolStripButtonDelete_Click);
            // 
            // toolStripButtonAddFormat
            // 
            this.toolStripButtonAddFormat.AutoSize = false;
            this.toolStripButtonAddFormat.AutoToolTip = false;
            this.toolStripButtonAddFormat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAddFormat.Image = global::EditClipboardContents.Properties.Resources.fluent_plus_48;
            this.toolStripButtonAddFormat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddFormat.Name = "toolStripButtonAddFormat";
            this.toolStripButtonAddFormat.Size = new System.Drawing.Size(48, 48);
            this.toolStripButtonAddFormat.Text = "Add a custom format";
            this.toolStripButtonAddFormat.ToolTipText = "Add a custom format";
            this.toolStripButtonAddFormat.Click += new System.EventHandler(this.toolStripButtonAddFormat_Click);
            // 
            // toolStripButtonSaveEdited
            // 
            this.toolStripButtonSaveEdited.AutoSize = false;
            this.toolStripButtonSaveEdited.AutoToolTip = false;
            this.toolStripButtonSaveEdited.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSaveEdited.Image = global::EditClipboardContents.Properties.Resources.fluent_floppy_48;
            this.toolStripButtonSaveEdited.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSaveEdited.Name = "toolStripButtonSaveEdited";
            this.toolStripButtonSaveEdited.Size = new System.Drawing.Size(48, 48);
            this.toolStripButtonSaveEdited.Text = "Re-Write clipboard with edited data";
            this.toolStripButtonSaveEdited.ToolTipText = "Re-Write clipboard with edited data";
            this.toolStripButtonSaveEdited.Click += new System.EventHandler(this.toolStripButtonSaveEdited_Click);
            // 
            // toolStripButtonExportSelected
            // 
            this.toolStripButtonExportSelected.AutoSize = false;
            this.toolStripButtonExportSelected.AutoToolTip = false;
            this.toolStripButtonExportSelected.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonExportSelected.Image = global::EditClipboardContents.Properties.Resources.export_48;
            this.toolStripButtonExportSelected.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonExportSelected.Name = "toolStripButtonExportSelected";
            this.toolStripButtonExportSelected.Size = new System.Drawing.Size(48, 48);
            this.toolStripButtonExportSelected.Text = "Export selected item data as file";
            this.toolStripButtonExportSelected.ToolTipText = "Export selected item data as file";
            this.toolStripButtonExportSelected.Click += new System.EventHandler(this.toolStripButtonExportSelected_Click);
            // 
            // toolStripButtonShowHistoryForm
            // 
            this.toolStripButtonShowHistoryForm.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonShowHistoryForm.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonShowHistoryForm.Image = global::EditClipboardContents.Properties.Resources.fluent_spiral_calendar_48;
            this.toolStripButtonShowHistoryForm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonShowHistoryForm.Name = "toolStripButtonShowHistoryForm";
            this.toolStripButtonShowHistoryForm.Size = new System.Drawing.Size(46, 46);
            this.toolStripButtonShowHistoryForm.Text = "Show Clipboard History Info";
            this.toolStripButtonShowHistoryForm.Click += new System.EventHandler(this.menuTools_HistoryInfo_click);
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(10, 51);
            this.splitContainerMain.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainerMain.Name = "splitContainerMain";
            this.splitContainerMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.labelLoading);
            this.splitContainerMain.Panel1.Controls.Add(this.dataGridViewClipboard);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.splitContainerBottom);
            this.splitContainerMain.Size = new System.Drawing.Size(1554, 813);
            this.splitContainerMain.SplitterDistance = 313;
            this.splitContainerMain.SplitterWidth = 9;
            this.splitContainerMain.TabIndex = 6;
            this.splitContainerMain.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainerMain_SplitterMoved);
            this.splitContainerMain.DoubleClick += new System.EventHandler(this.splitContainerMain_DoubleClick);
            // 
            // labelLoading
            // 
            this.labelLoading.AutoSize = true;
            this.labelLoading.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoading.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelLoading.Location = new System.Drawing.Point(412, 165);
            this.labelLoading.Name = "labelLoading";
            this.labelLoading.Padding = new System.Windows.Forms.Padding(15);
            this.labelLoading.Size = new System.Drawing.Size(721, 88);
            this.labelLoading.TabIndex = 14;
            this.labelLoading.Text = "Loading Data From Clipboard\r\nSometimes this can take a while (See \"Help\" dropdown" +
    " for why)";
            this.labelLoading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainerBottom
            // 
            this.splitContainerBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerBottom.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerBottom.IsSplitterFixed = true;
            this.splitContainerBottom.Location = new System.Drawing.Point(0, 0);
            this.splitContainerBottom.Name = "splitContainerBottom";
            this.splitContainerBottom.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerBottom.Panel1
            // 
            this.splitContainerBottom.Panel1.Controls.Add(this.tableLayoutPanel_MiddleControls);
            // 
            // splitContainerBottom.Panel2
            // 
            this.splitContainerBottom.Panel2.Controls.Add(this.splitterContainer_InnerTextBoxes);
            this.splitContainerBottom.Size = new System.Drawing.Size(1554, 491);
            this.splitContainerBottom.SplitterDistance = 45;
            this.splitContainerBottom.SplitterWidth = 1;
            this.splitContainerBottom.TabIndex = 18;
            // 
            // tableLayoutPanel_MiddleControls
            // 
            this.tableLayoutPanel_MiddleControls.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel_MiddleControls.ColumnCount = 10;
            this.tableLayoutPanel_MiddleControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_MiddleControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_MiddleControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_MiddleControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_MiddleControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_MiddleControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_MiddleControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_MiddleControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_MiddleControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_MiddleControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel_MiddleControls.Controls.Add(this.checkBoxAutoViewMode, 2, 0);
            this.tableLayoutPanel_MiddleControls.Controls.Add(this.buttonApplyEdit, 4, 0);
            this.tableLayoutPanel_MiddleControls.Controls.Add(this.dropdownContentsViewMode, 1, 0);
            this.tableLayoutPanel_MiddleControls.Controls.Add(this.buttonIncreaseIndexNumber, 7, 0);
            this.tableLayoutPanel_MiddleControls.Controls.Add(this.buttonDecreaseIndexNumber, 6, 0);
            this.tableLayoutPanel_MiddleControls.Controls.Add(this.buttonResetEdit, 5, 0);
            this.tableLayoutPanel_MiddleControls.Controls.Add(this.buttonResetOrder, 8, 0);
            this.tableLayoutPanel_MiddleControls.Controls.Add(this.panel_MiddleControlsText, 3, 0);
            this.tableLayoutPanel_MiddleControls.Controls.Add(this.labelViewMode, 0, 0);
            this.tableLayoutPanel_MiddleControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_MiddleControls.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_MiddleControls.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel_MiddleControls.Name = "tableLayoutPanel_MiddleControls";
            this.tableLayoutPanel_MiddleControls.RowCount = 1;
            this.tableLayoutPanel_MiddleControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_MiddleControls.Size = new System.Drawing.Size(1554, 45);
            this.tableLayoutPanel_MiddleControls.TabIndex = 18;
            // 
            // checkBoxAutoViewMode
            // 
            this.checkBoxAutoViewMode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBoxAutoViewMode.AutoSize = true;
            this.checkBoxAutoViewMode.Checked = true;
            this.checkBoxAutoViewMode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAutoViewMode.Location = new System.Drawing.Point(374, 12);
            this.checkBoxAutoViewMode.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.checkBoxAutoViewMode.Name = "checkBoxAutoViewMode";
            this.checkBoxAutoViewMode.Size = new System.Drawing.Size(55, 21);
            this.checkBoxAutoViewMode.TabIndex = 14;
            this.checkBoxAutoViewMode.Text = "Auto";
            this.checkBoxAutoViewMode.UseVisualStyleBackColor = true;
            // 
            // buttonApplyEdit
            // 
            this.buttonApplyEdit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonApplyEdit.Enabled = false;
            this.buttonApplyEdit.Location = new System.Drawing.Point(1167, 5);
            this.buttonApplyEdit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonApplyEdit.Name = "buttonApplyEdit";
            this.buttonApplyEdit.Size = new System.Drawing.Size(112, 34);
            this.buttonApplyEdit.TabIndex = 10;
            this.buttonApplyEdit.Text = "Apply Edit";
            this.buttonApplyEdit.UseVisualStyleBackColor = true;
            this.buttonApplyEdit.Visible = false;
            this.buttonApplyEdit.Click += new System.EventHandler(this.buttonApplyEdit_Click);
            // 
            // dropdownContentsViewMode
            // 
            this.dropdownContentsViewMode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dropdownContentsViewMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdownContentsViewMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropdownContentsViewMode.FormattingEnabled = true;
            this.dropdownContentsViewMode.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.dropdownContentsViewMode.Items.AddRange(new object[] {
            "Text",
            "Hex",
            "Hex (Editable)",
            "Object / Struct Details"});
            this.dropdownContentsViewMode.Location = new System.Drawing.Point(120, 7);
            this.dropdownContentsViewMode.Margin = new System.Windows.Forms.Padding(4);
            this.dropdownContentsViewMode.Name = "dropdownContentsViewMode";
            this.dropdownContentsViewMode.Size = new System.Drawing.Size(240, 30);
            this.dropdownContentsViewMode.TabIndex = 7;
            this.dropdownContentsViewMode.SelectedIndexChanged += new System.EventHandler(this.dropdownContentsViewMode_SelectedIndexChanged);
            // 
            // buttonIncreaseIndexNumber
            // 
            this.buttonIncreaseIndexNumber.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonIncreaseIndexNumber.Location = new System.Drawing.Point(1466, 5);
            this.buttonIncreaseIndexNumber.Name = "buttonIncreaseIndexNumber";
            this.buttonIncreaseIndexNumber.Size = new System.Drawing.Size(42, 34);
            this.buttonIncreaseIndexNumber.TabIndex = 16;
            this.buttonIncreaseIndexNumber.Text = "▼";
            this.toolTip1.SetToolTip(this.buttonIncreaseIndexNumber, "Increase order index (decrease priority)");
            this.buttonIncreaseIndexNumber.UseCompatibleTextRendering = true;
            this.buttonIncreaseIndexNumber.UseVisualStyleBackColor = true;
            this.buttonIncreaseIndexNumber.Click += new System.EventHandler(this.buttonIncreaseIndexNumber_Click);
            // 
            // buttonDecreaseIndexNumber
            // 
            this.buttonDecreaseIndexNumber.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonDecreaseIndexNumber.Location = new System.Drawing.Point(1418, 5);
            this.buttonDecreaseIndexNumber.Name = "buttonDecreaseIndexNumber";
            this.buttonDecreaseIndexNumber.Size = new System.Drawing.Size(42, 34);
            this.buttonDecreaseIndexNumber.TabIndex = 16;
            this.buttonDecreaseIndexNumber.Text = "▲";
            this.toolTip1.SetToolTip(this.buttonDecreaseIndexNumber, "Decrease order index (increase priority)");
            this.buttonDecreaseIndexNumber.UseCompatibleTextRendering = true;
            this.buttonDecreaseIndexNumber.UseVisualStyleBackColor = true;
            this.buttonDecreaseIndexNumber.Click += new System.EventHandler(this.buttonDecreaseIndexNumber_Click);
            // 
            // buttonResetEdit
            // 
            this.buttonResetEdit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonResetEdit.Enabled = false;
            this.buttonResetEdit.Location = new System.Drawing.Point(1287, 5);
            this.buttonResetEdit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonResetEdit.Name = "buttonResetEdit";
            this.buttonResetEdit.Size = new System.Drawing.Size(124, 34);
            this.buttonResetEdit.TabIndex = 11;
            this.buttonResetEdit.Text = "Reset Edit";
            this.buttonResetEdit.UseVisualStyleBackColor = true;
            this.buttonResetEdit.Click += new System.EventHandler(this.buttonResetEdit_Click);
            // 
            // buttonResetOrder
            // 
            this.buttonResetOrder.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonResetOrder.Location = new System.Drawing.Point(1514, 5);
            this.buttonResetOrder.Name = "buttonResetOrder";
            this.buttonResetOrder.Size = new System.Drawing.Size(27, 34);
            this.buttonResetOrder.TabIndex = 17;
            this.buttonResetOrder.Text = "R";
            this.toolTip1.SetToolTip(this.buttonResetOrder, "Reset ordering");
            this.buttonResetOrder.UseCompatibleTextRendering = true;
            this.buttonResetOrder.UseVisualStyleBackColor = true;
            this.buttonResetOrder.Click += new System.EventHandler(this.buttonResetOrder_Click);
            // 
            // panel_MiddleControlsText
            // 
            this.panel_MiddleControlsText.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_MiddleControlsText.Controls.Add(this.labelSynthesizedTypeWarn);
            this.panel_MiddleControlsText.Controls.Add(this.labelCustomFormatNameID);
            this.panel_MiddleControlsText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_MiddleControlsText.Location = new System.Drawing.Point(432, 0);
            this.panel_MiddleControlsText.Margin = new System.Windows.Forms.Padding(0);
            this.panel_MiddleControlsText.Name = "panel_MiddleControlsText";
            this.panel_MiddleControlsText.Size = new System.Drawing.Size(731, 45);
            this.panel_MiddleControlsText.TabIndex = 18;
            // 
            // labelSynthesizedTypeWarn
            // 
            this.labelSynthesizedTypeWarn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelSynthesizedTypeWarn.AutoSize = true;
            this.labelSynthesizedTypeWarn.Cursor = System.Windows.Forms.Cursors.Help;
            this.labelSynthesizedTypeWarn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSynthesizedTypeWarn.Location = new System.Drawing.Point(15, 12);
            this.labelSynthesizedTypeWarn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSynthesizedTypeWarn.Name = "labelSynthesizedTypeWarn";
            this.labelSynthesizedTypeWarn.Size = new System.Drawing.Size(171, 20);
            this.labelSynthesizedTypeWarn.TabIndex = 9;
            this.labelSynthesizedTypeWarn.Text = "⚠️ Synthesized Format";
            this.labelSynthesizedTypeWarn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.labelSynthesizedTypeWarn, resources.GetString("labelSynthesizedTypeWarn.ToolTip"));
            this.labelSynthesizedTypeWarn.Visible = false;
            this.labelSynthesizedTypeWarn.Click += new System.EventHandler(this.labelSynthesizedTypeWarn_Click);
            // 
            // labelCustomFormatNameID
            // 
            this.labelCustomFormatNameID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelCustomFormatNameID.AutoSize = true;
            this.labelCustomFormatNameID.Cursor = System.Windows.Forms.Cursors.Help;
            this.labelCustomFormatNameID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomFormatNameID.ForeColor = System.Drawing.Color.DarkRed;
            this.labelCustomFormatNameID.Location = new System.Drawing.Point(14, 9);
            this.labelCustomFormatNameID.Name = "labelCustomFormatNameID";
            this.labelCustomFormatNameID.Size = new System.Drawing.Size(593, 25);
            this.labelCustomFormatNameID.TabIndex = 15;
            this.labelCustomFormatNameID.Text = "⚠️ Note: You can specify a custom Format Name or ID, but not both";
            this.labelCustomFormatNameID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.labelCustomFormatNameID, resources.GetString("labelCustomFormatNameID.ToolTip"));
            this.labelCustomFormatNameID.Visible = false;
            this.labelCustomFormatNameID.Click += new System.EventHandler(this.labelCustomFormatNameID_Click);
            // 
            // labelViewMode
            // 
            this.labelViewMode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelViewMode.AutoSize = true;
            this.labelViewMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelViewMode.Location = new System.Drawing.Point(0, 10);
            this.labelViewMode.Margin = new System.Windows.Forms.Padding(0);
            this.labelViewMode.Name = "labelViewMode";
            this.labelViewMode.Size = new System.Drawing.Size(116, 25);
            this.labelViewMode.TabIndex = 8;
            this.labelViewMode.Text = "View Mode:";
            // 
            // splitterContainer_InnerTextBoxes
            // 
            this.splitterContainer_InnerTextBoxes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitterContainer_InnerTextBoxes.Location = new System.Drawing.Point(0, 0);
            this.splitterContainer_InnerTextBoxes.Margin = new System.Windows.Forms.Padding(0);
            this.splitterContainer_InnerTextBoxes.Name = "splitterContainer_InnerTextBoxes";
            // 
            // splitterContainer_InnerTextBoxes.Panel1
            // 
            this.splitterContainer_InnerTextBoxes.Panel1.Controls.Add(this.richTextBoxContents);
            // 
            // splitterContainer_InnerTextBoxes.Panel2
            // 
            this.splitterContainer_InnerTextBoxes.Panel2.Controls.Add(this.splitContainerHex);
            this.splitterContainer_InnerTextBoxes.Size = new System.Drawing.Size(1554, 445);
            this.splitterContainer_InnerTextBoxes.SplitterDistance = 1023;
            this.splitterContainer_InnerTextBoxes.SplitterWidth = 10;
            this.splitterContainer_InnerTextBoxes.TabIndex = 13;
            this.splitterContainer_InnerTextBoxes.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitterContainer_InnerTextBoxes_SplitterMoved);
            // 
            // richTextBoxContents
            // 
            this.richTextBoxContents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxContents.DetectUrls = false;
            this.richTextBoxContents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxContents.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxContents.HideSelection = false;
            this.richTextBoxContents.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxContents.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxContents.Name = "richTextBoxContents";
            this.richTextBoxContents.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBoxContents.Size = new System.Drawing.Size(1023, 445);
            this.richTextBoxContents.TabIndex = 4;
            this.richTextBoxContents.Text = "";
            this.richTextBoxContents.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richTextBoxContents_LinkClicked);
            this.richTextBoxContents.SelectionChanged += new System.EventHandler(this.richTextBoxContents_SelectionChanged);
            this.richTextBoxContents.TextChanged += new System.EventHandler(this.richTextBoxContents_TextChanged);
            // 
            // splitContainerHex
            // 
            this.splitContainerHex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerHex.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainerHex.IsSplitterFixed = true;
            this.splitContainerHex.Location = new System.Drawing.Point(0, 0);
            this.splitContainerHex.Name = "splitContainerHex";
            this.splitContainerHex.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerHex.Panel1
            // 
            this.splitContainerHex.Panel1.Controls.Add(this.richTextBox_HexPlaintext);
            // 
            // splitContainerHex.Panel2
            // 
            this.splitContainerHex.Panel2.Controls.Add(this.flowLayoutPanel_HexEditOptions);
            this.splitContainerHex.Size = new System.Drawing.Size(521, 445);
            this.splitContainerHex.SplitterDistance = 412;
            this.splitContainerHex.SplitterWidth = 1;
            this.splitContainerHex.TabIndex = 6;
            // 
            // richTextBox_HexPlaintext
            // 
            this.richTextBox_HexPlaintext.DetectUrls = false;
            this.richTextBox_HexPlaintext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_HexPlaintext.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_HexPlaintext.HideSelection = false;
            this.richTextBox_HexPlaintext.Location = new System.Drawing.Point(0, 0);
            this.richTextBox_HexPlaintext.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox_HexPlaintext.Name = "richTextBox_HexPlaintext";
            this.richTextBox_HexPlaintext.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox_HexPlaintext.Size = new System.Drawing.Size(521, 412);
            this.richTextBox_HexPlaintext.TabIndex = 0;
            this.richTextBox_HexPlaintext.Text = "";
            this.richTextBox_HexPlaintext.SelectionChanged += new System.EventHandler(this.richTextBox_HexPlaintext_SelectionChanged);
            this.richTextBox_HexPlaintext.TextChanged += new System.EventHandler(this.richTextBox_HexPlaintext_TextChanged);
            // 
            // flowLayoutPanel_HexEditOptions
            // 
            this.flowLayoutPanel_HexEditOptions.AutoSize = true;
            this.flowLayoutPanel_HexEditOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel_HexEditOptions.Controls.Add(this.dropdownHexToTextEncoding);
            this.flowLayoutPanel_HexEditOptions.Controls.Add(this.labelHexToPlaintextEncoding);
            this.flowLayoutPanel_HexEditOptions.Controls.Add(this.checkBoxPlainTextEditing);
            this.flowLayoutPanel_HexEditOptions.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel_HexEditOptions.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel_HexEditOptions.Location = new System.Drawing.Point(91, 0);
            this.flowLayoutPanel_HexEditOptions.Name = "flowLayoutPanel_HexEditOptions";
            this.flowLayoutPanel_HexEditOptions.Size = new System.Drawing.Size(430, 32);
            this.flowLayoutPanel_HexEditOptions.TabIndex = 0;
            this.flowLayoutPanel_HexEditOptions.WrapContents = false;
            // 
            // dropdownHexToTextEncoding
            // 
            this.dropdownHexToTextEncoding.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dropdownHexToTextEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdownHexToTextEncoding.FormattingEnabled = true;
            this.dropdownHexToTextEncoding.Items.AddRange(new object[] {
            "UTF-8",
            "UTF-16 LE (Unicode)",
            "UTF-16 BE",
            "UTF-32 LE",
            "UTF-32 BE",
            "Codepage 1252",
            "System Default"});
            this.dropdownHexToTextEncoding.Location = new System.Drawing.Point(183, 4);
            this.dropdownHexToTextEncoding.Margin = new System.Windows.Forms.Padding(4, 4, 30, 4);
            this.dropdownHexToTextEncoding.Name = "dropdownHexToTextEncoding";
            this.dropdownHexToTextEncoding.Size = new System.Drawing.Size(217, 21);
            this.dropdownHexToTextEncoding.TabIndex = 2;
            this.dropdownHexToTextEncoding.SelectedIndexChanged += new System.EventHandler(this.dropdownHexToTextEncoding_SelectedIndexChanged);
            // 
            // labelHexToPlaintextEncoding
            // 
            this.labelHexToPlaintextEncoding.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelHexToPlaintextEncoding.AutoSize = true;
            this.labelHexToPlaintextEncoding.Location = new System.Drawing.Point(120, 8);
            this.labelHexToPlaintextEncoding.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHexToPlaintextEncoding.Name = "labelHexToPlaintextEncoding";
            this.labelHexToPlaintextEncoding.Size = new System.Drawing.Size(55, 13);
            this.labelHexToPlaintextEncoding.TabIndex = 1;
            this.labelHexToPlaintextEncoding.Text = "Encoding:";
            // 
            // checkBoxPlainTextEditing
            // 
            this.checkBoxPlainTextEditing.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.checkBoxPlainTextEditing.AutoSize = true;
            this.checkBoxPlainTextEditing.Location = new System.Drawing.Point(4, 4);
            this.checkBoxPlainTextEditing.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxPlainTextEditing.Name = "checkBoxPlainTextEditing";
            this.checkBoxPlainTextEditing.Size = new System.Drawing.Size(108, 21);
            this.checkBoxPlainTextEditing.TabIndex = 3;
            this.checkBoxPlainTextEditing.Text = "Plaintext Editing";
            this.toolTip1.SetToolTip(this.checkBoxPlainTextEditing, resources.GetString("checkBoxPlainTextEditing.ToolTip"));
            this.checkBoxPlainTextEditing.UseVisualStyleBackColor = true;
            this.checkBoxPlainTextEditing.CheckedChanged += new System.EventHandler(this.checkBoxPlainTextEditing_CheckedChanged);
            // 
            // labelPendingChanges
            // 
            this.labelPendingChanges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPendingChanges.AutoSize = true;
            this.labelPendingChanges.BackColor = System.Drawing.Color.Transparent;
            this.labelPendingChanges.Cursor = System.Windows.Forms.Cursors.Help;
            this.labelPendingChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPendingChanges.ForeColor = System.Drawing.Color.Firebrick;
            this.labelPendingChanges.Location = new System.Drawing.Point(861, 14);
            this.labelPendingChanges.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPendingChanges.Name = "labelPendingChanges";
            this.labelPendingChanges.Size = new System.Drawing.Size(465, 22);
            this.labelPendingChanges.TabIndex = 12;
            this.labelPendingChanges.Text = "*Pending Changes - Click Save Icon to apply to clipboard";
            this.toolTip1.SetToolTip(this.labelPendingChanges, resources.GetString("labelPendingChanges.ToolTip"));
            this.labelPendingChanges.Visible = false;
            this.labelPendingChanges.Click += new System.EventHandler(this.labelPendingChanges_Click);
            // 
            // labelVersion
            // 
            this.labelVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVersion.AutoSize = true;
            this.labelVersion.BackColor = System.Drawing.Color.Transparent;
            this.labelVersion.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelVersion.Location = new System.Drawing.Point(1362, 16);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(45, 13);
            this.labelVersion.TabIndex = 13;
            this.labelVersion.Text = "Version:";
            // 
            // labelTestCount
            // 
            this.labelTestCount.AutoSize = true;
            this.labelTestCount.Location = new System.Drawing.Point(584, 0);
            this.labelTestCount.Name = "labelTestCount";
            this.labelTestCount.Size = new System.Drawing.Size(59, 13);
            this.labelTestCount.TabIndex = 16;
            this.labelTestCount.Text = "Test Count";
            this.labelTestCount.Visible = false;
            // 
            // labelTestMiscellaneous
            // 
            this.labelTestMiscellaneous.AutoSize = true;
            this.labelTestMiscellaneous.Location = new System.Drawing.Point(588, 25);
            this.labelTestMiscellaneous.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTestMiscellaneous.Name = "labelTestMiscellaneous";
            this.labelTestMiscellaneous.Size = new System.Drawing.Size(117, 13);
            this.labelTestMiscellaneous.TabIndex = 17;
            this.labelTestMiscellaneous.Text = "labelTestMiscellaneous";
            this.labelTestMiscellaneous.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1574, 874);
            this.Controls.Add(this.labelTestMiscellaneous);
            this.Controls.Add(this.labelTestCount);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.labelPendingChanges);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Menu = this.mainMenu1;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.Text = "Edit Clipboard Contents";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClipboard)).EndInit();
            this.contextMenuStrip_dataGridView.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel1.PerformLayout();
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.splitContainerBottom.Panel1.ResumeLayout(false);
            this.splitContainerBottom.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBottom)).EndInit();
            this.splitContainerBottom.ResumeLayout(false);
            this.tableLayoutPanel_MiddleControls.ResumeLayout(false);
            this.tableLayoutPanel_MiddleControls.PerformLayout();
            this.panel_MiddleControlsText.ResumeLayout(false);
            this.panel_MiddleControlsText.PerformLayout();
            this.splitterContainer_InnerTextBoxes.Panel1.ResumeLayout(false);
            this.splitterContainer_InnerTextBoxes.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitterContainer_InnerTextBoxes)).EndInit();
            this.splitterContainer_InnerTextBoxes.ResumeLayout(false);
            this.splitContainerHex.Panel1.ResumeLayout(false);
            this.splitContainerHex.Panel2.ResumeLayout(false);
            this.splitContainerHex.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerHex)).EndInit();
            this.splitContainerHex.ResumeLayout(false);
            this.flowLayoutPanel_HexEditOptions.ResumeLayout(false);
            this.flowLayoutPanel_HexEditOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewClipboard;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuMainFile;
        private System.Windows.Forms.MenuItem menuFile_ExportSelectedAsRawHex;
        private System.Windows.Forms.MenuItem menuMainEdit;
        private System.Windows.Forms.MenuItem menuEdit_CopyHexAsText;
        private System.Windows.Forms.MenuItem menuFile_ExportSelectedAsFile;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonRefresh;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelete;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.ComboBox dropdownContentsViewMode;
        private System.Windows.Forms.Label labelViewMode;
        private System.Windows.Forms.Label labelSynthesizedTypeWarn;
        private System.Windows.Forms.ToolStripButton toolStripButtonSaveEdited;
        private System.Windows.Forms.ToolStripButton toolStripButtonExportSelected;
        private System.Windows.Forms.MenuItem menuFile_ExportSelectedStruct;
        private System.Windows.Forms.MenuItem menuItemOptions;
        private System.Windows.Forms.MenuItem menuOptions_ShowLargeHex;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button buttonApplyEdit;
        private System.Windows.Forms.Button buttonResetEdit;
        private System.Windows.Forms.Label labelPendingChanges;
        private System.Windows.Forms.MenuItem menuEdit_CopyObjectInfoAsText;
        private System.Windows.Forms.MenuItem menuEdit_CopyEditedHexAsText;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuEdit_CopySelectedRows;
        private System.Windows.Forms.MenuItem menuOptions_IncludeRowHeaders;
        private System.Windows.Forms.MenuItem menuOptions_TabSeparation;
        private System.Windows.Forms.MenuItem menuOptions_TableModeMenu;
        private System.Windows.Forms.MenuItem menuOptions_CommaSeparation;
        private System.Windows.Forms.MenuItem menuOptions_PreFormatted;
        private System.Windows.Forms.MenuItem menuEdit_CopyEntireTable;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_dataGridView;
        private System.Windows.Forms.ToolStripMenuItem contextMenu_copySingleCell;
        private System.Windows.Forms.ToolStripMenuItem contextMenu_copySelectedRows;
        private System.Windows.Forms.ToolStripMenuItem contextMenu_copySelectedRowsNoHeader;
        private MySplitContainer splitterContainer_InnerTextBoxes;
        private System.Windows.Forms.RichTextBox richTextBox_HexPlaintext;
        private System.Windows.Forms.ComboBox dropdownHexToTextEncoding;
        private System.Windows.Forms.Label labelHexToPlaintextEncoding;
        private System.Windows.Forms.CheckBox checkBoxPlainTextEditing;
        private System.Windows.Forms.MenuItem menuItemHelp;
        private System.Windows.Forms.MenuItem menuHelp_About;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.CheckBox checkBoxAutoViewMode;
        private System.Windows.Forms.Label labelLoading;
        private System.Windows.Forms.MenuItem menuHelp_WhyTakingLong;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddFormat;
        private System.Windows.Forms.Label labelCustomFormatNameID;
        private System.Windows.Forms.MenuItem menuTools_ExportRegisteredFormats;
        private System.Windows.Forms.ToolStripButton toolStripButtonFetchManualFormat;
        private System.Windows.Forms.MenuItem menuOptions_RetryMode;
        private System.Windows.Forms.MenuItem menuTools_LoadBinaryDataToSelected;
        private System.Windows.Forms.Button buttonDecreaseIndexNumber;
        private System.Windows.Forms.Button buttonIncreaseIndexNumber;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuEdit_RefreshDataTable;
        private System.Windows.Forms.Button buttonResetOrder;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem menuFile_ExportAllFolder;
        private System.Windows.Forms.MenuItem menuFile_ExportAllZip;
        private System.Windows.Forms.MenuItem menuItem7;
        private System.Windows.Forms.MenuItem menuFile_ImportBackupFolder;
        private System.Windows.Forms.MenuItem menuFile_ImportBackupZip;
        private System.Windows.Forms.MenuItem menuEdit_ClearClipboard;
        private System.Windows.Forms.ToolStripMenuItem contextMenu_copySelectedCurrentColumnOnly;
        private System.Windows.Forms.ToolStripMenuItem contextMenu_copyColumn;
        private System.Windows.Forms.ToolStripMenuItem contextMenu_copyColumnNoHeader;
        private System.Windows.Forms.ToolStripButton toolStripButtonTimedRefresh;
        private System.Windows.Forms.MenuItem menuHelp_DebugInfo;
        private System.Windows.Forms.Label labelTestCount;
        private System.Windows.Forms.Label labelTestMiscellaneous;
        private System.Windows.Forms.MenuItem menuItemDebug;
        private System.Windows.Forms.MenuItem menuDebug_TestButton;
        private System.Windows.Forms.MenuItem menuDebug_MakeSig;
        private System.Windows.Forms.MenuItem menuDebug_TooltipDimensionsMode;
        private System.Windows.Forms.MenuItem menuDebug_CopyRTFStructInfo;
        private System.Windows.Forms.MenuItem menuTools;
        private System.Windows.Forms.ToolStripButton toolStripButtonShowHistoryForm;
        private System.Windows.Forms.RichTextBox richTextBoxContents;
        private System.Windows.Forms.MenuItem menuOptions_ShowStructFormatting;
        private System.Windows.Forms.SplitContainer splitContainerHex;
        private System.Windows.Forms.SplitContainer splitContainerBottom;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_MiddleControls;
        private System.Windows.Forms.Panel panel_MiddleControlsText;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_HexEditOptions;
    }
}