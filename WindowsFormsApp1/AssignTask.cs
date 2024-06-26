﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace WindowsFormsApp1
{
    public partial class AssignTask : UserControl
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle = cp.ExStyle | 0x2000000;
                return cp;
            }
        }

        public GroupPage page;
        public int memberID;
        public string name;
        public bool flag = true;
        public AssignTask()
        {
            InitializeComponent();
        }

        public void back_Click(object sender, EventArgs e)
        {
            page.FLPGroupPage.Show();
            this.Hide();
        }

        private void newtask_Click(object sender, EventArgs e)
        {
            NewTask task = new NewTask();
            task.groupID = page.group.group_ID;
            task.memberID = this.memberID;
            task.memName = this.name;
            task.page = this.page;
            page.outpnl.Controls.Add(task);
            task.BringToFront();
            page.Show();

        }

        private void gunaGradientPanel2_Click(object sender, EventArgs e)
        {

        }

        private void existingtask_Click(object sender, EventArgs e)
        {
            DBManager manage = new DBManager();
            List<Taskc> Tasks = manage.getTasks(this.page.group.group_ID);

            if (Tasks.Count > 0)
            {
                foreach (Taskc Task in Tasks)
                {
                    task panel = new task();
                    panel.memberID = this.memberID;
                    panel.page = this.page;
                    panel.isAssign = true;

                    panel.buttonTask.Text = Task.taskname;
                    panel.buttonTask.BringToFront();
                    panel.buttonTask.Visible = true;


                    this.ExistingFLP.Controls.Add(panel);
                }

                this.ExistingFLP.BringToFront();
                this.ExistingFLP.Show();
            }
            else
                MessageBox.Show("Currently no Tasks Exists");

       
        }

        private void back_MouseEnter(object sender, EventArgs e)
        {
            back.ImageSize = new Size(35, 35);
        }

        private void back_MouseLeave(object sender, EventArgs e)
        {
            back.ImageSize = new Size(30, 30);
        }
    }
}
