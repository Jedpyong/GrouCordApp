using System.Security.Principal;
using WindowsFormsApp1.Classes;

namespace GrouCordTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var account1 = new Account();
            account1.email = "jadejaballa@gmail.com";
           
            var account2 = new Account();
            account2.email = "jadejaballa@gmail.com";

            var result1 = account1.Equals(account2);

            Assert.True(result1);

        }
    }
}