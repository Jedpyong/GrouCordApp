using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
    public class Taskc
    {
        public int taskID {  get; set; }
        public string taskname { get; set; }
        public List<string> assigned {  get; set; }
        public string remarks {  get; set; }
        
        public string description { get; set; }
        public string link { get; set; }
        public DateTime dueDate { get; set; }  

        public Taskc()
        {
            assigned = new List<string>();
        }
    }
}
