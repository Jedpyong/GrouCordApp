using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using WindowsFormsApp1.Classes;

namespace WindowsFormsApp1
{
    public partial class UpdatePassword : Form
    {
       
        string email = ForgotPassword.to;

        public UpdatePassword()
        {
            InitializeComponent();
        }

        private void UpdatePassword_Load(object sender, EventArgs e)
        {

        }


        private void savebutton_Click(object sender, EventArgs e)
        {
            if (newpasstxtbx.Text == "" || confirmtxtbx.Text == "")
            {
                MessageBox.Show("Please input a password!");
            }

           /* bool letter1 = newpasstxtbx.Text.All(Char.IsLetter);
            bool letter2 = confirmtxtbx.Text.All(Char.IsLetter);

            if (!letter1 || !letter2 )
            {
                MessageBox.Show("Please Use Characters as Password");
                newpasstxtbx.Text = confirmtxtbx.Text = "";
            }*/

            if(currpass.Visible)
            {
                string eMail = LoginForm.account.email;
                if (newpasstxtbx.Text == confirmtxtbx.Text && newpasstxtbx.Text != "" && confirmtxtbx.Text != "" && currpass.Text == LoginForm.account.password)
                {
                    string con = "server=127.0.0.1;uid=root;pwd=July072004;database=groucord;";
                    MySqlConnection connection = new MySqlConnection(con);

                    string query = "UPDATE `groucord`.`account` SET `password` = '" + confirmtxtbx.Text + "' WHERE(email ='" + eMail + "')";
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Password Updated Successfully");

                  /*  GroupHandler handler = new GroupHandler();
                    List<Group> groups = handler.GetGroupByLeader(LoginForm.account.email);
                    foreach (Group g in groups)
                    {
                        groupz groupo = new groupz();
                        groupo.groupButton.Text = g.group_name;
                        groupo.GroupPic.Image = g.groupImageObj;
                        groupo.group = g;
                        LoginForm.hp.FLPPnl.Controls.Add(groupo);
                    }*/
                    DBManager manage = new DBManager();
                    LoginForm.account = manage.readAccountByEmail(LoginForm.account.email);

                    LoginForm.account.password = confirmtxtbx.Text;
                    LoginForm.hp.profileButton.Image = LoginForm.account.accountProfile;
                    LoginForm.hp.statuspic.Image = manage.getStatusPic(LoginForm.account.status.ToString());
                    LoginForm.hp.setStat.Text = LoginForm.account.status.ToString();
                    LoginForm.hp.Show();
                    this.Hide();
                   

                }
                else if (newpasstxtbx.Text != confirmtxtbx.Text || LoginForm.account.password != currpass.Text)
                {
                    MessageBox.Show("Mismatching Passwords!");
                }

            }
            else if(!currpass.Visible)
            {
                if (newpasstxtbx.Text == confirmtxtbx.Text && newpasstxtbx.Text != "" && confirmtxtbx.Text != "")
                {
                    string con = "server=127.0.0.1;uid=root;pwd=July072004;database=groucord;";
                    MySqlConnection connection = new MySqlConnection(con);

                    string query = "UPDATE `groucord`.`account` SET `password` = '" + confirmtxtbx.Text + "' WHERE(email ='" + email + "')";
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Password Updated Successfully");


                    DBManager manage = new DBManager();
                    LoginForm.account = manage.readAccountByEmail(LoginForm.account.email);

                   // LoginForm.account.password = confirmtxtbx.Text;
                    LoginForm.hp.profileButton.Image = LoginForm.account.accountProfile;
                    LoginForm.hp.statuspic.Image = manage.getStatusPic(LoginForm.account.status.ToString());
                    LoginForm.hp.setStat.Text = LoginForm.account.status.ToString();
                    LoginForm.hp.Show();

                    this.Hide();
                    this.Close();
                    connection.Close();

                }
                else if (newpasstxtbx.Text != confirmtxtbx.Text)
                {
                    MessageBox.Show("Mismatching Passwords!");
                }
            }
           
           
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaLabel3_Click(object sender, EventArgs e)
        {

        }
    }
}
