namespace EditClipboardContents;

partial class HistoryForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if ( disposing && (components != null) )
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.buttonRefreshHistory = new System.Windows.Forms.Button();
            this.dataGridViewHistory = new System.Windows.Forms.DataGridView();
            this.buttonDeleteHistoryItem = new System.Windows.Forms.Button();
            this.labelHeaderAvailableFormats = new System.Windows.Forms.Label();
            this.buttonSetActiveHistoryItem = new System.Windows.Forms.Button();
            this.labelHeaderHistoryGUID = new System.Windows.Forms.Label();
            this.labelHeaderIndex = new System.Windows.Forms.Label();
            this.textBoxHistoryContents = new System.Windows.Forms.RichTextBox();
            this.labelHeaderContents = new System.Windows.Forms.Label();
            this.labelIndex = new System.Windows.Forms.Label();
            this.labelHistoryGUID = new System.Windows.Forms.Label();
            this.labelHistoryStatus = new System.Windows.Forms.Label();
            this.listViewAvailableFormats = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRefreshHistory
            // 
            this.buttonRefreshHistory.Location = new System.Drawing.Point(1000, 23);
            this.buttonRefreshHistory.Name = "buttonRefreshHistory";
            this.buttonRefreshHistory.Size = new System.Drawing.Size(142, 40);
            this.buttonRefreshHistory.TabIndex = 0;
            this.buttonRefreshHistory.Text = "Refresh History";
            this.buttonRefreshHistory.UseVisualStyleBackColor = true;
            this.buttonRefreshHistory.Click += new System.EventHandler(this.buttonRefreshHistory_Click);
            // 
            // dataGridViewHistory
            // 
            this.dataGridViewHistory.AllowUserToAddRows = false;
            this.dataGridViewHistory.AllowUserToDeleteRows = false;
            this.dataGridViewHistory.AllowUserToResizeColumns = false;
            this.dataGridViewHistory.AllowUserToResizeRows = false;
            this.dataGridViewHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHistory.Location = new System.Drawing.Point(12, 80);
            this.dataGridViewHistory.Name = "dataGridViewHistory";
            this.dataGridViewHistory.ReadOnly = true;
            this.dataGridViewHistory.RowHeadersWidth = 62;
            this.dataGridViewHistory.RowTemplate.Height = 28;
            this.dataGridViewHistory.Size = new System.Drawing.Size(458, 522);
            this.dataGridViewHistory.TabIndex = 1;
            // 
            // buttonDeleteHistoryItem
            // 
            this.buttonDeleteHistoryItem.Location = new System.Drawing.Point(171, 23);
            this.buttonDeleteHistoryItem.Name = "buttonDeleteHistoryItem";
            this.buttonDeleteHistoryItem.Size = new System.Drawing.Size(171, 40);
            this.buttonDeleteHistoryItem.TabIndex = 2;
            this.buttonDeleteHistoryItem.Text = "Delete From History";
            this.buttonDeleteHistoryItem.UseVisualStyleBackColor = true;
            this.buttonDeleteHistoryItem.Click += new System.EventHandler(this.buttonDeleteHistoryItem_Click);
            // 
            // labelHeaderAvailableFormats
            // 
            this.labelHeaderAvailableFormats.AutoSize = true;
            this.labelHeaderAvailableFormats.Location = new System.Drawing.Point(481, 147);
            this.labelHeaderAvailableFormats.Name = "labelHeaderAvailableFormats";
            this.labelHeaderAvailableFormats.Size = new System.Drawing.Size(111, 20);
            this.labelHeaderAvailableFormats.TabIndex = 3;
            this.labelHeaderAvailableFormats.Text = "Data Formats:";
            // 
            // buttonSetActiveHistoryItem
            // 
            this.buttonSetActiveHistoryItem.Location = new System.Drawing.Point(12, 23);
            this.buttonSetActiveHistoryItem.Name = "buttonSetActiveHistoryItem";
            this.buttonSetActiveHistoryItem.Size = new System.Drawing.Size(154, 40);
            this.buttonSetActiveHistoryItem.TabIndex = 4;
            this.buttonSetActiveHistoryItem.Text = "Make Active Item";
            this.buttonSetActiveHistoryItem.UseVisualStyleBackColor = true;
            this.buttonSetActiveHistoryItem.Click += new System.EventHandler(this.buttonSetActiveHistoryItem_Click);
            // 
            // labelHeaderHistoryGUID
            // 
            this.labelHeaderHistoryGUID.AutoSize = true;
            this.labelHeaderHistoryGUID.Location = new System.Drawing.Point(481, 112);
            this.labelHeaderHistoryGUID.Name = "labelHeaderHistoryGUID";
            this.labelHeaderHistoryGUID.Size = new System.Drawing.Size(83, 20);
            this.labelHeaderHistoryGUID.TabIndex = 5;
            this.labelHeaderHistoryGUID.Text = "History ID:";
            // 
            // labelHeaderIndex
            // 
            this.labelHeaderIndex.AutoSize = true;
            this.labelHeaderIndex.Location = new System.Drawing.Point(481, 81);
            this.labelHeaderIndex.Name = "labelHeaderIndex";
            this.labelHeaderIndex.Size = new System.Drawing.Size(52, 20);
            this.labelHeaderIndex.TabIndex = 6;
            this.labelHeaderIndex.Text = "Index:";
            // 
            // textBoxHistoryContents
            // 
            this.textBoxHistoryContents.Location = new System.Drawing.Point(480, 276);
            this.textBoxHistoryContents.Name = "textBoxHistoryContents";
            this.textBoxHistoryContents.Size = new System.Drawing.Size(680, 326);
            this.textBoxHistoryContents.TabIndex = 7;
            this.textBoxHistoryContents.Text = "";
            // 
            // labelHeaderContents
            // 
            this.labelHeaderContents.AutoSize = true;
            this.labelHeaderContents.Location = new System.Drawing.Point(476, 249);
            this.labelHeaderContents.Name = "labelHeaderContents";
            this.labelHeaderContents.Size = new System.Drawing.Size(112, 20);
            this.labelHeaderContents.TabIndex = 8;
            this.labelHeaderContents.Text = "Text Contents:";
            // 
            // labelIndex
            // 
            this.labelIndex.AutoSize = true;
            this.labelIndex.Location = new System.Drawing.Point(623, 81);
            this.labelIndex.Name = "labelIndex";
            this.labelIndex.Size = new System.Drawing.Size(56, 20);
            this.labelIndex.TabIndex = 11;
            this.labelIndex.Text = "[Index]";
            // 
            // labelHistoryGUID
            // 
            this.labelHistoryGUID.AutoSize = true;
            this.labelHistoryGUID.Location = new System.Drawing.Point(623, 112);
            this.labelHistoryGUID.Name = "labelHistoryGUID";
            this.labelHistoryGUID.Size = new System.Drawing.Size(87, 20);
            this.labelHistoryGUID.TabIndex = 10;
            this.labelHistoryGUID.Text = "[History ID]";
            // 
            // labelHistoryStatus
            // 
            this.labelHistoryStatus.AutoSize = true;
            this.labelHistoryStatus.Location = new System.Drawing.Point(962, 66);
            this.labelHistoryStatus.Name = "labelHistoryStatus";
            this.labelHistoryStatus.Size = new System.Drawing.Size(180, 20);
            this.labelHistoryStatus.TabIndex = 12;
            this.labelHistoryStatus.Text = "Clipboard History Status";
            // 
            // listViewAvailableFormats
            // 
            this.listViewAvailableFormats.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewAvailableFormats.HideSelection = false;
            this.listViewAvailableFormats.Location = new System.Drawing.Point(627, 147);
            this.listViewAvailableFormats.Name = "listViewAvailableFormats";
            this.listViewAvailableFormats.ShowGroups = false;
            this.listViewAvailableFormats.Size = new System.Drawing.Size(375, 113);
            this.listViewAvailableFormats.TabIndex = 13;
            this.listViewAvailableFormats.UseCompatibleStateImageBehavior = false;
            this.listViewAvailableFormats.View = System.Windows.Forms.View.List;
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 614);
            this.Controls.Add(this.listViewAvailableFormats);
            this.Controls.Add(this.labelHistoryStatus);
            this.Controls.Add(this.labelIndex);
            this.Controls.Add(this.labelHistoryGUID);
            this.Controls.Add(this.labelHeaderContents);
            this.Controls.Add(this.textBoxHistoryContents);
            this.Controls.Add(this.labelHeaderIndex);
            this.Controls.Add(this.labelHeaderHistoryGUID);
            this.Controls.Add(this.buttonSetActiveHistoryItem);
            this.Controls.Add(this.labelHeaderAvailableFormats);
            this.Controls.Add(this.buttonDeleteHistoryItem);
            this.Controls.Add(this.dataGridViewHistory);
            this.Controls.Add(this.buttonRefreshHistory);
            this.Name = "HistoryForm";
            this.Text = "HistoryForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button buttonRefreshHistory;
    private System.Windows.Forms.DataGridView dataGridViewHistory;
    private System.Windows.Forms.Button buttonDeleteHistoryItem;
    private System.Windows.Forms.Label labelHeaderAvailableFormats;
    private System.Windows.Forms.Button buttonSetActiveHistoryItem;
    private System.Windows.Forms.Label labelHeaderHistoryGUID;
    private System.Windows.Forms.Label labelHeaderIndex;
    private System.Windows.Forms.RichTextBox textBoxHistoryContents;
    private System.Windows.Forms.Label labelHeaderContents;
    private System.Windows.Forms.Label labelIndex;
    private System.Windows.Forms.Label labelHistoryGUID;
    private System.Windows.Forms.Label labelHistoryStatus;
    private System.Windows.Forms.ListView listViewAvailableFormats;
}