using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Members : UserControl
    {

        public GroupPage page;
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

        private void Assign_MouseLeave_1(object sender, EventArgs e)
        {
            gunaLabel3.Text = "";
            for (int i = 0; i < 11; i++)
            {
                int x = assignBtn.Location.X + 5;
               assignBtn.Location = new Point(x, assignBtn.Location.Y);
            }
            for (int i = 0; i < 11; i++)
            {
                assignBtn.Width -= 5;
            }
        }

        private void status_Click(object sender, EventArgs e)
        {

        }

        private void status_MouseEnter(object sender, EventArgs e)
        {

        }

        private void Assign_Click_1(object sender, EventArgs e)
        {
            AssignTask ass = new AssignTask();
            
            page.outpnl.Controls.Add(ass);
            page.outpnl.BringToFront();
            ass.page = page;
            ass.BringToFront();
            page.Show();
            page.outpnl.Show();
            page.FLPGroupPage.Hide();


        }

        private void assignBtn_Click(object sender, EventArgs e)
        {
           
        }
    }
}
