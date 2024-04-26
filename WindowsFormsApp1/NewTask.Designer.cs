namespace WindowsFormsApp1
{
    partial class NewTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewTask));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.gunaGradientPanel2 = new Guna.UI.WinForms.GunaGradientPanel();
            this.descriptiontxtbx = new System.Windows.Forms.RichTextBox();
            this.assignBtn = new Guna.UI.WinForms.GunaGradiantButton();
            this.fileLinktxtbx = new Guna.UI.WinForms.GunaLineTextBox();
            this.taskNametxtbx = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaGradientPanel1 = new Guna.UI.WinForms.GunaGradientPanel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.back = new Guna.UI.WinForms.GunaImageButton();
            this.flowLayoutPanel1.SuspendLayout();
            this.gunaGradientPanel2.SuspendLayout();
            this.gunaGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.gunaGradientPanel2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 41);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(378, 289);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // gunaGradientPanel2
            // 
            this.gunaGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaGradientPanel2.BackgroundImage")));
            this.gunaGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaGradientPanel2.Controls.Add(this.descriptiontxtbx);
            this.gunaGradientPanel2.Controls.Add(this.assignBtn);
            this.gunaGradientPanel2.Controls.Add(this.fileLinktxtbx);
            this.gunaGradientPanel2.Controls.Add(this.taskNametxtbx);
            this.gunaGradientPanel2.Controls.Add(this.gunaLabel4);
            this.gunaGradientPanel2.Controls.Add(this.gunaLabel3);
            this.gunaGradientPanel2.Controls.Add(this.gunaLabel2);
            this.gunaGradientPanel2.GradiantColor1 = System.Drawing.Color.Black;
            this.gunaGradientPanel2.GradiantColor2 = System.Drawing.Color.Blue;
            this.gunaGradientPanel2.GradiantColor3 = System.Drawing.Color.Black;
            this.gunaGradientPanel2.GradiantColor4 = System.Drawing.Color.Black;
            this.gunaGradientPanel2.Location = new System.Drawing.Point(3, 3);
            this.gunaGradientPanel2.Name = "gunaGradientPanel2";
            this.gunaGradientPanel2.Size = new System.Drawing.Size(375, 286);
            this.gunaGradientPanel2.TabIndex = 0;
            this.gunaGradientPanel2.Text = "gunaGradientPanel2";
            this.gunaGradientPanel2.Click += new System.EventHandler(this.gunaGradientPanel2_Click);
            // 
            // descriptiontxtbx
            // 
            this.descriptiontxtbx.Location = new System.Drawing.Point(118, 69);
            this.descriptiontxtbx.Name = "descriptiontxtbx";
            this.descriptiontxtbx.Size = new System.Drawing.Size(239, 76);
            this.descriptiontxtbx.TabIndex = 7;
            this.descriptiontxtbx.Text = "";
            // 
            // assignBtn
            // 
            this.assignBtn.AnimationHoverSpeed = 0.07F;
            this.assignBtn.AnimationSpeed = 0.03F;
            this.assignBtn.BackColor = System.Drawing.Color.Transparent;
            this.assignBtn.BaseColor1 = System.Drawing.Color.Navy;
            this.assignBtn.BaseColor2 = System.Drawing.Color.Black;
            this.assignBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.assignBtn.ForeColor = System.Drawing.Color.White;
            this.assignBtn.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.assignBtn.Image = null;
            this.assignBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.assignBtn.Location = new System.Drawing.Point(138, 214);
            this.assignBtn.Name = "assignBtn";
            this.assignBtn.OnHoverBaseColor1 = System.Drawing.Color.Black;
            this.assignBtn.OnHoverBaseColor2 = System.Drawing.Color.Blue;
            this.assignBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.assignBtn.OnHoverImage = null;
            this.assignBtn.OnPressedColor = System.Drawing.Color.Black;
            this.assignBtn.Radius = 10;
            this.assignBtn.Size = new System.Drawing.Size(98, 38);
            this.assignBtn.TabIndex = 6;
            this.assignBtn.Text = "ASSIGN TASK";
            this.assignBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.assignBtn.Click += new System.EventHandler(this.assignBtn_Click);
            // 
            // fileLinktxtbx
            // 
            this.fileLinktxtbx.BackColor = System.Drawing.Color.White;
            this.fileLinktxtbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fileLinktxtbx.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.fileLinktxtbx.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.fileLinktxtbx.LineColor = System.Drawing.Color.DarkGray;
            this.fileLinktxtbx.Location = new System.Drawing.Point(118, 158);
            this.fileLinktxtbx.Name = "fileLinktxtbx";
            this.fileLinktxtbx.PasswordChar = '\0';
            this.fileLinktxtbx.Size = new System.Drawing.Size(239, 27);
            this.fileLinktxtbx.TabIndex = 5;
            // 
            // taskNametxtbx
            // 
            this.taskNametxtbx.BackColor = System.Drawing.Color.White;
            this.taskNametxtbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.taskNametxtbx.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.taskNametxtbx.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.taskNametxtbx.LineColor = System.Drawing.Color.DarkGray;
            this.taskNametxtbx.Location = new System.Drawing.Point(118, 25);
            this.taskNametxtbx.Name = "taskNametxtbx";
            this.taskNametxtbx.PasswordChar = '\0';
            this.taskNametxtbx.Size = new System.Drawing.Size(239, 27);
            this.taskNametxtbx.TabIndex = 3;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 9F, System.Drawing.FontStyle.Bold);
            this.gunaLabel4.ForeColor = System.Drawing.Color.White;
            this.gunaLabel4.Location = new System.Drawing.Point(58, 158);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(58, 16);
            this.gunaLabel4.TabIndex = 2;
            this.gunaLabel4.Text = "File Link :";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 9F, System.Drawing.FontStyle.Bold);
            this.gunaLabel3.ForeColor = System.Drawing.Color.White;
            this.gunaLabel3.Location = new System.Drawing.Point(39, 69);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(77, 16);
            this.gunaLabel3.TabIndex = 1;
            this.gunaLabel3.Text = "Description :";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.White;
            this.gunaLabel2.Location = new System.Drawing.Point(43, 25);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(73, 16);
            this.gunaLabel2.TabIndex = 0;
            this.gunaLabel2.Text = "Task Name :\r\n";
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
            this.gunaGradientPanel1.TabIndex = 2;
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
            this.gunaLabel1.Size = new System.Drawing.Size(90, 21);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "NEW TASK";
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
            // NewTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.gunaGradientPanel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "NewTask";
            this.Size = new System.Drawing.Size(378, 330);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.gunaGradientPanel2.ResumeLayout(false);
            this.gunaGradientPanel2.PerformLayout();
            this.gunaGradientPanel1.ResumeLayout(false);
            this.gunaGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI.WinForms.GunaImageButton back;
        private Guna.UI.WinForms.GunaGradientPanel gunaGradientPanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public Guna.UI.WinForms.GunaGradientPanel gunaGradientPanel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaGradiantButton assignBtn;
        private Guna.UI.WinForms.GunaLineTextBox fileLinktxtbx;
        private Guna.UI.WinForms.GunaLineTextBox taskNametxtbx;
        private System.Windows.Forms.RichTextBox descriptiontxtbx;
    }
}
