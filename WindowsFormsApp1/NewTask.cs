﻿using System;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WindowsFormsApp1
{
    public partial class NewTask : UserControl
    {
        public GroupPage page;
        public int groupID;
        public int memberID;
        public string memName;
        public NewTask()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            
            this.Hide();
        }

        private void assignBtn_Click(object sender, EventArgs e)
        {
            if (taskNametxtbx.Text != "" && fileLinktxtbx.Text != "" && descriptiontxtbx.Text != "")
            {
                //insertion
                string name = taskNametxtbx.Text;
                string description = descriptiontxtbx.Text;
                string link = fileLinktxtbx.Text;
                DBManager manage = new DBManager();
                manage.insertTask(memberID, description, name, link);


                //email or message
                string email = manage.emailQuerythroughID(memberID);
                string from, pass, messageBody;
                //Taskc task = manage.retrieveTaskbyID(memberID);


                from = "jadejaballa3@gmail.com";
                pass = "qugfcsimdnlurvbm";

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.EnableSsl = true;
                //smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, pass);

                MailMessage message = new MailMessage();

                messageBody = "Good day! This is " + page.group.group_name + " You are assigned to the following task:\n\nTask: " + name + "\n\nDescription: " + description + "\n\nFile link to work with: " + link;
                message.To.Add(email);
                message.From = new MailAddress(from);
                message.Body = messageBody;
                message.Subject = "TASK ASSIGNMENT FROM " + page.group.group_name;

                try
                {
                    smtp.Send(message);
                    MessageBox.Show("ASSIGNMENT SENT!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }




                //diplaying
                Tasks tasks = new Tasks();
                tasks.page = page;
                this.page.outpnl.Controls.Add(tasks);

                try
                {

                    List<Taskc> Tasks = manage.getTasks(groupID);

                    foreach (Taskc Task in Tasks)
                    {
                        task panel = new task();
                        panel.taskName.Text = Task.taskname;
                        panel.remarkss.Text = Task.remarks;

                        foreach (string ass in Task.assigned)
                        {
                            panel.assigned.Items.Add(ass);
                        }


                        tasks.TaskFlowchart.Controls.Add(panel);
                    }

                    tasks.BringToFront();
                    tasks.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message);
                }

                this.Hide();
            }
            else
                MessageBox.Show("You Lack Information to Assign");

           
        }

        private void gunaGradientPanel2_Click(object sender, EventArgs e)
        {

        }
    }
}
