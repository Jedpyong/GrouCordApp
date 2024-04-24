using Guna.UI.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
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

        public CurrStatus GetStatusFromString(string statusString)
        {
            switch (statusString.ToUpper()) 
            {
                case "BUSY":
                    return CurrStatus.BUSY;
                case "AVAILABLE":
                    return CurrStatus.AVAILABLE;
                case "ON_LEAVE":
                    return CurrStatus.ON_LEAVE;
                default:
                    throw new ArgumentException("Invalid status string: " + statusString);
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
                        account.status = this.GetStatusFromString(enumstatus);
                        
                       /* try
                        {
                            account.status = (CurrStatus)Enum.Parse(typeof(CurrStatus), enumstatus);
                        }
                        catch (ArgumentException)
                        {
                           MessageBox.Show($"Invalid enum value: {enumstatus}");
                        }*/
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

        public void updateStatus(string status, Account acc)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connect))
                {
                    connection.Open();
                    string query = "UPDATE `groucord`.`account` SET `status` = @status WHERE (`email` = @email);";
                    
                    string email = acc.email.ToString();
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.Parameters.AddWithValue("@email", email);

                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                
            }
        }
        public CurrStatus checkStatus(string email)
        {
            CurrStatus status = new CurrStatus();
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connect))
                {
                    connection.Open();
                    string query = "SELECT * FROM `account` WHERE `email` = @email;";
                    
                    
                    MySqlCommand cmd = new MySqlCommand(query, connection);
               
                    cmd.Parameters.AddWithValue("@email", email);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        string stat = reader.GetString("status");
                       
                        status = this.GetStatusFromString(stat);

                    }
                }

                   
               

                connection.Close();
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: mao ni?? " + ex.Message);
                
            }
            return status;
        }
        public string getUsername(string email)
        {
            string username = "";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connect))
                {
                    connection.Open();
                    string query = "SELECT `username` FROM account WHERE email = @email";

                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@email", email);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                         username = reader.GetString("username");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
               
            }

            return username;
        }







        public void InsertDate(int groupMemberID, string description, DateTime date)
        {
            
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connect))
                {
                    connection.Open();
                    

                    string query = "INSERT INTO `groucord`.`busysched` (`date`, `groupMemberID`,`description`) VALUES (@date, @id, @des);";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@date",date);
                    command.Parameters.AddWithValue("@id", groupMemberID);
                    command.Parameters.AddWithValue("@des", description);
                    command.ExecuteNonQuery();

                    MessageBox.Show("date added successfullly");

                    connection.Close();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            
        }





        public DataTable GetTableData(string sqlQuery)
        {
            DataTable dataTable = new DataTable();
            MySqlConnection connection = new MySqlConnection(connect);

            try
            {
                connection.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(sqlQuery, connection);
                adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                // Handle connection errors or exceptions here
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dataTable;
        }




        public DataTable LoadData(int desiredGroupID)
        {
            string sql = @"
             SELECT `account`.`username` AS `NAME`, `busysched`.`date` AS `DATE`, `busysched`.`description` AS `DESCRIPTION`
                FROM `busysched`
                INNER JOIN `groupmember` ON `busysched`.`groupMemberID` = `groupmember`.`groupMemberID`
                INNER JOIN `account`  ON `groupmember`.`groupMemberEmail` = `account`.`email`
                WHERE `groupmember`.`group_ID` = @groupID";

            using (MySqlConnection conn = new MySqlConnection(connect))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@groupID", desiredGroupID);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
            

        }



        public void insertTask(int ID, string description, string name,string link)
        {
           using(MySqlConnection connection = new MySqlConnection(connect))
            {
                int id = ID;
                string des = description;

                connection.Open();
                string query = "INSERT INTO `groucord`.`task`(`groupMemberID`,`description`,`taskName`,`remarks`,`link`) VALUES (@id,@des,@name,@remarks,@link);";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", ID);
                command.Parameters.AddWithValue("@des", des);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@remarks", "ON-GOING");
                command.Parameters.AddWithValue("@link", link);

                command.ExecuteNonQuery();  
                connection.Close() ;


            }
           
        }



        public List<Taskc> getTasks(int groupID)
        {
            List<Taskc> tasks = new List<Taskc>();
            try
            {
                using(MySqlConnection connection = new MySqlConnection(connect))
                {
                    connection.Open();
                    string query = "SELECT `account`.`username`, `task`.`taskName`,`task`.`remarks`,`task`.`description`, `task`.`link` FROM `account` INNER JOIN `groupmember`  ON `account`.`email` = `groupmember`.`groupMemberEmail` INNER JOIN `task` ON `groupmember`.`groupMemberID` = `task`.`groupMemberID` WHERE `groupmember`.`group_ID` = @id;";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", groupID);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        
                        
                        while (reader.Read())
                        {
                            int count = 0;
                            string Tnames = reader.GetString("taskName");
                            string uname = reader.GetString("username");
                            string rmrks = reader.GetString("remarks");
                            string des = reader.GetString("description");
                            string link = reader.GetString("link");

                            if(tasks.Count == 0)
                            {
                                Taskc Task1 = new Taskc();
                                Task1.taskname = Tnames;
                                Task1.remarks = rmrks;
                                Task1.description = des;
                                Task1.link = link;
                                Task1.assigned.Add(uname);

                                tasks.Add(Task1);
                                continue;
                            }

                            if (tasks.Count >= 1)
                            {
                                List<Taskc> modifiedtasks = new List<Taskc>();
                                
                                foreach (Taskc name in tasks)
                                {
                                    Taskc modtask = name;
                                    if (name.taskname == Tnames )
                                    {
                                        modtask.assigned.Add(uname);
                                        count++;
                                       
                                    }
 
                                    modifiedtasks.Add(modtask);
                                  
                                }
                                tasks = modifiedtasks;

                            }

                           if(count == 0)
                            {

                                Taskc Task = new Taskc();
                                Task.taskname = Tnames;
                                Task.remarks = rmrks;
                                Task.assigned.Add(uname);
                                Task.description = des;
                                Task.link = link;
                                tasks.Add(Task);
                            }
                               
                           
                        }
                    }
                   

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return tasks;
        }



        public Taskc retrieveTask(string name)
        {
            Taskc task = new Taskc();
            using (MySqlConnection connection = new MySqlConnection(connect))
            {
                connection.Open();

                string query = "SELECT `description`, `remarks`,`link` FROM `task` WHERE `taskName` = @name;";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@name", name);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    //caution
                    if (reader.Read())
                    {
                        
                        task.description = reader.GetString("description");
                        task.remarks = reader.GetString("remarks");
                        task.link = reader.GetString("link");
                    }
                }
                connection.Close();
            }
            return task;
        }



        public string emailQuerythroughID(int id)
        {
            string output ="";
            string query = "SELECT `groupMemberEmail` FROM `groupmember` WHERE `groupMemberID`= @id;";

            using(MySqlConnection connection = new MySqlConnection(connect))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(query,connection);
                command.Parameters.AddWithValue("@id", id);

                using(MySqlDataReader reader = command.ExecuteReader())
                { if (reader.Read())
                    {
                        output = reader.GetString("groupMemberEmail");
                    } 
                }
            }
            return output;
        }






        public Taskc retrieveTaskbyID(int id)
        {
            Taskc task = new Taskc();
            using (MySqlConnection connection = new MySqlConnection(connect))
            {
                connection.Open();

                string query = "SELECT `description`, `taskName`,`link` FROM `task` WHERE `groupMemberID` = @id;";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    //caution
                    while (reader.Read())
                    {

                        task.description = reader.GetString("description");
                        task.taskname = reader.GetString("taskName");
                        task.link = reader.GetString("link");
                    }
                }
                connection.Close();
            }
            return task;
        }


    }
}
