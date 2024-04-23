namespace WindowsFormsApp1
{
    partial class UpdatePassword
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
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.confirmtxtbx = new Guna.UI.WinForms.GunaTextBox();
            this.newpasstxtbx = new Guna.UI.WinForms.GunaTextBox();
            this.savebutton = new Guna.UI.WinForms.GunaButton();
            this.close = new Guna.UI.WinForms.GunaImageButton();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(68, 50);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(84, 15);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "New Password";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(48, 127);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(104, 15);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "Confirm Password";
            // 
            // confirmtxtbx
            // 
            this.confirmtxtbx.BaseColor = System.Drawing.Color.White;
            this.confirmtxtbx.BorderColor = System.Drawing.Color.Silver;
            this.confirmtxtbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.confirmtxtbx.FocusedBaseColor = System.Drawing.Color.White;
            this.confirmtxtbx.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.confirmtxtbx.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.confirmtxtbx.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.confirmtxtbx.Location = new System.Drawing.Point(170, 127);
            this.confirmtxtbx.Name = "confirmtxtbx";
            this.confirmtxtbx.PasswordChar = '\0';
            this.confirmtxtbx.Size = new System.Drawing.Size(206, 30);
            this.confirmtxtbx.TabIndex = 5;
            // 
            // newpasstxtbx
            // 
            this.newpasstxtbx.BaseColor = System.Drawing.Color.White;
            this.newpasstxtbx.BorderColor = System.Drawing.Color.Silver;
            this.newpasstxtbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.newpasstxtbx.FocusedBaseColor = System.Drawing.Color.White;
            this.newpasstxtbx.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.newpasstxtbx.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.newpasstxtbx.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.newpasstxtbx.Location = new System.Drawing.Point(170, 50);
            this.newpasstxtbx.Name = "newpasstxtbx";
            this.newpasstxtbx.PasswordChar = '\0';
            this.newpasstxtbx.Size = new System.Drawing.Size(206, 30);
            this.newpasstxtbx.TabIndex = 6;
            // 
            // savebutton
            // 
            this.savebutton.AnimationHoverSpeed = 0.07F;
            this.savebutton.AnimationSpeed = 0.03F;
            this.savebutton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.savebutton.BorderColor = System.Drawing.Color.Black;
            this.savebutton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.savebutton.ForeColor = System.Drawing.Color.White;
            this.savebutton.Image = null;
            this.savebutton.ImageSize = new System.Drawing.Size(20, 20);
            this.savebutton.Location = new System.Drawing.Point(338, 208);
            this.savebutton.Name = "savebutton";
            this.savebutton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.savebutton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.savebutton.OnHoverForeColor = System.Drawing.Color.White;
            this.savebutton.OnHoverImage = null;
            this.savebutton.OnPressedColor = System.Drawing.Color.Black;
            this.savebutton.Radius = 7;
            this.savebutton.Size = new System.Drawing.Size(81, 30);
            this.savebutton.TabIndex = 8;
            this.savebutton.Text = "Save";
            this.savebutton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
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
            // UpdatePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 285);
            this.Controls.Add(this.close);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.newpasstxtbx);
            this.Controls.Add(this.confirmtxtbx);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdatePassword";
            this.Text = "UpdatePassword";
            this.Load += new System.EventHandler(this.UpdatePassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaTextBox confirmtxtbx;
        private Guna.UI.WinForms.GunaTextBox newpasstxtbx;
        private Guna.UI.WinForms.GunaButton savebutton;
        private Guna.UI.WinForms.GunaImageButton close;
    }
}