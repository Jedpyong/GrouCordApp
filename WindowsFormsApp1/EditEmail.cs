using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Classes;

namespace WindowsFormsApp1
{
    public partial class EditEmail : UserControl
    {

        string randomCode;
     
        public static string to;
        public EditEmail()
        {
            InitializeComponent();
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

                if (dataTable.Rows.Count < 1)
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

                    messageBody = "Your OTP code is " + randomCode;
                    message.To.Add(to);
                    message.From = new MailAddress(from);
                    message.Body = messageBody;
                    message.Subject = "EMAIL UPDATE CODE";

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
                    MessageBox.Show("Email Address Already Exist");
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

        private void confirmbutn_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (randomCode == (OTPTxtbx.Text).ToString())

            {
                to = EmailTxtbx.Text;
                try
                {
                    DBManager manager = new DBManager();
                    manager.updateEmail(LoginForm.account.email, to);

                    MessageBox.Show("Email Updated Successfully!");

                    LoginForm.account.email = to;

                }
                catch(Exception ex)
                {
                    MessageBox.Show($"Error: { ex.Message }");
                }

             
                HomePage hp = new HomePage();
                LoginForm.hp = hp;
                LoginForm.hp.Refresh();
                LoginForm.hp.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Incorrect OTP code");
            }
            Cursor.Current = Cursors.Default;
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
