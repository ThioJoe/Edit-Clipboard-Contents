using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace EditClipboardContents
{
    public class RichTextBoxContextMenuManager
    {
        // Custom event to signal when the parent form should modify its suppression variable
        public event EventHandler<bool> SetSuppressionVariableForParentForm;

        // Helper method to raise event to tell parent form to suppress selection change events
        private void RaiseSuppressionEvent(bool suppressValue)
        {
            SetSuppressionVariableForParentForm?.Invoke(this, suppressValue);
        }

        private ContextMenuStrip contextMenu;
        private ToolStripMenuItem menuItemCopy;
        private ToolStripMenuItem menuItemCopyAllPlaintext;
        private ToolStripMenuItem menuItemSelectAll;
        private ToolStripMenuItem menuItemCopyLink;
        private ToolStripMenuItem menuItemOpenLink;
        private ToolStripSeparator separatorCopy;
        private ToolStripSeparator separatorLinks;
        private string lastSelectedHyperlink;

        public RichTextBoxContextMenuManager()
        {
            InitializeContextMenu();
        }

        private void InitializeContextMenu()
        {
            contextMenu = new ContextMenuStrip();

            menuItemCopy = new ToolStripMenuItem("Copy");
            menuItemCopyAllPlaintext = new ToolStripMenuItem("Copy All");
            menuItemSelectAll = new ToolStripMenuItem("Select All");
            menuItemCopyLink = new ToolStripMenuItem("Copy Link");
            menuItemOpenLink = new ToolStripMenuItem("Open Link");
            separatorCopy = new ToolStripSeparator();
            separatorLinks = new ToolStripSeparator();

            contextMenu.Items.AddRange(new ToolStripItem[] {
                menuItemOpenLink,
                menuItemCopyLink,
                separatorLinks,
                menuItemCopy,
                separatorCopy,
                menuItemSelectAll,
                menuItemCopyAllPlaintext,
            });

            // Attach event handlers
            contextMenu.Opening += ContextMenu_Opening;
            menuItemCopy.Click += MenuItemCopy_Click;
            menuItemCopyAllPlaintext.Click += MenuItemCopyAllPlaintext_Click;
            menuItemSelectAll.Click += MenuItemSelectAll_Click;
            menuItemCopyLink.Click += MenuItemCopyLink_Click;
            menuItemOpenLink.Click += MenuItemOpenLink_Click;
        }

        public void AttachToRichTextBox(RichTextBox richTextBox)
        {
            richTextBox.ContextMenuStrip = contextMenu;
            richTextBox.MouseDown += RichTextBox_MouseDown;
        }

        // ------------------------------ Contents Text Boxes Context Menu Events ---------------------------------

        // Decide which options to show in the menu
        private void ContextMenu_Opening(object sender, CancelEventArgs e)
        {
            // Conditions depending on if anything is selected
            if ( sender is ContextMenuStrip contextMenu && contextMenu.SourceControl is RichTextBox richTextBox )
            {
                // No Text Selected - Disable the regular 'copy' button, but enable the 'copy all' buttons
                if ( string.IsNullOrEmpty(richTextBox.SelectedText) )
                {
                    menuItemCopy.Visible = false;
                    separatorCopy.Visible = false;
                    menuItemCopyAllPlaintext.Visible = true;
                }
                // Text Selected - Enable the regular 'copy' button, but disable the 'copy all' buttons
                else
                {
                    menuItemCopy.Visible = true;
                    separatorCopy.Visible = true;
                    menuItemCopyAllPlaintext.Visible = false;
                }
            }
        }

        private void MenuItemCopyAllPlaintext_Click(object sender, EventArgs e)
        {
            // Get the text box that the context menu was opened from
            if ( sender is ToolStripMenuItem menuItem
                && menuItem.Owner is ContextMenuStrip contextMenu
                && contextMenu.SourceControl is RichTextBox richTextBox )
            {
                // Since we're copying everything, we can use the Text property instead of SelectedText, which gives us the contents in plaintext
                CopyIfValid(richTextBox.Text);
            }
        }

        private void MenuItemCopy_Click(object sender, EventArgs e)
        {
            // Get the text box that the context menu was opened from
            if ( sender is ToolStripMenuItem menuItem
                && menuItem.Owner is ContextMenuStrip contextMenu
                && contextMenu.SourceControl is RichTextBox richTextBox )
            {
                // Use SelectedText property to get the plaintext, instead of doing .Copy() method which would copy with formatting
                CopyIfValid(richTextBox.SelectedText);
            }
        }

        private void MenuItemSelectAll_Click(object sender, EventArgs e)
        {
            // Get the text box that the context menu was opened from
            if ( sender is ToolStripMenuItem menuItem
                && menuItem.Owner is ContextMenuStrip contextMenu
                && contextMenu.SourceControl is RichTextBox richTextBox )
            {
                richTextBox.SelectAll();
            }
        }

        private void MenuItemOpenLink_Click(object sender, EventArgs e)
        {
            if ( !String.IsNullOrEmpty(lastSelectedHyperlink) ) // Should not be null or empty here but just in case
            {
                try
                {
                    System.Diagnostics.Process.Start(lastSelectedHyperlink);
                }
                catch ( Exception ex )
                {
                    MessageBox.Show($"Error opening link: {lastSelectedHyperlink}\n\nError:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void MenuItemCopyLink_Click(object sender, EventArgs e)
        {
            CopyIfValid(lastSelectedHyperlink);
        }

        private void RichTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            // Decide whether to show the 'Copy Hyperlink' context menu item depending on if the mouse is over a hyperlink when right clicking
            if ( e.Button == MouseButtons.Right && sender is RichTextBox richTextBox )
            {
                // Set the default visibility to false unless it's a link for the link related menu items
                menuItemCopyLink.Visible = false;
                menuItemOpenLink.Visible = false;
                separatorLinks.Visible = false;

                // Get the indexes range of the current selection
                int start = richTextBox.SelectionStart;
                int length = richTextBox.SelectionLength;

                // Get the character index at the mouse position
                int charIndex = richTextBox.GetCharIndexFromPosition(e.Location);

                // Signal to the parent form to suppress selection change events
                RaiseSuppressionEvent(true);

                // Create a temporary selection to check formatting
                richTextBox.Select(charIndex, 1);

                // Check if it's a hyperlink indirectly, by checking if the 'selectionrtf' has a blue color table, but selected text is not blue
                // This signals the blue formatting is from a hyperlink, not just a blue font color
                string lookForStr = @"{\colortbl ;\red0\green0\blue255;}";

                // If it is a hyperlink
                if ( richTextBox.SelectedRtf.Contains(lookForStr) && !richTextBox.SelectionColor.Equals(Color.Blue) )
                {
                    string url = GetLinkAtPosition(richTextBox, charIndex);
                    if ( !String.IsNullOrEmpty(url) )
                    {
                        menuItemCopyLink.Visible = true;
                        menuItemOpenLink.Visible = true;
                        separatorLinks.Visible = true;
                        lastSelectedHyperlink = url;
                    }
                }

                // Restore the original selection. If it fails for some reason set a default selection
                try
                {
                    richTextBox.Select(start, length);
                }
                catch
                {
                    richTextBox.Select(0, 0);
                }

                // Signal to the parent form to restore selection change events
                RaiseSuppressionEvent(false);
            }
        }

        private string GetLinkAtPosition(RichTextBox richTextBox, int charIndex)
        {
            // Store original selection
            int originalStart = richTextBox.SelectionStart;
            int originalLength = richTextBox.SelectionLength;

            try
            {
                // First scan backwards to previous whitespace or start of document
                int start = charIndex;
                while ( start > 0 && !char.IsWhiteSpace(richTextBox.Text[start - 1]) )
                {
                    start--;
                }

                // Then scan forwards to next whitespace or end of document
                int end = charIndex;
                while ( end < richTextBox.TextLength && !char.IsWhiteSpace(richTextBox.Text[end]) )
                {
                    end++;
                }

                // Select the word and check if it's a hyperlink
                richTextBox.Select(start, end - start);
                string rtf = richTextBox.SelectedRtf;

                if ( rtf.Contains("HYPERLINK") )
                {
                    int linkStart = rtf.IndexOf(@"HYPERLINK ");
                    if ( linkStart != -1 )
                    {
                        linkStart += @"HYPERLINK ".Length;
                        int linkEnd = rtf.IndexOf(' ', linkStart); // Find the index of the next space after the link
                        if ( linkEnd != -1 )
                        {
                            return rtf.Substring(linkStart, linkEnd - linkStart);
                        }
                    }
                }

                return "";
            }
            finally
            {
                // Restore original selection
                try
                {
                    richTextBox.Select(originalStart, originalLength);
                }
                catch
                {
                    richTextBox.Select(0, 0);
                }
            }
        }

        private static void CopyIfValid(string text)
        {
            if ( !string.IsNullOrEmpty(text) )
                Clipboard.SetText(text);
            else
            {
                // Show a tooltip if the user tries to copy an empty string
                ToolTip tt = new ToolTip();
                Point cursorPosition = Form.ActiveForm.PointToClient(Cursor.Position);
                cursorPosition.Y += 20; // Offset the Y coordinate by 20 pixels downward
                tt.Show("Nothing to copy", Form.ActiveForm, cursorPosition, 1500);
            }
        }
    }
}