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

namespace WindowsFormsApp1
{
    public partial class Schedules : UserControl
    {
        public int groupID ;
        public Schedules()
        {
            InitializeComponent();
            
        }

        private void addDB_Click(object sender, EventArgs e)
        {
            DBManager manager = new DBManager();
            DateTime date = dateTimePicker1.Value;
            manager.InsertDate(40, description.Text, date);
        }



        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Schedules_Load(object sender, EventArgs e)
        {
            DBManager manage = new DBManager();
           
            try
            {
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
    }
}