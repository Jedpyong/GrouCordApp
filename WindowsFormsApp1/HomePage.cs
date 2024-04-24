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

namespace WindowsFormsApp1
{
    public partial class HomePage : Form
    {
        //List<groupz> groupzs = CreateGroup.groups;
       
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
            DBManager manager = new DBManager();
            
         
            
           
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
            if(searchTxtBx.Text == "Search")
                searchTxtBx.Text = "";
        }

        private void searchTxtBx_Leave_1(object sender, EventArgs e)
        {
            if (searchTxtBx.Text == "")
                searchTxtBx.Text = "Search";
        }

 


        private void close_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddGroupBtn_Click(object sender, EventArgs e)
        {
            CreateGroupUC createGroup = new CreateGroupUC();

            CombPnl.Controls.Add(createGroup);
            createGroup.BringToFront();
            createGroup.Show();
            //this.Close();
        }

        private void gunaComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string stat = gunaComboBox1.GetItemText(gunaComboBox1.SelectedItem.ToString());

            DBManager manage = new DBManager();
            LoginForm.account.status = manage.GetStatusFromString(stat);
            manage.updateStatus(stat, LoginForm.account);

        }

        private void MainPnl_Click(object sender, EventArgs e)
        {

        }

        private void searchTxtBx_Click_1(object sender, EventArgs e)
        {

        }

        private void gunaCircleButton2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
