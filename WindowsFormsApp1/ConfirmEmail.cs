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
using WindowsFormsApp1.Classes;

namespace WindowsFormsApp1
{
    public partial class ConfirmEmail : Form
    {


        string email = CreateAccount.email;
        string password = CreateAccount.password;
        string name = CreateAccount.name;
        string code = CreateAccount.randomCode;
        DBManager manager = new DBManager();

    public ConfirmEmail()
        {
            InitializeComponent();
        }

        private void confirmbutn_Click(object sender, EventArgs e)
        {
            if (code == (OTPTxtbx.Text).ToString())
            {
                string con = "server=127.0.0.1;uid=root;pwd=July072004;database=groucord;";
                MySqlConnection connection = new MySqlConnection(con);

                string query1 = "insert into account(email,password,username,contactNumber) values('"+email+"','"+password+"','"+name+"','N/A')";
               // string query2 = "INSERT INTO profile SET username = '" + name + "',idAccount = (SELECT idAccount FROM account WHERE email = '" + email + "')";
                connection.Open();
                MySqlCommand cmd1 = new MySqlCommand(query1, connection);
                cmd1.ExecuteNonQuery();
                //cmd1 = new MySqlCommand(query2, connection);
                //cmd1.ExecuteNonQuery();
                MessageBox.Show("Account Created Successfully");
                connection.Close();


                //sheeehshhsshs wapani ma sud sa database diay

                LoginForm.account = new Account();
                LoginForm.account.email = email;
                LoginForm.account.password = password;
                LoginForm.account.username = name;
                
                string path = @"C:\Users\USER\Desktop\GrouCord\WindowsFormsApp1\WindowsFormsApp1\Resources\user (1).png";
                manager.updateProfilePic(path, LoginForm.account.email);
                
                LoginForm.account.status = Classes.CurrStatus.AVAILABLE;
                manager.updateStatus(LoginForm.account.status.ToString(), LoginForm.account.email);

                LoginForm.hp.Show();

                connection.Close();
                this.Close();

            }
            else
            {
                MessageBox.Show("Incorrect OTP code");
            }

        }

        private void ConfirmEmail_Load(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
