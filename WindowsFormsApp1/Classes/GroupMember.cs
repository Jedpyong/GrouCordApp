using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
    internal class GroupMember
    {
        public Account profile { get; set; }
        public  CurrStatus status { get; set; }

        public GroupMember(Account profile)
        {

            this.profile = profile;
            this.status = CurrStatus.AVAILABLE;
        }


    }
}
