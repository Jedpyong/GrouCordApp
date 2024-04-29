namespace WindowsFormsApp1
{
    partial class task
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(task));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaGradientPanel1 = new Guna.UI.WinForms.GunaGradientPanel();
            this.Remarks = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.assigned = new Guna.UI.WinForms.GunaComboBox();
            this.taskName = new Guna.UI.WinForms.GunaLabel();
            this.remarkss = new Guna.UI.WinForms.GunaLabel();
            this.buttonTask = new Guna.UI.WinForms.GunaButton();
            this.gunaGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 10;
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaGradientPanel1
            // 
            this.gunaGradientPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.gunaGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaGradientPanel1.BackgroundImage")));
            this.gunaGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaGradientPanel1.Controls.Add(this.Remarks);
            this.gunaGradientPanel1.Controls.Add(this.gunaLabel2);
            this.gunaGradientPanel1.Controls.Add(this.assigned);
            this.gunaGradientPanel1.Controls.Add(this.taskName);
            this.gunaGradientPanel1.Controls.Add(this.remarkss);
            this.gunaGradientPanel1.Controls.Add(this.buttonTask);
            this.gunaGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaGradientPanel1.ForeColor = System.Drawing.Color.White;
            this.gunaGradientPanel1.GradiantColor1 = System.Drawing.Color.Navy;
            this.gunaGradientPanel1.GradiantColor2 = System.Drawing.Color.DodgerBlue;
            this.gunaGradientPanel1.GradiantColor3 = System.Drawing.Color.Navy;
            this.gunaGradientPanel1.GradiantColor4 = System.Drawing.Color.DodgerBlue;
            this.gunaGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaGradientPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.gunaGradientPanel1.Name = "gunaGradientPanel1";
            this.gunaGradientPanel1.Size = new System.Drawing.Size(357, 89);
            this.gunaGradientPanel1.TabIndex = 0;
            this.gunaGradientPanel1.Text = "gunaGradientPanel1";
            this.gunaGradientPanel1.Click += new System.EventHandler(this.gunaGradientPanel1_Click);
            this.gunaGradientPanel1.MouseEnter += new System.EventHandler(this.gunaGradientPanel1_MouseEnter);
            this.gunaGradientPanel1.MouseLeave += new System.EventHandler(this.gunaGradientPanel1_MouseLeave);
            // 
            // Remarks
            // 
            this.Remarks.BackColor = System.Drawing.Color.Black;
            this.Remarks.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remarks.ForeColor = System.Drawing.Color.White;
            this.Remarks.Location = new System.Drawing.Point(243, 28);
            this.Remarks.Name = "Remarks";
            this.Remarks.Size = new System.Drawing.Size(100, 23);
            this.Remarks.TabIndex = 3;
            this.Remarks.Text = "Remarks";
            this.Remarks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Remarks.Click += new System.EventHandler(this.Remarks_Click);
            this.Remarks.Leave += new System.EventHandler(this.Remarks_Leave);
            this.Remarks.MouseEnter += new System.EventHandler(this.Remarks_MouseEnter);
            this.Remarks.MouseLeave += new System.EventHandler(this.Remarks_MouseLeave);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel2.Location = new System.Drawing.Point(115, 28);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(97, 23);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "ASSIGNED";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // assigned
            // 
            this.assigned.BackColor = System.Drawing.Color.Transparent;
            this.assigned.BaseColor = System.Drawing.Color.White;
            this.assigned.BorderColor = System.Drawing.Color.Silver;
            this.assigned.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.assigned.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.assigned.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.assigned.ForeColor = System.Drawing.Color.Black;
            this.assigned.FormattingEnabled = true;
            this.assigned.Location = new System.Drawing.Point(113, 27);
            this.assigned.Name = "assigned";
            this.assigned.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.assigned.OnHoverItemForeColor = System.Drawing.Color.White;
            this.assigned.Size = new System.Drawing.Size(121, 26);
            this.assigned.TabIndex = 1;
            // 
            // taskName
            // 
            this.taskName.BackColor = System.Drawing.Color.Transparent;
            this.taskName.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskName.Location = new System.Drawing.Point(6, 15);
            this.taskName.Name = "taskName";
            this.taskName.Size = new System.Drawing.Size(100, 55);
            this.taskName.TabIndex = 0;
            this.taskName.Text = "PANGAN NI\r\n SA TASK";
            this.taskName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.taskName.Click += new System.EventHandler(this.taskName_Click);
            // 
            // remarkss
            // 
            this.remarkss.BackColor = System.Drawing.Color.Transparent;
            this.remarkss.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remarkss.ForeColor = System.Drawing.Color.White;
            this.remarkss.Location = new System.Drawing.Point(243, 28);
            this.remarkss.Name = "remarkss";
            this.remarkss.Size = new System.Drawing.Size(100, 23);
            this.remarkss.TabIndex = 4;
            this.remarkss.Text = "FINISH";
            this.remarkss.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.remarkss.Visible = false;
            this.remarkss.MouseLeave += new System.EventHandler(this.remarkss_MouseLeave);
            // 
            // buttonTask
            // 
            this.buttonTask.AnimationHoverSpeed = 0.07F;
            this.buttonTask.AnimationSpeed = 0.03F;
            this.buttonTask.BackColor = System.Drawing.Color.Transparent;
            this.buttonTask.BaseColor = System.Drawing.Color.Transparent;
            this.buttonTask.BorderColor = System.Drawing.Color.Black;
            this.buttonTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonTask.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonTask.ForeColor = System.Drawing.Color.White;
            this.buttonTask.Image = null;
            this.buttonTask.ImageSize = new System.Drawing.Size(20, 20);
            this.buttonTask.Location = new System.Drawing.Point(0, 0);
            this.buttonTask.Name = "buttonTask";
            this.buttonTask.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.buttonTask.OnHoverBorderColor = System.Drawing.Color.Black;
            this.buttonTask.OnHoverForeColor = System.Drawing.Color.White;
            this.buttonTask.OnHoverImage = null;
            this.buttonTask.OnPressedColor = System.Drawing.Color.Black;
            this.buttonTask.Size = new System.Drawing.Size(357, 89);
            this.buttonTask.TabIndex = 5;
            this.buttonTask.Text = "gunaButton1";
            this.buttonTask.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.buttonTask.Visible = false;
            this.buttonTask.Click += new System.EventHandler(this.buttonTask_Click);
            // 
            // task
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaGradientPanel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "task";
            this.Size = new System.Drawing.Size(357, 89);
            this.gunaGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGradientPanel gunaGradientPanel1;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        public Guna.UI.WinForms.GunaLabel taskName;
        public Guna.UI.WinForms.GunaComboBox assigned;
        public Guna.UI.WinForms.GunaLabel Remarks;
        public Guna.UI.WinForms.GunaLabel remarkss;
        public Guna.UI.WinForms.GunaLabel gunaLabel2;
        public Guna.UI.WinForms.GunaButton buttonTask;
    }
}
