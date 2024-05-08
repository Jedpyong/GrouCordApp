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
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.createAcc = new Guna.UI.WinForms.GunaLinkLabel();
            this.forgotpass = new System.Windows.Forms.LinkLabel();
            this.loginButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gunaGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI Variable Small", 9F, System.Drawing.FontStyle.Bold);
            this.passwordTextBox.Location = new System.Drawing.Point(169, 124);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = 'O';
            this.passwordTextBox.Size = new System.Drawing.Size(186, 23);
            this.passwordTextBox.TabIndex = 16;
            this.passwordTextBox.Tag = "";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Font = new System.Drawing.Font("Segoe UI Variable Small", 9F, System.Drawing.FontStyle.Bold);
            this.usernameTextBox.Location = new System.Drawing.Point(169, 81);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(186, 23);
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
            this.gunaGradientPanel1.Controls.Add(this.gunaPictureBox1);
            this.gunaGradientPanel1.Controls.Add(this.createAcc);
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
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.GrouCord_Logo;
            this.gunaPictureBox1.Location = new System.Drawing.Point(101, 4);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Radius = 10;
            this.gunaPictureBox1.Size = new System.Drawing.Size(69, 60);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 22;
            this.gunaPictureBox1.TabStop = false;
            // 
            // createAcc
            // 
            this.createAcc.AutoSize = true;
            this.createAcc.BackColor = System.Drawing.Color.Transparent;
            this.createAcc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.createAcc.ForeColor = System.Drawing.Color.White;
            this.createAcc.LinkColor = System.Drawing.Color.White;
            this.createAcc.Location = new System.Drawing.Point(150, 251);
            this.createAcc.Name = "createAcc";
            this.createAcc.Size = new System.Drawing.Size(116, 15);
            this.createAcc.TabIndex = 19;
            this.createAcc.TabStop = true;
            this.createAcc.Text = "Create New Account";
            this.createAcc.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.createAcc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createAcc_LinkClicked);
            // 
            // forgotpass
            // 
            this.forgotpass.AutoSize = true;
            this.forgotpass.BackColor = System.Drawing.Color.Transparent;
            this.forgotpass.Font = new System.Drawing.Font("Segoe UI Variable Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotpass.ForeColor = System.Drawing.Color.White;
            this.forgotpass.LinkColor = System.Drawing.Color.White;
            this.forgotpass.Location = new System.Drawing.Point(159, 203);
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
            this.loginButton.Location = new System.Drawing.Point(136, 166);
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
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(76, 125);
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
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(48, 83);
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
            this.label2.Location = new System.Drawing.Point(163, 9);
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
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
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
        private Guna.UI.WinForms.GunaLinkLabel createAcc;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
    }
}

