namespace WindowsFormsApp1
{
    partial class ForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassword));
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.EmailTxtbx = new Guna.UI.WinForms.GunaTextBox();
            this.OTPTxtbx = new Guna.UI.WinForms.GunaTextBox();
            this.sendotpbutn = new Guna.UI.WinForms.GunaButton();
            this.confirmbutn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.close = new Guna.UI.WinForms.GunaImageButton();
            this.gunaGradientPanel1 = new Guna.UI.WinForms.GunaGradientPanel();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.label2 = new System.Windows.Forms.Label();
            this.gunaGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gunaLabel1.Location = new System.Drawing.Point(21, 70);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(182, 17);
            this.gunaLabel1.TabIndex = 2;
            this.gunaLabel1.Text = "Input your Email Address:";
            this.gunaLabel1.Click += new System.EventHandler(this.gunaLabel1_Click);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.gunaLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gunaLabel2.Location = new System.Drawing.Point(21, 162);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(118, 17);
            this.gunaLabel2.TabIndex = 3;
            this.gunaLabel2.Text = "Input OTP Code:";
            // 
            // EmailTxtbx
            // 
            this.EmailTxtbx.BackColor = System.Drawing.Color.Transparent;
            this.EmailTxtbx.BaseColor = System.Drawing.Color.White;
            this.EmailTxtbx.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.EmailTxtbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmailTxtbx.FocusedBaseColor = System.Drawing.Color.White;
            this.EmailTxtbx.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.EmailTxtbx.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.EmailTxtbx.Font = new System.Drawing.Font("Segoe UI Variable Small", 9F, System.Drawing.FontStyle.Bold);
            this.EmailTxtbx.Location = new System.Drawing.Point(71, 99);
            this.EmailTxtbx.Name = "EmailTxtbx";
            this.EmailTxtbx.PasswordChar = '\0';
            this.EmailTxtbx.Size = new System.Drawing.Size(160, 30);
            this.EmailTxtbx.TabIndex = 4;
            // 
            // OTPTxtbx
            // 
            this.OTPTxtbx.BackColor = System.Drawing.Color.Transparent;
            this.OTPTxtbx.BaseColor = System.Drawing.Color.White;
            this.OTPTxtbx.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.OTPTxtbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.OTPTxtbx.FocusedBaseColor = System.Drawing.Color.White;
            this.OTPTxtbx.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.OTPTxtbx.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.OTPTxtbx.Font = new System.Drawing.Font("Segoe UI Variable Small", 9F, System.Drawing.FontStyle.Bold);
            this.OTPTxtbx.Location = new System.Drawing.Point(71, 183);
            this.OTPTxtbx.Name = "OTPTxtbx";
            this.OTPTxtbx.PasswordChar = '\0';
            this.OTPTxtbx.Size = new System.Drawing.Size(160, 30);
            this.OTPTxtbx.TabIndex = 5;
            // 
            // sendotpbutn
            // 
            this.sendotpbutn.AnimationHoverSpeed = 0.07F;
            this.sendotpbutn.AnimationSpeed = 0.03F;
            this.sendotpbutn.BackColor = System.Drawing.Color.Transparent;
            this.sendotpbutn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.sendotpbutn.BorderColor = System.Drawing.Color.Black;
            this.sendotpbutn.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.sendotpbutn.ForeColor = System.Drawing.Color.White;
            this.sendotpbutn.Image = null;
            this.sendotpbutn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sendotpbutn.ImageSize = new System.Drawing.Size(20, 20);
            this.sendotpbutn.Location = new System.Drawing.Point(291, 99);
            this.sendotpbutn.Name = "sendotpbutn";
            this.sendotpbutn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.sendotpbutn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.sendotpbutn.OnHoverForeColor = System.Drawing.Color.White;
            this.sendotpbutn.OnHoverImage = null;
            this.sendotpbutn.OnPressedColor = System.Drawing.Color.Black;
            this.sendotpbutn.Radius = 7;
            this.sendotpbutn.Size = new System.Drawing.Size(111, 30);
            this.sendotpbutn.TabIndex = 6;
            this.sendotpbutn.Text = "Send OTP";
            this.sendotpbutn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sendotpbutn.Click += new System.EventHandler(this.sendotpbutn_Click);
            // 
            // confirmbutn
            // 
            this.confirmbutn.AnimationHoverSpeed = 0.07F;
            this.confirmbutn.AnimationSpeed = 0.03F;
            this.confirmbutn.BackColor = System.Drawing.Color.Transparent;
            this.confirmbutn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.confirmbutn.BorderColor = System.Drawing.Color.Black;
            this.confirmbutn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.confirmbutn.CheckedBorderColor = System.Drawing.Color.Black;
            this.confirmbutn.CheckedForeColor = System.Drawing.Color.White;
            this.confirmbutn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("confirmbutn.CheckedImage")));
            this.confirmbutn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.confirmbutn.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.confirmbutn.ForeColor = System.Drawing.Color.White;
            this.confirmbutn.Image = null;
            this.confirmbutn.ImageSize = new System.Drawing.Size(20, 20);
            this.confirmbutn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.confirmbutn.Location = new System.Drawing.Point(291, 183);
            this.confirmbutn.Name = "confirmbutn";
            this.confirmbutn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.confirmbutn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.confirmbutn.OnHoverForeColor = System.Drawing.Color.White;
            this.confirmbutn.OnHoverImage = null;
            this.confirmbutn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.confirmbutn.OnPressedColor = System.Drawing.Color.Black;
            this.confirmbutn.Radius = 7;
            this.confirmbutn.Size = new System.Drawing.Size(111, 30);
            this.confirmbutn.TabIndex = 1;
            this.confirmbutn.Text = "Confirm";
            this.confirmbutn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.confirmbutn.Visible = false;
            this.confirmbutn.Click += new System.EventHandler(this.nextbutton_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Red;
            this.close.Image = global::WindowsFormsApp1.Properties.Resources.close_4361951;
            this.close.ImageSize = new System.Drawing.Size(27, 27);
            this.close.Location = new System.Drawing.Point(426, 2);
            this.close.Name = "close";
            this.close.OnHoverImage = null;
            this.close.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.close.Size = new System.Drawing.Size(20, 20);
            this.close.TabIndex = 12;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // gunaGradientPanel1
            // 
            this.gunaGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaGradientPanel1.BackgroundImage")));
            this.gunaGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaGradientPanel1.Controls.Add(this.gunaAdvenceButton1);
            this.gunaGradientPanel1.Controls.Add(this.label2);
            this.gunaGradientPanel1.Controls.Add(this.close);
            this.gunaGradientPanel1.Controls.Add(this.gunaLabel1);
            this.gunaGradientPanel1.Controls.Add(this.EmailTxtbx);
            this.gunaGradientPanel1.Controls.Add(this.OTPTxtbx);
            this.gunaGradientPanel1.Controls.Add(this.gunaLabel2);
            this.gunaGradientPanel1.Controls.Add(this.sendotpbutn);
            this.gunaGradientPanel1.Controls.Add(this.confirmbutn);
            this.gunaGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaGradientPanel1.GradiantColor1 = System.Drawing.Color.Black;
            this.gunaGradientPanel1.GradiantColor2 = System.Drawing.Color.Blue;
            this.gunaGradientPanel1.GradiantColor3 = System.Drawing.Color.Black;
            this.gunaGradientPanel1.GradiantColor4 = System.Drawing.Color.Black;
            this.gunaGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaGradientPanel1.Name = "gunaGradientPanel1";
            this.gunaGradientPanel1.Size = new System.Drawing.Size(447, 285);
            this.gunaGradientPanel1.TabIndex = 13;
            this.gunaGradientPanel1.Text = "gunaGradientPanel1";
            // 
            // gunaAdvenceButton1
            // 
            this.gunaAdvenceButton1.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton1.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaAdvenceButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedForeColor = System.Drawing.SystemColors.Window;
            this.gunaAdvenceButton1.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton1.CheckedImage")));
            this.gunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton1.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.gunaAdvenceButton1.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.Image = null;
            this.gunaAdvenceButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.Location = new System.Drawing.Point(291, 183);
            this.gunaAdvenceButton1.Name = "gunaAdvenceButton1";
            this.gunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.OnHoverForeColor = System.Drawing.SystemColors.Window;
            this.gunaAdvenceButton1.OnHoverImage = null;
            this.gunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.Radius = 7;
            this.gunaAdvenceButton1.Size = new System.Drawing.Size(111, 30);
            this.gunaAdvenceButton1.TabIndex = 14;
            this.gunaAdvenceButton1.Text = "Confirm";
            this.gunaAdvenceButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaAdvenceButton1.Click += new System.EventHandler(this.gunaAdvenceButton1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(152, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 37);
            this.label2.TabIndex = 13;
            this.label2.Text = "GrouCord";
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 285);
            this.Controls.Add(this.gunaGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgotPassword";
            this.Load += new System.EventHandler(this.ForgotPassword_Load);
            this.gunaGradientPanel1.ResumeLayout(false);
            this.gunaGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaTextBox EmailTxtbx;
        private Guna.UI.WinForms.GunaTextBox OTPTxtbx;
        private Guna.UI.WinForms.GunaButton sendotpbutn;
        private Guna.UI.WinForms.GunaImageButton close;
        private Guna.UI.WinForms.GunaGradientPanel gunaGradientPanel1;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
        public Guna.UI.WinForms.GunaAdvenceButton confirmbutn;
    }
}