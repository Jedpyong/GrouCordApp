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
            this.profileButton = new Guna.UI.WinForms.GunaImageButton();
            this.DemoPnl = new Guna.UI.WinForms.GunaGradientPanel();
            this.gunaComboBox1 = new Guna.UI.WinForms.GunaComboBox();
            this.statlabel = new System.Windows.Forms.Label();
            this.accName = new Guna.UI.WinForms.GunaLabel();
            this.CombPnl = new Guna.UI.WinForms.GunaPanel();
            this.FLPPnl = new System.Windows.Forms.FlowLayoutPanel();
            this.AddSearchPnl = new Guna.UI.WinForms.GunaPanel();
            this.AddGroupBtn = new Guna.UI.WinForms.GunaCircleButton();
            this.gunaCircleButton2 = new Guna.UI.WinForms.GunaCircleButton();
            this.gunaTextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.groupLabel = new Guna.UI.WinForms.GunaLabel();
            this.DemoPnl.SuspendLayout();
            this.CombPnl.SuspendLayout();
            this.AddSearchPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // profileButton
            // 
            this.profileButton.BackColor = System.Drawing.Color.Transparent;
            this.profileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.profileButton.Image = ((System.Drawing.Image)(resources.GetObject("profileButton.Image")));
            this.profileButton.ImageSize = new System.Drawing.Size(65, 65);
            this.profileButton.Location = new System.Drawing.Point(0, 0);
            this.profileButton.Name = "profileButton";
            this.profileButton.OnHoverImage = null;
            this.profileButton.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.profileButton.Size = new System.Drawing.Size(93, 97);
            this.profileButton.TabIndex = 0;
            // 
            // DemoPnl
            // 
            this.DemoPnl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DemoPnl.BackgroundImage")));
            this.DemoPnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DemoPnl.Controls.Add(this.gunaComboBox1);
            this.DemoPnl.Controls.Add(this.statlabel);
            this.DemoPnl.Controls.Add(this.accName);
            this.DemoPnl.Controls.Add(this.profileButton);
            this.DemoPnl.GradiantColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.DemoPnl.GradiantColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.DemoPnl.GradiantColor3 = System.Drawing.Color.Blue;
            this.DemoPnl.GradiantColor4 = System.Drawing.Color.White;
            this.DemoPnl.Location = new System.Drawing.Point(3, 3);
            this.DemoPnl.Name = "DemoPnl";
            this.DemoPnl.Size = new System.Drawing.Size(514, 89);
            this.DemoPnl.TabIndex = 1;
            this.DemoPnl.Text = "gunaGradientPanel1";
            // 
            // gunaComboBox1
            // 
            this.gunaComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaComboBox1.BaseColor = System.Drawing.Color.White;
            this.gunaComboBox1.BorderColor = System.Drawing.Color.Silver;
            this.gunaComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gunaComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gunaComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaComboBox1.ForeColor = System.Drawing.Color.Black;
            this.gunaComboBox1.FormattingEnabled = true;
            this.gunaComboBox1.Location = new System.Drawing.Point(367, 45);
            this.gunaComboBox1.Name = "gunaComboBox1";
            this.gunaComboBox1.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaComboBox1.OnHoverItemForeColor = System.Drawing.Color.White;
            this.gunaComboBox1.Size = new System.Drawing.Size(121, 26);
            this.gunaComboBox1.TabIndex = 2;
            this.gunaComboBox1.SelectedIndexChanged += new System.EventHandler(this.gunaComboBox1_SelectedIndexChanged);
            // 
            // statlabel
            // 
            this.statlabel.AutoSize = true;
            this.statlabel.BackColor = System.Drawing.Color.Transparent;
            this.statlabel.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statlabel.ForeColor = System.Drawing.Color.Black;
            this.statlabel.Location = new System.Drawing.Point(364, 16);
            this.statlabel.Name = "statlabel";
            this.statlabel.Size = new System.Drawing.Size(55, 14);
            this.statlabel.TabIndex = 2;
            this.statlabel.Text = "Status: ";
            // 
            // accName
            // 
            this.accName.AutoSize = true;
            this.accName.BackColor = System.Drawing.Color.Transparent;
            this.accName.Font = new System.Drawing.Font("Cooper Black", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accName.ForeColor = System.Drawing.Color.Black;
            this.accName.Location = new System.Drawing.Point(99, 16);
            this.accName.Name = "accName";
            this.accName.Size = new System.Drawing.Size(240, 40);
            this.accName.TabIndex = 1;
            this.accName.Text = "Jade Jaballa";
            this.accName.Click += new System.EventHandler(this.accName_Click);
            // 
            // CombPnl
            // 
            this.CombPnl.Controls.Add(this.FLPPnl);
            this.CombPnl.Controls.Add(this.AddSearchPnl);
            this.CombPnl.Location = new System.Drawing.Point(39, 122);
            this.CombPnl.Margin = new System.Windows.Forms.Padding(0);
            this.CombPnl.Name = "CombPnl";
            this.CombPnl.Size = new System.Drawing.Size(448, 253);
            this.CombPnl.TabIndex = 6;
            // 
            // FLPPnl
            // 
            this.FLPPnl.AutoScroll = true;
            this.FLPPnl.AutoScrollMargin = new System.Drawing.Size(5, 5);
            this.FLPPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLPPnl.Location = new System.Drawing.Point(0, 46);
            this.FLPPnl.Margin = new System.Windows.Forms.Padding(0);
            this.FLPPnl.Name = "FLPPnl";
            this.FLPPnl.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.FLPPnl.Size = new System.Drawing.Size(448, 207);
            this.FLPPnl.TabIndex = 3;
//            this.FLPPnl.Paint += new System.Windows.Forms.PaintEventHandler(this.FLPPnl_Paint);
            // 
            // AddSearchPnl
            // 
            this.AddSearchPnl.Controls.Add(this.AddGroupBtn);
            this.AddSearchPnl.Controls.Add(this.gunaCircleButton2);
            this.AddSearchPnl.Controls.Add(this.gunaTextBox1);
            this.AddSearchPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddSearchPnl.Location = new System.Drawing.Point(0, 0);
            this.AddSearchPnl.Name = "AddSearchPnl";
            this.AddSearchPnl.Size = new System.Drawing.Size(448, 46);
            this.AddSearchPnl.TabIndex = 0;
            // 
            // AddGroupBtn
            // 
            this.AddGroupBtn.AnimationHoverSpeed = 0.07F;
            this.AddGroupBtn.AnimationSpeed = 0.03F;
            this.AddGroupBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddGroupBtn.BackgroundImage")));
            this.AddGroupBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.AddGroupBtn.BorderColor = System.Drawing.Color.Black;
            this.AddGroupBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddGroupBtn.ForeColor = System.Drawing.Color.White;
            this.AddGroupBtn.Image = ((System.Drawing.Image)(resources.GetObject("AddGroupBtn.Image")));
            this.AddGroupBtn.ImageSize = new System.Drawing.Size(35, 35);
            this.AddGroupBtn.Location = new System.Drawing.Point(394, 5);
            this.AddGroupBtn.Name = "AddGroupBtn";
            this.AddGroupBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.AddGroupBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.AddGroupBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.AddGroupBtn.OnHoverImage = null;
            this.AddGroupBtn.OnPressedColor = System.Drawing.Color.Black;
            this.AddGroupBtn.Size = new System.Drawing.Size(35, 35);
            this.AddGroupBtn.TabIndex = 4;
            this.AddGroupBtn.Click += new System.EventHandler(this.AddGroupBtn_Click);
            // 
            // gunaCircleButton2
            // 
            this.gunaCircleButton2.AnimationHoverSpeed = 0.07F;
            this.gunaCircleButton2.AnimationSpeed = 0.03F;
            this.gunaCircleButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaCircleButton2.BackgroundImage")));
            this.gunaCircleButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaCircleButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaCircleButton2.ForeColor = System.Drawing.Color.White;
            this.gunaCircleButton2.Image = ((System.Drawing.Image)(resources.GetObject("gunaCircleButton2.Image")));
            this.gunaCircleButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaCircleButton2.Location = new System.Drawing.Point(169, 5);
            this.gunaCircleButton2.Name = "gunaCircleButton2";
            this.gunaCircleButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaCircleButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaCircleButton2.OnHoverImage = null;
            this.gunaCircleButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaCircleButton2.Size = new System.Drawing.Size(35, 35);
            this.gunaCircleButton2.TabIndex = 3;
            // 
            // gunaTextBox1
            // 
            this.gunaTextBox1.BaseColor = System.Drawing.Color.DimGray;
            this.gunaTextBox1.BorderColor = System.Drawing.Color.Transparent;
            this.gunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox1.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBox1.Location = new System.Drawing.Point(3, 5);
            this.gunaTextBox1.Name = "gunaTextBox1";
            this.gunaTextBox1.PasswordChar = '\0';
            this.gunaTextBox1.Radius = 10;
            this.gunaTextBox1.Size = new System.Drawing.Size(160, 35);
            this.gunaTextBox1.TabIndex = 2;
            this.gunaTextBox1.Text = "Search";
            // 
            // groupLabel
            // 
            this.groupLabel.AutoSize = true;
            this.groupLabel.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupLabel.ForeColor = System.Drawing.Color.Blue;
            this.groupLabel.Location = new System.Drawing.Point(224, 95);
            this.groupLabel.Name = "groupLabel";
            this.groupLabel.Size = new System.Drawing.Size(89, 24);
            this.groupLabel.TabIndex = 2;
            this.groupLabel.Text = "Groups";
            // 
            // HomePage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(520, 384);
            this.Controls.Add(this.CombPnl);
            this.Controls.Add(this.groupLabel);
            this.Controls.Add(this.DemoPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.DemoPnl.ResumeLayout(false);
            this.DemoPnl.PerformLayout();
            this.CombPnl.ResumeLayout(false);
            this.AddSearchPnl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaImageButton profileButton;
        private Guna.UI.WinForms.GunaGradientPanel DemoPnl;
        private Guna.UI.WinForms.GunaLabel accName;
        private System.Windows.Forms.Label statlabel;
        private Guna.UI.WinForms.GunaComboBox gunaComboBox1;
        private Guna.UI.WinForms.GunaPanel CombPnl;
        private Guna.UI.WinForms.GunaPanel AddSearchPnl;
        private Guna.UI.WinForms.GunaLabel groupLabel;
        private Guna.UI.WinForms.GunaCircleButton gunaCircleButton2;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox1;
        private System.Windows.Forms.FlowLayoutPanel FLPPnl;
        private Guna.UI.WinForms.GunaCircleButton AddGroupBtn;
    }
}