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
    public partial class Announcement : UserControl
    {

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle = cp.ExStyle | 0x2000000;
                return cp;
            }
        }
        public GroupPage page { get; set; }
        public Group group { get; set; }

        public Announcement()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            page.FLPGroupPage.BringToFront();
            page.FLPGroupPage.Show();
            this.Hide();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PostButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (Atitle.Text != "Announcement Head" && Bodytxtbx.Text != "                             Text Body")
            {
                AnnouncementC announcement = new AnnouncementC();
                announcement.announcementBody = Bodytxtbx.Text;
                announcement.announcementHead = Atitle.Text;
                announcement.announcedDate = DateTime.Now;
                announcement.AGroup_ID = group.group_ID;


                checkedListBox1.Items.Add(Atitle.Text);

                DBManager manager = new DBManager();
                manager.insertUpdateAnnouncement(announcement.announcementHead, announcement.announcementBody, announcement.AGroup_ID, announcement.announcedDate);


                NotifAnnouncement notif = new NotifAnnouncement();
                notif.Announcement.Clear();
                notif.Announcement.Text = "\n" + announcement.announcementHead + "\n" + announcement.announcedDate.ToString() + "\n\n" + announcement.announcementBody;

                page.notif = notif;

                Atitle.Text = "";
                Bodytxtbx.Text = "";

            }
            else
                MessageBox.Show("Please enter some inputs");

            Cursor.Current = Cursors.Default;

        }

        private void gunaCircleButton1_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count > 0)
            {
                DBManager manager = new DBManager();

                for (int i = checkedListBox1.CheckedItems.Count - 1; i >= 0; i--)
                {
                    object item = checkedListBox1.CheckedItems[i];
                    manager.deleteAnnouncement(item.ToString(), group.group_ID);
                    checkedListBox1.Items.Remove(item);
                }
            }


        }

        private void Atitle_Click(object sender, EventArgs e)
        {

        }

        private void Atitle_MouseEnter(object sender, EventArgs e)
        {

        }

        private void Atitle_MouseLeave(object sender, EventArgs e)
        {

        }

        private void Bodytxtbx_Enter(object sender, EventArgs e)
        {
            if (Bodytxtbx.Text == "                             Text Body")
                Bodytxtbx.Text = "";
        }

        private void Bodytxtbx_Leave(object sender, EventArgs e)
        {
            if (Bodytxtbx.Text == "")
                Bodytxtbx.Text = "                             Text Body";
        }

        private void Atitle_Enter(object sender, EventArgs e)
        {
            if (Atitle.Text == "Announcement Head")
                Atitle.Text = "";
        }

        private void Atitle_Leave(object sender, EventArgs e)
        {
            if (Atitle.Text == "")
                Atitle.Text = "Announcement Head";
        }


        private void Repost_Click(object sender, EventArgs e)
        {
            DBManager manageer = new DBManager();
           if(checkedListBox1.CheckedItems.Count > 0)
            {
                Atitle.Text = checkedListBox1.CheckedItems[0].ToString();
                
                Bodytxtbx.Text = manageer.getAnnouncementBody(Atitle.Text, group.group_ID);

                for (int i = checkedListBox1.CheckedItems.Count - 1; i >= 0; i--)
                {
                    object item = checkedListBox1.CheckedItems[i];
                    checkedListBox1.Items.Remove(item);
                }
            }
           
        }

        private void Announcement_Load(object sender, EventArgs e)
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
