namespace DUBStats
{
    partial class FilmName
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
            this.filmNameLabel = new System.Windows.Forms.Label();
            this.filmNameTextBox = new System.Windows.Forms.TextBox();
            this.sendFilmName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // filmNameLabel
            // 
            this.filmNameLabel.AutoSize = true;
            this.filmNameLabel.Location = new System.Drawing.Point(12, 32);
            this.filmNameLabel.Name = "filmNameLabel";
            this.filmNameLabel.Size = new System.Drawing.Size(43, 13);
            this.filmNameLabel.TabIndex = 0;
            this.filmNameLabel.Text = "Project:";
            // 
            // filmNameTextBox
            // 
            this.filmNameTextBox.Location = new System.Drawing.Point(61, 25);
            this.filmNameTextBox.Name = "filmNameTextBox";
            this.filmNameTextBox.Size = new System.Drawing.Size(287, 20);
            this.filmNameTextBox.TabIndex = 1;
            // 
            // sendFilmName
            // 
            this.sendFilmName.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.sendFilmName.Location = new System.Drawing.Point(272, 52);
            this.sendFilmName.Name = "sendFilmName";
            this.sendFilmName.Size = new System.Drawing.Size(75, 23);
            this.sendFilmName.TabIndex = 2;
            this.sendFilmName.Text = "OK";
            this.sendFilmName.UseVisualStyleBackColor = true;
            this.sendFilmName.Click += new System.EventHandler(this.sendFilmName_Click);
            // 
            // FilmName
            // 
            this.AcceptButton = this.sendFilmName;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 102);
            this.Controls.Add(this.sendFilmName);
            this.Controls.Add(this.filmNameTextBox);
            this.Controls.Add(this.filmNameLabel);
            this.Name = "FilmName";
            this.Text = "Project Name";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label filmNameLabel;
        private System.Windows.Forms.TextBox filmNameTextBox;
        private System.Windows.Forms.Button sendFilmName;
    }
}