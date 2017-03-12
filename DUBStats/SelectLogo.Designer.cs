namespace DUBStats
{
    partial class SelectLogo
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
            this.imagePanel = new System.Windows.Forms.Panel();
            this.instructions1Label = new System.Windows.Forms.Label();
            this.instructions2Label = new System.Windows.Forms.Label();
            this.selectImageButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.imagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // imagePanel
            // 
            this.imagePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagePanel.Controls.Add(this.pictureBox);
            this.imagePanel.Location = new System.Drawing.Point(12, 12);
            this.imagePanel.Name = "imagePanel";
            this.imagePanel.Size = new System.Drawing.Size(200, 200);
            this.imagePanel.TabIndex = 0;
            // 
            // instructions1Label
            // 
            this.instructions1Label.Location = new System.Drawing.Point(219, 13);
            this.instructions1Label.Name = "instructions1Label";
            this.instructions1Label.Size = new System.Drawing.Size(299, 36);
            this.instructions1Label.TabIndex = 1;
            this.instructions1Label.Text = "Select an image with your Company Logo. The image will appear on your output docu" +
    "ments. ";
            // 
            // instructions2Label
            // 
            this.instructions2Label.Location = new System.Drawing.Point(219, 49);
            this.instructions2Label.Name = "instructions2Label";
            this.instructions2Label.Size = new System.Drawing.Size(296, 32);
            this.instructions2Label.TabIndex = 2;
            this.instructions2Label.Text = "The maximum dimension for the image must be 200 x 200 pixels.";
            // 
            // selectImageButton
            // 
            this.selectImageButton.Location = new System.Drawing.Point(222, 189);
            this.selectImageButton.Name = "selectImageButton";
            this.selectImageButton.Size = new System.Drawing.Size(95, 23);
            this.selectImageButton.TabIndex = 3;
            this.selectImageButton.Text = "Select Image...";
            this.selectImageButton.UseVisualStyleBackColor = true;
            this.selectImageButton.Click += new System.EventHandler(this.selectImageButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(450, 266);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(369, 266);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save Image";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(198, 198);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // SelectLogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 301);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.selectImageButton);
            this.Controls.Add(this.instructions2Label);
            this.Controls.Add(this.instructions1Label);
            this.Controls.Add(this.imagePanel);
            this.Name = "SelectLogo";
            this.Text = "Select Company Logo";
            this.imagePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel imagePanel;
        private System.Windows.Forms.Label instructions1Label;
        private System.Windows.Forms.Label instructions2Label;
        private System.Windows.Forms.Button selectImageButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}