namespace WindowsFormsApp1
{
    partial class EditEmail
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditEmail));
            this.confirmbutn = new Guna.UI.WinForms.GunaGradiantButton();
            this.newEmail = new System.Windows.Forms.Label();
            this.gunaGradientPanel2 = new Guna.UI.WinForms.GunaGradientPanel();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaGradiantButton();
            this.sendotpbutn = new Guna.UI.WinForms.GunaGradiantButton();
            this.OTPTxtbx = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EmailTxtbx = new Guna.UI.WinForms.GunaTextBox();
            this.back = new Guna.UI.WinForms.GunaImageButton();
            this.gunaGradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // confirmbutn
            // 
            this.confirmbutn.AnimationHoverSpeed = 0.07F;
            this.confirmbutn.AnimationSpeed = 0.03F;
            this.confirmbutn.BackColor = System.Drawing.Color.Transparent;
            this.confirmbutn.BaseColor1 = System.Drawing.Color.Navy;
            this.confirmbutn.BaseColor2 = System.Drawing.Color.RoyalBlue;
            this.confirmbutn.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.confirmbutn.ForeColor = System.Drawing.Color.White;
            this.confirmbutn.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.confirmbutn.Image = null;
            this.confirmbutn.ImageSize = new System.Drawing.Size(20, 20);
            this.confirmbutn.Location = new System.Drawing.Point(306, 255);
            this.confirmbutn.Name = "confirmbutn";
            this.confirmbutn.OnHoverBaseColor1 = System.Drawing.Color.Blue;
            this.confirmbutn.OnHoverBaseColor2 = System.Drawing.Color.Red;
            this.confirmbutn.OnHoverForeColor = System.Drawing.Color.White;
            this.confirmbutn.OnHoverImage = null;
            this.confirmbutn.OnPressedColor = System.Drawing.Color.Black;
            this.confirmbutn.Radius = 10;
            this.confirmbutn.Size = new System.Drawing.Size(146, 38);
            this.confirmbutn.TabIndex = 13;
            this.confirmbutn.Text = "Confirm";
            this.confirmbutn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.confirmbutn.Visible = false;
            this.confirmbutn.Click += new System.EventHandler(this.confirmbutn_Click);
            // 
            // newEmail
            // 
            this.newEmail.AutoSize = true;
            this.newEmail.BackColor = System.Drawing.Color.Transparent;
            this.newEmail.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newEmail.ForeColor = System.Drawing.Color.White;
            this.newEmail.Location = new System.Drawing.Point(49, 44);
            this.newEmail.Name = "newEmail";
            this.newEmail.Size = new System.Drawing.Size(147, 17);
            this.newEmail.TabIndex = 14;
            this.newEmail.Text = "Input Email Address:";
            // 
            // gunaGradientPanel2
            // 
            this.gunaGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaGradientPanel2.BackgroundImage")));
            this.gunaGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaGradientPanel2.Controls.Add(this.back);
            this.gunaGradientPanel2.Controls.Add(this.gunaAdvenceButton1);
            this.gunaGradientPanel2.Controls.Add(this.sendotpbutn);
            this.gunaGradientPanel2.Controls.Add(this.OTPTxtbx);
            this.gunaGradientPanel2.Controls.Add(this.label1);
            this.gunaGradientPanel2.Controls.Add(this.EmailTxtbx);
            this.gunaGradientPanel2.Controls.Add(this.newEmail);
            this.gunaGradientPanel2.Controls.Add(this.confirmbutn);
            this.gunaGradientPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaGradientPanel2.GradiantColor1 = System.Drawing.Color.Black;
            this.gunaGradientPanel2.GradiantColor2 = System.Drawing.Color.Black;
            this.gunaGradientPanel2.GradiantColor3 = System.Drawing.Color.Blue;
            this.gunaGradientPanel2.GradiantColor4 = System.Drawing.Color.Black;
            this.gunaGradientPanel2.Location = new System.Drawing.Point(0, 0);
            this.gunaGradientPanel2.Name = "gunaGradientPanel2";
            this.gunaGradientPanel2.Size = new System.Drawing.Size(520, 333);
            this.gunaGradientPanel2.TabIndex = 2;
            this.gunaGradientPanel2.Text = "gunaGradientPanel2";
            // 
            // gunaAdvenceButton1
            // 
            this.gunaAdvenceButton1.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton1.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton1.BaseColor1 = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton1.BaseColor2 = System.Drawing.Color.Gray;
            this.gunaAdvenceButton1.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.gunaAdvenceButton1.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gunaAdvenceButton1.Image = null;
            this.gunaAdvenceButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton1.Location = new System.Drawing.Point(306, 255);
            this.gunaAdvenceButton1.Name = "gunaAdvenceButton1";
            this.gunaAdvenceButton1.OnHoverBaseColor1 = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton1.OnHoverBaseColor2 = System.Drawing.Color.Gray;
            this.gunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.OnHoverImage = null;
            this.gunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.Radius = 10;
            this.gunaAdvenceButton1.Size = new System.Drawing.Size(146, 38);
            this.gunaAdvenceButton1.TabIndex = 19;
            this.gunaAdvenceButton1.Text = "Confirm";
            this.gunaAdvenceButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaAdvenceButton1.Click += new System.EventHandler(this.gunaAdvenceButton1_Click);
            // 
            // sendotpbutn
            // 
            this.sendotpbutn.AnimationHoverSpeed = 0.07F;
            this.sendotpbutn.AnimationSpeed = 0.03F;
            this.sendotpbutn.BackColor = System.Drawing.Color.Transparent;
            this.sendotpbutn.BaseColor1 = System.Drawing.Color.Navy;
            this.sendotpbutn.BaseColor2 = System.Drawing.Color.RoyalBlue;
            this.sendotpbutn.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.sendotpbutn.ForeColor = System.Drawing.Color.White;
            this.sendotpbutn.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.sendotpbutn.Image = null;
            this.sendotpbutn.ImageSize = new System.Drawing.Size(20, 20);
            this.sendotpbutn.Location = new System.Drawing.Point(306, 123);
            this.sendotpbutn.Name = "sendotpbutn";
            this.sendotpbutn.OnHoverBaseColor1 = System.Drawing.Color.Blue;
            this.sendotpbutn.OnHoverBaseColor2 = System.Drawing.Color.Red;
            this.sendotpbutn.OnHoverForeColor = System.Drawing.Color.White;
            this.sendotpbutn.OnHoverImage = null;
            this.sendotpbutn.OnPressedColor = System.Drawing.Color.Black;
            this.sendotpbutn.Radius = 10;
            this.sendotpbutn.Size = new System.Drawing.Size(146, 38);
            this.sendotpbutn.TabIndex = 18;
            this.sendotpbutn.Text = "Send OTP";
            this.sendotpbutn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sendotpbutn.Click += new System.EventHandler(this.sendotpbutn_Click);
            // 
            // OTPTxtbx
            // 
            this.OTPTxtbx.BaseColor = System.Drawing.Color.White;
            this.OTPTxtbx.BorderColor = System.Drawing.Color.Silver;
            this.OTPTxtbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.OTPTxtbx.FocusedBaseColor = System.Drawing.Color.White;
            this.OTPTxtbx.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.OTPTxtbx.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.OTPTxtbx.Font = new System.Drawing.Font("Segoe UI Variable Small", 9F, System.Drawing.FontStyle.Bold);
            this.OTPTxtbx.Location = new System.Drawing.Point(144, 203);
            this.OTPTxtbx.Name = "OTPTxtbx";
            this.OTPTxtbx.PasswordChar = '\0';
            this.OTPTxtbx.Size = new System.Drawing.Size(238, 30);
            this.OTPTxtbx.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(49, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Input OTP Code:";
            // 
            // EmailTxtbx
            // 
            this.EmailTxtbx.BaseColor = System.Drawing.Color.White;
            this.EmailTxtbx.BorderColor = System.Drawing.Color.Silver;
            this.EmailTxtbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmailTxtbx.FocusedBaseColor = System.Drawing.Color.White;
            this.EmailTxtbx.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.EmailTxtbx.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.EmailTxtbx.Font = new System.Drawing.Font("Segoe UI Variable Small", 9F, System.Drawing.FontStyle.Bold);
            this.EmailTxtbx.Location = new System.Drawing.Point(144, 77);
            this.EmailTxtbx.Name = "EmailTxtbx";
            this.EmailTxtbx.PasswordChar = '\0';
            this.EmailTxtbx.Size = new System.Drawing.Size(238, 30);
            this.EmailTxtbx.TabIndex = 15;
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.Image = global::WindowsFormsApp1.Properties.Resources.left_arrow;
            this.back.ImageSize = new System.Drawing.Size(20, 20);
            this.back.Location = new System.Drawing.Point(3, 3);
            this.back.Name = "back";
            this.back.OnHoverImage = null;
            this.back.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.back.Size = new System.Drawing.Size(25, 25);
            this.back.TabIndex = 20;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // EditEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaGradientPanel2);
            this.Name = "EditEmail";
            this.Size = new System.Drawing.Size(520, 333);
            this.gunaGradientPanel2.ResumeLayout(false);
            this.gunaGradientPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaGradiantButton confirmbutn;
        private System.Windows.Forms.Label newEmail;
        private Guna.UI.WinForms.GunaGradientPanel gunaGradientPanel2;
        private Guna.UI.WinForms.GunaTextBox EmailTxtbx;
        private Guna.UI.WinForms.GunaGradiantButton sendotpbutn;
        private Guna.UI.WinForms.GunaTextBox OTPTxtbx;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaGradiantButton gunaAdvenceButton1;
        private Guna.UI.WinForms.GunaImageButton back;
    }
}
