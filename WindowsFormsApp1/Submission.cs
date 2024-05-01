using Microsoft.VisualBasic;
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
using System.Xml.Linq;
using WindowsFormsApp1.Classes;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Submission : UserControl
    {
        public task panel;
        public Taskc thisTask;
        public bool isResubmit = false;
        public Submission()
        {
            InitializeComponent();
        }



       





        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(fileLinktxtbx.Text.Trim()))
            {

                if (string.IsNullOrEmpty(descriptiontxtbx.Text.Trim()))
                {
                    descriptiontxtbx.Text = " ";
                }

                DBManager manager = new DBManager();
                if(isResubmit)
                {
                    manager.updateTaskSubmitted(fileLinktxtbx.Text, descriptiontxtbx.Text, DateTime.Now, thisTask.taskID);
                    this.Hide();
                }
                else
                {
                    manager.insertTaskSubmitted(fileLinktxtbx.Text, descriptiontxtbx.Text, DateTime.Now, thisTask.taskID);
                    manager.updateTaskRemarks(thisTask.taskID);
                    panel.Remarks.Visible = true;
                    thisTask.remarks = "SUBMITTED";
                    panel.remarkss.Text = "SUBMITTED";
                    panel.submit.Visible = false;
                    this.Hide();
                }

               

            }
            else
            {
                MessageBox.Show("Please input a link to your file!");
            }
           
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
