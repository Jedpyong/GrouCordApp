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

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle = cp.ExStyle | 0x2000000;
                return cp;
            }
        }

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
            Cursor.Current = Cursors.WaitCursor;
            if (randomCode == (OTPTxtbx.Text).ToString())
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
            Cursor.Current = Cursors.Default;
        }


        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void sendotpbutn_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
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
                        this.confirmbutn.Visible = true;
                        this.gunaAdvenceButton1.Visible = false;
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
                Cursor.Current = Cursors.Default;
                connection.Close();
            }

           
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
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
