using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
    public class AnnouncementC

    {
        public int announcementID {  get; set; }
        public string announcementHead { get; set; }
        public string announcementBody { get; set; }
        public DateTime announcedDate { get; set; }
        public bool isLatest {  get; set; } 
        public int AGroup_ID {  get; set; }

        public AnnouncementC() { }

    }
}
