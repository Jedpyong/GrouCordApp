using MySqlX.XDevAPI;
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
    public partial class GroupPage : UserControl
    {
        

        public Group group;
        public GroupPage()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            
        }

        private void GroupPage_Load(object sender, EventArgs e)
        {
           
           
            /* this.DoubleBuffered = true;
             if (group.groupLeader == LoginForm.account.email)
             {
                 List<Account> members = group.members;
                 foreach(Account m in members)
                 {
                     Members member = new Members();
                     member.Role.Text = "MEMBER";
                     member.status.Text = m.status.ToString();
                     member.emailLabel.Text = m.email;
                     member.memberName.Text = m.username;
                     FLPGroupPage.Controls.Add(member);
                 }
             }

             Members member2 = new Members();
             FLPGroupPage.Controls.Add(member2);*/


        }

        private void FLPGroupPage_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            // LoginForm.hp.DemoPnl.Visible = true;
            //outpnl.Hide();
            //this.outpnl.Controls.Clear();
            outpnl.SendToBack();
            FLPGroupPage.Show();
            FLPGroupPage.BringToFront();
            LoginForm.hp.BringToFront();
            LoginForm.hp.Show();
            this.Hide();
        }


        private void gunaImageButton1_MouseEnter(object sender, EventArgs e)
        {
            gunaImageButton1.ImageSize = new Size(40, 40);
            
        }

        private void gunaImageButton1_MouseLeave(object sender, EventArgs e)
        {
            gunaImageButton1.ImageSize = new Size(35, 35);
        }

        private void gunaImageButton2_MouseEnter(object sender, EventArgs e)
        {
            gunaImageButton2.ImageSize = new Size(40, 40);
        }

        private void gunaImageButton2_MouseLeave(object sender, EventArgs e)
        {
            gunaImageButton2.ImageSize = new Size(35, 35);
        }

        private void gunaImageButton1_Paint(object sender, PaintEventArgs e)
        {

        }

      

        private void Schedules_Click(object sender, EventArgs e)
        {
           //outpnl.Controls.Clear();
            Schedules sched = new Schedules();
            sched.groupID = this.group.group_ID;
            outpnl.Controls.Add(sched);
            //sched.SendToBack();
            sched.BringToFront();
            
        }

        private void FLPGroupPage_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void outpnl_Click(object sender, EventArgs e)
        {

        }

        private void Tasks_Click(object sender, EventArgs e)
        {
            Tasks tasks = new Tasks();
            tasks.page = this;
            outpnl.Controls.Add(tasks);
            try
            {
                DBManager manage = new DBManager();
               
                List<Taskc> Tasks = manage.getTasks(group.group_ID);

                foreach (Taskc Task in Tasks)
                {
                    task panel = new task();
                    panel.taskName.Text = Task.taskname;
                    panel.remarkss.Text = Task.remarks;
                   
                    foreach(string ass in Task.assigned)
                    {
                        panel.assigned.Items.Add(ass);
                    }
                   

                    tasks.TaskFlowchart.Controls.Add(panel);
                }

                tasks.BringToFront();
                tasks.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
           
        }

        private void addMember_Click(object sender, EventArgs e)
        {
            AddMember add = new AddMember();
            add.grop = this;
            add.group = this.group;
            outpnl.Controls.Add(add);
            add.BringToFront();
            add.Show();
        }
    }
}
