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
using System.Xml.Linq;
using WindowsFormsApp1.Classes;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class task : UserControl
    {
        public bool isAssign=false;
        public int memberID;
        public GroupPage page;
        public task()
        {
            InitializeComponent();
           
        }

        private void Remarks_Click(object sender, EventArgs e)
        {
            if(remarkss.Text == "FINISHED")
            {
                remarkss.BackColor = Color.Green;
                remarkss.BringToFront();
                remarkss.Visible = true;
                Remarks.SendToBack();
            }
            else if(remarkss.Text =="ON-GOING")
            {
                remarkss.BackColor = Color.Red;
                remarkss.BringToFront();
                remarkss.Visible = true;
                Remarks.SendToBack();
            }
        }

        private void Remarks_Leave(object sender, EventArgs e)
        {
           
        }

        private void remarkss_MouseLeave(object sender, EventArgs e)
        {
            Remarks.BringToFront();
            remarkss.Visible = false;
        }

        private void Remarks_MouseEnter(object sender, EventArgs e)
        {
            Remarks.BackColor = Color.DarkBlue;
        }

        private void Remarks_MouseLeave(object sender, EventArgs e)
        {
            Remarks.BackColor = Color.Black;
        }

        private void gunaGradientPanel1_Click(object sender, EventArgs e)
        {

            
        }

        private void gunaGradientPanel1_MouseEnter(object sender, EventArgs e)
        {
            /*if(this.isAssign)
            {
                gunaGradientPanel1.GradiantColor4 = Color.Black;
            }*/
        }

        private void gunaGradientPanel1_MouseLeave(object sender, EventArgs e)
        {/*
            if(this.isAssign)
                gunaGradientPanel1.GradiantColor4 = Color.DodgerBlue;*/
        }

        private void taskName_Click(object sender, EventArgs e)
        {

        }

        private void buttonTask_Click(object sender, EventArgs e)
        {
            if (this.isAssign)
            {
                //insertion
                DBManager manage = new DBManager();
                Taskc task = manage.retrieveTask(buttonTask.Text);
                task.taskname = buttonTask.Text;
               // MessageBox.Show(task.taskname + task.description + task.remarks + memberID,task.link);

                manage.insertTask(memberID, task.description, task.taskname, task.link);

                //emailing

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

                messageBody = "\tGood day! This is " + page.group.group_name + " You are assigned to the following task:\n\nTask: " +task.taskname + "\n\nDescription: " + task.description + "\n\nFile link to work with: " + task.link;
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




                //displaying

                Tasks tasks = new Tasks();
                tasks.page = page;
                this.page.outpnl.Controls.Add(tasks);

                try
                {

                    List<Taskc> Tasks = manage.getTasks(page.group.group_ID);

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
        }
    }
}
