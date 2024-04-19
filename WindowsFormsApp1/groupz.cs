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
    public partial class groupz : UserControl
    {
        public groupz()
        {
            InitializeComponent();
        }

        private void DeleteGroup_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();

        }

     

        private void gunaPanel1_Click(object sender, EventArgs e)
        {

            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }



        private void GroupPic_Click_2(object sender, EventArgs e)
        {
           LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }
    }
}
