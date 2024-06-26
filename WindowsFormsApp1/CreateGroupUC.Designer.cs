﻿namespace WindowsFormsApp1
{
    partial class CreateGroupUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateGroupUC));
            this.GroupTxtBx = new Guna.UI.WinForms.GunaTextBox();
            this.memberTxtBx = new Guna.UI.WinForms.GunaTextBox();
            this.CreateGroupBtn = new Guna.UI.WinForms.GunaButton();
            this.CancelGroup = new Guna.UI.WinForms.GunaButton();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.initMembFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.add = new Guna.UI.WinForms.GunaCircleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupTxtBx
            // 
            this.GroupTxtBx.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.GroupTxtBx.BorderColor = System.Drawing.Color.Transparent;
            this.GroupTxtBx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.GroupTxtBx.FocusedBaseColor = System.Drawing.Color.MidnightBlue;
            this.GroupTxtBx.FocusedBorderColor = System.Drawing.Color.Black;
            this.GroupTxtBx.FocusedForeColor = System.Drawing.Color.WhiteSmoke;
            this.GroupTxtBx.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GroupTxtBx.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GroupTxtBx.Location = new System.Drawing.Point(32, 14);
            this.GroupTxtBx.Name = "GroupTxtBx";
            this.GroupTxtBx.PasswordChar = '\0';
            this.GroupTxtBx.Radius = 10;
            this.GroupTxtBx.Size = new System.Drawing.Size(242, 36);
            this.GroupTxtBx.TabIndex = 6;
            this.GroupTxtBx.Text = "Group Name";
            this.GroupTxtBx.Click += new System.EventHandler(this.GroupTxtBx_Click);
            this.GroupTxtBx.Enter += new System.EventHandler(this.GroupTxtBxOn_Enter);
            this.GroupTxtBx.Leave += new System.EventHandler(this.GroupTxtBx_Leave);
            // 
            // memberTxtBx
            // 
            this.memberTxtBx.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.memberTxtBx.BorderColor = System.Drawing.Color.Transparent;
            this.memberTxtBx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.memberTxtBx.FocusedBaseColor = System.Drawing.Color.MidnightBlue;
            this.memberTxtBx.FocusedBorderColor = System.Drawing.Color.Black;
            this.memberTxtBx.FocusedForeColor = System.Drawing.Color.WhiteSmoke;
            this.memberTxtBx.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.memberTxtBx.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.memberTxtBx.Location = new System.Drawing.Point(34, 86);
            this.memberTxtBx.Name = "memberTxtBx";
            this.memberTxtBx.PasswordChar = '\0';
            this.memberTxtBx.Radius = 10;
            this.memberTxtBx.Size = new System.Drawing.Size(208, 35);
            this.memberTxtBx.TabIndex = 7;
            this.memberTxtBx.Text = "Email Address";
            this.memberTxtBx.Click += new System.EventHandler(this.memberTxtBx_Click);
            this.memberTxtBx.Enter += new System.EventHandler(this.memberTxtBx_Enter);
            this.memberTxtBx.Leave += new System.EventHandler(this.memberTxtBx_Leave);
            // 
            // CreateGroupBtn
            // 
            this.CreateGroupBtn.AnimationHoverSpeed = 0.07F;
            this.CreateGroupBtn.AnimationSpeed = 0.03F;
            this.CreateGroupBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.CreateGroupBtn.BorderColor = System.Drawing.Color.Black;
            this.CreateGroupBtn.Font = new System.Drawing.Font("Segoe UI Variable Display", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateGroupBtn.ForeColor = System.Drawing.Color.White;
            this.CreateGroupBtn.Image = null;
            this.CreateGroupBtn.ImageSize = new System.Drawing.Size(23, 23);
            this.CreateGroupBtn.Location = new System.Drawing.Point(351, 180);
            this.CreateGroupBtn.Name = "CreateGroupBtn";
            this.CreateGroupBtn.OnHoverBaseColor = System.Drawing.Color.SlateBlue;
            this.CreateGroupBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.CreateGroupBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.CreateGroupBtn.OnHoverImage = null;
            this.CreateGroupBtn.OnPressedColor = System.Drawing.Color.Black;
            this.CreateGroupBtn.Radius = 15;
            this.CreateGroupBtn.Size = new System.Drawing.Size(85, 42);
            this.CreateGroupBtn.TabIndex = 8;
            this.CreateGroupBtn.Text = "Create Group";
            this.CreateGroupBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CreateGroupBtn.Click += new System.EventHandler(this.CreateGroupBtn_Click);
            // 
            // CancelGroup
            // 
            this.CancelGroup.AnimationHoverSpeed = 0.07F;
            this.CancelGroup.AnimationSpeed = 0.03F;
            this.CancelGroup.BaseColor = System.Drawing.Color.Maroon;
            this.CancelGroup.BorderColor = System.Drawing.Color.Black;
            this.CancelGroup.Font = new System.Drawing.Font("Segoe UI Variable Display", 8.25F, System.Drawing.FontStyle.Bold);
            this.CancelGroup.ForeColor = System.Drawing.Color.White;
            this.CancelGroup.Image = null;
            this.CancelGroup.ImageSize = new System.Drawing.Size(20, 20);
            this.CancelGroup.Location = new System.Drawing.Point(261, 181);
            this.CancelGroup.Name = "CancelGroup";
            this.CancelGroup.OnHoverBaseColor = System.Drawing.Color.OrangeRed;
            this.CancelGroup.OnHoverBorderColor = System.Drawing.Color.Black;
            this.CancelGroup.OnHoverForeColor = System.Drawing.Color.White;
            this.CancelGroup.OnHoverImage = null;
            this.CancelGroup.OnPressedColor = System.Drawing.Color.Black;
            this.CancelGroup.Radius = 15;
            this.CancelGroup.Size = new System.Drawing.Size(81, 42);
            this.CancelGroup.TabIndex = 9;
            this.CancelGroup.Text = "Cancel";
            this.CancelGroup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CancelGroup.Click += new System.EventHandler(this.CancelGroup_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(32, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Add Members:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(35, 130);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(196, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // initMembFlow
            // 
            this.initMembFlow.AutoScroll = true;
            this.initMembFlow.Location = new System.Drawing.Point(35, 132);
            this.initMembFlow.Name = "initMembFlow";
            this.initMembFlow.Size = new System.Drawing.Size(207, 96);
            this.initMembFlow.TabIndex = 12;
            this.initMembFlow.Paint += new System.Windows.Forms.PaintEventHandler(this.initMembFlow_Paint);
            // 
            // add
            // 
            this.add.AnimationHoverSpeed = 0.07F;
            this.add.AnimationSpeed = 0.03F;
            this.add.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.add.BorderColor = System.Drawing.Color.Black;
            this.add.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.add.ForeColor = System.Drawing.Color.White;
            this.add.Image = ((System.Drawing.Image)(resources.GetObject("add.Image")));
            this.add.ImageSize = new System.Drawing.Size(25, 25);
            this.add.Location = new System.Drawing.Point(253, 89);
            this.add.Name = "add";
            this.add.OnHoverBaseColor = System.Drawing.Color.SlateBlue;
            this.add.OnHoverBorderColor = System.Drawing.Color.Black;
            this.add.OnHoverForeColor = System.Drawing.Color.White;
            this.add.OnHoverImage = null;
            this.add.OnPressedColor = System.Drawing.Color.Black;
            this.add.Size = new System.Drawing.Size(29, 29);
            this.add.TabIndex = 10;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.capture;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(320, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // CreateGroupUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.initMembFlow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add);
            this.Controls.Add(this.CancelGroup);
            this.Controls.Add(this.CreateGroupBtn);
            this.Controls.Add(this.memberTxtBx);
            this.Controls.Add(this.GroupTxtBx);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "CreateGroupUC";
            this.Size = new System.Drawing.Size(448, 257);
            this.Load += new System.EventHandler(this.CreateGroupUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaTextBox GroupTxtBx;
        private Guna.UI.WinForms.GunaTextBox memberTxtBx;
        private Guna.UI.WinForms.GunaButton CreateGroupBtn;
        private Guna.UI.WinForms.GunaButton CancelGroup;
        private Guna.UI.WinForms.GunaCircleButton add;
        private System.Windows.Forms.Label label1;
       // private System.Windows.Forms.ComboBox membersbox;
        private System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.FlowLayoutPanel initMembFlow;
    }
}
