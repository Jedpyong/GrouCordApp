using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Classes;

namespace WindowsFormsApp1
{
    public partial class HomePage : Form
    {
        //List<groupz> groupzs = CreateGroup.groups;
       
        public HomePage()
        {
            InitializeComponent();  

            
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void accName_Click(object sender, EventArgs e)
        {
          

        }

        private void gunaShadowPanel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void gunaComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        /*private void addGroup(Group group)
        {
            Panel panel = new Panel();
            panel.Name = string.Format("PnlGroup{0}", group.group_ID);
            panel.Size = new Size(445, 70);
            panel.BackColor = Color.White;
            panel.Margin = new Padding(10);
            panel.Tag = group.group_ID;

            PictureBox picBox;
            picBox = new PictureBox();
            picBox.Name = String.Format("PbGroupImage{0}", group.group_ID);
            picBox.Size = new Size(69, 70);
            picBox.Location = new Point(12, 10);
            picBox.SizeMode = PictureBoxSizeMode.AutoSize;

            

            picBox.Tag = group.group_ID;

            Label labelTitle;
            labelTitle = new Label();
            labelTitle.Name = String
        }*/

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void gunaCircleButton1_Click(object sender, EventArgs e)
        {

        }

        private void AddGroupBtn_Click(object sender, EventArgs e)
        {
            CreateGroupUC createGroup = new CreateGroupUC();
           
            CombPnl.Controls.Add(createGroup);
            createGroup.BringToFront();
            createGroup.Show();

            
        }

        

    

        private void HomePage_Load(object sender, EventArgs e)
        {
            /*if(groupzs != null) 
            {
                foreach (groupz group in groupzs)
                {
                    FLPPnl.Controls.Add(group);
                }
            }*/

         
            
           
        }

        public void addToFPL(groupz group)
        {
            FLPPnl.Controls.Add(group);
            
        }

      
    }
}
