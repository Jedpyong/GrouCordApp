using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class AddMember : UserControl
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

        public List<Account> accs = new List<Account>();
        public Group group;
        public GroupPage grop;
        public AddMember()
        {
            InitializeComponent();
            
        }


        private void AddButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            
            if (AddMemFLP.Controls.Count == 0)
                MessageBox.Show("Please add some members");

            else if(AddMemFLP.Controls.Count >0)
            {
                GroupHandler handler = new GroupHandler();
                foreach (Account a in accs)
                {
                    handler.insertMember(group.group_ID, a.email);
                }
                grop.FLPGroupPage.Controls.Clear(); 

                List<Account> members = handler.getMembers(group);
                foreach (Account mem in members)
                {
                    Members panel = new Members(false);
                    panel.memberName.Text = mem.username;
                    panel.emailLabel.Text = mem.email;
                    panel.status.Text = mem.status.ToString();
                    panel.Role.Text = "MEMBER";
                    panel.memberPic.Image = mem.accountProfile;
                    panel.page = grop;
                    panel.memberID = handler.getMemberID_BYEmail(mem.email, group.group_ID);
                    panel.name = mem.username;
                    panel.group = this.group;
                    grop.FLPGroupPage.Controls.Add(panel);

                }

                grop.group = this.group;
                LoginForm.hp.MainPnl.Controls.Add(grop);
                grop.FLPGroupPage.BringToFront();
                grop.Show();
                grop.BringToFront();


                Cursor.Current = Cursors.Default;
            }
        }

        private void mainPanel_Click(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
           
            grop.FLPGroupPage.BringToFront();
            grop.FLPGroupPage.Show();
            this.Hide();
        }

        private void back_MouseEnter(object sender, EventArgs e)
        {
            back.ImageSize = new Size(35, 35);
        }

        private void back_MouseLeave(object sender, EventArgs e)
        {
            back.ImageSize = new Size(30, 30);
        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                bool flag = false, exist = false;

                DBManager manage = new DBManager();

                exist = manage.DBSearchAccount(EmailTxtbx.Text);
                GroupHandler handler = new GroupHandler();
                List<Account> members = handler.getMembers(group);



                Account account = new Account();
                if (exist)
                {
                    account = manage.readAccountByEmail(EmailTxtbx.Text);
                    foreach (Account check in accs)
                    {
                        flag = check.Equals(account);
                        if (flag == true)
                        {
                            MessageBox.Show("Account already added");
                            break;
                        }

                    }
                    foreach (Account check in members)
                    {
                        flag = check.Equals(account);
                        if (flag == true)
                        {
                            MessageBox.Show("Account already added");
                            break;
                        }
                    }
                    if (account.Equals(LoginForm.account))
                    {
                        MessageBox.Show("You are already a leader of the group");
                        flag = true;
                    }
                    if (flag == false)
                    {

                        accs.Add(account);

                        InitialMembers Mem = new InitialMembers();
                        Mem.initialMemberBtn.Text = account.username;
                        Mem.acc = account;
                        Mem.Apanel = this;

                        AddMemFLP.Controls.Add(Mem);

                        EmailTxtbx.Text = "";
                    }

                }
                else if (!exist)
                {
                    MessageBox.Show("Account Doesn't Exist");
                    flag = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }
    }
}
