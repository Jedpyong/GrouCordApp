using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class HomePage : Form
    {
        //List<groupz> groupzs = CreateGroup.groups;
        public static DBManager manage = new DBManager();

        public HomePage()
        {
            InitializeComponent();  
            this.DoubleBuffered = true;
            
            
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void accName_Click(object sender, EventArgs e)
        {
          

        }

        private void gunaShadowPanel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void gunaComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
  
        }
        

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void gunaCircleButton1_Click(object sender, EventArgs e)
        {

        }

       

    

        private void HomePage_Load(object sender, EventArgs e)
        {

            GroupHandler handler = new GroupHandler();
            List<Group> groups = handler.GetGroupByLeader(LoginForm.account.email);
            foreach(Group g in groups)
            {
                groupz groupo = new groupz();
                groupo.groupButton.Text = g.group_name;
                groupo.GroupPic.Image = g.groupImageObj;
                groupo.group = g;
                FLPPnl.Controls.Add(groupo);
            }
           
            LoginForm.account = manage.readAccountByEmail(LoginForm.account.email);
            this.profileButton.Image = LoginForm.account.accountProfile;
            this.statuspic.Image = manage.getStatusPic(LoginForm.account.status.ToString());
            this.setStat.Text = LoginForm.account.status.ToString();
            statuspnl.Visible = false;
            this.Refresh();
            
         
            
           
        }

        public void addToFPL(groupz group)
        {
            FLPPnl.Controls.Add(group);
            
        }

       

        private void DemoPnl_Click(object sender, EventArgs e)
        {

        }



        private void searchTxtBx_Click(object sender, EventArgs e)
        {

        }

        private void searchTxtBx_Enter_1(object sender, EventArgs e)
        {
            statuspnl.Visible = false;
            if (searchTxtBx.Text == "Search")
                searchTxtBx.Text = "";
        }

        private void searchTxtBx_Leave_1(object sender, EventArgs e)
        {
            if (searchTxtBx.Text == "")
                searchTxtBx.Text = "Search";
        }

 


        private void close_Click_1(object sender, EventArgs e)
        {
            statuspnl.Visible = false;
            this.Close();
        }

        private void AddGroupBtn_Click(object sender, EventArgs e)
        {
            CreateGroupUC createGroup = new CreateGroupUC();

            CombPnl.Controls.Add(createGroup);
            createGroup.BringToFront();
            createGroup.Show();
            statuspnl.Visible = false;
            //this.Close();
        }

        /*private void gunaComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string stat = gunaComboBox1.GetItemText(gunaComboBox1.SelectedItem.ToString());

           
            LoginForm.account.status = manage.GetStatusFromString(stat);
            manage.updateStatus(stat, LoginForm.account.email.ToString());
            
            this.statuspic.Image = manage.getStatusPic(LoginForm.account.status.ToString());

            this.Refresh();

        }*/

        private void MainPnl_Click(object sender, EventArgs e)
        {
            statuspnl.Visible = false;
        }


        private void gunaCircleButton2_Click_1(object sender, EventArgs e)
        {
            statuspnl.Visible = false;
        }

       

        private void profileButton_Click_1(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            this.MainPnl.Controls.Add(profile);
            //profile.hp = this;
            profile.BringToFront();

            profile.Show();
            statuspnl.Visible = false;
            //this.Controls.Clear();
        }

        private void statuspic_Click(object sender, EventArgs e)
        {
            statuspnl.Visible = false;
        }

        private void setStat_Click(object sender, EventArgs e)
        {
            if (LoginForm.hp.statuspnl.Visible == true)
            {
               /* for (int i = 0; i < 12; i++)
                {
                    LoginForm.hp.statuspnl.Height -= 10;
                }*/
                LoginForm.hp.statuspnl.Visible = false; 

            }
            else
            LoginForm.hp.statuspnl.Visible = true;
           /* for (int i = 0; i < 12; i++)
            {
                LoginForm.hp.statuspnl.Height += 10;
            }*/


        }

        private void busybtn_Click(object sender, EventArgs e)
        {
            setStat.Text = "BUSY";
            manage.updateStatus(setStat.Text, LoginForm.account.email);
            LoginForm.account = manage.readAccountByEmail(LoginForm.account.email);
            LoginForm.hp.profileButton.Image = LoginForm.account.accountProfile;
            LoginForm.hp.statuspic.Image = manage.getStatusPic(LoginForm.account.status.ToString());

           /* for (int i = 0; i < 6; i++)
            {
                LoginForm.hp.statuspnl.Height -= 20;
            }*/
            
            statuspnl.Visible = false;
        }

        private void AVbtn_Click(object sender, EventArgs e)
        {
            setStat.Text = "AVAILABLE";
            manage.updateStatus(setStat.Text, LoginForm.account.email);
            LoginForm.account = manage.readAccountByEmail(LoginForm.account.email);
            LoginForm.hp.profileButton.Image = LoginForm.account.accountProfile;
            LoginForm.hp.statuspic.Image = manage.getStatusPic(LoginForm.account.status.ToString());

            /*for (int i = 0; i < 6; i++)
            {
                LoginForm.hp.statuspnl.Height -= 20;
            }*/
            statuspnl.Visible = false;
        }

        private void onleavebtn_Click(object sender, EventArgs e)
        {
            setStat.Text = "ON_LEAVE";
            manage.updateStatus(setStat.Text, LoginForm.account.email);
            LoginForm.account = manage.readAccountByEmail(LoginForm.account.email);
            LoginForm.hp.profileButton.Image = LoginForm.account.accountProfile;
            LoginForm.hp.statuspic.Image = manage.getStatusPic(LoginForm.account.status.ToString());

            /*for (int i = 0; i < 6; i++)
            {
                LoginForm.hp.statuspnl.Height -= 20;
            }*/
            statuspnl.Visible = false;
        }

        private void DemoPnl_Click_1(object sender, EventArgs e)
        {
            statuspnl.Visible = false;
        }

        private void accName_Click_1(object sender, EventArgs e)
        {
            statuspnl.Visible = false;
        }

        private void groupLabel_Click(object sender, EventArgs e)
        {
            statuspnl.Visible = false;
        }
    }
}
