namespace WindowsFormsApp1
{
    partial class NotifAnnouncement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotifAnnouncement));
            this.gunaGradientPanel1 = new Guna.UI.WinForms.GunaGradientPanel();
            this.annLabel = new Guna.UI.WinForms.GunaLabel();
            this.back = new Guna.UI.WinForms.GunaImageButton();
            this.mainPanel = new Guna.UI.WinForms.GunaGradientPanel();
            this.Announcement = new System.Windows.Forms.RichTextBox();
            this.gunaGradientPanel1.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaGradientPanel1
            // 
            this.gunaGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaGradientPanel1.BackgroundImage")));
            this.gunaGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaGradientPanel1.Controls.Add(this.annLabel);
            this.gunaGradientPanel1.Controls.Add(this.back);
            this.gunaGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaGradientPanel1.GradiantColor1 = System.Drawing.Color.Black;
            this.gunaGradientPanel1.GradiantColor2 = System.Drawing.Color.RoyalBlue;
            this.gunaGradientPanel1.GradiantColor3 = System.Drawing.Color.Navy;
            this.gunaGradientPanel1.GradiantColor4 = System.Drawing.Color.Navy;
            this.gunaGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaGradientPanel1.Name = "gunaGradientPanel1";
            this.gunaGradientPanel1.Size = new System.Drawing.Size(378, 41);
            this.gunaGradientPanel1.TabIndex = 5;
            this.gunaGradientPanel1.Text = "gunaGradientPanel1";
            // 
            // annLabel
            // 
            this.annLabel.AutoSize = true;
            this.annLabel.BackColor = System.Drawing.Color.Transparent;
            this.annLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annLabel.ForeColor = System.Drawing.Color.White;
            this.annLabel.Location = new System.Drawing.Point(114, 10);
            this.annLabel.Name = "annLabel";
            this.annLabel.Size = new System.Drawing.Size(149, 21);
            this.annLabel.TabIndex = 2;
            this.annLabel.Text = "ANNOUNCEMENT";
            this.annLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // mainPanel
            // 
            this.mainPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainPanel.BackgroundImage")));
            this.mainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainPanel.Controls.Add(this.Announcement);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.GradiantColor1 = System.Drawing.Color.Black;
            this.mainPanel.GradiantColor2 = System.Drawing.Color.Navy;
            this.mainPanel.GradiantColor3 = System.Drawing.Color.Black;
            this.mainPanel.GradiantColor4 = System.Drawing.Color.Black;
            this.mainPanel.Location = new System.Drawing.Point(0, 41);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(378, 289);
            this.mainPanel.TabIndex = 6;
            this.mainPanel.Text = "gunaGradientPanel2";
            // 
            // Announcement
            // 
            this.Announcement.AcceptsTab = true;
            this.Announcement.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Announcement.ForeColor = System.Drawing.Color.White;
            this.Announcement.Location = new System.Drawing.Point(16, 3);
            this.Announcement.Name = "Announcement";
            this.Announcement.ReadOnly = true;
            this.Announcement.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.Announcement.Size = new System.Drawing.Size(346, 283);
            this.Announcement.TabIndex = 26;
            this.Announcement.Text = "";
            this.Announcement.TextChanged += new System.EventHandler(this.Announcement_TextChanged);
            // 
            // NotifAnnouncement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.gunaGradientPanel1);
            this.Name = "NotifAnnouncement";
            this.Size = new System.Drawing.Size(378, 330);
            this.gunaGradientPanel1.ResumeLayout(false);
            this.gunaGradientPanel1.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGradientPanel gunaGradientPanel1;
        private Guna.UI.WinForms.GunaLabel annLabel;
        public Guna.UI.WinForms.GunaImageButton back;
        private Guna.UI.WinForms.GunaGradientPanel mainPanel;
        public System.Windows.Forms.RichTextBox Announcement;
    }
}
