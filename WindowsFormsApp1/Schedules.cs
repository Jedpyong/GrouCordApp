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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    public partial class Schedules : UserControl
    {
        public int groupID ;
        public Classes.Group group;
        public bool isMember;
        public GroupPage grop;
        public Schedules()
        {
            InitializeComponent();
            
        }

        private void addDB_Click(object sender, EventArgs e)
        {
            DBManager manager = new DBManager();
            DateTime date = dateTimePicker1.Value;
            GroupHandler handler = new GroupHandler();
            int id = handler.getMemberID_BYEmail(LoginForm.account.email, group.group_ID);
            manager.InsertDate(id, description.Text, date);
            try
            {
                DataTable dt = manager.LoadMemberData(id);
                data.DataSource = dt;
                description.Text = "Description...";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }



        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Schedules_Load(object sender, EventArgs e)
        {
            DBManager manage = new DBManager();
            GroupHandler handler = new GroupHandler();
            int id = handler.getMemberID_BYEmail(LoginForm.account.email,group.group_ID);
            if(isMember)
            {
                try
                {
                    DataTable dt = manage.LoadMemberData(id);
                    data.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }


            }
            else
                 try
                 {
                    gunaGradientPanel2.Size = new Size(378, 5);
                        DataTable dt = manage.LoadData(groupID);
                        data.DataSource = dt;

                 }
                catch (Exception ex)
                 {
                         MessageBox.Show(ex.Message.ToString());
                 }
                
           

        }

        private void data_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 1) // Replace with your date column index
            {
                if (e.Value is DateTime)
                {
                    e.Value = ((DateTime)e.Value).ToString("M"); // Customize format as needed
                    e.FormattingApplied = true; // Mark formatting applied
                }
            }
        }

        private void description_Click(object sender, EventArgs e)
        {

        }

        private void description_TextChanged(object sender, EventArgs e)
        {

        }

        private void description_MouseEnter(object sender, EventArgs e)
        {
            if(description.Text == "Description..." )
            {
                description.Text = "";
            }
        }

        private void description_MouseLeave(object sender, EventArgs e)
        {
            if(description.Text == "" || description.Text == " ")
            {
                description.Text = "Description...";
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            grop.FLPGroupPage.BringToFront();
            grop.FLPGroupPage.Show();
            this.Hide();
        }
    }
}