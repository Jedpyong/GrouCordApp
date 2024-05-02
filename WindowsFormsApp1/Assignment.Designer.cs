namespace WindowsFormsApp1
{
    partial class Assignment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Assignment));
            this.gunaGradientPanel2 = new Guna.UI.WinForms.GunaGradientPanel();
            this.descriptiontxtbx = new System.Windows.Forms.RichTextBox();
            this.back = new Guna.UI.WinForms.GunaImageButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaGradientPanel1 = new Guna.UI.WinForms.GunaGradientPanel();
            this.gunaGradientPanel2.SuspendLayout();
            this.gunaGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaGradientPanel2
            // 
            this.gunaGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaGradientPanel2.BackgroundImage")));
            this.gunaGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaGradientPanel2.Controls.Add(this.descriptiontxtbx);
            this.gunaGradientPanel2.GradiantColor1 = System.Drawing.Color.Black;
            this.gunaGradientPanel2.GradiantColor2 = System.Drawing.Color.Blue;
            this.gunaGradientPanel2.GradiantColor3 = System.Drawing.Color.Black;
            this.gunaGradientPanel2.GradiantColor4 = System.Drawing.Color.Black;
            this.gunaGradientPanel2.Location = new System.Drawing.Point(0, 41);
            this.gunaGradientPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.gunaGradientPanel2.Name = "gunaGradientPanel2";
            this.gunaGradientPanel2.Size = new System.Drawing.Size(378, 289);
            this.gunaGradientPanel2.TabIndex = 4;
            this.gunaGradientPanel2.Text = "gunaGradientPanel2";
            this.gunaGradientPanel2.Click += new System.EventHandler(this.gunaGradientPanel2_Click);
            // 
            // descriptiontxtbx
            // 
            this.descriptiontxtbx.AcceptsTab = true;
            this.descriptiontxtbx.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Bold);
            this.descriptiontxtbx.Location = new System.Drawing.Point(18, 3);
            this.descriptiontxtbx.Name = "descriptiontxtbx";
            this.descriptiontxtbx.ReadOnly = true;
            this.descriptiontxtbx.Size = new System.Drawing.Size(342, 273);
            this.descriptiontxtbx.TabIndex = 7;
            this.descriptiontxtbx.Text = "";
            this.descriptiontxtbx.TextChanged += new System.EventHandler(this.descriptiontxtbx_TextChanged);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.Image = global::WindowsFormsApp1.Properties.Resources.turn_back;
            this.back.ImageSize = new System.Drawing.Size(30, 30);
            this.back.Location = new System.Drawing.Point(0, 0);
            this.back.Name = "back";
            this.back.OnHoverImage = null;
            this.back.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.back.Size = new System.Drawing.Size(40, 41);
            this.back.TabIndex = 0;
            this.back.Click += new System.EventHandler(this.back_Click);
            this.back.MouseEnter += new System.EventHandler(this.back_MouseEnter);
            this.back.MouseLeave += new System.EventHandler(this.back_MouseLeave);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(137, 9);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(114, 21);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "ASSIGNMENT";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaGradientPanel1
            // 
            this.gunaGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaGradientPanel1.BackgroundImage")));
            this.gunaGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaGradientPanel1.Controls.Add(this.gunaLabel1);
            this.gunaGradientPanel1.Controls.Add(this.back);
            this.gunaGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaGradientPanel1.GradiantColor1 = System.Drawing.Color.Black;
            this.gunaGradientPanel1.GradiantColor2 = System.Drawing.Color.Navy;
            this.gunaGradientPanel1.GradiantColor3 = System.Drawing.Color.Blue;
            this.gunaGradientPanel1.GradiantColor4 = System.Drawing.Color.Black;
            this.gunaGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaGradientPanel1.Name = "gunaGradientPanel1";
            this.gunaGradientPanel1.Size = new System.Drawing.Size(378, 41);
            this.gunaGradientPanel1.TabIndex = 3;
            this.gunaGradientPanel1.Text = "gunaGradientPanel1";
            // 
            // Assignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaGradientPanel2);
            this.Controls.Add(this.gunaGradientPanel1);
            this.Name = "Assignment";
            this.Size = new System.Drawing.Size(378, 330);
            this.Load += new System.EventHandler(this.Assignment_Load);
            this.gunaGradientPanel2.ResumeLayout(false);
            this.gunaGradientPanel1.ResumeLayout(false);
            this.gunaGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public Guna.UI.WinForms.GunaGradientPanel gunaGradientPanel2;
        public System.Windows.Forms.RichTextBox descriptiontxtbx;
        public Guna.UI.WinForms.GunaImageButton back;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaGradientPanel gunaGradientPanel1;
    }
}
