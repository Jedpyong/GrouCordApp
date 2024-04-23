namespace WindowsFormsApp1
{
    partial class CreateAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAccount));
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.username = new Guna.UI.WinForms.GunaLabel();
            this.Email = new Guna.UI.WinForms.GunaLabel();
            this.Password = new Guna.UI.WinForms.GunaLabel();
            this.usernameTxtbx = new Guna.UI.WinForms.GunaLineTextBox();
            this.EmailTxtbx = new Guna.UI.WinForms.GunaLineTextBox();
            this.PasswordTxtbx = new Guna.UI.WinForms.GunaLineTextBox();
            this.createAccountButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.close = new Guna.UI.WinForms.GunaImageButton();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(166, 22);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(116, 15);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Create New Account";
            this.gunaLabel1.Click += new System.EventHandler(this.gunaLabel1_Click);
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.username.Location = new System.Drawing.Point(72, 48);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(60, 15);
            this.username.TabIndex = 1;
            this.username.Text = "Username";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Email.Location = new System.Drawing.Point(72, 103);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(36, 15);
            this.Email.TabIndex = 2;
            this.Email.Text = "Email";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Password.Location = new System.Drawing.Point(72, 155);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(57, 15);
            this.Password.TabIndex = 3;
            this.Password.Text = "Password";
            this.Password.Click += new System.EventHandler(this.Password_Click);
            // 
            // usernameTxtbx
            // 
            this.usernameTxtbx.BackColor = System.Drawing.Color.White;
            this.usernameTxtbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameTxtbx.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.usernameTxtbx.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.usernameTxtbx.LineColor = System.Drawing.Color.Gainsboro;
            this.usernameTxtbx.Location = new System.Drawing.Point(94, 65);
            this.usernameTxtbx.Name = "usernameTxtbx";
            this.usernameTxtbx.PasswordChar = '\0';
            this.usernameTxtbx.Size = new System.Drawing.Size(255, 26);
            this.usernameTxtbx.TabIndex = 4;
            this.usernameTxtbx.Click += new System.EventHandler(this.usernameTxtbx_Click);
            // 
            // EmailTxtbx
            // 
            this.EmailTxtbx.BackColor = System.Drawing.Color.White;
            this.EmailTxtbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmailTxtbx.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.EmailTxtbx.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EmailTxtbx.LineColor = System.Drawing.Color.Gainsboro;
            this.EmailTxtbx.Location = new System.Drawing.Point(94, 120);
            this.EmailTxtbx.Name = "EmailTxtbx";
            this.EmailTxtbx.PasswordChar = '\0';
            this.EmailTxtbx.Size = new System.Drawing.Size(255, 26);
            this.EmailTxtbx.TabIndex = 5;
            // 
            // PasswordTxtbx
            // 
            this.PasswordTxtbx.BackColor = System.Drawing.Color.White;
            this.PasswordTxtbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTxtbx.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.PasswordTxtbx.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PasswordTxtbx.LineColor = System.Drawing.Color.Gainsboro;
            this.PasswordTxtbx.Location = new System.Drawing.Point(94, 173);
            this.PasswordTxtbx.Name = "PasswordTxtbx";
            this.PasswordTxtbx.PasswordChar = '\0';
            this.PasswordTxtbx.Size = new System.Drawing.Size(255, 26);
            this.PasswordTxtbx.TabIndex = 6;
            // 
            // createAccountButton
            // 
            this.createAccountButton.AnimationHoverSpeed = 0.07F;
            this.createAccountButton.AnimationSpeed = 0.03F;
            this.createAccountButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.createAccountButton.BorderColor = System.Drawing.Color.Black;
            this.createAccountButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.createAccountButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.createAccountButton.CheckedForeColor = System.Drawing.Color.White;
            this.createAccountButton.CheckedImage = ((System.Drawing.Image)(resources.GetObject("createAccountButton.CheckedImage")));
            this.createAccountButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.createAccountButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.createAccountButton.ForeColor = System.Drawing.Color.White;
            this.createAccountButton.Image = null;
            this.createAccountButton.ImageSize = new System.Drawing.Size(20, 20);
            this.createAccountButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.createAccountButton.Location = new System.Drawing.Point(149, 217);
            this.createAccountButton.Name = "createAccountButton";
            this.createAccountButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.createAccountButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.createAccountButton.OnHoverForeColor = System.Drawing.Color.White;
            this.createAccountButton.OnHoverImage = null;
            this.createAccountButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.createAccountButton.OnPressedColor = System.Drawing.Color.Black;
            this.createAccountButton.Radius = 7;
            this.createAccountButton.Size = new System.Drawing.Size(148, 32);
            this.createAccountButton.TabIndex = 8;
            this.createAccountButton.Text = "Create Account";
            this.createAccountButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.createAccountButton.Click += new System.EventHandler(this.createAccountButton_Click);
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
            this.close.TabIndex = 11;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 285);
            this.Controls.Add(this.close);
            this.Controls.Add(this.createAccountButton);
            this.Controls.Add(this.PasswordTxtbx);
            this.Controls.Add(this.EmailTxtbx);
            this.Controls.Add(this.usernameTxtbx);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.username);
            this.Controls.Add(this.gunaLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateAccount";
            this.Load += new System.EventHandler(this.CreateAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel username;
        private Guna.UI.WinForms.GunaLabel Email;
        private Guna.UI.WinForms.GunaLabel Password;
        private Guna.UI.WinForms.GunaLineTextBox usernameTxtbx;
        private Guna.UI.WinForms.GunaLineTextBox EmailTxtbx;
        private Guna.UI.WinForms.GunaLineTextBox PasswordTxtbx;
        private Guna.UI.WinForms.GunaAdvenceButton createAccountButton;
        private Guna.UI.WinForms.GunaImageButton close;
    }
}