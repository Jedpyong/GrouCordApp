namespace WindowsFormsApp1
{
    partial class Submissions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Submissions));
            this.gunaGradientPanel1 = new Guna.UI.WinForms.GunaGradientPanel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.back = new Guna.UI.WinForms.GunaImageButton();
            this.gunaGradientPanel2 = new Guna.UI.WinForms.GunaGradientPanel();
            this.edit = new Guna.UI.WinForms.GunaGradiantButton();
            this.descriptiontxtbx = new System.Windows.Forms.RichTextBox();
            this.gunaGradientPanel1.SuspendLayout();
            this.gunaGradientPanel2.SuspendLayout();
            this.SuspendLayout();
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
            this.gunaGradientPanel1.TabIndex = 4;
            this.gunaGradientPanel1.Text = "gunaGradientPanel1";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(137, 9);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(118, 21);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "SUBMISSIONS";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // 
            // gunaGradientPanel2
            // 
            this.gunaGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaGradientPanel2.BackgroundImage")));
            this.gunaGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaGradientPanel2.Controls.Add(this.edit);
            this.gunaGradientPanel2.Controls.Add(this.descriptiontxtbx);
            this.gunaGradientPanel2.GradiantColor1 = System.Drawing.Color.Black;
            this.gunaGradientPanel2.GradiantColor2 = System.Drawing.Color.Blue;
            this.gunaGradientPanel2.GradiantColor3 = System.Drawing.Color.Black;
            this.gunaGradientPanel2.GradiantColor4 = System.Drawing.Color.Black;
            this.gunaGradientPanel2.Location = new System.Drawing.Point(0, 41);
            this.gunaGradientPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.gunaGradientPanel2.Name = "gunaGradientPanel2";
            this.gunaGradientPanel2.Size = new System.Drawing.Size(378, 289);
            this.gunaGradientPanel2.TabIndex = 5;
            this.gunaGradientPanel2.Text = "gunaGradientPanel2";
            // 
            // edit
            // 
            this.edit.AnimationHoverSpeed = 0.07F;
            this.edit.AnimationSpeed = 0.03F;
            this.edit.BackColor = System.Drawing.Color.Transparent;
            this.edit.BaseColor1 = System.Drawing.Color.Green;
            this.edit.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.edit.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Bold);
            this.edit.ForeColor = System.Drawing.Color.White;
            this.edit.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.edit.Image = null;
            this.edit.ImageSize = new System.Drawing.Size(20, 20);
            this.edit.Location = new System.Drawing.Point(201, 232);
            this.edit.Name = "edit";
            this.edit.OnHoverBaseColor1 = System.Drawing.Color.Black;
            this.edit.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.edit.OnHoverForeColor = System.Drawing.Color.White;
            this.edit.OnHoverImage = null;
            this.edit.OnPressedColor = System.Drawing.Color.Black;
            this.edit.Radius = 10;
            this.edit.Size = new System.Drawing.Size(144, 38);
            this.edit.TabIndex = 9;
            this.edit.Text = "EDIT SUBMISSION";
            this.edit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // descriptiontxtbx
            // 
            this.descriptiontxtbx.AcceptsTab = true;
            this.descriptiontxtbx.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Bold);
            this.descriptiontxtbx.Location = new System.Drawing.Point(18, 3);
            this.descriptiontxtbx.Name = "descriptiontxtbx";
            this.descriptiontxtbx.ReadOnly = true;
            this.descriptiontxtbx.Size = new System.Drawing.Size(342, 223);
            this.descriptiontxtbx.TabIndex = 7;
            this.descriptiontxtbx.Text = "";
            // 
            // Submissions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaGradientPanel2);
            this.Controls.Add(this.gunaGradientPanel1);
            this.Name = "Submissions";
            this.Size = new System.Drawing.Size(378, 330);
            this.Load += new System.EventHandler(this.Submissions_Load);
            this.gunaGradientPanel1.ResumeLayout(false);
            this.gunaGradientPanel1.PerformLayout();
            this.gunaGradientPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGradientPanel gunaGradientPanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        public Guna.UI.WinForms.GunaImageButton back;
        public Guna.UI.WinForms.GunaGradientPanel gunaGradientPanel2;
        public System.Windows.Forms.RichTextBox descriptiontxtbx;
        public Guna.UI.WinForms.GunaGradiantButton edit;
    }
}
