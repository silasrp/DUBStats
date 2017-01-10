namespace DUBStats
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.selectFileLabel = new System.Windows.Forms.Label();
            this.fileLocationTextBox = new System.Windows.Forms.TextBox();
            this.getStatsButton = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.previewLbl = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openInputFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeProjectNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setOutputFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectFileLabel
            // 
            this.selectFileLabel.AutoSize = true;
            this.selectFileLabel.Location = new System.Drawing.Point(12, 43);
            this.selectFileLabel.Name = "selectFileLabel";
            this.selectFileLabel.Size = new System.Drawing.Size(59, 13);
            this.selectFileLabel.TabIndex = 0;
            this.selectFileLabel.Text = "Select File:";
            // 
            // fileLocationTextBox
            // 
            this.fileLocationTextBox.Location = new System.Drawing.Point(78, 39);
            this.fileLocationTextBox.Name = "fileLocationTextBox";
            this.fileLocationTextBox.Size = new System.Drawing.Size(306, 20);
            this.fileLocationTextBox.TabIndex = 1;
            // 
            // getStatsButton
            // 
            this.getStatsButton.Location = new System.Drawing.Point(390, 78);
            this.getStatsButton.Name = "getStatsButton";
            this.getStatsButton.Size = new System.Drawing.Size(93, 23);
            this.getStatsButton.TabIndex = 3;
            this.getStatsButton.Text = "Save Stats...";
            this.getStatsButton.UseVisualStyleBackColor = true;
            this.getStatsButton.Click += new System.EventHandler(this.getStatsButton_Click);
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(78, 78);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultTextBox.Size = new System.Drawing.Size(306, 323);
            this.resultTextBox.TabIndex = 4;
            // 
            // previewLbl
            // 
            this.previewLbl.AutoSize = true;
            this.previewLbl.Location = new System.Drawing.Point(12, 78);
            this.previewLbl.Name = "previewLbl";
            this.previewLbl.Size = new System.Drawing.Size(48, 13);
            this.previewLbl.TabIndex = 5;
            this.previewLbl.Text = "Preview:";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(391, 38);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(92, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search...";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(495, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openInputFileToolStripMenuItem,
            this.changeProjectNameToolStripMenuItem,
            this.setOutputFolderToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.menuToolStripMenuItem.Text = "Project Options";
            // 
            // openInputFileToolStripMenuItem
            // 
            this.openInputFileToolStripMenuItem.Name = "openInputFileToolStripMenuItem";
            this.openInputFileToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.openInputFileToolStripMenuItem.Text = "Open Input File...";
            this.openInputFileToolStripMenuItem.Click += new System.EventHandler(this.openInputFileToolStripMenuItem_Click);
            // 
            // changeProjectNameToolStripMenuItem
            // 
            this.changeProjectNameToolStripMenuItem.Name = "changeProjectNameToolStripMenuItem";
            this.changeProjectNameToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.changeProjectNameToolStripMenuItem.Text = "Change Project Name...";
            this.changeProjectNameToolStripMenuItem.Click += new System.EventHandler(this.changeProjectNameToolStripMenuItem_Click);
            // 
            // setOutputFolderToolStripMenuItem
            // 
            this.setOutputFolderToolStripMenuItem.Name = "setOutputFolderToolStripMenuItem";
            this.setOutputFolderToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.setOutputFolderToolStripMenuItem.Text = "Set Default Output Folder...";
            this.setOutputFolderToolStripMenuItem.Click += new System.EventHandler(this.setOutputFolderToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 417);
            this.Controls.Add(this.previewLbl);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.getStatsButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.fileLocationTextBox);
            this.Controls.Add(this.selectFileLabel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "DUBStats";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label selectFileLabel;
        private System.Windows.Forms.TextBox fileLocationTextBox;
        private System.Windows.Forms.Button getStatsButton;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Label previewLbl;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openInputFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeProjectNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setOutputFolderToolStripMenuItem;
    }
}

