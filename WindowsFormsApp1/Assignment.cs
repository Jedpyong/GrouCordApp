using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Classes;

namespace WindowsFormsApp1
{
    public partial class Assignment : UserControl
    {
        public Taskc thisTask;
        public Assignment()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Assignment_Load(object sender, EventArgs e)
        {
           
            descriptiontxtbx.Text = "\n Task:\t" + thisTask.taskname + "\n File Link: " + thisTask.link + "\n\n Description:\n\t" + thisTask.description + "\n\nDeadline of Submission:\t" + ((DateTime)thisTask.dueDate).ToString("D");
        }

        private void gunaGradientPanel2_Click(object sender, EventArgs e)
        {

        }

        private void back_MouseEnter(object sender, EventArgs e)
        {
            back.ImageSize = new Size(35, 35);
        }

        private void back_MouseLeave(object sender, EventArgs e)
        {
            back.ImageSize = new Size(30, 30);
        }
    }
}
