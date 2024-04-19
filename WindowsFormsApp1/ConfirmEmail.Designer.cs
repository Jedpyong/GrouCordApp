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
            this.OTPTxtbx = new Guna.UI.WinForms.GunaTextBox();
            this.confirmbutn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.SuspendLayout();
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
            this.OTPTxtbx.Location = new System.Drawing.Point(86, 109);
            this.OTPTxtbx.Name = "OTPTxtbx";
            this.OTPTxtbx.PasswordChar = '\0';
            this.OTPTxtbx.Size = new System.Drawing.Size(160, 30);
            this.OTPTxtbx.TabIndex = 8;
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
            this.confirmbutn.Location = new System.Drawing.Point(282, 109);
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
            // ConfirmEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 285);
            this.Controls.Add(this.confirmbutn);
            this.Controls.Add(this.OTPTxtbx);
            this.Name = "ConfirmEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfirmEmail";
            this.Load += new System.EventHandler(this.ConfirmEmail_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaTextBox OTPTxtbx;
        private Guna.UI.WinForms.GunaAdvenceButton confirmbutn;
    }
}