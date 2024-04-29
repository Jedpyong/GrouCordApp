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
    public partial class groupz : UserControl
    {
        public Group group;
        public GroupPage grop = new GroupPage();
        public groupz()
        {
            InitializeComponent();
        }

        private void DeleteGroup_Click(object sender, EventArgs e)
        {
           GroupHandler handler = new GroupHandler();
            LoginForm.hp.FLPPnl.Controls.Remove(this);
            handler.removeGroup(group.group_ID);

        }



        private void gunaPanel1_Click(object sender, EventArgs e)
        {

            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }



        private void GroupPic_Click_2(object sender, EventArgs e)
        {
       
        }



        public void groupButton_Click(object sender, EventArgs e)
        {

            //LoginForm.hp.Controls.Clear();
            //grop.group = group;
            grop.FLPGroupPage.Controls.Clear();
            GroupHandler handler = new GroupHandler();
            List<Account> members = handler.getMembers(group);
            foreach(Account mem in members)
            {
                Members panel = new Members();
                panel.memberName.Text = mem.username;
                panel.emailLabel.Text = mem.email;
                panel.status.Text = mem.status.ToString();
                panel.Role.Text = "MEMBER";
                panel.memberPic.Image = mem.accountProfile;
                panel.page = grop;
                panel.memberID = handler.getMemberID_BYEmail(mem.email, group.group_ID);
                panel.name = mem.username;
                panel.group = this.group;
                grop.FLPGroupPage.Controls.Add(panel);
                
            }
           
            grop.group = this.group;
            LoginForm.hp.MainPnl.Controls.Add(grop);
            grop.FLPGroupPage.BringToFront();
            grop.FLPGroupPage.Show();
            grop.Show();
            grop.BringToFront();



        }

        private void DeleteGroup_MouseEnter(object sender, EventArgs e)
        {
            DeleteGroup.BackColor = Color.FromKnownColor(KnownColor.OrangeRed);
        }

        private void DeleteGroup_MouseLeave(object sender, EventArgs e)
        {
            DeleteGroup.BackColor = Color.Red;
        }

        private void groupz_Load(object sender, EventArgs e)
        {
            //kuha nalang sa database
        }

        private void DeleteGroup_MouseEnter_1(object sender, EventArgs e)
        {
            DeleteGroup.ImageSize = new Size(40, 40);
        }

        private void DeleteGroup_MouseLeave_1(object sender, EventArgs e)
        {
            DeleteGroup.ImageSize = new Size(30, 30);
        }
    }
}
