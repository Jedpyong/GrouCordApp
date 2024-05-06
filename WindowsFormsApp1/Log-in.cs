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
using Microsoft.VisualBasic.Devices;


namespace WindowsFormsApp1
{
    public partial class LoginForm : Form
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

        public static HomePage hp;

        public static Account account = new Account();
        DBManager manager = new DBManager();
        public LoginForm()
        {
            InitializeComponent();
            
            hp = new HomePage();
            this.DoubleBuffered = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

      

        private void forgotpass_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword fp = new ForgotPassword();
            this.Hide();
            fp.Show();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }


        private void loginButton_Click_1(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

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
                    account = manager.readAccountByEmail(usernameTextBox.Text);
                    account.email = usernameTextBox.Text;
                    account.password = passwordTextBox.Text;

                   

                    hp = new HomePage();

                    hp.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                Cursor.Current = Cursors.Default;
                connection.Close();
            }
        }

        private void gunaGradientPanel1_Click(object sender, EventArgs e)
        {

        }

        private void createAcc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateAccount ca = new CreateAccount();
            this.Hide();
            ca.Show();
        }
    }
}
