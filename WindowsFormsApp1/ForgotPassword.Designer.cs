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
            this.label2 = new System.Windows.Forms.Label();
            this.confirmbutn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.close = new Guna.UI.WinForms.GunaImageButton();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(92, 72);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(36, 15);
            this.gunaLabel1.TabIndex = 2;
            this.gunaLabel1.Text = "Email";
            this.gunaLabel1.Click += new System.EventHandler(this.gunaLabel1_Click);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(92, 144);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(28, 15);
            this.gunaLabel2.TabIndex = 3;
            this.gunaLabel2.Text = "OTP";
            // 
            // EmailTxtbx
            // 
            this.EmailTxtbx.BaseColor = System.Drawing.Color.White;
            this.EmailTxtbx.BorderColor = System.Drawing.Color.Silver;
            this.EmailTxtbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmailTxtbx.FocusedBaseColor = System.Drawing.Color.White;
            this.EmailTxtbx.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.EmailTxtbx.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.EmailTxtbx.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EmailTxtbx.Location = new System.Drawing.Point(95, 90);
            this.EmailTxtbx.Name = "EmailTxtbx";
            this.EmailTxtbx.PasswordChar = '\0';
            this.EmailTxtbx.Size = new System.Drawing.Size(160, 30);
            this.EmailTxtbx.TabIndex = 4;
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
            this.OTPTxtbx.Location = new System.Drawing.Point(95, 162);
            this.OTPTxtbx.Name = "OTPTxtbx";
            this.OTPTxtbx.PasswordChar = '\0';
            this.OTPTxtbx.Size = new System.Drawing.Size(160, 30);
            this.OTPTxtbx.TabIndex = 5;
            // 
            // sendotpbutn
            // 
            this.sendotpbutn.AnimationHoverSpeed = 0.07F;
            this.sendotpbutn.AnimationSpeed = 0.03F;
            this.sendotpbutn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.sendotpbutn.BorderColor = System.Drawing.Color.Black;
            this.sendotpbutn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sendotpbutn.ForeColor = System.Drawing.Color.White;
            this.sendotpbutn.Image = null;
            this.sendotpbutn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sendotpbutn.ImageSize = new System.Drawing.Size(20, 20);
            this.sendotpbutn.Location = new System.Drawing.Point(307, 90);
            this.sendotpbutn.Name = "sendotpbutn";
            this.sendotpbutn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.sendotpbutn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.sendotpbutn.OnHoverForeColor = System.Drawing.Color.White;
            this.sendotpbutn.OnHoverImage = null;
            this.sendotpbutn.OnPressedColor = System.Drawing.Color.Black;
            this.sendotpbutn.Radius = 7;
            this.sendotpbutn.Size = new System.Drawing.Size(81, 30);
            this.sendotpbutn.TabIndex = 6;
            this.sendotpbutn.Text = "Send OTP";
            this.sendotpbutn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sendotpbutn.Click += new System.EventHandler(this.sendotpbutn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(166, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "GrouCord";
            // 
            // confirmbutn
            // 
            this.confirmbutn.AnimationHoverSpeed = 0.07F;
            this.confirmbutn.AnimationSpeed = 0.03F;
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
            this.confirmbutn.Location = new System.Drawing.Point(307, 162);
            this.confirmbutn.Name = "confirmbutn";
            this.confirmbutn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.confirmbutn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.confirmbutn.OnHoverForeColor = System.Drawing.Color.White;
            this.confirmbutn.OnHoverImage = null;
            this.confirmbutn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.confirmbutn.OnPressedColor = System.Drawing.Color.Black;
            this.confirmbutn.Radius = 7;
            this.confirmbutn.Size = new System.Drawing.Size(81, 30);
            this.confirmbutn.TabIndex = 1;
            this.confirmbutn.Text = "Confirm";
            this.confirmbutn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.confirmbutn.Click += new System.EventHandler(this.nextbutton_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.Image = global::WindowsFormsApp1.Properties.Resources.close_4361951;
            this.close.ImageSize = new System.Drawing.Size(25, 25);
            this.close.Location = new System.Drawing.Point(419, -1);
            this.close.Name = "close";
            this.close.OnHoverImage = null;
            this.close.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.close.Size = new System.Drawing.Size(27, 27);
            this.close.TabIndex = 12;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 285);
            this.Controls.Add(this.close);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sendotpbutn);
            this.Controls.Add(this.OTPTxtbx);
            this.Controls.Add(this.EmailTxtbx);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.confirmbutn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgotPassword";
            this.Load += new System.EventHandler(this.ForgotPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaAdvenceButton confirmbutn;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaTextBox EmailTxtbx;
        private Guna.UI.WinForms.GunaTextBox OTPTxtbx;
        private Guna.UI.WinForms.GunaButton sendotpbutn;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaImageButton close;
    }
}