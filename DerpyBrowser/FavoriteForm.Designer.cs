namespace DerpyBrowser
{
    partial class FavoriteForm
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
            if (disposing && (components != null))
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
            this.components = new System.ComponentModel.Container();
            this.rightClickMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editTitleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.nameMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nameBox = new System.Windows.Forms.ToolStripTextBox();
            this.rightClickMenu.SuspendLayout();
            this.nameMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // rightClickMenu
            // 
            this.rightClickMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeToolStripMenuItem,
            this.editTitleToolStripMenuItem});
            this.rightClickMenu.Name = "rightClickMenu";
            this.rightClickMenu.Size = new System.Drawing.Size(116, 48);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // editTitleToolStripMenuItem
            // 
            this.editTitleToolStripMenuItem.Name = "editTitleToolStripMenuItem";
            this.editTitleToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.editTitleToolStripMenuItem.Text = "Edit Title";
            this.editTitleToolStripMenuItem.Click += new System.EventHandler(this.editTitleToolStripMenuItem_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 13);
            this.listBox1.MultiColumn = true;
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(787, 498);
            this.listBox1.TabIndex = 0;
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick_1);
            this.listBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDown);
            // 
            // nameMenu
            // 
            this.nameMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nameBox});
            this.nameMenu.Name = "contextMenuStrip1";
            this.nameMenu.Size = new System.Drawing.Size(261, 27);
            // 
            // nameBox
            // 
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(200, 21);
            this.nameBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nameBox_KeyDown);
            // 
            // FavoriteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 515);
            this.Controls.Add(this.listBox1);
            this.Name = "FavoriteForm";
            this.Text = "FavoriteForm";
            this.rightClickMenu.ResumeLayout(false);
            this.nameMenu.ResumeLayout(false);
            this.nameMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip rightClickMenu;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editTitleToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ContextMenuStrip nameMenu;
        private System.Windows.Forms.ToolStripTextBox nameBox;
    }
}