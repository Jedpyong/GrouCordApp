using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WindowsFormsApp1.Classes
{
    public class DBManager
    {
        private const string connect = "server=127.0.0.1;uid=root;pwd=July072004;database=groucord;";


        public bool DBSearchAccount(string email)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connect))
                {
                    connection.Open();
                    string query = "SELECT * FROM account WHERE email = @email";

                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@email", email);
                    
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable data = new DataTable();
                    adapter.Fill(data);

                    if (data.Rows.Count > 0)
                    {
                        return true;
                    }
                    else
                        return false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
            
         
        }



        public bool GroupSearch(string groupName)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connect))
                {
                    connection.Open();
                    string query = "SELECT * FROM group WHERE groupName = @name";

                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@name", groupName);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable data = new DataTable();
                    adapter.Fill(data);

                    if (data.Rows.Count > 0)
                    {
                        return true;
                    }
                    else
                        return false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }

        public Account readAccountByEmail(string email)
        {
            Account account = new Account();
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connect))
                {
                    connection.Open();
                    string query = "SELECT * FROM account WHERE email = @email"; ;

                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@email", email);

                    MySqlDataReader reader = cmd.ExecuteReader();
                   
                    account.email = email;
                    while (reader.Read())
                    {
                        account.accountID = Convert.ToInt32(reader["idAccount"]);
                        account.username = reader.GetString("username");
                        //account.contactNumber = reader.GetInt32("contactNumber");
                        account.password = reader.GetString("password");
                        string enumstatus = reader.GetString("status");
                        
                        try
                        {
                            account.status = (CurrStatus)Enum.Parse(typeof(CurrStatus), enumstatus);
                        }
                        catch (ArgumentException)
                        {
                           MessageBox.Show($"Invalid enum value: {enumstatus}");
                        }
                    }
                    

                }
                return account;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);       
            }
            return null;
           
        }
    }
}
