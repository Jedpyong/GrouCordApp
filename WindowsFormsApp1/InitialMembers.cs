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
    public partial class InitialMembers : UserControl
    {
        public CreateGroupUC panel = null;
        public Account acc;
        public AddMember Apanel = null;
        public InitialMembers()
        {
            InitializeComponent();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if(Apanel == null)
            {
                panel.initMembFlow.Controls.Remove(this);
                panel.accs.Remove(acc);

            }
            else if(panel == null)
            {
                Apanel.AddMemFLP.Controls.Remove(this);
                Apanel.accs.Remove(acc);
            }
            
   
        }

        private void initialMemberBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
