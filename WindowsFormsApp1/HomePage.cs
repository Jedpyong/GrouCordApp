using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle = cp.ExStyle | 0x2000000;
                return cp;
            }
        }

        public static DBManager manage = new DBManager();
        public List<groupz> allGroups = new List<groupz>();
        public HomePage()
        {
            InitializeComponent();  
            this.DoubleBuffered = true;
            
            
        }

        public void ReloadHomeFLP()
        {
            FLPPnl.Controls.Clear();

            try
            {


                GroupHandler handler = new GroupHandler();
                List<Group> groups = handler.GetGroupByLeader(LoginForm.account.email);
                foreach (Group g in groups)
                {
                    groupz groupo = new groupz();
                    groupo.groupButton.Text = g.group_name;
                    groupo.GroupPic.Image = g.groupImageObj;
                    groupo.group = g;
                   
                    FLPPnl.Controls.Add(groupo);
                }

                groups = handler.GetGroupByEmail(LoginForm.account.email);
                foreach (Group g in groups)
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
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }


        }





        private void HomePage_Load(object sender, EventArgs e)
        {
            try
            {
                

                GroupHandler handler = new GroupHandler();
                List<Group> groups = handler.GetGroupByLeader(LoginForm.account.email);
                foreach (Group g in groups)
                {
                    groupz groupo = new groupz();
                    groupo.groupButton.Text = g.group_name;
                    groupo.GroupPic.Image = g.groupImageObj;
                    groupo.group = g;
                    allGroups.Add(groupo);
                    FLPPnl.Controls.Add(groupo);
                }

                groups = handler.GetGroupByEmail(LoginForm.account.email);
                foreach(Group g in groups)
                {
                    groupz groupo = new groupz();
                    groupo.groupButton.Text = g.group_name;
                    groupo.GroupPic.Image = g.groupImageObj;
                    groupo.group = g;
                    allGroups.Add(groupo);
                    FLPPnl.Controls.Add(groupo);
                }


                LoginForm.account = manage.readAccountByEmail(LoginForm.account.email);


                this.profileButton.Image = LoginForm.account.accountProfile;
                this.statuspic.Image = manage.getStatusPic(LoginForm.account.status.ToString());
                this.setStat.Text = LoginForm.account.status.ToString();
                this.accName.Text = LoginForm.account.username;
                statuspnl.Visible = false;
                this.Refresh();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }    
           
        }

        public void addToFPL(groupz group)
        {
            FLPPnl.Controls.Add(group);
            
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
            
        }


        private void MainPnl_Click(object sender, EventArgs e)
        {
            statuspnl.Visible = false;
        }


        private void profileButton_Click_1(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Profile profile = new Profile();
            this.MainPnl.Controls.Add(profile);
            profile.BringToFront();
            profile.Show();
            statuspnl.Visible = false;
            Cursor.Current = Cursors.Default;
        }

        private void statuspic_Click(object sender, EventArgs e)
        {
            statuspnl.Visible = false;
        }

        private void setStat_Click(object sender, EventArgs e)
        {
            if (LoginForm.hp.statuspnl.Visible == true)
            {
             
                LoginForm.hp.statuspnl.Visible = false; 

            }
            else
            LoginForm.hp.statuspnl.Visible = true;
          
        }

        private void busybtn_Click(object sender, EventArgs e)
        {
            setStat.Text = "BUSY";
            manage.updateStatus(setStat.Text, LoginForm.account.email);
            LoginForm.account = manage.readAccountByEmail(LoginForm.account.email);
            LoginForm.hp.profileButton.Image = LoginForm.account.accountProfile;
            LoginForm.hp.statuspic.Image = manage.getStatusPic(LoginForm.account.status.ToString());

            statuspnl.Visible = false;
        }

        private void AVbtn_Click(object sender, EventArgs e)
        {
            setStat.Text = "AVAILABLE";
            manage.updateStatus(setStat.Text, LoginForm.account.email);
            LoginForm.account = manage.readAccountByEmail(LoginForm.account.email);
            LoginForm.hp.profileButton.Image = LoginForm.account.accountProfile;
            LoginForm.hp.statuspic.Image = manage.getStatusPic(LoginForm.account.status.ToString());

            statuspnl.Visible = false;
        }

        private void onleavebtn_Click(object sender, EventArgs e)
        {
            setStat.Text = "ON_LEAVE";
            manage.updateStatus(setStat.Text, LoginForm.account.email);
            LoginForm.account = manage.readAccountByEmail(LoginForm.account.email);
            LoginForm.hp.profileButton.Image = LoginForm.account.accountProfile;
            LoginForm.hp.statuspic.Image = manage.getStatusPic(LoginForm.account.status.ToString());

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

        private void searchTxtBx_Click_1(object sender, EventArgs e)
        {
            
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            statuspnl.Visible = false;

            string searchTerm = searchTxtBx.Text;

            List<groupz> searched = new List<groupz>();
            foreach (groupz g in allGroups)
            {
                if(g.groupButton.Text.ToUpper().Contains(searchTerm.ToUpper()))
                {
                    searched.Add(g);
                }
            }

            FLPPnl.Controls.Clear();

            foreach(groupz g in searched)
            {
                FLPPnl.Controls.Add(g);
            }


            Cursor.Current = Cursors.Default;


        }


      
    }
}
