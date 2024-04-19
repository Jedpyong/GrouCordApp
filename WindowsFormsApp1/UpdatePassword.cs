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

            bool letter1 = newpasstxtbx.Text.All(Char.IsLetter);
            bool letter2 = confirmtxtbx.Text.All(Char.IsLetter);

            if (!letter1 || !letter2 )
            {
                MessageBox.Show("Please Use Characters as Password");
                newpasstxtbx.Text = confirmtxtbx.Text = "";
            }

            if (newpasstxtbx.Text == confirmtxtbx.Text && newpasstxtbx.Text != "" && confirmtxtbx.Text != "")
            {
                string con = "server=127.0.0.1;uid=root;pwd=July072004;database=groucord;";
                MySqlConnection connection = new MySqlConnection(con);

                string query = "UPDATE `groucord`.`account` SET `password` = '"+confirmtxtbx.Text+"' WHERE(email ='"+email+"')";
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Password Updated Successfully");

                LoginForm.account.password = confirmtxtbx.Text;

                HomePage hp = new HomePage();
                this.Hide();
                hp.Show();
                connection.Close();
                
            }
            else if(newpasstxtbx.Text != confirmtxtbx.Text)
            {
                MessageBox.Show("Mismatching Passwords!");
            }
        }
    }
}
