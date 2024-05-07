using Guna.UI.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.IO;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.Security.Cryptography;

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
                        account.contactNumber = reader.GetString("contactNumber");
                        account.password = reader.GetString("password");
                        string enumstatus = reader.GetString("status");
                        account.status = this.GetStatusFromString(enumstatus);
                        account.accountImage = reader["accountProfile"] == DBNull.Value ? null : (byte[])reader["accountProfile"];

                       if (account.accountImage != null)
                        {
                            using (var ms = new MemoryStream(account.accountImage))
                            {
                                account.accountProfile = Image.FromStream(ms);
                            }
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

        public void updateStatus(string status, string email)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connect))
                {
                    connection.Open();
                    string query = "UPDATE `groucord`.`account` SET `status` = @status WHERE (`email` = @email);";
                    
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
                        //try
                        dt.DefaultView.Sort = "DATE ASC";
                        return dt;
                    }
                }
            }
            

        }


        public DataTable LoadMemberData(int memberID)
        {
            string sql = @"
             SELECT `account`.`username` AS `NAME`, `busysched`.`date` AS `DATE`, `busysched`.`description` AS `DESCRIPTION`
                FROM `busysched`
                INNER JOIN `groupmember` ON `busysched`.`groupMemberID` = `groupmember`.`groupMemberID`
                INNER JOIN `account`  ON `groupmember`.`groupMemberEmail` = `account`.`email`
                WHERE `groupmember`.`groupMemberID` = @ID";

            using (MySqlConnection conn = new MySqlConnection(connect))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", memberID);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        //try
                        dt.DefaultView.Sort = "DATE ASC";
                        return dt;
                    }
                }
            }


        }










        public void insertTask(int ID, string description, string name,string link, DateTime due)
        {
           using(MySqlConnection connection = new MySqlConnection(connect))
            {
                int id = ID;
                string des = description;

                connection.Open();
                string query = "INSERT INTO `groucord`.`task`(`groupMemberID`,`description`,`taskName`, `dueDate`, `remarks`,`link`) VALUES (@id,@des,@name,@due,@remarks,@link);";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", ID);
                command.Parameters.AddWithValue("@des", des);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@due", due);
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




        public List<Taskc> getMemberTasks(int memberID)
        {
           
            List<Taskc> tasks = new List<Taskc>();
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connect))
                {
                    connection.Open();
                   
                    string query = "SELECT `taskID`,`description`, `taskName`, `dueDate`, `Remarks`, `link` FROM `task` WHERE `groupMemberID` = @id;";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", memberID);
                    
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {


                        while (reader.Read())
                        {
                           
                            
                            string Tnames = reader.GetString("taskName");
                            DateTime due = reader.GetDateTime("dueDate");
                            string rmrks = reader.GetString("remarks");
                            string des = reader.GetString("description");
                            string link = reader.GetString("link");
                            int id = reader.GetInt32("taskID");
                            
                                Taskc Task1 = new Taskc();
                                Task1.taskID = id;
                                Task1.taskname = Tnames;
                                Task1.remarks = rmrks;
                                Task1.description = des;
                                Task1.link = link;
                                Task1.dueDate = due;
                              

                                tasks.Add(Task1);
                          
                           
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

                string query = "SELECT `taskID`,`description`, `dueDate`,`remarks`,`link` FROM `task` WHERE `taskName` = @name;";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@name", name);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    //caution
                    if (reader.Read())
                    {
                        task.taskID = reader.GetInt32("taskID");
                        task.dueDate = reader.GetDateTime("dueDate");
                        task.description = reader.GetString("description");
                        task.remarks = reader.GetString("remarks");
                        task.link = reader.GetString("link");
                    }
                }
                connection.Close();
            }
            return task;
        }


        public Taskc updateTaskRemarks(int id)
        {
            Taskc task = new Taskc();
            using (MySqlConnection connection = new MySqlConnection(connect))
            {
                connection.Open();

                string query = "UPDATE `groucord`.`task` SET `remarks` = 'SUBMITTED' WHERE (`taskID` = @id);";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
               
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


        public void insertUpdateAnnouncement(string ahead, string abody, int id, DateTime date)
        {
            bool exist = false;
            using (MySqlConnection connection = new MySqlConnection(connect))
            {
                connection.Open();

                string query = "UPDATE `groucord`.`announcement` SET `isLatest` = '0' WHERE (`AGroup_ID` = @id);";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();



                 query = "SELECT * FROM `groucord`.`announcement` WHERE `announcementHead`=@ah AND `AGroup_ID`=@id;";
                command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@ah", ahead);
                command.Parameters.AddWithValue("@id", id);
               
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable data = new DataTable();
                adapter.Fill(data);

                if (data.Rows.Count > 0)
                {
                    exist = true;
                    query = "UPDATE `groucord`.`announcement` SET `isLatest` = '1' WHERE (`AGroup_ID` = @id AND `announcementHead`=@ah);";
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@ah", ahead);
                    command.ExecuteNonQuery();

                }
  
                if (!exist)
                {
                     query = "INSERT INTO `groucord`.`announcement` (`announcementHead`, `announcementBody`, `AGroup_ID`, `isLatest`,`datePosted`) VALUES (@ah, @ab, @id, '1',@date);";
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ah", ahead);
                    command.Parameters.AddWithValue("@ab", abody);
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@date", date);
                    command.ExecuteNonQuery();
                    
                }
                connection.Close();

            }
        }

        public AnnouncementC getAnnouncement(int id)
        {
            AnnouncementC ann = new AnnouncementC();
            
            using (MySqlConnection connection = new MySqlConnection(connect))
            {
                connection.Open();
                string query = "SELECT * FROM `announcement` WHERE `AGroup_ID`=@id AND `isLatest` = '1';";

                MySqlCommand command = new MySqlCommand(query,connection);
                command.Parameters.AddWithValue("@id", id);
                using(MySqlDataReader reader = command.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        ann.announcementID = reader.GetInt32("announcementID");
                        ann.announcementHead = reader.GetString("announcementHead");
                        ann.announcementBody = reader.GetString("announcementBody");
                        ann.AGroup_ID = reader.GetInt32("AGroup_ID");
                        ann.announcedDate = reader.GetDateTime("datePosted");
                    }
                }

                connection.Close();
                return ann;
               
            }
           
        }


        public string getAnnouncementBody(string ahead,int id)
        {
            string body = "";
            using (MySqlConnection connection = new MySqlConnection(connect))
            {
                connection.Open();

                string query = "SELECT `announcementBody` FROM `groucord`.`announcement` WHERE `announcementHead`=@ah AND `AGroup_ID`=@id;";
                MySqlCommand command = new MySqlCommand(query,connection);
                command.Parameters.AddWithValue("@ah", ahead);
                command.Parameters.AddWithValue("@id",id);
                using(MySqlDataReader reader = command.ExecuteReader())
                {
                    if(reader.Read())
                    {
                        body = reader.GetString("announcementBody");
                    }
                }
                connection.Close();
                return body;

            }
        }



        public void deleteAnnouncement(string ahead, int id)
        {
            using(MySqlConnection connection = new MySqlConnection(connect))
            {
                connection.Open();

                string query = "DELETE FROM `groucord`.`announcement` WHERE (`announcementHead`=@ah AND `AGroup_ID`=@id);";
                MySqlCommand command = new MySqlCommand( query,connection);
                command.Parameters.AddWithValue("@ah", ahead);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
        }




        public List<string> getALLAnnouncementHeads(int id)
        {
            List<string> ahead = new List<string>();
            using (MySqlConnection connection = new MySqlConnection(connect))
            {
                connection.Open();
                string query = "SELECT `announcementHead` FROM `announcement` WHERE `AGroup_ID`=@id ;";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ahead.Add(reader.GetString("announcementHead")); 
                    }
                }

                connection.Close();
                return ahead;

            }




        }



        public void updateEmail(string oldEmail, string newEmail)
        {
            using(MySqlConnection connection = new MySqlConnection(connect))
            {
                connection.Open();
                string query = "UPDATE `account` SET `email`=@new WHERE `email`=@old;";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@new", newEmail);
                command.Parameters.AddWithValue("@old", oldEmail);
                command.ExecuteNonQuery();
                connection.Close(); 
            }
        }


        public void updateNumber(string oldNum, string newNum)
        {
            using (MySqlConnection connection = new MySqlConnection(connect))
            {
                connection.Open();
                string query = "UPDATE `account` SET `contactNumber`=@new WHERE `contactNumber`=@old;";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@new", newNum);
                command.Parameters.AddWithValue("@old", oldNum);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void updateProfilePic(string path, string email)
        {
          
            using(MySqlConnection connection = new MySqlConnection(connect))
            {
                connection.Open();

                string query = "UPDATE `account` SET `accountProfile` = @image WHERE `email`=@email;";
                byte[] imageData = File.ReadAllBytes(path);
                       
                MySqlCommand command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@Image", imageData);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void updateUsername(string name, string email)
        {

            using (MySqlConnection connection = new MySqlConnection(connect))
            {
                connection.Open();

                string query = "UPDATE `account` SET `username` = @name WHERE `email`=@email;";
                

                MySqlCommand command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@name", name);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }


        public void insertPicStatus(string path, string state)
        {
            using (MySqlConnection connection = new MySqlConnection(connect))
            {
                connection.Open();

                string query = "INSERT INTO `groucord`.`status` (`state`,`statPic`) VALUES (@state,@image);";
                byte[] imageData = File.ReadAllBytes(path);

                MySqlCommand command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@state", state);
                command.Parameters.AddWithValue("@image", imageData);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        public Image getStatusPic(string status)
        {
            byte[] imageData = null;
            Image image = null;
            using(MySqlConnection connection = new MySqlConnection(connect) )
            {
                connection.Open();
                string query = "SELECT * FROM `groucord`.`status` WHERE `state`=@status; ";
                MySqlCommand command = new MySqlCommand(query,connection);
                command.Parameters.AddWithValue("@status", status);
                
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if(reader.Read())
                    {
                       imageData = reader["statPic"] == DBNull.Value ? null : (byte[])reader["statPic"];
                    }
                    if (imageData != null)
                    {
                        using (var ms = new MemoryStream(imageData))
                        {
                           image = Image.FromStream(ms);
                        }
                    }

                }
                connection.Close();
            }

            return image;
        }

       


        public void insertTaskSubmitted(string link, string description, DateTime date, int taskID)
        {
            MySqlConnection connection = new MySqlConnection(connect);
            string query = "INSERT INTO `submittedTask`(`fileLink`,`description`,`taskID`,`dateSubmitted`) VALUES (@link,@des,@id,@date);";
            connection.Open();
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@link", link);
            command.Parameters.AddWithValue("@des", description);
            command.Parameters.AddWithValue("@id", taskID);
            command.Parameters.AddWithValue("@date", date);
            command.ExecuteNonQuery();

            connection.Close();
            
        }






        public void updateTaskSubmitted(string link, string description, DateTime date, int taskID)
        {
            MySqlConnection connection = new MySqlConnection(connect);
            string query = "UPDATE `groucord`.`submittedtask` SET `fileLink` = @link, `description` = @des, `dateSubmitted` = @date WHERE (`taskID` = @id);";
            connection.Open();
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@link", link);
            command.Parameters.AddWithValue("@des", description);
            command.Parameters.AddWithValue("@date", date);
            command.Parameters.AddWithValue("@id", taskID);
            command.ExecuteNonQuery();

            connection.Close();

        }


        public Taskc retrieveTaskSubmitted(int taskID)
        {
            Taskc task = new Taskc();
            MySqlConnection connection = new MySqlConnection(connect);
            string query = "SELECT * FROM `submittedtask` WHERE `taskID` = @id;";
            connection.Open();
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", taskID);
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    task.taskID = reader.GetInt32("taskID");
                    task.link = reader.GetString("fileLink");
                    task.description = reader.GetString("description");
                    task.dueDate = reader.GetDateTime("dateSubmitted");                    
                }
            }
            return task;
        }




        public List<Taskc> retrieveTaskSubmittedByLeader(string description, string name, string link )
        {
            List<Taskc> tasks = new List<Taskc>();
            List<int> taskID = new List<int>();
            MySqlConnection connection = new MySqlConnection(connect);
            string query = "SELECT taskID FROM groucord.task WHERE `description` = @des AND `taskName` = @name AND `link` = @link;";
            connection.Open();
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@des", description);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@link", link);
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    taskID.Add(reader.GetInt32("taskID"));
                }
            }

            query = "SELECT fileLink, description, dateSubmitted FROM groucord.submittedtask WHERE taskID = @id;";

            foreach (int id in taskID)
            {
                command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        Taskc task = new Taskc
                        {
                            link = reader.GetString("fileLink"),
                            description = reader.GetString("description"),
                            dueDate = reader.GetDateTime("dateSubmitted")
                        };
                        tasks.Add(task);
                    }
                }
            }

            return tasks;
        }


       


    }
}
