using Guna.UI.WinForms;
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
    public partial class Members : UserControl
    {
        public Group group;
        public GroupPage page;
        public int memberID;
        public string name;
        public Members()
        {
            InitializeComponent();
        }

        private void Member_Click(object sender, EventArgs e)
        {

        }

        private void Assign_Click(object sender, EventArgs e)
        {

        }



        private void remove_MouseEnter(object sender, EventArgs e)
        {
            gunaLabel1.Text = "REMOVE";
            for (int i = 0; i < 11; i++)
            {
                int x = removeBtn.Location.X - 5;
                removeBtn.Location = new Point(x, removeBtn.Location.Y);
            }
            for (int i = 0; i < 11; i++)
            {
                removeBtn.Width += 5;
            }
        }

        private void remove_MouseLeave(object sender, EventArgs e)
        {
            gunaLabel1.Text = "";
            for (int i = 0; i < 11; i++)
            {
                int x = removeBtn.Location.X + 5;
                removeBtn.Location = new Point(x, removeBtn.Location.Y);
            }
            for (int i = 0; i < 11; i++)
            {
                removeBtn.Width -= 5;
            }
        }

        private void gunaGradientPanel1_Resize(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

       



        private void removeBtn_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void removeBtn_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void Assign_MouseEnter_1(object sender, EventArgs e)
        {
            DBManager manage = new DBManager();
            string email = manage.emailQuerythroughID(memberID);
            Classes.CurrStatus status = manage.checkStatus(email);
            if(status.Equals(Classes.CurrStatus.AVAILABLE))
            {
                gunaLabel3.Text = "ASSIGN";
                for (int i = 0; i < 11; i++)
                {
                    int x = assignBtn.Location.X - 5;
                    assignBtn.Location = new Point(x, assignBtn.Location.Y);
                }
                for (int i = 0; i < 11; i++)
                {
                    assignBtn.Width += 5;
                }
            }
            else if (status.Equals(Classes.CurrStatus.ON_LEAVE))
            {
                gunaLabel3.Text = "ON_LEAVE";
                for (int i = 0; i < 11; i++)
                {
                    int x = assignBtn.Location.X - 7;
                    assignBtn.Location = new Point(x, assignBtn.Location.Y);
                }
                
                for (int i = 0; i < 11; i++)
                {
                    assignBtn.Width += 7;
                }
                gunaLabel3.Location = new Point(3, 6);
            }
            else if(status.Equals(Classes.CurrStatus.BUSY))
            {
                gunaLabel3.Text = "BUSY";
                for (int i = 0; i < 11; i++)
                {
                    int x = assignBtn.Location.X - 5;
                    assignBtn.Location = new Point(x, assignBtn.Location.Y);
                }
                gunaLabel3.Location = new Point(-45,6);
                for (int i = 0; i < 11; i++)
                {
                    assignBtn.Width += 5;
                }
            }
               

        }

        private void Assign_MouseLeave_1(object sender, EventArgs e)
        {
            gunaLabel3.Text = "";
            for (int i = 0; i < 11; i++)
            {
                int x = assignBtn.Location.X + 5;
               assignBtn.Location = new Point(x, assignBtn.Location.Y);
            }
            assignBtn.Location = new Point (316,assignBtn.Location.Y);
            for (int i = 0; i < 11; i++)
            {
                assignBtn.Width -= 5;
            }
            assignBtn.Width = 35;
        }

        private void status_Click(object sender, EventArgs e)
        {

        }

        private void status_MouseEnter(object sender, EventArgs e)
        {

        }

        private void Assign_Click_1(object sender, EventArgs e)
        {
            DBManager manage = new DBManager();
            string email = manage.emailQuerythroughID(memberID);
            Classes.CurrStatus status = manage.checkStatus(email);

            if (status.Equals(Classes.CurrStatus.AVAILABLE))
            {
                AssignTask ass = new AssignTask();
                page.outpnl.Controls.Add(ass);
                page.outpnl.BringToFront();
                ass.page = page;
                ass.memberID = this.memberID;
                ass.name = this.name;
                ass.BringToFront();
                page.Show();
                page.outpnl.Show();
                page.FLPGroupPage.Hide();
            }
            else if (status.Equals(Classes.CurrStatus.ON_LEAVE))
            {
                string from, pass, messageBody;
                Taskc task = manage.retrieveTaskbyID(memberID);


                from = "jadejaballa3@gmail.com";
                pass = "qugfcsimdnlurvbm";

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.EnableSsl = true;
                //smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, pass);

                MailMessage message = new MailMessage();

                messageBody = "\tGood day! kindly connect with the leader of this group as soon as you are available so that we can start on our group project. \n Your cooperation will be greatly appreciated.Thank you." ;
                message.To.Add(email);
                message.From = new MailAddress(from);
                message.Body = messageBody;
                message.Subject = "NOTICE FOR TASK ASSIGNMENT FROM " + this.group.group_name;

                try
                {
                    smtp.Send(message);
                    MessageBox.Show("NOTICE OF ASSIGNMENT SENT!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
            else
                MessageBox.Show("Be patient, your friend might lose focus.");
           


        }

        private void assignBtn_Click(object sender, EventArgs e)
        {
           
        }

        private void gunaGradientPanel1_Click(object sender, EventArgs e)
        {

        }
    }
}
