using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using MySql.Data.MySqlClient;
using WindowsFormsApp1.Classes;


namespace WindowsFormsApp1
{

    public partial class ForgotPassword : Form
    {
       
        string randomCode;
        public static string to;

        public ForgotPassword()
        {
            InitializeComponent();
        }

  

        private void ForgotPassword_Load(object sender, EventArgs e)
        {

        }

   

        private void nextbutton_Click(object sender, EventArgs e)
        {
            if(randomCode == (OTPTxtbx.Text).ToString())
            {
                to = EmailTxtbx.Text;
                LoginForm.account.email = to;
                UpdatePassword up = new UpdatePassword();
                
                up.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("Incorrect OTP code");
            }
        }


        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void sendotpbutn_Click(object sender, EventArgs e)
        {
            string con = "server=127.0.0.1;uid=root;pwd=July072004;database=groucord;";
            MySqlConnection connection = new MySqlConnection(con);

            string email = EmailTxtbx.Text;
           

            string query = "SELECT * FROM account WHERE email = @email";

            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@email", email);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                if (dataTable.Rows.Count == 1)
                {
                    string from, pass, messageBody;
                    Random rand = new Random();
                    randomCode = (rand.Next(999999)).ToString();

                    to = email;
                    from = "jadejaballa3@gmail.com";
                    pass = "qugfcsimdnlurvbm";

                    SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                    smtp.EnableSsl = true;
                    //smtp.Port = 587;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Credentials = new NetworkCredential(from, pass);

                    MailMessage message = new MailMessage();

                    messageBody = "Your reset code is " + randomCode;
                    message.To.Add(to);
                    message.From = new MailAddress(from);
                    message.Body = messageBody;
                    message.Subject = "Password Update Code";

                    try
                    {
                        smtp.Send(message);
                        MessageBox.Show("code sent succesfully");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }
                }
                else
                {
                    MessageBox.Show("Account Doesn't Exist");
                    EmailTxtbx.Text = "";
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

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
