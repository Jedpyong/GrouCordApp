namespace WindowsFormsApp1
{
    partial class Announcement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Announcement));
            this.mainPanel = new Guna.UI.WinForms.GunaGradientPanel();
            this.gunaGradientPanel2 = new Guna.UI.WinForms.GunaGradientPanel();
            this.Repost = new Guna.UI.WinForms.GunaCircleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaCircleButton1 = new Guna.UI.WinForms.GunaCircleButton();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.Atitle = new Guna.UI.WinForms.GunaTextBox();
            this.Bodytxtbx = new System.Windows.Forms.RichTextBox();
            this.PostButton = new Guna.UI.WinForms.GunaButton();
            this.gunaGradientPanel1 = new Guna.UI.WinForms.GunaGradientPanel();
            this.annLabel = new Guna.UI.WinForms.GunaLabel();
            this.back = new Guna.UI.WinForms.GunaImageButton();
            this.mainPanel.SuspendLayout();
            this.gunaGradientPanel2.SuspendLayout();
            this.gunaGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainPanel.BackgroundImage")));
            this.mainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainPanel.Controls.Add(this.gunaGradientPanel2);
            this.mainPanel.Controls.Add(this.Atitle);
            this.mainPanel.Controls.Add(this.Bodytxtbx);
            this.mainPanel.Controls.Add(this.PostButton);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.GradiantColor1 = System.Drawing.Color.Black;
            this.mainPanel.GradiantColor2 = System.Drawing.Color.Black;
            this.mainPanel.GradiantColor3 = System.Drawing.Color.Blue;
            this.mainPanel.GradiantColor4 = System.Drawing.Color.Black;
            this.mainPanel.Location = new System.Drawing.Point(0, 41);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(378, 281);
            this.mainPanel.TabIndex = 5;
            this.mainPanel.Text = "gunaGradientPanel2";
            // 
            // gunaGradientPanel2
            // 
            this.gunaGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaGradientPanel2.BackgroundImage")));
            this.gunaGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaGradientPanel2.Controls.Add(this.Repost);
            this.gunaGradientPanel2.Controls.Add(this.label1);
            this.gunaGradientPanel2.Controls.Add(this.gunaCircleButton1);
            this.gunaGradientPanel2.Controls.Add(this.checkedListBox1);
            this.gunaGradientPanel2.GradiantColor1 = System.Drawing.Color.Black;
            this.gunaGradientPanel2.GradiantColor2 = System.Drawing.Color.Black;
            this.gunaGradientPanel2.GradiantColor3 = System.Drawing.Color.Blue;
            this.gunaGradientPanel2.GradiantColor4 = System.Drawing.Color.Blue;
            this.gunaGradientPanel2.Location = new System.Drawing.Point(0, 0);
            this.gunaGradientPanel2.Name = "gunaGradientPanel2";
            this.gunaGradientPanel2.Size = new System.Drawing.Size(128, 289);
            this.gunaGradientPanel2.TabIndex = 28;
            this.gunaGradientPanel2.Text = "gunaGradientPanel2";
            // 
            // Repost
            // 
            this.Repost.AnimationHoverSpeed = 0.07F;
            this.Repost.AnimationSpeed = 0.03F;
            this.Repost.BackColor = System.Drawing.Color.Transparent;
            this.Repost.BaseColor = System.Drawing.Color.White;
            this.Repost.BorderColor = System.Drawing.Color.Black;
            this.Repost.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Repost.ForeColor = System.Drawing.Color.White;
            this.Repost.Image = global::WindowsFormsApp1.Properties.Resources.loop;
            this.Repost.ImageSize = new System.Drawing.Size(30, 30);
            this.Repost.Location = new System.Drawing.Point(75, 223);
            this.Repost.Name = "Repost";
            this.Repost.OnHoverBaseColor = System.Drawing.Color.Black;
            this.Repost.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Repost.OnHoverForeColor = System.Drawing.Color.White;
            this.Repost.OnHoverImage = null;
            this.Repost.OnPressedColor = System.Drawing.Color.Black;
            this.Repost.Size = new System.Drawing.Size(40, 40);
            this.Repost.TabIndex = 31;
            this.Repost.Click += new System.EventHandler(this.Repost_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 34);
            this.label1.TabIndex = 29;
            this.label1.Text = "       Previous\r\n Announcements";
            // 
            // gunaCircleButton1
            // 
            this.gunaCircleButton1.AnimationHoverSpeed = 0.07F;
            this.gunaCircleButton1.AnimationSpeed = 0.03F;
            this.gunaCircleButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaCircleButton1.BaseColor = System.Drawing.Color.White;
            this.gunaCircleButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaCircleButton1.ForeColor = System.Drawing.Color.White;
            this.gunaCircleButton1.Image = global::WindowsFormsApp1.Properties.Resources.delete;
            this.gunaCircleButton1.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaCircleButton1.Location = new System.Drawing.Point(16, 222);
            this.gunaCircleButton1.Name = "gunaCircleButton1";
            this.gunaCircleButton1.OnHoverBaseColor = System.Drawing.Color.Black;
            this.gunaCircleButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaCircleButton1.OnHoverImage = null;
            this.gunaCircleButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaCircleButton1.Size = new System.Drawing.Size(40, 40);
            this.gunaCircleButton1.TabIndex = 28;
            this.gunaCircleButton1.Click += new System.EventHandler(this.gunaCircleButton1_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.Color.Lavender;
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.ForeColor = System.Drawing.Color.Black;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.HorizontalScrollbar = true;
            this.checkedListBox1.Location = new System.Drawing.Point(11, 53);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(109, 157);
            this.checkedListBox1.TabIndex = 27;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // Atitle
            // 
            this.Atitle.BackColor = System.Drawing.SystemColors.Window;
            this.Atitle.BaseColor = System.Drawing.Color.White;
            this.Atitle.BorderColor = System.Drawing.Color.Silver;
            this.Atitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Atitle.FocusedBaseColor = System.Drawing.Color.White;
            this.Atitle.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Atitle.FocusedForeColor = System.Drawing.Color.Black;
            this.Atitle.Font = new System.Drawing.Font("Segoe UI Variable Display Light", 9F);
            this.Atitle.ForeColor = System.Drawing.Color.Black;
            this.Atitle.Location = new System.Drawing.Point(149, 19);
            this.Atitle.Name = "Atitle";
            this.Atitle.PasswordChar = '\0';
            this.Atitle.Size = new System.Drawing.Size(218, 30);
            this.Atitle.TabIndex = 26;
            this.Atitle.Text = "Announcement Head";
            this.Atitle.Click += new System.EventHandler(this.Atitle_Click);
            this.Atitle.Enter += new System.EventHandler(this.Atitle_Enter);
            this.Atitle.Leave += new System.EventHandler(this.Atitle_Leave);
            // 
            // Bodytxtbx
            // 
            this.Bodytxtbx.AcceptsTab = true;
            this.Bodytxtbx.Font = new System.Drawing.Font("Segoe UI Variable Display Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bodytxtbx.ForeColor = System.Drawing.Color.Black;
            this.Bodytxtbx.Location = new System.Drawing.Point(149, 55);
            this.Bodytxtbx.Name = "Bodytxtbx";
            this.Bodytxtbx.Size = new System.Drawing.Size(218, 151);
            this.Bodytxtbx.TabIndex = 25;
            this.Bodytxtbx.Text = "                             Text Body";
            this.Bodytxtbx.Enter += new System.EventHandler(this.Bodytxtbx_Enter);
            this.Bodytxtbx.Leave += new System.EventHandler(this.Bodytxtbx_Leave);
            // 
            // PostButton
            // 
            this.PostButton.AnimationHoverSpeed = 0.07F;
            this.PostButton.AnimationSpeed = 0.03F;
            this.PostButton.BackColor = System.Drawing.Color.Transparent;
            this.PostButton.BaseColor = System.Drawing.Color.Navy;
            this.PostButton.BorderColor = System.Drawing.Color.Black;
            this.PostButton.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostButton.ForeColor = System.Drawing.Color.White;
            this.PostButton.Image = null;
            this.PostButton.ImageSize = new System.Drawing.Size(20, 20);
            this.PostButton.Location = new System.Drawing.Point(239, 223);
            this.PostButton.Name = "PostButton";
            this.PostButton.OnHoverBaseColor = System.Drawing.Color.Black;
            this.PostButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.PostButton.OnHoverForeColor = System.Drawing.Color.White;
            this.PostButton.OnHoverImage = null;
            this.PostButton.OnPressedColor = System.Drawing.Color.Black;
            this.PostButton.Radius = 10;
            this.PostButton.Size = new System.Drawing.Size(116, 39);
            this.PostButton.TabIndex = 24;
            this.PostButton.Text = "POST";
            this.PostButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PostButton.Click += new System.EventHandler(this.PostButton_Click);
            // 
            // gunaGradientPanel1
            // 
            this.gunaGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaGradientPanel1.BackgroundImage")));
            this.gunaGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaGradientPanel1.Controls.Add(this.annLabel);
            this.gunaGradientPanel1.Controls.Add(this.back);
            this.gunaGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaGradientPanel1.GradiantColor1 = System.Drawing.Color.DarkBlue;
            this.gunaGradientPanel1.GradiantColor2 = System.Drawing.Color.Navy;
            this.gunaGradientPanel1.GradiantColor3 = System.Drawing.Color.RoyalBlue;
            this.gunaGradientPanel1.GradiantColor4 = System.Drawing.Color.Black;
            this.gunaGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaGradientPanel1.Name = "gunaGradientPanel1";
            this.gunaGradientPanel1.Size = new System.Drawing.Size(378, 41);
            this.gunaGradientPanel1.TabIndex = 4;
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
            // Announcement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.gunaGradientPanel1);
            this.Name = "Announcement";
            this.Size = new System.Drawing.Size(378, 322);
            this.Load += new System.EventHandler(this.Announcement_Load);
            this.mainPanel.ResumeLayout(false);
            this.gunaGradientPanel2.ResumeLayout(false);
            this.gunaGradientPanel2.PerformLayout();
            this.gunaGradientPanel1.ResumeLayout(false);
            this.gunaGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGradientPanel gunaGradientPanel1;
        private Guna.UI.WinForms.GunaLabel annLabel;
        public Guna.UI.WinForms.GunaImageButton back;
        private Guna.UI.WinForms.GunaGradientPanel mainPanel;
        private System.Windows.Forms.RichTextBox Bodytxtbx;
        private Guna.UI.WinForms.GunaButton PostButton;
        private Guna.UI.WinForms.GunaTextBox Atitle;
        private Guna.UI.WinForms.GunaGradientPanel gunaGradientPanel2;
        public System.Windows.Forms.CheckedListBox checkedListBox1;
        private Guna.UI.WinForms.GunaCircleButton gunaCircleButton1;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaCircleButton Repost;
    }
}
