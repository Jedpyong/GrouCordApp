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
    }
}
