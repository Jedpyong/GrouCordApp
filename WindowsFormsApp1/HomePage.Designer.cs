namespace WindowsFormsApp1
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.MainPnl = new Guna.UI.WinForms.GunaGradientPanel();
            this.statuspnl = new Guna.UI.WinForms.GunaElipsePanel();
            this.busybtn = new Guna.UI.WinForms.GunaGradiantButton();
            this.onleavebtn = new Guna.UI.WinForms.GunaGradiantButton();
            this.AVbtn = new Guna.UI.WinForms.GunaGradiantButton();
            this.CombPnl = new Guna.UI.WinForms.GunaPanel();
            this.FLPPnl = new System.Windows.Forms.FlowLayoutPanel();
            this.AddSearchPnl = new Guna.UI.WinForms.GunaPanel();
            this.AddGroupBtn = new Guna.UI.WinForms.GunaCircleButton();
            this.searchTxtBx = new Guna.UI.WinForms.GunaTextBox();
            this.searchBtn = new Guna.UI.WinForms.GunaCircleButton();
            this.groupLabel = new Guna.UI.WinForms.GunaLabel();
            this.DemoPnl = new Guna.UI.WinForms.GunaGradientPanel();
            this.setStat = new Guna.UI.WinForms.GunaGradiantButton();
            this.profileButton = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.statuspic = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.close = new Guna.UI.WinForms.GunaImageButton();
            this.statlabel = new System.Windows.Forms.Label();
            this.accName = new Guna.UI.WinForms.GunaLabel();
            this.MainPnl.SuspendLayout();
            this.statuspnl.SuspendLayout();
            this.CombPnl.SuspendLayout();
            this.AddSearchPnl.SuspendLayout();
            this.DemoPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profileButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statuspic)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPnl
            // 
            this.MainPnl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MainPnl.BackgroundImage")));
            this.MainPnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainPnl.Controls.Add(this.statuspnl);
            this.MainPnl.Controls.Add(this.CombPnl);
            this.MainPnl.Controls.Add(this.groupLabel);
            this.MainPnl.Controls.Add(this.DemoPnl);
            this.MainPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPnl.GradiantColor1 = System.Drawing.Color.Black;
            this.MainPnl.GradiantColor2 = System.Drawing.Color.Navy;
            this.MainPnl.GradiantColor3 = System.Drawing.Color.Black;
            this.MainPnl.GradiantColor4 = System.Drawing.Color.Black;
            this.MainPnl.Location = new System.Drawing.Point(0, 0);
            this.MainPnl.Name = "MainPnl";
            this.MainPnl.Size = new System.Drawing.Size(520, 384);
            this.MainPnl.TabIndex = 0;
            this.MainPnl.Text = "gunaGradientPanel1";
            this.MainPnl.Click += new System.EventHandler(this.MainPnl_Click);
            // 
            // statuspnl
            // 
            this.statuspnl.BackColor = System.Drawing.Color.Black;
            this.statuspnl.BaseColor = System.Drawing.Color.Black;
            this.statuspnl.Controls.Add(this.busybtn);
            this.statuspnl.Controls.Add(this.onleavebtn);
            this.statuspnl.Controls.Add(this.AVbtn);
            this.statuspnl.Location = new System.Drawing.Point(330, 86);
            this.statuspnl.Margin = new System.Windows.Forms.Padding(0);
            this.statuspnl.Name = "statuspnl";
            this.statuspnl.Size = new System.Drawing.Size(189, 132);
            this.statuspnl.TabIndex = 33;
            this.statuspnl.Visible = false;
            // 
            // busybtn
            // 
            this.busybtn.AnimationHoverSpeed = 0.07F;
            this.busybtn.AnimationSpeed = 0.03F;
            this.busybtn.BaseColor1 = System.Drawing.Color.MediumBlue;
            this.busybtn.BaseColor2 = System.Drawing.Color.Black;
            this.busybtn.Font = new System.Drawing.Font("Segoe UI Black", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.busybtn.ForeColor = System.Drawing.Color.White;
            this.busybtn.Image = null;
            this.busybtn.ImageSize = new System.Drawing.Size(20, 20);
            this.busybtn.Location = new System.Drawing.Point(1, 44);
            this.busybtn.Margin = new System.Windows.Forms.Padding(0);
            this.busybtn.Name = "busybtn";
            this.busybtn.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.busybtn.OnHoverBaseColor2 = System.Drawing.Color.Black;
            this.busybtn.OnHoverForeColor = System.Drawing.Color.White;
            this.busybtn.OnHoverImage = null;
            this.busybtn.OnPressedColor = System.Drawing.Color.Black;
            this.busybtn.Size = new System.Drawing.Size(160, 42);
            this.busybtn.TabIndex = 3;
            this.busybtn.Text = "BUSY";
            this.busybtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.busybtn.Click += new System.EventHandler(this.busybtn_Click);
            // 
            // onleavebtn
            // 
            this.onleavebtn.AnimationHoverSpeed = 0.07F;
            this.onleavebtn.AnimationSpeed = 0.03F;
            this.onleavebtn.BaseColor1 = System.Drawing.Color.MediumBlue;
            this.onleavebtn.BaseColor2 = System.Drawing.Color.Black;
            this.onleavebtn.Font = new System.Drawing.Font("Segoe UI Black", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.onleavebtn.ForeColor = System.Drawing.Color.White;
            this.onleavebtn.Image = null;
            this.onleavebtn.ImageSize = new System.Drawing.Size(20, 20);
            this.onleavebtn.Location = new System.Drawing.Point(1, 87);
            this.onleavebtn.Margin = new System.Windows.Forms.Padding(0);
            this.onleavebtn.Name = "onleavebtn";
            this.onleavebtn.OnHoverBaseColor1 = System.Drawing.Color.Yellow;
            this.onleavebtn.OnHoverBaseColor2 = System.Drawing.Color.Black;
            this.onleavebtn.OnHoverForeColor = System.Drawing.Color.White;
            this.onleavebtn.OnHoverImage = null;
            this.onleavebtn.OnPressedColor = System.Drawing.Color.Black;
            this.onleavebtn.Size = new System.Drawing.Size(159, 42);
            this.onleavebtn.TabIndex = 4;
            this.onleavebtn.Text = "ON_LEAVE";
            this.onleavebtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.onleavebtn.Click += new System.EventHandler(this.onleavebtn_Click);
            // 
            // AVbtn
            // 
            this.AVbtn.AnimationHoverSpeed = 0.07F;
            this.AVbtn.AnimationSpeed = 0.03F;
            this.AVbtn.BaseColor1 = System.Drawing.Color.MediumBlue;
            this.AVbtn.BaseColor2 = System.Drawing.Color.Black;
            this.AVbtn.Font = new System.Drawing.Font("Segoe UI Black", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.AVbtn.ForeColor = System.Drawing.Color.White;
            this.AVbtn.Image = null;
            this.AVbtn.ImageSize = new System.Drawing.Size(20, 20);
            this.AVbtn.Location = new System.Drawing.Point(1, 1);
            this.AVbtn.Name = "AVbtn";
            this.AVbtn.OnHoverBaseColor1 = System.Drawing.Color.Green;
            this.AVbtn.OnHoverBaseColor2 = System.Drawing.Color.Black;
            this.AVbtn.OnHoverForeColor = System.Drawing.Color.White;
            this.AVbtn.OnHoverImage = null;
            this.AVbtn.OnPressedColor = System.Drawing.Color.Black;
            this.AVbtn.Size = new System.Drawing.Size(160, 42);
            this.AVbtn.TabIndex = 0;
            this.AVbtn.Text = "AVAILABLE";
            this.AVbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AVbtn.Click += new System.EventHandler(this.AVbtn_Click);
            // 
            // CombPnl
            // 
            this.CombPnl.BackColor = System.Drawing.Color.Transparent;
            this.CombPnl.Controls.Add(this.FLPPnl);
            this.CombPnl.Controls.Add(this.AddSearchPnl);
            this.CombPnl.Location = new System.Drawing.Point(36, 119);
            this.CombPnl.Margin = new System.Windows.Forms.Padding(0);
            this.CombPnl.Name = "CombPnl";
            this.CombPnl.Size = new System.Drawing.Size(454, 253);
            this.CombPnl.TabIndex = 9;
            // 
            // FLPPnl
            // 
            this.FLPPnl.AutoScroll = true;
            this.FLPPnl.AutoScrollMargin = new System.Drawing.Size(5, 5);
            this.FLPPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLPPnl.ForeColor = System.Drawing.Color.Transparent;
            this.FLPPnl.Location = new System.Drawing.Point(0, 46);
            this.FLPPnl.Margin = new System.Windows.Forms.Padding(0);
            this.FLPPnl.Name = "FLPPnl";
            this.FLPPnl.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.FLPPnl.Size = new System.Drawing.Size(454, 207);
            this.FLPPnl.TabIndex = 3;
            // 
            // AddSearchPnl
            // 
            this.AddSearchPnl.BackColor = System.Drawing.Color.Transparent;
            this.AddSearchPnl.Controls.Add(this.AddGroupBtn);
            this.AddSearchPnl.Controls.Add(this.searchTxtBx);
            this.AddSearchPnl.Controls.Add(this.searchBtn);
            this.AddSearchPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddSearchPnl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddSearchPnl.Location = new System.Drawing.Point(0, 0);
            this.AddSearchPnl.Name = "AddSearchPnl";
            this.AddSearchPnl.Size = new System.Drawing.Size(454, 46);
            this.AddSearchPnl.TabIndex = 0;
            // 
            // AddGroupBtn
            // 
            this.AddGroupBtn.AnimationHoverSpeed = 0.07F;
            this.AddGroupBtn.AnimationSpeed = 0.03F;
            this.AddGroupBtn.BaseColor = System.Drawing.Color.White;
            this.AddGroupBtn.BorderColor = System.Drawing.Color.Black;
            this.AddGroupBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddGroupBtn.ForeColor = System.Drawing.Color.White;
            this.AddGroupBtn.Image = global::WindowsFormsApp1.Properties.Resources.user;
            this.AddGroupBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.AddGroupBtn.Location = new System.Drawing.Point(409, 5);
            this.AddGroupBtn.Name = "AddGroupBtn";
            this.AddGroupBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.AddGroupBtn.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.AddGroupBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.AddGroupBtn.OnHoverImage = null;
            this.AddGroupBtn.OnPressedColor = System.Drawing.Color.Black;
            this.AddGroupBtn.Size = new System.Drawing.Size(39, 39);
            this.AddGroupBtn.TabIndex = 4;
            this.AddGroupBtn.Click += new System.EventHandler(this.AddGroupBtn_Click);
            // 
            // searchTxtBx
            // 
            this.searchTxtBx.BackColor = System.Drawing.Color.Transparent;
            this.searchTxtBx.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.searchTxtBx.BorderColor = System.Drawing.Color.Transparent;
            this.searchTxtBx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchTxtBx.FocusedBaseColor = System.Drawing.Color.MidnightBlue;
            this.searchTxtBx.FocusedBorderColor = System.Drawing.Color.Black;
            this.searchTxtBx.FocusedForeColor = System.Drawing.Color.WhiteSmoke;
            this.searchTxtBx.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchTxtBx.ForeColor = System.Drawing.Color.Black;
            this.searchTxtBx.Location = new System.Drawing.Point(0, 5);
            this.searchTxtBx.Name = "searchTxtBx";
            this.searchTxtBx.PasswordChar = '\0';
            this.searchTxtBx.Radius = 10;
            this.searchTxtBx.Size = new System.Drawing.Size(160, 35);
            this.searchTxtBx.TabIndex = 5;
            this.searchTxtBx.Text = "Search";
            this.searchTxtBx.Click += new System.EventHandler(this.searchTxtBx_Click_1);
            this.searchTxtBx.Enter += new System.EventHandler(this.searchTxtBx_Enter_1);
            this.searchTxtBx.Leave += new System.EventHandler(this.searchTxtBx_Leave_1);
            // 
            // searchBtn
            // 
            this.searchBtn.AnimationHoverSpeed = 0.07F;
            this.searchBtn.AnimationSpeed = 0.03F;
            this.searchBtn.BackColor = System.Drawing.Color.Transparent;
            this.searchBtn.BaseColor = System.Drawing.Color.White;
            this.searchBtn.BorderColor = System.Drawing.Color.Black;
            this.searchBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.Image = global::WindowsFormsApp1.Properties.Resources.icons8_search_64;
            this.searchBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.searchBtn.Location = new System.Drawing.Point(169, 5);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.searchBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.searchBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.searchBtn.OnHoverImage = null;
            this.searchBtn.OnPressedColor = System.Drawing.Color.Black;
            this.searchBtn.Size = new System.Drawing.Size(35, 35);
            this.searchBtn.TabIndex = 3;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // groupLabel
            // 
            this.groupLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupLabel.BackColor = System.Drawing.Color.Transparent;
            this.groupLabel.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupLabel.ForeColor = System.Drawing.Color.White;
            this.groupLabel.Location = new System.Drawing.Point(223, 91);
            this.groupLabel.Name = "groupLabel";
            this.groupLabel.Size = new System.Drawing.Size(89, 29);
            this.groupLabel.TabIndex = 8;
            this.groupLabel.Text = "Groups";
            this.groupLabel.Click += new System.EventHandler(this.groupLabel_Click);
            // 
            // DemoPnl
            // 
            this.DemoPnl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DemoPnl.BackgroundImage")));
            this.DemoPnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DemoPnl.Controls.Add(this.setStat);
            this.DemoPnl.Controls.Add(this.profileButton);
            this.DemoPnl.Controls.Add(this.statuspic);
            this.DemoPnl.Controls.Add(this.close);
            this.DemoPnl.Controls.Add(this.statlabel);
            this.DemoPnl.Controls.Add(this.accName);
            this.DemoPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.DemoPnl.GradiantColor1 = System.Drawing.Color.Navy;
            this.DemoPnl.GradiantColor2 = System.Drawing.Color.DarkBlue;
            this.DemoPnl.GradiantColor3 = System.Drawing.Color.Black;
            this.DemoPnl.GradiantColor4 = System.Drawing.Color.Black;
            this.DemoPnl.Location = new System.Drawing.Point(0, 0);
            this.DemoPnl.Name = "DemoPnl";
            this.DemoPnl.Size = new System.Drawing.Size(520, 89);
            this.DemoPnl.TabIndex = 10;
            this.DemoPnl.Text = "gunaGradientPanel1";
            this.DemoPnl.Click += new System.EventHandler(this.DemoPnl_Click_1);
            // 
            // setStat
            // 
            this.setStat.AnimationHoverSpeed = 0.07F;
            this.setStat.AnimationSpeed = 0.03F;
            this.setStat.BaseColor1 = System.Drawing.Color.MediumBlue;
            this.setStat.BaseColor2 = System.Drawing.Color.Black;
            this.setStat.Font = new System.Drawing.Font("Segoe UI Black", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.setStat.ForeColor = System.Drawing.Color.White;
            this.setStat.Image = null;
            this.setStat.ImageSize = new System.Drawing.Size(20, 20);
            this.setStat.Location = new System.Drawing.Point(330, 44);
            this.setStat.Name = "setStat";
            this.setStat.OnHoverBaseColor1 = System.Drawing.Color.Green;
            this.setStat.OnHoverBaseColor2 = System.Drawing.Color.Black;
            this.setStat.OnHoverForeColor = System.Drawing.Color.White;
            this.setStat.OnHoverImage = null;
            this.setStat.OnPressedColor = System.Drawing.Color.Black;
            this.setStat.Size = new System.Drawing.Size(190, 42);
            this.setStat.TabIndex = 14;
            this.setStat.Text = "AVAILABLE";
            this.setStat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.setStat.Click += new System.EventHandler(this.setStat_Click);
            // 
            // profileButton
            // 
            this.profileButton.BackColor = System.Drawing.Color.Transparent;
            this.profileButton.BaseColor = System.Drawing.Color.White;
            this.profileButton.Location = new System.Drawing.Point(12, 0);
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(83, 86);
            this.profileButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profileButton.TabIndex = 13;
            this.profileButton.TabStop = false;
            this.profileButton.UseTransfarantBackground = false;
            this.profileButton.Click += new System.EventHandler(this.profileButton_Click_1);
            // 
            // statuspic
            // 
            this.statuspic.BackColor = System.Drawing.Color.Transparent;
            this.statuspic.BaseColor = System.Drawing.Color.White;
            this.statuspic.Image = global::WindowsFormsApp1.Properties.Resources.sunbed__1_;
            this.statuspic.Location = new System.Drawing.Point(418, 4);
            this.statuspic.Name = "statuspic";
            this.statuspic.Size = new System.Drawing.Size(35, 35);
            this.statuspic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.statuspic.TabIndex = 3;
            this.statuspic.TabStop = false;
            this.statuspic.UseTransfarantBackground = false;
            this.statuspic.Click += new System.EventHandler(this.statuspic_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.close.Image = global::WindowsFormsApp1.Properties.Resources.close_4361951;
            this.close.ImageSize = new System.Drawing.Size(30, 30);
            this.close.Location = new System.Drawing.Point(496, -1);
            this.close.Name = "close";
            this.close.OnHoverImage = null;
            this.close.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.close.Size = new System.Drawing.Size(25, 23);
            this.close.TabIndex = 12;
            this.close.Click += new System.EventHandler(this.close_Click_1);
            // 
            // statlabel
            // 
            this.statlabel.AutoSize = true;
            this.statlabel.BackColor = System.Drawing.Color.Transparent;
            this.statlabel.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statlabel.ForeColor = System.Drawing.Color.White;
            this.statlabel.Location = new System.Drawing.Point(345, 12);
            this.statlabel.Name = "statlabel";
            this.statlabel.Size = new System.Drawing.Size(64, 20);
            this.statlabel.TabIndex = 2;
            this.statlabel.Text = "Status: ";
            // 
            // accName
            // 
            this.accName.AutoSize = true;
            this.accName.BackColor = System.Drawing.Color.Transparent;
            this.accName.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.accName.ForeColor = System.Drawing.Color.Transparent;
            this.accName.Location = new System.Drawing.Point(108, 26);
            this.accName.Name = "accName";
            this.accName.Size = new System.Drawing.Size(185, 37);
            this.accName.TabIndex = 1;
            this.accName.Text = "Jade Jaballa";
            this.accName.Click += new System.EventHandler(this.accName_Click_1);
            // 
            // HomePage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(520, 384);
            this.Controls.Add(this.MainPnl);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomePage";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.MainPnl.ResumeLayout(false);
            this.statuspnl.ResumeLayout(false);
            this.CombPnl.ResumeLayout(false);
            this.AddSearchPnl.ResumeLayout(false);
            this.DemoPnl.ResumeLayout(false);
            this.DemoPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profileButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statuspic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public Guna.UI.WinForms.GunaGradientPanel DemoPnl;
        private Guna.UI.WinForms.GunaImageButton close;
        private System.Windows.Forms.Label statlabel;
        private Guna.UI.WinForms.GunaLabel accName;
        public Guna.UI.WinForms.GunaPanel CombPnl;
        private Guna.UI.WinForms.GunaPanel AddSearchPnl;
        private Guna.UI.WinForms.GunaTextBox searchTxtBx;
        private Guna.UI.WinForms.GunaCircleButton AddGroupBtn;
        private Guna.UI.WinForms.GunaCircleButton searchBtn;
        public Guna.UI.WinForms.GunaLabel groupLabel;
        public Guna.UI.WinForms.GunaGradientPanel MainPnl;
        public Guna.UI.WinForms.GunaCirclePictureBox statuspic;
        public Guna.UI.WinForms.GunaCirclePictureBox profileButton;
        private Guna.UI.WinForms.GunaElipsePanel statuspnl;
        private Guna.UI.WinForms.GunaGradiantButton busybtn;
        private Guna.UI.WinForms.GunaGradiantButton onleavebtn;
        private Guna.UI.WinForms.GunaGradiantButton AVbtn;
        public Guna.UI.WinForms.GunaGradiantButton setStat;
        public System.Windows.Forms.FlowLayoutPanel FLPPnl;
    }
}