using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
    public class Account
    {
        public int accountID {  get; set; }
        public string email { get; set; }
        public string password {private get; set; }
        public string username { get; set; }
        public string contactNumber { get; set; }
        public byte[] accountImage { get; set; }
        public Image accountProfile { get; set; }

        public CurrStatus status { get; set; }
        public Account ()
        {
            
            this.email = string.Empty;
            this.password = string.Empty;
        }
        public Account ( string email, string password)
        {
           // this.accountID = accountID;
            this.email = email;
            this.password = password;
        }

        public override bool Equals(object obj)
        {
            if(!(obj is Account)) { return false; }
            if(obj is null) { return false; }

            Account a = obj as Account;
            return a.email == this.email;
        }
    }
}
