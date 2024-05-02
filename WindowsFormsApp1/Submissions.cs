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
    public partial class Submissions : UserControl
    {
        public GroupPage page;
        public Taskc assignedTask;
        public Taskc subTask;
        public List<Taskc> subtasks;
        public bool isMember = false;

        public Submissions()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            if(assignedTask.dueDate > DateTime.Now)
            {
                Submission resubmit = new Submission();
                resubmit.thisTask = assignedTask;
                resubmit.isResubmit = true;
                page.outpnl.Controls.Add(resubmit);
                resubmit.BringToFront();
                page.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Task deadline was on " + assignedTask.dueDate.ToString("f") + "\nCannot be edited.");
            }
           
        }

        private void Submissions_Load(object sender, EventArgs e)
        {
            if (isMember)
            {
                descriptiontxtbx.Text = "\nDate Submitted: " + subTask.dueDate + "\nFile Link: " + subTask.link + "\n" + subTask.description;
            }
            else if (!isMember)
            {
                int i = 0;
                foreach (Taskc task in subtasks)
                {
                    i++;
                    descriptiontxtbx.Text += "\n"+i.ToString()+"\tDate Submitted: " + task.dueDate + "\nFile Link: " + task.link + "\n" + task.description+"\n";
                }
            }
        }

       
    }
}
