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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.forgotpass = new System.Windows.Forms.LinkLabel();
            this.loginButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaLinkLabel1 = new Guna.UI.WinForms.GunaLinkLabel();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "username:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(164, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "GrouCord";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "password: ";
            // 
            // forgotpass
            // 
            this.forgotpass.AutoSize = true;
            this.forgotpass.Location = new System.Drawing.Point(182, 183);
            this.forgotpass.Name = "forgotpass";
            this.forgotpass.Size = new System.Drawing.Size(82, 13);
            this.forgotpass.TabIndex = 8;
            this.forgotpass.TabStop = true;
            this.forgotpass.Text = "forgot password";
            this.forgotpass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgotpass_LinkClicked);
            // 
            // loginButton
            // 
            this.loginButton.AnimationHoverSpeed = 0.07F;
            this.loginButton.AnimationSpeed = 0.03F;
            this.loginButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.loginButton.BorderColor = System.Drawing.Color.Black;
            this.loginButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.loginButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.loginButton.CheckedForeColor = System.Drawing.Color.White;
            this.loginButton.CheckedImage = ((System.Drawing.Image)(resources.GetObject("loginButton.CheckedImage")));
            this.loginButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.loginButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Image = null;
            this.loginButton.ImageSize = new System.Drawing.Size(20, 20);
            this.loginButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.loginButton.Location = new System.Drawing.Point(150, 149);
            this.loginButton.Name = "loginButton";
            this.loginButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.loginButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.loginButton.OnHoverForeColor = System.Drawing.Color.White;
            this.loginButton.OnHoverImage = null;
            this.loginButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.loginButton.OnPressedColor = System.Drawing.Color.Black;
            this.loginButton.Radius = 10;
            this.loginButton.Size = new System.Drawing.Size(146, 31);
            this.loginButton.TabIndex = 9;
            this.loginButton.Text = "Log-in";
            this.loginButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // gunaLinkLabel1
            // 
            this.gunaLinkLabel1.AutoSize = true;
            this.gunaLinkLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLinkLabel1.Location = new System.Drawing.Point(166, 247);
            this.gunaLinkLabel1.Name = "gunaLinkLabel1";
            this.gunaLinkLabel1.Size = new System.Drawing.Size(116, 15);
            this.gunaLinkLabel1.TabIndex = 10;
            this.gunaLinkLabel1.TabStop = true;
            this.gunaLinkLabel1.Text = "Create New Account";
            this.gunaLinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.gunaLinkLabel1_LinkClicked);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(169, 113);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = 'O';
            this.passwordTextBox.Size = new System.Drawing.Size(186, 20);
            this.passwordTextBox.TabIndex = 15;
            this.passwordTextBox.Tag = "";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(169, 67);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(186, 20);
            this.usernameTextBox.TabIndex = 16;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(447, 285);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.gunaLinkLabel1);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.forgotpass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Blue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log-in";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel forgotpass;
        private Guna.UI.WinForms.GunaAdvenceButton loginButton;
        private Guna.UI.WinForms.GunaLinkLabel gunaLinkLabel1;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
    }
}

