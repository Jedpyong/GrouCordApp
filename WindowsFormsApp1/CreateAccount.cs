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
using System.Net.Mail;
using System.Net;

namespace WindowsFormsApp1
{
    public partial class CreateAccount : Form
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

        public static string email;
        public static string password;
        public static string name;
        public static string randomCode;

        public CreateAccount()
        {
            InitializeComponent();
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Password_Click(object sender, EventArgs e)
        {

        }


        private void usernameTxtbx_Click(object sender, EventArgs e)
        {

        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            string con = "server=127.0.0.1;uid=root;pwd=July072004;database=groucord;";
            MySqlConnection connection = new MySqlConnection(con);

            email = EmailTxtbx.Text;
            password = PasswordTxtbx.Text;
            name = usernameTxtbx.Text;

          

            string queryemail = "SELECT * FROM account WHERE email = @email";
            string queryusername = "SELECT * FROM account WHERE username = @username";
            this.createAccountButton.Cursor = Cursors.WaitCursor;
            try
            {
                connection.Open();
                MySqlCommand cmd1 = new MySqlCommand(queryemail, connection);
                MySqlCommand cmd2 = new MySqlCommand(queryusername, connection);
                cmd1.Parameters.AddWithValue("@email", email);
                cmd2.Parameters.AddWithValue("@username", name);
                MySqlDataAdapter adapter1 = new MySqlDataAdapter(cmd1);
                MySqlDataAdapter adapter2 = new MySqlDataAdapter(cmd2);
                DataTable dt1 = new DataTable();
                DataTable dt2 = new DataTable();
                adapter1.Fill(dt1);
                adapter2.Fill(dt2);

                if(dt1.Rows.Count >= 1)
                {
                    MessageBox.Show("Email Address already used");
                    EmailTxtbx.Text = "";
                }
                if(dt2.Rows.Count >= 1)
                {
                    MessageBox.Show("Username already taken");
                    usernameTxtbx.Text = "";
                }
                if(confirmTxtbx.Text != PasswordTxtbx.Text)
                {
                    MessageBox.Show("Passwords doesn't match");
                    PasswordTxtbx.Text = "";
                    confirmTxtbx.Text = "";
                }
               
                else if(dt1.Rows.Count < 1 && dt2.Rows.Count < 1 && confirmTxtbx.Text == PasswordTxtbx.Text ) 
                {
                    string from, pass, messageBody;
                    Random rand = new Random();
                    randomCode = (rand.Next(999999)).ToString();

                  
                    from = "jadejaballa3@gmail.com";
                    pass = "qugfcsimdnlurvbm";

                    SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                    smtp.EnableSsl = true;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Credentials = new NetworkCredential(from, pass);

                    MailMessage message = new MailMessage();

                    messageBody = "Your OTP code is " + randomCode;
                    message.To.Add(email);
                    message.From = new MailAddress(from);
                    message.Body = messageBody;
                    message.Subject = "Email Confirmation Code";

                    try
                    {
                        smtp.Send(message);
                        
                        MessageBox.Show("code sent succesfully");
                        ConfirmEmail ce = new ConfirmEmail();
                        
                        ce.Show();
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }

                  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                this.createAccountButton.Cursor = Cursors.Default;
                connection.Close();
            }

      

        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EmailTxtbx_Click(object sender, EventArgs e)
        {

        }

      
        private void back_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }
    }
}
