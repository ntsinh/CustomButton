namespace UserControl
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            customButton1 = new CustomButton();
            customButton2 = new CustomButton();
            customButton3 = new CustomButton();
            SuspendLayout();
            // 
            // customButton1
            // 
            customButton1.BackColor = Color.Orange;
            customButton1.BackgroundColor = Color.Orange;
            customButton1.BorderColor = Color.PaleVioletRed;
            customButton1.BorderRadius = 10;
            customButton1.BorderSize = 0;
            customButton1.FlatAppearance.BorderSize = 0;
            customButton1.FlatStyle = FlatStyle.Flat;
            customButton1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            customButton1.ForeColor = Color.White;
            customButton1.Image = (Image)resources.GetObject("customButton1.Image");
            customButton1.ImageAlign = ContentAlignment.MiddleLeft;
            customButton1.Location = new Point(26, 23);
            customButton1.Name = "customButton1";
            customButton1.Padding = new Padding(7, 0, 0, 0);
            customButton1.Size = new Size(261, 51);
            customButton1.TabIndex = 0;
            customButton1.Text = "Thêm sản phảm";
            customButton1.TextColor = Color.White;
            customButton1.UseVisualStyleBackColor = false;
            // 
            // customButton2
            // 
            customButton2.BackColor = Color.LimeGreen;
            customButton2.BackgroundColor = Color.LimeGreen;
            customButton2.BorderColor = Color.PaleVioletRed;
            customButton2.BorderRadius = 10;
            customButton2.BorderSize = 0;
            customButton2.FlatAppearance.BorderSize = 0;
            customButton2.FlatStyle = FlatStyle.Flat;
            customButton2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            customButton2.ForeColor = Color.White;
            customButton2.Image = Properties.Resources.edit;
            customButton2.ImageAlign = ContentAlignment.MiddleLeft;
            customButton2.Location = new Point(26, 91);
            customButton2.Name = "customButton2";
            customButton2.Padding = new Padding(8, 0, 0, 0);
            customButton2.Size = new Size(261, 51);
            customButton2.TabIndex = 0;
            customButton2.Text = "Sửa thông tin";
            customButton2.TextColor = Color.White;
            customButton2.UseVisualStyleBackColor = false;
            // 
            // customButton3
            // 
            customButton3.BackColor = Color.White;
            customButton3.BackgroundColor = Color.White;
            customButton3.BorderColor = Color.Red;
            customButton3.BorderRadius = 10;
            customButton3.BorderSize = 2;
            customButton3.FlatAppearance.BorderSize = 0;
            customButton3.FlatStyle = FlatStyle.Flat;
            customButton3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            customButton3.ForeColor = Color.Red;
            customButton3.Image = (Image)resources.GetObject("customButton3.Image");
            customButton3.ImageAlign = ContentAlignment.MiddleLeft;
            customButton3.Location = new Point(26, 158);
            customButton3.Name = "customButton3";
            customButton3.Padding = new Padding(7, 0, 0, 0);
            customButton3.Size = new Size(261, 51);
            customButton3.TabIndex = 0;
            customButton3.Text = "Xóa sản phẩm";
            customButton3.TextColor = Color.Red;
            customButton3.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 228);
            Controls.Add(customButton3);
            Controls.Add(customButton2);
            Controls.Add(customButton1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private CustomButton customButton1;
        private CustomButton customButton2;
        private CustomButton customButton3;
    }
}