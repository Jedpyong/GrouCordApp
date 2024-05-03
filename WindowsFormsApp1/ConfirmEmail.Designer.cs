namespace WindowsFormsApp1
{
    partial class ConfirmEmail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmEmail));
            this.close = new Guna.UI.WinForms.GunaImageButton();
            this.gunaGradientPanel1 = new Guna.UI.WinForms.GunaGradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OTPTxtbx = new Guna.UI.WinForms.GunaTextBox();
            this.confirmbutn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Red;
            this.close.Image = global::WindowsFormsApp1.Properties.Resources.close_4361951;
            this.close.ImageSize = new System.Drawing.Size(27, 27);
            this.close.Location = new System.Drawing.Point(426, 1);
            this.close.Name = "close";
            this.close.OnHoverImage = null;
            this.close.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.close.Size = new System.Drawing.Size(20, 20);
            this.close.TabIndex = 10;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // gunaGradientPanel1
            // 
            this.gunaGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaGradientPanel1.BackgroundImage")));
            this.gunaGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaGradientPanel1.Controls.Add(this.gunaPictureBox1);
            this.gunaGradientPanel1.Controls.Add(this.label1);
            this.gunaGradientPanel1.Controls.Add(this.label2);
            this.gunaGradientPanel1.Controls.Add(this.OTPTxtbx);
            this.gunaGradientPanel1.Controls.Add(this.confirmbutn);
            this.gunaGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaGradientPanel1.GradiantColor1 = System.Drawing.Color.Black;
            this.gunaGradientPanel1.GradiantColor2 = System.Drawing.Color.Blue;
            this.gunaGradientPanel1.GradiantColor3 = System.Drawing.Color.Black;
            this.gunaGradientPanel1.GradiantColor4 = System.Drawing.Color.Black;
            this.gunaGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaGradientPanel1.Name = "gunaGradientPanel1";
            this.gunaGradientPanel1.Size = new System.Drawing.Size(447, 285);
            this.gunaGradientPanel1.TabIndex = 19;
            this.gunaGradientPanel1.Text = "gunaGradientPanel1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(35, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Confirm OTP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(180, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "GrouCord";
            // 
            // OTPTxtbx
            // 
            this.OTPTxtbx.BaseColor = System.Drawing.Color.White;
            this.OTPTxtbx.BorderColor = System.Drawing.Color.Silver;
            this.OTPTxtbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.OTPTxtbx.FocusedBaseColor = System.Drawing.Color.White;
            this.OTPTxtbx.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.OTPTxtbx.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.OTPTxtbx.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.OTPTxtbx.Location = new System.Drawing.Point(79, 138);
            this.OTPTxtbx.Name = "OTPTxtbx";
            this.OTPTxtbx.PasswordChar = '\0';
            this.OTPTxtbx.Size = new System.Drawing.Size(160, 30);
            this.OTPTxtbx.TabIndex = 8;
            // 
            // confirmbutn
            // 
            this.confirmbutn.AnimationHoverSpeed = 0.07F;
            this.confirmbutn.AnimationSpeed = 0.03F;
            this.confirmbutn.BackColor = System.Drawing.Color.Transparent;
            this.confirmbutn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.confirmbutn.BorderColor = System.Drawing.Color.Black;
            this.confirmbutn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.confirmbutn.CheckedBorderColor = System.Drawing.Color.Black;
            this.confirmbutn.CheckedForeColor = System.Drawing.Color.White;
            this.confirmbutn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("confirmbutn.CheckedImage")));
            this.confirmbutn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.confirmbutn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.confirmbutn.ForeColor = System.Drawing.Color.White;
            this.confirmbutn.Image = null;
            this.confirmbutn.ImageSize = new System.Drawing.Size(20, 20);
            this.confirmbutn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.confirmbutn.Location = new System.Drawing.Point(285, 138);
            this.confirmbutn.Name = "confirmbutn";
            this.confirmbutn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.confirmbutn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.confirmbutn.OnHoverForeColor = System.Drawing.Color.White;
            this.confirmbutn.OnHoverImage = null;
            this.confirmbutn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.confirmbutn.OnPressedColor = System.Drawing.Color.Black;
            this.confirmbutn.Radius = 7;
            this.confirmbutn.Size = new System.Drawing.Size(81, 30);
            this.confirmbutn.TabIndex = 9;
            this.confirmbutn.Text = "Confirm";
            this.confirmbutn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.confirmbutn.Click += new System.EventHandler(this.confirmbutn_Click);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.GrouCord_Logo;
            this.gunaPictureBox1.Location = new System.Drawing.Point(116, 12);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Radius = 10;
            this.gunaPictureBox1.Size = new System.Drawing.Size(69, 60);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 22;
            this.gunaPictureBox1.TabStop = false;
            // 
            // ConfirmEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 285);
            this.Controls.Add(this.close);
            this.Controls.Add(this.gunaGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConfirmEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfirmEmail";
            this.Load += new System.EventHandler(this.ConfirmEmail_Load);
            this.gunaGradientPanel1.ResumeLayout(false);
            this.gunaGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaTextBox OTPTxtbx;
        private Guna.UI.WinForms.GunaAdvenceButton confirmbutn;
        private Guna.UI.WinForms.GunaGradientPanel gunaGradientPanel1;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaImageButton close;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
    }
}