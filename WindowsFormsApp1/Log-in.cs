using MySql.Data.MySqlClient;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Org.BouncyCastle.Asn1.Mozilla;
using WindowsFormsApp1.Classes;


namespace WindowsFormsApp1
{
    public partial class LoginForm : Form
    {
        public static HomePage hp;

        public static Account account = new Account();
        public LoginForm()
        {
            InitializeComponent();
            hp = new HomePage();
            this.DoubleBuffered = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void usernameTextBox_Enter(object sender, EventArgs e)
        {

        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void forgotpass_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword fp = new ForgotPassword();
            this.Hide();
            fp.Show();
        }



        
        

        private void gunaLinkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateAccount ca = new CreateAccount();
            this.Hide();
            ca.Show();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void usernameTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void loginButton_Click_1(object sender, EventArgs e)
        {
            string con = "server=127.0.0.1;uid=root;pwd=July072004;database=groucord;";
            MySqlConnection connection = new MySqlConnection(con);

            string email = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            string query = "SELECT * FROM account WHERE email = @email AND password = @password";

            try
            {
                connection.Open();


                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", password);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                if (dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("Invalid username or password!");
                    usernameTextBox.Text = email;
                    passwordTextBox.Text = "";
                }
                else if (dataTable.Rows.Count == 1)
                {

                    account.email = usernameTextBox.Text;
                    account.password = passwordTextBox.Text;

                    hp = new HomePage();

                    hp.Show();
                    //this.Close();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }

  
    }
}
