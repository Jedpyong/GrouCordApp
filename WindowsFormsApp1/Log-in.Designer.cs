namespace WindowsFormsApp1
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.close = new Guna.UI.WinForms.GunaImageButton();
            this.gunaGradientPanel1 = new Guna.UI.WinForms.GunaGradientPanel();
            this.gunaLinkLabel1 = new Guna.UI.WinForms.GunaLinkLabel();
            this.forgotpass = new System.Windows.Forms.LinkLabel();
            this.loginButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gunaGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(169, 113);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = 'O';
            this.passwordTextBox.Size = new System.Drawing.Size(186, 20);
            this.passwordTextBox.TabIndex = 16;
            this.passwordTextBox.Tag = "";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(169, 67);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(186, 20);
            this.usernameTextBox.TabIndex = 16;
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Red;
            this.close.Image = global::WindowsFormsApp1.Properties.Resources.close_4361951;
            this.close.ImageSize = new System.Drawing.Size(27, 27);
            this.close.Location = new System.Drawing.Point(425, 3);
            this.close.Name = "close";
            this.close.OnHoverImage = null;
            this.close.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.close.Size = new System.Drawing.Size(20, 20);
            this.close.TabIndex = 17;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // gunaGradientPanel1
            // 
            this.gunaGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaGradientPanel1.BackgroundImage")));
            this.gunaGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaGradientPanel1.Controls.Add(this.gunaLinkLabel1);
            this.gunaGradientPanel1.Controls.Add(this.forgotpass);
            this.gunaGradientPanel1.Controls.Add(this.loginButton);
            this.gunaGradientPanel1.Controls.Add(this.label3);
            this.gunaGradientPanel1.Controls.Add(this.label1);
            this.gunaGradientPanel1.Controls.Add(this.label2);
            this.gunaGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaGradientPanel1.GradiantColor1 = System.Drawing.Color.Black;
            this.gunaGradientPanel1.GradiantColor2 = System.Drawing.Color.Blue;
            this.gunaGradientPanel1.GradiantColor3 = System.Drawing.Color.Black;
            this.gunaGradientPanel1.GradiantColor4 = System.Drawing.Color.Black;
            this.gunaGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaGradientPanel1.Name = "gunaGradientPanel1";
            this.gunaGradientPanel1.Size = new System.Drawing.Size(447, 285);
            this.gunaGradientPanel1.TabIndex = 18;
            this.gunaGradientPanel1.Text = "gunaGradientPanel1";
            this.gunaGradientPanel1.Click += new System.EventHandler(this.gunaGradientPanel1_Click);
            // 
            // gunaLinkLabel1
            // 
            this.gunaLinkLabel1.AutoSize = true;
            this.gunaLinkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLinkLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLinkLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLinkLabel1.LinkColor = System.Drawing.Color.White;
            this.gunaLinkLabel1.Location = new System.Drawing.Point(150, 251);
            this.gunaLinkLabel1.Name = "gunaLinkLabel1";
            this.gunaLinkLabel1.Size = new System.Drawing.Size(116, 15);
            this.gunaLinkLabel1.TabIndex = 19;
            this.gunaLinkLabel1.TabStop = true;
            this.gunaLinkLabel1.Text = "Create New Account";
            this.gunaLinkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gunaLinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.gunaLinkLabel1_LinkClicked_1);
            // 
            // forgotpass
            // 
            this.forgotpass.AutoSize = true;
            this.forgotpass.BackColor = System.Drawing.Color.Transparent;
            this.forgotpass.Font = new System.Drawing.Font("Segoe UI Variable Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotpass.ForeColor = System.Drawing.Color.White;
            this.forgotpass.LinkColor = System.Drawing.Color.White;
            this.forgotpass.Location = new System.Drawing.Point(159, 191);
            this.forgotpass.Name = "forgotpass";
            this.forgotpass.Size = new System.Drawing.Size(99, 16);
            this.forgotpass.TabIndex = 19;
            this.forgotpass.TabStop = true;
            this.forgotpass.Text = "forgot password?\r\n";
            this.forgotpass.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.forgotpass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgotpass_LinkClicked_1);
            // 
            // loginButton
            // 
            this.loginButton.AnimationHoverSpeed = 0.07F;
            this.loginButton.AnimationSpeed = 0.03F;
            this.loginButton.BackColor = System.Drawing.Color.Transparent;
            this.loginButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.loginButton.BorderColor = System.Drawing.Color.Black;
            this.loginButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.loginButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.loginButton.CheckedForeColor = System.Drawing.Color.White;
            this.loginButton.CheckedImage = null;
            this.loginButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.loginButton.Font = new System.Drawing.Font("Segoe UI Variable Small", 9.5F, System.Drawing.FontStyle.Bold);
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Image = null;
            this.loginButton.ImageSize = new System.Drawing.Size(20, 20);
            this.loginButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.loginButton.Location = new System.Drawing.Point(136, 148);
            this.loginButton.Name = "loginButton";
            this.loginButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.loginButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.loginButton.OnHoverForeColor = System.Drawing.Color.White;
            this.loginButton.OnHoverImage = null;
            this.loginButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.loginButton.OnPressedColor = System.Drawing.Color.Black;
            this.loginButton.Radius = 10;
            this.loginButton.Size = new System.Drawing.Size(146, 31);
            this.loginButton.TabIndex = 19;
            this.loginButton.Text = "Log-in";
            this.loginButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Small", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(76, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Email Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(154, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "GrouCord";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(447, 285);
            this.Controls.Add(this.close);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.gunaGradientPanel1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Blue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log-in";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gunaGradientPanel1.ResumeLayout(false);
            this.gunaGradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private Guna.UI.WinForms.GunaImageButton close;
        private Guna.UI.WinForms.GunaGradientPanel gunaGradientPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaAdvenceButton loginButton;
        private System.Windows.Forms.LinkLabel forgotpass;
        private Guna.UI.WinForms.GunaLinkLabel gunaLinkLabel1;
    }
}

