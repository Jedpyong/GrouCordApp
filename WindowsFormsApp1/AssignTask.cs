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
    public partial class AssignTask : UserControl
    {
        public GroupPage page;
        public AssignTask()
        {
            InitializeComponent();
        }

        public void back_Click(object sender, EventArgs e)
        {
            page.FLPGroupPage.Show();
            this.Hide();
        }

        private void newtask_Click(object sender, EventArgs e)
        {
            NewTask task = new NewTask();
            page.outpnl.Controls.Add(task);
            task.BringToFront();
            page.Show();
            // this.Hide();
            //this.SendToBack();
        }
    }
}
