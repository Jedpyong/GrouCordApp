namespace WindowsFormsApp1
{
    partial class GroupPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupPage));
            this.outpnl = new Guna.UI.WinForms.GunaGradientPanel();
            this.FLPGroupPage = new System.Windows.Forms.FlowLayoutPanel();
            this.gunaGradientPanel1 = new Guna.UI.WinForms.GunaGradientPanel();
            this.Schedules = new Guna.UI.WinForms.GunaGradiantButton();
            this.mainPanel = new Guna.UI.WinForms.GunaGradientPanel();
            this.Announcements = new Guna.UI.WinForms.GunaGradiantButton();
            this.Tasks = new Guna.UI.WinForms.GunaGradiantButton();
            this.addMember = new Guna.UI.WinForms.GunaGradiantButton();
            this.upperPanel = new Guna.UI.WinForms.GunaGradientPanel();
            this.Notif2 = new Guna.UI.WinForms.GunaImageButton();
            this.groupPic = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.groupName = new Guna.UI.WinForms.GunaLabel();
            this.HomeBtn = new Guna.UI.WinForms.GunaImageButton();
            this.outpnl.SuspendLayout();
            this.gunaGradientPanel1.SuspendLayout();
            this.upperPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupPic)).BeginInit();
            this.SuspendLayout();
            // 
            // outpnl
            // 
            this.outpnl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("outpnl.BackgroundImage")));
            this.outpnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.outpnl.Controls.Add(this.FLPGroupPage);
            this.outpnl.GradiantColor1 = System.Drawing.Color.Black;
            this.outpnl.GradiantColor2 = System.Drawing.Color.Black;
            this.outpnl.GradiantColor3 = System.Drawing.Color.Blue;
            this.outpnl.GradiantColor4 = System.Drawing.Color.Black;
            this.outpnl.Location = new System.Drawing.Point(126, 63);
            this.outpnl.Margin = new System.Windows.Forms.Padding(20, 1, 0, 0);
            this.outpnl.Name = "outpnl";
            this.outpnl.Size = new System.Drawing.Size(394, 321);
            this.outpnl.TabIndex = 0;
            this.outpnl.Text = "gunaGradientPanel2";
            this.outpnl.Click += new System.EventHandler(this.outpnl_Click);
            // 
            // FLPGroupPage
            // 
            this.FLPGroupPage.AutoScroll = true;
            this.FLPGroupPage.BackColor = System.Drawing.Color.Transparent;
            this.FLPGroupPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.FLPGroupPage.Location = new System.Drawing.Point(0, 0);
            this.FLPGroupPage.Margin = new System.Windows.Forms.Padding(0);
            this.FLPGroupPage.Name = "FLPGroupPage";
            this.FLPGroupPage.Size = new System.Drawing.Size(394, 323);
            this.FLPGroupPage.TabIndex = 2;
            this.FLPGroupPage.Paint += new System.Windows.Forms.PaintEventHandler(this.FLPGroupPage_Paint_1);
            // 
            // gunaGradientPanel1
            // 
            this.gunaGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaGradientPanel1.BackgroundImage")));
            this.gunaGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaGradientPanel1.Controls.Add(this.Schedules);
            this.gunaGradientPanel1.Controls.Add(this.mainPanel);
            this.gunaGradientPanel1.Controls.Add(this.Announcements);
            this.gunaGradientPanel1.Controls.Add(this.Tasks);
            this.gunaGradientPanel1.Controls.Add(this.addMember);
            this.gunaGradientPanel1.GradiantColor1 = System.Drawing.Color.Black;
            this.gunaGradientPanel1.GradiantColor2 = System.Drawing.Color.Navy;
            this.gunaGradientPanel1.GradiantColor3 = System.Drawing.Color.Black;
            this.gunaGradientPanel1.GradiantColor4 = System.Drawing.Color.Black;
            this.gunaGradientPanel1.Location = new System.Drawing.Point(0, 56);
            this.gunaGradientPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.gunaGradientPanel1.Name = "gunaGradientPanel1";
            this.gunaGradientPanel1.Size = new System.Drawing.Size(126, 329);
            this.gunaGradientPanel1.TabIndex = 0;
            this.gunaGradientPanel1.Text = "gunaGradientPanel1";
            this.gunaGradientPanel1.Click += new System.EventHandler(this.gunaGradientPanel1_Click);
            // 
            // Schedules
            // 
            this.Schedules.AnimationHoverSpeed = 0.07F;
            this.Schedules.AnimationSpeed = 0.03F;
            this.Schedules.BaseColor1 = System.Drawing.Color.Navy;
            this.Schedules.BaseColor2 = System.Drawing.Color.SlateBlue;
            this.Schedules.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Schedules.ForeColor = System.Drawing.Color.White;
            this.Schedules.Image = global::WindowsFormsApp1.Properties.Resources.schedule_2669764;
            this.Schedules.ImageSize = new System.Drawing.Size(20, 20);
            this.Schedules.Location = new System.Drawing.Point(0, 54);
            this.Schedules.Name = "Schedules";
            this.Schedules.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.Schedules.OnHoverBaseColor2 = System.Drawing.Color.Black;
            this.Schedules.OnHoverForeColor = System.Drawing.Color.White;
            this.Schedules.OnHoverImage = null;
            this.Schedules.OnPressedColor = System.Drawing.Color.Black;
            this.Schedules.Radius = 1;
            this.Schedules.Size = new System.Drawing.Size(126, 42);
            this.Schedules.TabIndex = 8;
            this.Schedules.Text = " Schedules  ";
            this.Schedules.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Schedules.Click += new System.EventHandler(this.Schedules_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainPanel.BackgroundImage")));
            this.mainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainPanel.GradiantColor1 = System.Drawing.Color.White;
            this.mainPanel.GradiantColor2 = System.Drawing.Color.White;
            this.mainPanel.GradiantColor3 = System.Drawing.Color.Black;
            this.mainPanel.GradiantColor4 = System.Drawing.Color.Black;
            this.mainPanel.Location = new System.Drawing.Point(141, 6);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(378, 321);
            this.mainPanel.TabIndex = 1;
            this.mainPanel.Text = "gunaGradientPanel2";
            // 
            // Announcements
            // 
            this.Announcements.AnimationHoverSpeed = 0.07F;
            this.Announcements.AnimationSpeed = 0.03F;
            this.Announcements.BaseColor1 = System.Drawing.Color.Navy;
            this.Announcements.BaseColor2 = System.Drawing.Color.SlateBlue;
            this.Announcements.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Announcements.ForeColor = System.Drawing.Color.White;
            this.Announcements.Image = global::WindowsFormsApp1.Properties.Resources.megaphone_2907972;
            this.Announcements.ImageSize = new System.Drawing.Size(20, 20);
            this.Announcements.Location = new System.Drawing.Point(0, 102);
            this.Announcements.Name = "Announcements";
            this.Announcements.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.Announcements.OnHoverBaseColor2 = System.Drawing.Color.Black;
            this.Announcements.OnHoverForeColor = System.Drawing.Color.White;
            this.Announcements.OnHoverImage = null;
            this.Announcements.OnPressedColor = System.Drawing.Color.Black;
            this.Announcements.Radius = 1;
            this.Announcements.Size = new System.Drawing.Size(126, 42);
            this.Announcements.TabIndex = 6;
            this.Announcements.Text = "       Announcements";
            this.Announcements.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Announcements.Click += new System.EventHandler(this.Announcements_Click);
            // 
            // Tasks
            // 
            this.Tasks.AnimationHoverSpeed = 0.07F;
            this.Tasks.AnimationSpeed = 0.03F;
            this.Tasks.BaseColor1 = System.Drawing.Color.Navy;
            this.Tasks.BaseColor2 = System.Drawing.Color.SlateBlue;
            this.Tasks.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Tasks.ForeColor = System.Drawing.Color.White;
            this.Tasks.Image = global::WindowsFormsApp1.Properties.Resources.task_10074264;
            this.Tasks.ImageSize = new System.Drawing.Size(20, 20);
            this.Tasks.Location = new System.Drawing.Point(0, 6);
            this.Tasks.Name = "Tasks";
            this.Tasks.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.Tasks.OnHoverBaseColor2 = System.Drawing.Color.Black;
            this.Tasks.OnHoverForeColor = System.Drawing.Color.White;
            this.Tasks.OnHoverImage = null;
            this.Tasks.OnPressedColor = System.Drawing.Color.Black;
            this.Tasks.Radius = 1;
            this.Tasks.Size = new System.Drawing.Size(126, 42);
            this.Tasks.TabIndex = 4;
            this.Tasks.Text = "Tasks";
            this.Tasks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Tasks.Click += new System.EventHandler(this.Tasks_Click);
            this.Tasks.Leave += new System.EventHandler(this.Tasks_Leave);
            // 
            // addMember
            // 
            this.addMember.AnimationHoverSpeed = 0.07F;
            this.addMember.AnimationSpeed = 0.03F;
            this.addMember.BaseColor1 = System.Drawing.Color.Navy;
            this.addMember.BaseColor2 = System.Drawing.Color.SlateBlue;
            this.addMember.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addMember.ForeColor = System.Drawing.Color.White;
            this.addMember.Image = global::WindowsFormsApp1.Properties.Resources.add_user_456320;
            this.addMember.ImageSize = new System.Drawing.Size(20, 20);
            this.addMember.Location = new System.Drawing.Point(0, 150);
            this.addMember.Name = "addMember";
            this.addMember.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.addMember.OnHoverBaseColor2 = System.Drawing.Color.Black;
            this.addMember.OnHoverForeColor = System.Drawing.Color.White;
            this.addMember.OnHoverImage = null;
            this.addMember.OnPressedColor = System.Drawing.Color.Black;
            this.addMember.Radius = 1;
            this.addMember.Size = new System.Drawing.Size(126, 42);
            this.addMember.TabIndex = 0;
            this.addMember.Text = "    Add Member";
            this.addMember.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.addMember.Click += new System.EventHandler(this.addMember_Click);
            // 
            // upperPanel
            // 
            this.upperPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("upperPanel.BackgroundImage")));
            this.upperPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.upperPanel.Controls.Add(this.Notif2);
            this.upperPanel.Controls.Add(this.groupPic);
            this.upperPanel.Controls.Add(this.groupName);
            this.upperPanel.Controls.Add(this.HomeBtn);
            this.upperPanel.GradiantColor1 = System.Drawing.Color.Black;
            this.upperPanel.GradiantColor2 = System.Drawing.Color.Black;
            this.upperPanel.GradiantColor3 = System.Drawing.Color.Blue;
            this.upperPanel.GradiantColor4 = System.Drawing.Color.Black;
            this.upperPanel.Location = new System.Drawing.Point(0, 0);
            this.upperPanel.Margin = new System.Windows.Forms.Padding(0);
            this.upperPanel.Name = "upperPanel";
            this.upperPanel.Size = new System.Drawing.Size(519, 62);
            this.upperPanel.TabIndex = 0;
            this.upperPanel.Text = "gunaGradientPanel1";
            this.upperPanel.Click += new System.EventHandler(this.upperPanel_Click);
            // 
            // Notif2
            // 
            this.Notif2.BackColor = System.Drawing.Color.Transparent;
            this.Notif2.Image = global::WindowsFormsApp1.Properties.Resources.notification__2_;
            this.Notif2.ImageSize = new System.Drawing.Size(36, 36);
            this.Notif2.Location = new System.Drawing.Point(471, 9);
            this.Notif2.Name = "Notif2";
            this.Notif2.OnHoverImage = null;
            this.Notif2.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.Notif2.Size = new System.Drawing.Size(36, 36);
            this.Notif2.TabIndex = 5;
            this.Notif2.Click += new System.EventHandler(this.Notif2_Click);
            this.Notif2.MouseEnter += new System.EventHandler(this.Notif2_MouseEnter);
            this.Notif2.MouseLeave += new System.EventHandler(this.Notif2_MouseLeave);
            // 
            // groupPic
            // 
            this.groupPic.BackColor = System.Drawing.Color.Transparent;
            this.groupPic.BaseColor = System.Drawing.Color.White;
            this.groupPic.Image = ((System.Drawing.Image)(resources.GetObject("groupPic.Image")));
            this.groupPic.Location = new System.Drawing.Point(82, 3);
            this.groupPic.Name = "groupPic";
            this.groupPic.Size = new System.Drawing.Size(56, 53);
            this.groupPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.groupPic.TabIndex = 4;
            this.groupPic.TabStop = false;
            this.groupPic.UseTransfarantBackground = false;
            // 
            // groupName
            // 
            this.groupName.BackColor = System.Drawing.Color.Transparent;
            this.groupName.Font = new System.Drawing.Font("Segoe UI Black", 17F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupName.Location = new System.Drawing.Point(144, 3);
            this.groupName.Margin = new System.Windows.Forms.Padding(0);
            this.groupName.Name = "groupName";
            this.groupName.Size = new System.Drawing.Size(321, 48);
            this.groupName.TabIndex = 2;
            this.groupName.Text = "GroupName";
            this.groupName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HomeBtn
            // 
            this.HomeBtn.BackColor = System.Drawing.Color.Transparent;
            this.HomeBtn.Image = global::WindowsFormsApp1.Properties.Resources.home;
            this.HomeBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.HomeBtn.Location = new System.Drawing.Point(12, 9);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.OnHoverImage = null;
            this.HomeBtn.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.HomeBtn.Size = new System.Drawing.Size(36, 35);
            this.HomeBtn.TabIndex = 1;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            this.HomeBtn.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaImageButton1_Paint);
            this.HomeBtn.MouseEnter += new System.EventHandler(this.gunaImageButton1_MouseEnter);
            this.HomeBtn.MouseLeave += new System.EventHandler(this.gunaImageButton1_MouseLeave);
            // 
            // GroupPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.Controls.Add(this.gunaGradientPanel1);
            this.Controls.Add(this.upperPanel);
            this.Controls.Add(this.outpnl);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "GroupPage";
            this.Size = new System.Drawing.Size(520, 384);
            this.Load += new System.EventHandler(this.GroupPage_Load);
            this.outpnl.ResumeLayout(false);
            this.gunaGradientPanel1.ResumeLayout(false);
            this.upperPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGradientPanel upperPanel;
        private Guna.UI.WinForms.GunaImageButton HomeBtn;
        public Guna.UI.WinForms.GunaLabel groupName;
        public Guna.UI.WinForms.GunaCirclePictureBox groupPic;
        private Guna.UI.WinForms.GunaGradientPanel gunaGradientPanel1;
        private Guna.UI.WinForms.GunaGradiantButton addMember;
        private Guna.UI.WinForms.GunaGradiantButton Announcements;
        private Guna.UI.WinForms.GunaGradiantButton Tasks;
        private Guna.UI.WinForms.GunaGradientPanel mainPanel;
        public System.Windows.Forms.FlowLayoutPanel FLPGroupPage;
        public Guna.UI.WinForms.GunaGradientPanel outpnl;
        private Guna.UI.WinForms.GunaGradiantButton Schedules;
        private Guna.UI.WinForms.GunaImageButton Notif2;
    }
}
