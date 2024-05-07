using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Classes;

namespace WindowsFormsApp1
{
    public partial class Tasks : UserControl
    {
        public int groupID;
        public GroupPage page;
       // public bool isAssign = false;
        public Tasks()
        {
            InitializeComponent();
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void TaskFlowchart_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Tasks_Load(object sender, EventArgs e)
        {
            DBManager manage = new DBManager();
            List<Taskc> tasks = manage.getTasks(groupID);

            foreach(Taskc Task in tasks)
            {
                task panel = new task();
                panel.taskName.Text = Task.taskname;
                panel.remarkss.Text = Task.remarks;
                //caution
               // panel.isAssign = this.isAssign;

                foreach (string ass in Task.assigned)
                {
                    panel.assigned.Items.Add(ass);
                }

                this.TaskFlowchart.Controls.Add(panel);
            }

            this.BringToFront();
            this.Show();


        }

        private void back_Click(object sender, EventArgs e)
        {
           
            page.FLPGroupPage.BringToFront();
            page.FLPGroupPage.Show();
            this.SendToBack();
            this.Hide();
        }

        private void Tasks_Leave(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
