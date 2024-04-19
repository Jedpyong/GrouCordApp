using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg.OpenPgp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WindowsFormsApp1.Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WindowsFormsApp1
{
    public partial class CreateGroupUC : UserControl
    {

       public static List<Account> accs = new List<Account>();
       
           
        public CreateGroupUC()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void CreateGroupBtn_Click(object sender, EventArgs e)
        {
            if (GroupTxtBx.Text == "Group Name")
                MessageBox.Show("Please input a Group Name");
            if (initMembFlow.Controls.Count == 0)
                MessageBox.Show("Please add some members");

          if(GroupTxtBx.Text != "Group Name" && initMembFlow.Controls.Count > 0 )
            {
                GroupHandler handler = new GroupHandler();



                string path;
                //if empty ang pic
                if (pictureBox1.ImageLocation == null)
                {
                    pictureBox1.Image = Image.FromFile(@"C:\Users\USER\Downloads\icons8-group-50.png");
                    pictureBox1.ImageLocation = @"C:\Users\USER\Downloads\icons8-group-50.png";
                    path = pictureBox1.ImageLocation.ToString();
                }
                path = pictureBox1.ImageLocation.ToString();
                groupz group = new groupz();
                group.groupButton.Text = GroupTxtBx.Text;
                group.GroupPic.Image = pictureBox1.Image;
                string Name = group.groupButton.Text;
                Account acc = LoginForm.account;

                //if wala sa database ang member
                //if daghan members

                handler.InsertGroup(path, Name, acc, accs);

                //remove all from accs if ma create na ang group

                //ug mag error dili mupadayun anhi

                LoginForm.hp.addToFPL(group);
                
                this.Hide();
                accs.Clear();
            }




        }


        private void CancelGroup_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void GroupTxtBx_Click(object sender, EventArgs e)
        {

        }

        private void GroupTxtBxOn_Enter(object sender, EventArgs e)
        {
            if(GroupTxtBx.Text == "Group Name")
             GroupTxtBx.Text = "";
        }

        private void GroupTxtBx_Leave(object sender, EventArgs e)
        {
            if(GroupTxtBx.Text == "")
                GroupTxtBx.Text = "Group Name";
        }

        private void memberTxtBx_Enter(object sender, EventArgs e)
        {
            if(memberTxtBx.Text == "Email Address")
             memberTxtBx.Text = "";
        }

        private void memberTxtBx_Leave(object sender, EventArgs e)
        {
            if(memberTxtBx.Text == "")
                memberTxtBx.Text = "Email Address";
        }

        private void memberTxtBx_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gunaCircleButton1_Click(object sender, EventArgs e)
        {
            if (memberTxtBx.Text == "Email Address" || memberTxtBx.Text == "")
            {
                MessageBox.Show("Input a member");
            }
            else
            {
                try
                {
                    bool flag = false, exist = false;

                    DBManager manage = new DBManager();
                    exist = manage.DBSearchAccount(memberTxtBx.Text);
                    Account account = new Account();
                    if (exist)
                    {
                        account = manage.readAccountByEmail(memberTxtBx.Text);
                        foreach (Account check in accs)
                        {
                            flag = check.Equals(account);
                            if (flag == true)
                            {
                                MessageBox.Show("Account already added");
                                break;
                            }

                        }
                        if(account.Equals(LoginForm.account))
                        {
                            MessageBox.Show("You are already a leader of the group");
                            flag = true;
                        }
                        if (flag == false)
                        {
                            accs.Add(account);

                            InitialMembers Mem = new InitialMembers();
                            Mem.initialMemberBtn.Text = memberTxtBx.Text;

                            initMembFlow.Controls.Add(Mem);

                            memberTxtBx.Text = "";
                        }
                        
                    }
                    else if (!exist)
                    {
                        MessageBox.Show("Account Doesn't Exist");
                        flag = true;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }

            }



        }

        private void initMembFlow_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFile.FileName;
            }
        }
    }
}
