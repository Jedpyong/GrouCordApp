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
    public partial class Profile : UserControl
    {
        //public HomePage hp = new HomePage();
        public DBManager manager = new DBManager();
       

        public Profile()
        {
            InitializeComponent();
        }

        private void statlabel_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gunaCircleButton1_Click(object sender, EventArgs e)
        {
            EditEmail ee = new EditEmail();
            //ee.hp = hp;
            this.gunaGradientPanel2.Controls.Add(ee);
            ee.BringToFront();
            ee.Show();
            
        }

        private void ProfilePic_Click(object sender, EventArgs e)
        {
            userpanel.Visible = false;
            statuspnl.Visible = false;
            userpanel.Visible = false;


            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                ProfilePic.ImageLocation = openFile.FileName;
            }

            string path;
            //if empty ang pic
            if (ProfilePic.ImageLocation == null)
            {
               ProfilePic.Image = Image.FromFile(@"C:\Users\USER\Desktop\GrouCord\WindowsFormsApp1\WindowsFormsApp1\Resources\user (1).png");
                ProfilePic.ImageLocation = @"C:\Users\USER\Desktop\GrouCord\WindowsFormsApp1\WindowsFormsApp1\Resources\user (1).png";
                path = ProfilePic.ImageLocation.ToString();
            }
            path = ProfilePic.ImageLocation.ToString();
            ProfilePic.Image = Image.FromFile(path);
            manager.updateProfilePic(path, LoginForm.account.email);
           

        }

        private void gunaTileButton1_Click(object sender, EventArgs e)
        {

        }


        private void gunaGradiantButton3_Click(object sender, EventArgs e)
        {

        }

        private void AVbtn_Click(object sender, EventArgs e)
        {
            STATUS.Text = "AVAILABLE";
            manager.updateStatus(STATUS.Text, LoginForm.account.email);
            statuspnl.Visible = false;
           
        }

        private void gunaCircleButton3_Click(object sender, EventArgs e)
        {
            statuspnl.BringToFront();
            statuspnl.Visible = true;
            numpanel.Visible = false;
            userpanel.Visible = false;

        }

        private void gunaGradientPanel2_Click(object sender, EventArgs e)
        {
            statuspnl.Visible = false;
            numpanel.Visible = false;
            userpanel.Visible = false;

            gunaCircleButton2.Visible = true;
            gunaCircleButton4.Visible = true;
        }

        private void busybtn_Click(object sender, EventArgs e)
        {
            STATUS.Text = "BUSY";
            manager.updateStatus(STATUS.Text, LoginForm.account.email);
            statuspnl.Visible=false;
            
        }

        private void onleavebtn_Click(object sender, EventArgs e)
        {

            STATUS.Text = "ON_LEAVE";
            manager.updateStatus(STATUS.Text, LoginForm.account.email);
            statuspnl.Visible = false;
           
        }

        private void groupLabel_Click(object sender, EventArgs e)
        {

        }

        private void Profile_Load(object sender, EventArgs e)
        {
            Account account = new Account();
            
        }

        private void gunaCircleButton4_Click(object sender, EventArgs e)
        {
            userpanel.BringToFront();
            userpanel.Visible = true;
            statuspnl.Visible = false;
            numpanel.Visible = false; 
            gunaCircleButton2.Visible = true;
            gunaCircleButton4.Visible = false;
        }

        private void STATUS_Click(object sender, EventArgs e)
        {

        }

        private void gunaCircleButton2_Click(object sender, EventArgs e)
        {
            numpanel.BringToFront();
            numpanel.Visible = true;
            statuspnl.Visible = false;
            userpanel.Visible = false;
            gunaCircleButton2.Visible = false;
            gunaCircleButton4.Visible = true;


        }

        private void confirm_Click(object sender, EventArgs e)
        {
            NUMBER.Text = numtxtbx.Text;
            manager.updateNumber(LoginForm.account.contactNumber, NUMBER.Text);
            numpanel.Visible = false;
            gunaCircleButton2.Visible = true;


        }

        private void numpanel_Leave(object sender, EventArgs e)
        {
            numpanel.Visible = false;
            gunaCircleButton2.Visible = true;

        }

        private void statuspnl_Leave(object sender, EventArgs e)
        {
            statuspnl.Visible = false;
        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            LoginForm.hp.BringToFront();
            LoginForm.hp.Show();
            this.Hide();
            statuspnl.Visible=false;
            numpanel.Visible=false;
        }

        private void Profile_Click(object sender, EventArgs e)
        {
       

        }

        private void confirm_MouseEnter(object sender, EventArgs e)
        {
            confirm.ImageSize = new Size(30, 30);
        }

        private void confirm_MouseLeave(object sender, EventArgs e)
        {
            confirm.ImageSize = new Size(25,25);
        }

        private void confirmUsername_Click(object sender, EventArgs e)
        {
            USERNAME.Text = usernametxtbx.Text;
            manager.updateUsername(USERNAME.Text, LoginForm.account.email);
            userpanel.Visible = false;
            gunaCircleButton4.Visible = true;

        }

        private void assignBtn_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();

            Form parentForm = FindForm();
            if (parentForm != null)
            {
                parentForm.Close();
            }

          
        }
    }
}
