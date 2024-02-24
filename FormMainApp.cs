using ImageToIconApp.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageToIconApp
{
    public partial class FormMainApp : Form
    {
        public FormMainApp()
        {
            InitializeComponent();
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            this.openFileDialogImage.Filter = "(*.jpg)|*.jpg|(*.png)|*.png";
            DialogResult result=  this.openFileDialogImage.ShowDialog();
            if (result == DialogResult.OK)
            {
                var fileName = this.openFileDialogImage.FileName;
                if (!string.IsNullOrEmpty(fileName)) 
                {
                    this.textBoxImagePath.Text = fileName;
                }
            }
        }

        private void buttonChangeIcon_Click(object sender, EventArgs e)
        {
            var imagePath = this.textBoxImagePath.Text;
           var fileName = Path.GetFileNameWithoutExtension(imagePath);
            string outFilePath =$"{AppDomain.CurrentDomain.BaseDirectory}\\{fileName}.ico" ;
            if (!string.IsNullOrEmpty(imagePath)) 
            {
                var imageSize =  this.comboBoxSize.Text;
                var size = getConvertSize(imageSize);

                IconHelper.ConvertPNGToIcon(imagePath, outFilePath,size,false);
            }
        }
        /// <summary>
        /// 16*16 24*24 32*32 48*48 64*64 72*72 92*92 108*108
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        private int getConvertSize(string size) 
        {
            int sizeImgage = 16;
            switch (size)
            {
                case "16*16":
                    sizeImgage=16;
                    break;
                case "24*24":
                    sizeImgage = 24;
                    break;
                case "32*32":
                    sizeImgage = 32;
                    break;
                case "48*48":
                    sizeImgage = 48;
                    break;
                case "64*64":
                    sizeImgage = 64;
                    break;
                case "72*72":
                    sizeImgage=72;
                    break;
                case "92*92":
                    sizeImgage = 92;
                    break;
                case "108*108":
                    sizeImgage = 108;
                    break;
                default:
                    sizeImgage = 32;
                    break;
            }
            return sizeImgage;
        }
    }
}
