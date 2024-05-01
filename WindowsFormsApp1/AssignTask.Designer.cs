namespace WindowsFormsApp1
{
    partial class AssignTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssignTask));
            this.gunaGradientPanel2 = new Guna.UI.WinForms.GunaGradientPanel();
            this.existingtask = new Guna.UI.WinForms.GunaGradiantButton();
            this.newtask = new Guna.UI.WinForms.GunaGradiantButton();
            this.ExistingFLP = new System.Windows.Forms.FlowLayoutPanel();
            this.gunaGradientPanel1 = new Guna.UI.WinForms.GunaGradientPanel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.back = new Guna.UI.WinForms.GunaImageButton();
            this.gunaGradientPanel2.SuspendLayout();
            this.gunaGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaGradientPanel2
            // 
            this.gunaGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaGradientPanel2.BackgroundImage")));
            this.gunaGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaGradientPanel2.Controls.Add(this.existingtask);
            this.gunaGradientPanel2.Controls.Add(this.newtask);
            this.gunaGradientPanel2.Controls.Add(this.ExistingFLP);
            this.gunaGradientPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaGradientPanel2.GradiantColor1 = System.Drawing.Color.Black;
            this.gunaGradientPanel2.GradiantColor2 = System.Drawing.Color.Blue;
            this.gunaGradientPanel2.GradiantColor3 = System.Drawing.Color.Black;
            this.gunaGradientPanel2.GradiantColor4 = System.Drawing.Color.Black;
            this.gunaGradientPanel2.Location = new System.Drawing.Point(0, 41);
            this.gunaGradientPanel2.Name = "gunaGradientPanel2";
            this.gunaGradientPanel2.Size = new System.Drawing.Size(378, 289);
            this.gunaGradientPanel2.TabIndex = 1;
            this.gunaGradientPanel2.Text = "gunaGradientPanel2";
            this.gunaGradientPanel2.Click += new System.EventHandler(this.gunaGradientPanel2_Click);
            // 
            // existingtask
            // 
            this.existingtask.AnimationHoverSpeed = 0.07F;
            this.existingtask.AnimationSpeed = 0.03F;
            this.existingtask.BackColor = System.Drawing.Color.Transparent;
            this.existingtask.BaseColor1 = System.Drawing.Color.Navy;
            this.existingtask.BaseColor2 = System.Drawing.Color.Black;
            this.existingtask.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.existingtask.ForeColor = System.Drawing.Color.White;
            this.existingtask.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.existingtask.Image = null;
            this.existingtask.ImageSize = new System.Drawing.Size(20, 20);
            this.existingtask.Location = new System.Drawing.Point(118, 151);
            this.existingtask.Name = "existingtask";
            this.existingtask.OnHoverBaseColor1 = System.Drawing.Color.Black;
            this.existingtask.OnHoverBaseColor2 = System.Drawing.Color.Blue;
            this.existingtask.OnHoverForeColor = System.Drawing.Color.White;
            this.existingtask.OnHoverImage = null;
            this.existingtask.OnPressedColor = System.Drawing.Color.Black;
            this.existingtask.Radius = 10;
            this.existingtask.Size = new System.Drawing.Size(160, 42);
            this.existingtask.TabIndex = 1;
            this.existingtask.Text = "EXISTING TASK";
            this.existingtask.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.existingtask.Click += new System.EventHandler(this.existingtask_Click);
            // 
            // newtask
            // 
            this.newtask.AnimationHoverSpeed = 0.07F;
            this.newtask.AnimationSpeed = 0.03F;
            this.newtask.BackColor = System.Drawing.Color.Transparent;
            this.newtask.BaseColor1 = System.Drawing.Color.Navy;
            this.newtask.BaseColor2 = System.Drawing.Color.Black;
            this.newtask.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.newtask.ForeColor = System.Drawing.Color.White;
            this.newtask.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.newtask.Image = null;
            this.newtask.ImageSize = new System.Drawing.Size(20, 20);
            this.newtask.Location = new System.Drawing.Point(118, 62);
            this.newtask.Name = "newtask";
            this.newtask.OnHoverBaseColor1 = System.Drawing.Color.Black;
            this.newtask.OnHoverBaseColor2 = System.Drawing.Color.Blue;
            this.newtask.OnHoverForeColor = System.Drawing.Color.White;
            this.newtask.OnHoverImage = null;
            this.newtask.OnPressedColor = System.Drawing.Color.Black;
            this.newtask.Radius = 10;
            this.newtask.Size = new System.Drawing.Size(160, 42);
            this.newtask.TabIndex = 0;
            this.newtask.Text = "NEW TASK";
            this.newtask.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.newtask.Click += new System.EventHandler(this.newtask_Click);
            // 
            // ExistingFLP
            // 
            this.ExistingFLP.AutoScroll = true;
            this.ExistingFLP.BackColor = System.Drawing.Color.Transparent;
            this.ExistingFLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExistingFLP.Location = new System.Drawing.Point(0, 0);
            this.ExistingFLP.Name = "ExistingFLP";
            this.ExistingFLP.Size = new System.Drawing.Size(378, 289);
            this.ExistingFLP.TabIndex = 2;
            this.ExistingFLP.Visible = false;
            // 
            // gunaGradientPanel1
            // 
            this.gunaGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaGradientPanel1.BackgroundImage")));
            this.gunaGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaGradientPanel1.Controls.Add(this.gunaLabel1);
            this.gunaGradientPanel1.Controls.Add(this.back);
            this.gunaGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaGradientPanel1.GradiantColor1 = System.Drawing.Color.Blue;
            this.gunaGradientPanel1.GradiantColor2 = System.Drawing.Color.Black;
            this.gunaGradientPanel1.GradiantColor3 = System.Drawing.Color.Blue;
            this.gunaGradientPanel1.GradiantColor4 = System.Drawing.Color.Black;
            this.gunaGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaGradientPanel1.Name = "gunaGradientPanel1";
            this.gunaGradientPanel1.Size = new System.Drawing.Size(378, 41);
            this.gunaGradientPanel1.TabIndex = 0;
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
            this.gunaLabel1.Size = new System.Drawing.Size(110, 21);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "ASSIGN TASK";
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
            this.back.MouseEnter += new System.EventHandler(this.back_MouseEnter);
            this.back.MouseLeave += new System.EventHandler(this.back_MouseLeave);
            // 
            // AssignTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaGradientPanel2);
            this.Controls.Add(this.gunaGradientPanel1);
            this.Name = "AssignTask";
            this.Size = new System.Drawing.Size(378, 330);
            this.gunaGradientPanel2.ResumeLayout(false);
            this.gunaGradientPanel1.ResumeLayout(false);
            this.gunaGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGradientPanel gunaGradientPanel1;
        private Guna.UI.WinForms.GunaGradientPanel gunaGradientPanel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaGradiantButton existingtask;
        private Guna.UI.WinForms.GunaGradiantButton newtask;
        public Guna.UI.WinForms.GunaImageButton back;
        public System.Windows.Forms.FlowLayoutPanel ExistingFLP;
    }
}
