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
    public partial class NotifAnnouncement : UserControl
    {
        public GroupPage page = new GroupPage();
        public NotifAnnouncement()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            page.FLPGroupPage.BringToFront();
            page.FLPGroupPage.Show();
            this.Hide();
        }

        private void Announcement_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
