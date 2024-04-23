using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
    public class Group
    {
        public int group_ID { get; set; }
        public string group_name { get; set; } 

        public byte[] groupImage { get;  set; }
        public Image groupImageObj { get; set; }
        public string groupLeader {  get; set; }
        public List<Account> members { get;  set; }
        public Group() 
        {
            
            group_name = null;
            groupImage = null;
            groupLeader = null;
            members = new List<Account>();
        }
        public Group( string group_name, byte[] groupImage, string groupLeader)
        {
           
            this.group_name = group_name;
            this.groupImage = groupImage;
            this.groupLeader = groupLeader;
            this.members = new List<Account>();
        }
    }
}
