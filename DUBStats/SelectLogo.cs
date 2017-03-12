﻿using System;
using System.Windows.Forms;
using System.Reflection;
using System.Resources;
using System.Drawing;

namespace DUBStats
{
    public partial class SelectLogo : Form
    {
        public SelectLogo()
        {
            InitializeComponent();
            ResourceManager resources = new ResourceManager("DUBStats.Properties.Resources", Assembly.GetExecutingAssembly());
            Bitmap bitmap = (Bitmap)resources.GetObject("Bright_Way_Logo");

            pictureBox.Image = bitmap;
        }

        private void selectImageButton_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures),
                Title = @"Select File",
                Filter = @"JPG files|*.jpg|PNG files|*.png|GIF files|*.gif|Bitmap files|*.bmp|All Files|*.*"
            };

            if (openFileDialog.ShowDialog() != DialogResult.OK) return;
            {

                //    _inputFile = openFileDialog.FileName;
                //    fileLocationTextBox.Text = _inputFile;
                //    resultTextBox.Text = String.Empty;
                //    ParseInputFile(_inputFile);
            }

            //if (_filmName == String.Empty)
            //{
            //    ChangeProjectName();
            //}
        }
    }
}