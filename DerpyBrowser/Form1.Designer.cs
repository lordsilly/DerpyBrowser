namespace DerpyBrowser
{
    partial class Form1
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
            this.urlBox = new System.Windows.Forms.TextBox();
            this.navigateButton = new System.Windows.Forms.Button();
            this.tabsContainer = new System.Windows.Forms.TabControl();
            this.backButton = new System.Windows.Forms.Button();
            this.forwardButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.newTabButton = new System.Windows.Forms.Button();
            this.addFaveButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.homeMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.setCurrentPageAsHomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.forwardMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addFaveMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nameBox = new System.Windows.Forms.ToolStripTextBox();
            this.closeTabButton = new System.Windows.Forms.Button();
            this.homeMenu.SuspendLayout();
            this.addFaveMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // urlBox
            // 
            this.urlBox.Location = new System.Drawing.Point(12, 12);
            this.urlBox.Name = "urlBox";
            this.urlBox.Size = new System.Drawing.Size(980, 20);
            this.urlBox.TabIndex = 1;
            this.urlBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.urlBox_KeyDown);
            // 
            // navigateButton
            // 
            this.navigateButton.Location = new System.Drawing.Point(993, 12);
            this.navigateButton.Name = "navigateButton";
            this.navigateButton.Size = new System.Drawing.Size(71, 19);
            this.navigateButton.TabIndex = 2;
            this.navigateButton.Text = "Derp";
            this.navigateButton.UseVisualStyleBackColor = true;
            this.navigateButton.Click += new System.EventHandler(this.navigateButton_Click);
            // 
            // tabsContainer
            // 
            this.tabsContainer.Location = new System.Drawing.Point(12, 67);
            this.tabsContainer.Name = "tabsContainer";
            this.tabsContainer.SelectedIndex = 0;
            this.tabsContainer.Size = new System.Drawing.Size(1053, 522);
            this.tabsContainer.TabIndex = 3;
            this.tabsContainer.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabsContainer_Selected);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 38);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(50, 23);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "<-";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            this.backButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.backButton_MouseDown);
            // 
            // forwardButton
            // 
            this.forwardButton.Location = new System.Drawing.Point(68, 38);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(50, 23);
            this.forwardButton.TabIndex = 5;
            this.forwardButton.Text = "->";
            this.forwardButton.UseVisualStyleBackColor = true;
            this.forwardButton.Click += new System.EventHandler(this.forwardButton_Click);
            this.forwardButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.forwardButton_MouseDown);
            // 
            // homeButton
            // 
            this.homeButton.Location = new System.Drawing.Point(124, 39);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(50, 23);
            this.homeButton.TabIndex = 6;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            this.homeButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.homeButton_MouseDown);
            // 
            // newTabButton
            // 
            this.newTabButton.Location = new System.Drawing.Point(911, 41);
            this.newTabButton.Name = "newTabButton";
            this.newTabButton.Size = new System.Drawing.Size(73, 22);
            this.newTabButton.TabIndex = 9;
            this.newTabButton.Text = "New Tab";
            this.newTabButton.UseVisualStyleBackColor = true;
            this.newTabButton.Click += new System.EventHandler(this.newTabButton_Click);
            // 
            // addFaveButton
            // 
            this.addFaveButton.Location = new System.Drawing.Point(312, 41);
            this.addFaveButton.Name = "addFaveButton";
            this.addFaveButton.Size = new System.Drawing.Size(103, 22);
            this.addFaveButton.TabIndex = 10;
            this.addFaveButton.Text = "Add To Favorites";
            this.addFaveButton.UseVisualStyleBackColor = true;
            this.addFaveButton.Click += new System.EventHandler(this.addFaveButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(180, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "History";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(236, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Favourites";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.favoritesButton_Click);
            // 
            // homeMenu
            // 
            this.homeMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setCurrentPageAsHomeToolStripMenuItem});
            this.homeMenu.Name = "homeMenu";
            this.homeMenu.Size = new System.Drawing.Size(199, 26);
            // 
            // setCurrentPageAsHomeToolStripMenuItem
            // 
            this.setCurrentPageAsHomeToolStripMenuItem.Name = "setCurrentPageAsHomeToolStripMenuItem";
            this.setCurrentPageAsHomeToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.setCurrentPageAsHomeToolStripMenuItem.Text = "Set current page as home";
            this.setCurrentPageAsHomeToolStripMenuItem.Click += new System.EventHandler(this.setCurrentPageAsHomeToolStripMenuItem_Click);
            // 
            // backMenu
            // 
            this.backMenu.Name = "backMenu";
            this.backMenu.Size = new System.Drawing.Size(61, 4);
            this.backMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.backMenu_ItemClicked);
            // 
            // forwardMenu
            // 
            this.forwardMenu.Name = "forwardMenu";
            this.forwardMenu.Size = new System.Drawing.Size(61, 4);
            this.forwardMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.forwardMenu_ItemClicked);
            // 
            // addFaveMenu
            // 
            this.addFaveMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nameBox});
            this.addFaveMenu.Name = "addFaveMenu";
            this.addFaveMenu.Size = new System.Drawing.Size(261, 27);
            // 
            // nameBox
            // 
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(200, 21);
            this.nameBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nameBox_KeyDown);
            // 
            // closeTabButton
            // 
            this.closeTabButton.Location = new System.Drawing.Point(990, 41);
            this.closeTabButton.Name = "closeTabButton";
            this.closeTabButton.Size = new System.Drawing.Size(73, 22);
            this.closeTabButton.TabIndex = 13;
            this.closeTabButton.Text = "Close Tab";
            this.closeTabButton.UseVisualStyleBackColor = true;
            this.closeTabButton.Click += new System.EventHandler(this.closeTabButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 601);
            this.Controls.Add(this.closeTabButton);
            this.Controls.Add(this.addFaveButton);
            this.Controls.Add(this.newTabButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.forwardButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.tabsContainer);
            this.Controls.Add(this.navigateButton);
            this.Controls.Add(this.urlBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.homeMenu.ResumeLayout(false);
            this.addFaveMenu.ResumeLayout(false);
            this.addFaveMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox urlBox;
        private System.Windows.Forms.Button navigateButton;
        private System.Windows.Forms.TabControl tabsContainer;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button forwardButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button newTabButton;
        private System.Windows.Forms.Button addFaveButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ContextMenuStrip homeMenu;
        private System.Windows.Forms.ToolStripMenuItem setCurrentPageAsHomeToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip backMenu;
        private System.Windows.Forms.ContextMenuStrip forwardMenu;
        private System.Windows.Forms.ContextMenuStrip addFaveMenu;
        private System.Windows.Forms.ToolStripTextBox nameBox;
        private System.Windows.Forms.Button closeTabButton;
    }
}

