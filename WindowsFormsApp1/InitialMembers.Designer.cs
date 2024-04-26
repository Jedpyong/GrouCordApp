namespace WindowsFormsApp1
{
    partial class InitialMembers
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
            this.initialMemberBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.removeBtn = new Guna.UI.WinForms.GunaButton();
            this.SuspendLayout();
            // 
            // initialMemberBtn
            // 
            this.initialMemberBtn.AnimationHoverSpeed = 0.07F;
            this.initialMemberBtn.AnimationSpeed = 0.03F;
            this.initialMemberBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.initialMemberBtn.BorderColor = System.Drawing.Color.Black;
            this.initialMemberBtn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.initialMemberBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.initialMemberBtn.CheckedForeColor = System.Drawing.Color.White;
            this.initialMemberBtn.CheckedImage = null;
            this.initialMemberBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.initialMemberBtn.Font = new System.Drawing.Font("Segoe UI Variable Small", 9.75F, System.Drawing.FontStyle.Bold);
            this.initialMemberBtn.ForeColor = System.Drawing.Color.White;
            this.initialMemberBtn.Image = null;
            this.initialMemberBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.initialMemberBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.initialMemberBtn.Location = new System.Drawing.Point(3, 0);
            this.initialMemberBtn.Name = "initialMemberBtn";
            this.initialMemberBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.initialMemberBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.initialMemberBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.initialMemberBtn.OnHoverImage = null;
            this.initialMemberBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.initialMemberBtn.OnPressedColor = System.Drawing.Color.Black;
            this.initialMemberBtn.Radius = 7;
            this.initialMemberBtn.Size = new System.Drawing.Size(140, 22);
            this.initialMemberBtn.TabIndex = 1;
            this.initialMemberBtn.Text = "gunaAdvenceButton1";
            this.initialMemberBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // removeBtn
            // 
            this.removeBtn.AnimationHoverSpeed = 0.07F;
            this.removeBtn.AnimationSpeed = 0.03F;
            this.removeBtn.BaseColor = System.Drawing.Color.Transparent;
            this.removeBtn.BorderColor = System.Drawing.Color.Black;
            this.removeBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.removeBtn.ForeColor = System.Drawing.Color.White;
            this.removeBtn.Image = global::WindowsFormsApp1.Properties.Resources.close;
            this.removeBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.removeBtn.ImageSize = new System.Drawing.Size(15, 15);
            this.removeBtn.Location = new System.Drawing.Point(146, 1);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.removeBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.removeBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.removeBtn.OnHoverImage = null;
            this.removeBtn.OnPressedColor = System.Drawing.Color.Black;
            this.removeBtn.Size = new System.Drawing.Size(29, 22);
            this.removeBtn.TabIndex = 0;
            this.removeBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // InitialMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.initialMemberBtn);
            this.Controls.Add(this.removeBtn);
            this.Name = "InitialMembers";
            this.Size = new System.Drawing.Size(183, 22);
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI.WinForms.GunaButton removeBtn;
        public Guna.UI.WinForms.GunaAdvenceButton initialMemberBtn;
    }
}
