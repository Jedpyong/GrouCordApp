using MySqlX.XDevAPI;
using Org.BouncyCastle.Asn1.Anssi;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class GroupPage : UserControl
    {
        

        public Group group;
        public NotifAnnouncement notif ;
        public bool isMember;
        public GroupPage()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            
        }

        private void GroupPage_Load(object sender, EventArgs e)
        {
            if(isMember)
            {
                Announcements.Visible = false;
                addMember.Visible = false;
            }
            this.groupPic.Image = this.group.groupImageObj;
            this.groupName.Text = this.group.group_name;



        }

        private void FLPGroupPage_Paint(object sender, PaintEventArgs e)
        {

        }



        


        private void gunaImageButton1_MouseEnter(object sender, EventArgs e)
        {
            gunaImageButton1.ImageSize = new Size(36, 36);
            
        }

        private void gunaImageButton1_MouseLeave(object sender, EventArgs e)
        {
            gunaImageButton1.ImageSize = new Size(30, 30);
        }


       

        private void gunaImageButton1_Paint(object sender, PaintEventArgs e)
        {

        }

      

        private void Schedules_Click(object sender, EventArgs e)
        {
          
            Schedules sched = new Schedules();
            sched.groupID = this.group.group_ID;
            sched.group = this.group;
            sched.isMember = this.isMember;
            sched.grop = this;
            outpnl.Controls.Add(sched);
            //sched.SendToBack();
            sched.BringToFront();
            
        }

        private void FLPGroupPage_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void outpnl_Click(object sender, EventArgs e)
        {

        }

        private void Tasks_Click(object sender, EventArgs e)
        {
         
            Tasks tasks = new Tasks();
            tasks.page = this;
            outpnl.Controls.Add(tasks);
            DBManager manage = new DBManager();

            if(isMember)
            {
                
                try
                {
                    GroupHandler handler = new GroupHandler();
                    int id = handler.getMemberID_BYEmail(LoginForm.account.email, group.group_ID);
                    List<Taskc> Tasks = manage.getMemberTasks(id);
                   
                    foreach (Taskc Task in Tasks)
                    {
                        task panel = new task();
                        panel.taskName.Text = Task.taskname;
                        panel.assigned.Visible = false;
                       
                        panel.gunaLabel2.Visible = false;
                        panel.open.Visible = true;
                        panel.remarkss.Text = Task.remarks;
                        panel.thisTask = Task;
                        panel.page = this;
                        panel.isMember = true;
                        if(Task.remarks == "ON-GOING")
                        {
                            panel.submit.Visible = true;
                            panel.Remarks.Visible = false;
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
            }
            else

            try
            {
               
               
                List<Taskc> Tasks = manage.getTasks(group.group_ID);

                foreach (Taskc Task in Tasks)
                {
                    task panel = new task();
                    panel.taskName.Text = Task.taskname;
                    panel.remarkss.Text = Task.remarks;
                    panel.thisTask = Task;
                    panel.page = this;

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
           
        }

        private void addMember_Click(object sender, EventArgs e)
        {
            //FLPGroupPage.Controls.Clear();
            //outpnl.Controls.Clear();
            AddMember add = new AddMember();
            add.grop = this;
            add.group = this.group;
            outpnl.Controls.Add(add);
            //FLPGroupPage.Controls.Add(outpnl);
            //outpnl.BringToFront();
            //outpnl.Show();
            add.BringToFront();
            add.Show();
        }

        private void Announcements_Click(object sender, EventArgs e)
        {
           
            Announcement anns = new Announcement();

            outpnl.Controls.Add(anns);
            anns.page = this;
            anns.group = this.group;

            DBManager manager = new DBManager();
           
            List<string> ahead = manager.getALLAnnouncementHeads(this.group.group_ID);

            foreach (string a in ahead)
            {
                anns.checkedListBox1.Items.Add(a);
            }

            anns.BringToFront();
            anns.Show();
        }


        private void upperPanel_Click(object sender, EventArgs e)
        {

        }

        private void Notif2_Click(object sender, EventArgs e)
        {

            DBManager manager = new DBManager();
            AnnouncementC ann = manager.getAnnouncement(group.group_ID);
            notif = new NotifAnnouncement();
            notif.page = this;
            notif.Announcement.Clear();

            if (ann.announcedDate.ToString() != "01/01/0001 12:00:00 am")
                    notif.Announcement.Text = "\n" + ann.announcementHead + "\n" + ann.announcedDate.ToString() + "\n\n" + ann.announcementBody;

            outpnl.Controls.Add(notif);
            notif.BringToFront();
            notif.Show();
        }

        private void Notif2_MouseEnter(object sender, EventArgs e)
        {
            Notif2.ImageSize = new Size(40, 40);
        }

        private void Notif2_MouseLeave(object sender, EventArgs e)
        {
            Notif2.ImageSize = new Size(36, 36);
        }

        private void gunaImageButton1_Click_1(object sender, EventArgs e)
        {
            //naunsa ko ani?
            /*
            outpnl.SendToBack();
            FLPGroupPage.BringToFront();
            FLPGroupPage.Show();
          */

            LoginForm.hp.ReloadHomeFLP();
            LoginForm.hp.BringToFront();
            LoginForm.hp.Show();
            this.Hide();
        }

        private void gunaGradientPanel1_Click(object sender, EventArgs e)
        {

        }
    }
}
