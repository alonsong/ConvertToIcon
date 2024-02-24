namespace ImageToIconApp
{
    partial class FormMainApp
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainApp));
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.comboBoxSize = new System.Windows.Forms.ComboBox();
            this.buttonChangeIcon = new System.Windows.Forms.Button();
            this.textBoxImagePath = new System.Windows.Forms.TextBox();
            this.openFileDialogImage = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.Location = new System.Drawing.Point(149, 66);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(117, 30);
            this.btnSelectImage.TabIndex = 0;
            this.btnSelectImage.Text = "PNG图片选择";
            this.btnSelectImage.UseVisualStyleBackColor = true;
            this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click);
            // 
            // comboBoxSize
            // 
            this.comboBoxSize.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxSize.FormattingEnabled = true;
            this.comboBoxSize.Items.AddRange(new object[] {
            "16*16",
            "24*24",
            "32*32",
            "48*48",
            "64*64",
            "72*72",
            "92*92",
            "108*108"});
            this.comboBoxSize.Location = new System.Drawing.Point(23, 25);
            this.comboBoxSize.Name = "comboBoxSize";
            this.comboBoxSize.Size = new System.Drawing.Size(95, 25);
            this.comboBoxSize.TabIndex = 2;
            this.comboBoxSize.Text = "16*16";
            // 
            // buttonChangeIcon
            // 
            this.buttonChangeIcon.Location = new System.Drawing.Point(328, 66);
            this.buttonChangeIcon.Name = "buttonChangeIcon";
            this.buttonChangeIcon.Size = new System.Drawing.Size(117, 30);
            this.buttonChangeIcon.TabIndex = 4;
            this.buttonChangeIcon.Text = "Icon转换";
            this.buttonChangeIcon.UseVisualStyleBackColor = true;
            this.buttonChangeIcon.Click += new System.EventHandler(this.buttonChangeIcon_Click);
            // 
            // textBoxImagePath
            // 
            this.textBoxImagePath.Enabled = false;
            this.textBoxImagePath.Location = new System.Drawing.Point(124, 25);
            this.textBoxImagePath.Name = "textBoxImagePath";
            this.textBoxImagePath.Size = new System.Drawing.Size(501, 25);
            this.textBoxImagePath.TabIndex = 5;
            // 
            // openFileDialogImage
            // 
            this.openFileDialogImage.RestoreDirectory = true;
            this.openFileDialogImage.Title = "图片选择";
            // 
            // FormMainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 130);
            this.Controls.Add(this.textBoxImagePath);
            this.Controls.Add(this.buttonChangeIcon);
            this.Controls.Add(this.comboBoxSize);
            this.Controls.Add(this.btnSelectImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMainApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图片转换Icon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectImage;
        private System.Windows.Forms.ComboBox comboBoxSize;
        private System.Windows.Forms.Button buttonChangeIcon;
        private System.Windows.Forms.TextBox textBoxImagePath;
        private System.Windows.Forms.OpenFileDialog openFileDialogImage;
    }
}

