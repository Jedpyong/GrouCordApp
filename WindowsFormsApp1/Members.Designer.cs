namespace WindowsFormsApp1
{
    partial class Members
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Members));
            this.Member = new Guna.UI.WinForms.GunaGradientPanel();
            this.memberPic = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.assignBtn = new Guna.UI.WinForms.GunaGradientPanel();
            this.Assign = new Guna.UI.WinForms.GunaImageButton();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.removeBtn = new Guna.UI.WinForms.GunaGradientPanel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.remove = new Guna.UI.WinForms.GunaImageButton();
            this.memberName = new Guna.UI.WinForms.GunaLabel();
            this.emailLabel = new Guna.UI.WinForms.GunaLabel();
            this.gunaGradientPanel1 = new Guna.UI.WinForms.GunaGradientPanel();
            this.status = new Guna.UI.WinForms.GunaLabel();
            this.Role = new Guna.UI.WinForms.GunaLabel();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.Member.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberPic)).BeginInit();
            this.assignBtn.SuspendLayout();
            this.removeBtn.SuspendLayout();
            this.gunaGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Member
            // 
            this.Member.BackColor = System.Drawing.Color.Navy;
            this.Member.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Member.BackgroundImage")));
            this.Member.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Member.Controls.Add(this.memberPic);
            this.Member.Controls.Add(this.assignBtn);
            this.Member.Controls.Add(this.removeBtn);
            this.Member.Controls.Add(this.memberName);
            this.Member.Controls.Add(this.emailLabel);
            this.Member.Controls.Add(this.gunaGradientPanel1);
            this.Member.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Member.GradiantColor1 = System.Drawing.Color.Black;
            this.Member.GradiantColor2 = System.Drawing.Color.DarkBlue;
            this.Member.GradiantColor3 = System.Drawing.Color.Black;
            this.Member.GradiantColor4 = System.Drawing.Color.Black;
            this.Member.Location = new System.Drawing.Point(0, 0);
            this.Member.Name = "Member";
            this.Member.Size = new System.Drawing.Size(352, 70);
            this.Member.TabIndex = 0;
            this.Member.Text = "gunaGradientPanel1";
            this.Member.Click += new System.EventHandler(this.Member_Click);
            // 
            // memberPic
            // 
            this.memberPic.BackColor = System.Drawing.Color.Transparent;
            this.memberPic.BaseColor = System.Drawing.Color.White;
            this.memberPic.Location = new System.Drawing.Point(3, 8);
            this.memberPic.Name = "memberPic";
            this.memberPic.Size = new System.Drawing.Size(50, 50);
            this.memberPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.memberPic.TabIndex = 0;
            this.memberPic.TabStop = false;
            this.memberPic.UseTransfarantBackground = false;
            // 
            // assignBtn
            // 
            this.assignBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("assignBtn.BackgroundImage")));
            this.assignBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.assignBtn.Controls.Add(this.Assign);
            this.assignBtn.Controls.Add(this.gunaLabel3);
            this.assignBtn.GradiantColor1 = System.Drawing.Color.Lime;
            this.assignBtn.GradiantColor2 = System.Drawing.Color.ForestGreen;
            this.assignBtn.GradiantColor3 = System.Drawing.Color.LimeGreen;
            this.assignBtn.GradiantColor4 = System.Drawing.Color.DarkGreen;
            this.assignBtn.Location = new System.Drawing.Point(316, 4);
            this.assignBtn.Margin = new System.Windows.Forms.Padding(0);
            this.assignBtn.Name = "assignBtn";
            this.assignBtn.Size = new System.Drawing.Size(35, 30);
            this.assignBtn.TabIndex = 13;
            this.assignBtn.Text = "gunaGradientPanel1";
            this.assignBtn.Click += new System.EventHandler(this.assignBtn_Click);
            // 
            // Assign
            // 
            this.Assign.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Assign.BackColor = System.Drawing.Color.Transparent;
            this.Assign.Image = global::WindowsFormsApp1.Properties.Resources.clipboard_14722058;
            this.Assign.ImageSize = new System.Drawing.Size(27, 27);
            this.Assign.Location = new System.Drawing.Point(0, 0);
            this.Assign.Name = "Assign";
            this.Assign.OnHoverImage = null;
            this.Assign.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.Assign.Size = new System.Drawing.Size(34, 30);
            this.Assign.TabIndex = 3;
            this.Assign.Click += new System.EventHandler(this.Assign_Click_1);
            this.Assign.MouseEnter += new System.EventHandler(this.Assign_MouseEnter_1);
            this.Assign.MouseLeave += new System.EventHandler(this.Assign_MouseLeave_1);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.ForeColor = System.Drawing.Color.Transparent;
            this.gunaLabel3.Location = new System.Drawing.Point(-52, 6);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(62, 15);
            this.gunaLabel3.TabIndex = 5;
            this.gunaLabel3.Text = "ON_LEAVE";
            this.gunaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // removeBtn
            // 
            this.removeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("removeBtn.BackgroundImage")));
            this.removeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.removeBtn.Controls.Add(this.gunaLabel1);
            this.removeBtn.Controls.Add(this.remove);
            this.removeBtn.GradiantColor1 = System.Drawing.Color.Firebrick;
            this.removeBtn.GradiantColor2 = System.Drawing.Color.Red;
            this.removeBtn.GradiantColor3 = System.Drawing.Color.DarkRed;
            this.removeBtn.GradiantColor4 = System.Drawing.Color.Maroon;
            this.removeBtn.Location = new System.Drawing.Point(316, 37);
            this.removeBtn.Margin = new System.Windows.Forms.Padding(0);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(35, 30);
            this.removeBtn.TabIndex = 12;
            this.removeBtn.Text = "gunaGradientPanel1";
            this.removeBtn.MouseEnter += new System.EventHandler(this.removeBtn_MouseEnter);
            this.removeBtn.MouseLeave += new System.EventHandler(this.removeBtn_MouseLeave);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.ForeColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Location = new System.Drawing.Point(-52, 6);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(50, 15);
            this.gunaLabel1.TabIndex = 5;
            this.gunaLabel1.Text = "Remove";
            // 
            // remove
            // 
            this.remove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.remove.BackColor = System.Drawing.Color.Transparent;
            this.remove.Image = global::WindowsFormsApp1.Properties.Resources.backspace_7156299;
            this.remove.ImageSize = new System.Drawing.Size(40, 37);
            this.remove.Location = new System.Drawing.Point(0, 0);
            this.remove.Name = "remove";
            this.remove.OnHoverImage = null;
            this.remove.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.remove.Size = new System.Drawing.Size(35, 30);
            this.remove.TabIndex = 4;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            this.remove.MouseEnter += new System.EventHandler(this.remove_MouseEnter);
            this.remove.MouseLeave += new System.EventHandler(this.remove_MouseLeave);
            // 
            // memberName
            // 
            this.memberName.BackColor = System.Drawing.Color.Transparent;
            this.memberName.Font = new System.Drawing.Font("Segoe UI Variable Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.memberName.Location = new System.Drawing.Point(65, 8);
            this.memberName.Name = "memberName";
            this.memberName.Size = new System.Drawing.Size(164, 32);
            this.memberName.TabIndex = 1;
            this.memberName.Text = "Jade Jaballa";
            this.memberName.Click += new System.EventHandler(this.memberName_Click);
            // 
            // emailLabel
            // 
            this.emailLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.emailLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.emailLabel.Location = new System.Drawing.Point(68, 37);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(161, 21);
            this.emailLabel.TabIndex = 14;
            this.emailLabel.Text = "jadejaballa@gmail.com";
            this.emailLabel.Click += new System.EventHandler(this.emailLabel_Click);
            // 
            // gunaGradientPanel1
            // 
            this.gunaGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaGradientPanel1.BackgroundImage")));
            this.gunaGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaGradientPanel1.Controls.Add(this.status);
            this.gunaGradientPanel1.Controls.Add(this.Role);
            this.gunaGradientPanel1.GradiantColor1 = System.Drawing.Color.MidnightBlue;
            this.gunaGradientPanel1.GradiantColor2 = System.Drawing.Color.Black;
            this.gunaGradientPanel1.GradiantColor3 = System.Drawing.Color.Black;
            this.gunaGradientPanel1.GradiantColor4 = System.Drawing.Color.Blue;
            this.gunaGradientPanel1.Location = new System.Drawing.Point(235, 0);
            this.gunaGradientPanel1.Name = "gunaGradientPanel1";
            this.gunaGradientPanel1.Size = new System.Drawing.Size(71, 70);
            this.gunaGradientPanel1.TabIndex = 16;
            this.gunaGradientPanel1.Text = "gunaGradientPanel1";
            this.gunaGradientPanel1.Click += new System.EventHandler(this.gunaGradientPanel1_Click);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.BackColor = System.Drawing.Color.Transparent;
            this.status.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Bold);
            this.status.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.status.Location = new System.Drawing.Point(2, 37);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(67, 16);
            this.status.TabIndex = 5;
            this.status.Text = "AVAILABLE";
            this.status.Click += new System.EventHandler(this.status_Click);
            this.status.MouseEnter += new System.EventHandler(this.status_MouseEnter);
            // 
            // Role
            // 
            this.Role.AutoSize = true;
            this.Role.BackColor = System.Drawing.Color.Transparent;
            this.Role.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Bold);
            this.Role.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Role.Location = new System.Drawing.Point(2, 16);
            this.Role.Name = "Role";
            this.Role.Size = new System.Drawing.Size(50, 16);
            this.Role.TabIndex = 15;
            this.Role.Text = "LEADER";
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 5;
            this.gunaElipse1.TargetControl = this;
            // 
            // Members
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Member);
            this.Name = "Members";
            this.Size = new System.Drawing.Size(352, 70);
            this.Load += new System.EventHandler(this.Members_Load);
            this.Member.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memberPic)).EndInit();
            this.assignBtn.ResumeLayout(false);
            this.assignBtn.PerformLayout();
            this.removeBtn.ResumeLayout(false);
            this.removeBtn.PerformLayout();
            this.gunaGradientPanel1.ResumeLayout(false);
            this.gunaGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public Guna.UI.WinForms.GunaCirclePictureBox memberPic;
        public Guna.UI.WinForms.GunaLabel memberName;
        public Guna.UI.WinForms.GunaLabel status;
        private Guna.UI.WinForms.GunaImageButton remove;
        private Guna.UI.WinForms.GunaGradientPanel Member;
        private Guna.UI.WinForms.GunaImageButton Assign;
        private Guna.UI.WinForms.GunaGradientPanel removeBtn;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaGradientPanel assignBtn;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        public Guna.UI.WinForms.GunaLabel Role;
        public Guna.UI.WinForms.GunaLabel emailLabel;
        private Guna.UI.WinForms.GunaGradientPanel gunaGradientPanel1;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
    }
}
