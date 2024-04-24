namespace WindowsFormsApp1
{
    partial class groupz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(groupz));
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.groupButton = new Guna.UI.WinForms.GunaButton();
            this.GroupPic = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.DeleteGroup = new Guna.UI.WinForms.GunaImageButton();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupPic)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaPanel1.Controls.Add(this.GroupPic);
            this.gunaPanel1.Controls.Add(this.groupButton);
            this.gunaPanel1.Location = new System.Drawing.Point(0, 5);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(374, 38);
            this.gunaPanel1.TabIndex = 3;
            this.gunaPanel1.Click += new System.EventHandler(this.gunaPanel1_Click);
            // 
            // groupButton
            // 
            this.groupButton.AnimationHoverSpeed = 0.07F;
            this.groupButton.AnimationSpeed = 0.03F;
            this.groupButton.BackColor = System.Drawing.Color.Transparent;
            this.groupButton.BaseColor = System.Drawing.Color.Transparent;
            this.groupButton.BorderColor = System.Drawing.Color.Black;
            this.groupButton.BorderSize = 1;
            this.groupButton.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Italic);
            this.groupButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupButton.Image = null;
            this.groupButton.ImageSize = new System.Drawing.Size(20, 20);
            this.groupButton.Location = new System.Drawing.Point(0, 0);
            this.groupButton.Name = "groupButton";
            this.groupButton.OnHoverBaseColor = System.Drawing.Color.MediumBlue;
            this.groupButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.groupButton.OnHoverForeColor = System.Drawing.Color.White;
            this.groupButton.OnHoverImage = null;
            this.groupButton.OnPressedColor = System.Drawing.Color.Black;
            this.groupButton.Size = new System.Drawing.Size(374, 38);
            this.groupButton.TabIndex = 4;
            this.groupButton.Text = "Handsome Group";
            this.groupButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.groupButton.Click += new System.EventHandler(this.groupButton_Click);
            // 
            // GroupPic
            // 
            this.GroupPic.BackColor = System.Drawing.Color.Transparent;
            this.GroupPic.BaseColor = System.Drawing.Color.Transparent;
            this.GroupPic.Image = ((System.Drawing.Image)(resources.GetObject("GroupPic.Image")));
            this.GroupPic.Location = new System.Drawing.Point(0, 0);
            this.GroupPic.Margin = new System.Windows.Forms.Padding(0);
            this.GroupPic.Name = "GroupPic";
            this.GroupPic.Size = new System.Drawing.Size(43, 38);
            this.GroupPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GroupPic.TabIndex = 6;
            this.GroupPic.TabStop = false;
            this.GroupPic.UseTransfarantBackground = false;
            this.GroupPic.Click += new System.EventHandler(this.GroupPic_Click_2);
            // 
            // DeleteGroup
            // 
            this.DeleteGroup.BackColor = System.Drawing.Color.Red;
            this.DeleteGroup.Image = ((System.Drawing.Image)(resources.GetObject("DeleteGroup.Image")));
            this.DeleteGroup.ImageSize = new System.Drawing.Size(20, 20);
            this.DeleteGroup.Location = new System.Drawing.Point(380, 5);
            this.DeleteGroup.Name = "DeleteGroup";
            this.DeleteGroup.OnHoverImage = null;
            this.DeleteGroup.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.DeleteGroup.Size = new System.Drawing.Size(38, 38);
            this.DeleteGroup.TabIndex = 0;
            this.DeleteGroup.Click += new System.EventHandler(this.DeleteGroup_Click);
            this.DeleteGroup.MouseEnter += new System.EventHandler(this.DeleteGroup_MouseEnter);
            this.DeleteGroup.MouseLeave += new System.EventHandler(this.DeleteGroup_MouseLeave);
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 7;
            this.gunaElipse1.TargetControl = this;
            // 
            // groupz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.DeleteGroup);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "groupz";
            this.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.Size = new System.Drawing.Size(426, 50);
            this.Load += new System.EventHandler(this.groupz_Load);
            this.gunaPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GroupPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaImageButton DeleteGroup;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        public Guna.UI.WinForms.GunaCirclePictureBox GroupPic;
        public Guna.UI.WinForms.GunaButton groupButton;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
    }
}
