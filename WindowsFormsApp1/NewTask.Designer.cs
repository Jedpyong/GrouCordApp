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
            this.gunaGradientPanel1 = new Guna.UI.WinForms.GunaGradientPanel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.back = new Guna.UI.WinForms.GunaImageButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.gunaGradientPanel2 = new Guna.UI.WinForms.GunaGradientPanel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLineTextBox1 = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLineTextBox3 = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaGradiantButton1 = new Guna.UI.WinForms.GunaGradiantButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.gunaGradientPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
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
            this.gunaGradientPanel1.GradiantColor1 = System.Drawing.Color.DarkBlue;
            this.gunaGradientPanel1.GradiantColor2 = System.Drawing.Color.Navy;
            this.gunaGradientPanel1.GradiantColor3 = System.Drawing.Color.RoyalBlue;
            this.gunaGradientPanel1.GradiantColor4 = System.Drawing.Color.GhostWhite;
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.gunaGradientPanel2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 41);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(378, 267);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // gunaGradientPanel2
            // 
            this.gunaGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaGradientPanel2.BackgroundImage")));
            this.gunaGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaGradientPanel2.Controls.Add(this.richTextBox1);
            this.gunaGradientPanel2.Controls.Add(this.gunaGradiantButton1);
            this.gunaGradientPanel2.Controls.Add(this.gunaLineTextBox3);
            this.gunaGradientPanel2.Controls.Add(this.gunaLineTextBox1);
            this.gunaGradientPanel2.Controls.Add(this.gunaLabel4);
            this.gunaGradientPanel2.Controls.Add(this.gunaLabel3);
            this.gunaGradientPanel2.Controls.Add(this.gunaLabel2);
            this.gunaGradientPanel2.GradiantColor1 = System.Drawing.Color.MediumPurple;
            this.gunaGradientPanel2.GradiantColor2 = System.Drawing.Color.MediumBlue;
            this.gunaGradientPanel2.GradiantColor3 = System.Drawing.Color.White;
            this.gunaGradientPanel2.GradiantColor4 = System.Drawing.Color.Navy;
            this.gunaGradientPanel2.Location = new System.Drawing.Point(3, 3);
            this.gunaGradientPanel2.Name = "gunaGradientPanel2";
            this.gunaGradientPanel2.Size = new System.Drawing.Size(375, 264);
            this.gunaGradientPanel2.TabIndex = 0;
            this.gunaGradientPanel2.Text = "gunaGradientPanel2";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(29, 25);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(70, 15);
            this.gunaLabel2.TabIndex = 0;
            this.gunaLabel2.Text = "Task Name :\r\n";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(29, 71);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(73, 15);
            this.gunaLabel3.TabIndex = 1;
            this.gunaLabel3.Text = "Description :";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel4.Location = new System.Drawing.Point(43, 158);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(56, 15);
            this.gunaLabel4.TabIndex = 2;
            this.gunaLabel4.Text = "File Link :";
            // 
            // gunaLineTextBox1
            // 
            this.gunaLineTextBox1.BackColor = System.Drawing.Color.White;
            this.gunaLineTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaLineTextBox1.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaLineTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLineTextBox1.LineColor = System.Drawing.Color.DarkGray;
            this.gunaLineTextBox1.Location = new System.Drawing.Point(118, 25);
            this.gunaLineTextBox1.Name = "gunaLineTextBox1";
            this.gunaLineTextBox1.PasswordChar = '\0';
            this.gunaLineTextBox1.Size = new System.Drawing.Size(239, 27);
            this.gunaLineTextBox1.TabIndex = 3;
            // 
            // gunaLineTextBox3
            // 
            this.gunaLineTextBox3.BackColor = System.Drawing.Color.White;
            this.gunaLineTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaLineTextBox3.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaLineTextBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLineTextBox3.LineColor = System.Drawing.Color.DarkGray;
            this.gunaLineTextBox3.Location = new System.Drawing.Point(118, 158);
            this.gunaLineTextBox3.Name = "gunaLineTextBox3";
            this.gunaLineTextBox3.PasswordChar = '\0';
            this.gunaLineTextBox3.Size = new System.Drawing.Size(239, 27);
            this.gunaLineTextBox3.TabIndex = 5;
            // 
            // gunaGradiantButton1
            // 
            this.gunaGradiantButton1.AnimationHoverSpeed = 0.07F;
            this.gunaGradiantButton1.AnimationSpeed = 0.03F;
            this.gunaGradiantButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradiantButton1.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.gunaGradiantButton1.BaseColor2 = System.Drawing.Color.Indigo;
            this.gunaGradiantButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaGradiantButton1.ForeColor = System.Drawing.Color.White;
            this.gunaGradiantButton1.Image = null;
            this.gunaGradiantButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaGradiantButton1.Location = new System.Drawing.Point(138, 191);
            this.gunaGradiantButton1.Name = "gunaGradiantButton1";
            this.gunaGradiantButton1.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.gunaGradiantButton1.OnHoverBaseColor2 = System.Drawing.Color.Black;
            this.gunaGradiantButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradiantButton1.OnHoverImage = null;
            this.gunaGradiantButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradiantButton1.Radius = 10;
            this.gunaGradiantButton1.Size = new System.Drawing.Size(98, 38);
            this.gunaGradiantButton1.TabIndex = 6;
            this.gunaGradiantButton1.Text = "ASSIGN TASK";
            this.gunaGradiantButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(118, 69);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(239, 76);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // NewTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.gunaGradientPanel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "NewTask";
            this.Size = new System.Drawing.Size(378, 308);
            this.gunaGradientPanel1.ResumeLayout(false);
            this.gunaGradientPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.gunaGradientPanel2.ResumeLayout(false);
            this.gunaGradientPanel2.PerformLayout();
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
        private Guna.UI.WinForms.GunaGradiantButton gunaGradiantButton1;
        private Guna.UI.WinForms.GunaLineTextBox gunaLineTextBox3;
        private Guna.UI.WinForms.GunaLineTextBox gunaLineTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}
