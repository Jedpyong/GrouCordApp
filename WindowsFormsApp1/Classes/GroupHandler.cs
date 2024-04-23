using MySql.Data.MySqlClient;
using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Security.Principal;
using System.Diagnostics.Metrics;


namespace WindowsFormsApp1.Classes
{
    public class GroupHandler
    {
        private const string connect = "server=127.0.0.1;uid=root;pwd=July072004;database=groucord;";

        public Group InsertGroup(string imagePath,string groupName, Account groupLeader, List<Account> member)
        {
            Group group = new Group();
            //if same name ra ang group?
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connect))
                {
                    connection.Open();
                    byte[] imageData = File.ReadAllBytes(imagePath);
                    string name = groupName;
                    string email = groupLeader.email;
                    
                    group.groupImage = imageData;

                   
                    string query = "INSERT INTO `groucord`.`group` (`groupName`, `groupLeader`,`groupImage`) VALUES (@name, @email, @Image);";
                   
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@Image", imageData);
                    command.ExecuteNonQuery();

                    foreach (Account account in member)
                    {

                        // string acc = account.email.ToString();
                        string acc = account.email;
                       // string query2 = "INSERT INTO `groucord`.`groupmember` SET `groupMemberEmail` = @acc,`group_ID` = (SELECT `group_ID` FROM `group` WHERE `groupLeader` = @email);";
                        string query2 = "INSERT INTO `groucord`.`groupmember` (`group_ID`, `groupMemberEmail`) VALUES ((SELECT `group_ID` FROM `group` WHERE `groupLeader` = @email AND `groupName` = @name),@acc);";

                        MySqlCommand command2 = new MySqlCommand(query2, connection);
                        command2.Parameters.AddWithValue("@acc", acc);
                        command2.Parameters.AddWithValue("@email", email);
                        command2.Parameters.AddWithValue("@name", name);
                        command2.ExecuteNonQuery();
                    }

                    string query3 = "SELECT `group_ID` FROM `group` WHERE `groupLeader` = @email"; ;

                    MySqlCommand cmd = new MySqlCommand(query3, connection);
                    cmd.Parameters.AddWithValue("@email", email);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    
                    while (reader.Read())
                    {
                        group.group_ID = Convert.ToInt32(reader["group_ID"]);
                    }

                        MessageBox.Show("Group added successfullly");

                    connection.Close();
                }
            }
           
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return group;
        }

        public void RetrieveGroupImage(int GroupID, string savePath)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connect))
                {
                    connection.Open();

                    string query = "SELECT groupImage FROM group WHERE group_ID = @groupID";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@groupID", GroupID);

                    byte[] imageData = (byte[])command.ExecuteScalar();

                    File.WriteAllBytes(savePath, imageData);

                    MessageBox.Show("Image Retrieved Succcessfully");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: "+ex.Message);
            }
        } 
        
        public List<Group> GetGroupByLeader(string leaderEmail)
        {
            List<Group> groupList = new List<Group>();
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connect))
                {
                    connection.Open();

                    string query = "SELECT `group_ID`, `groupName`, `groupImage` FROM `group` WHERE `groupLeader` = @leader;";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@leader", leaderEmail);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Group group = new Group
                            {
                                group_ID = reader.GetInt32("group_ID"),
                                group_name = reader.GetString("groupName"),
                                groupImage = reader["GroupImage"] == DBNull.Value ? null : (byte[])reader["groupImage"],
                                groupLeader = leaderEmail
                                
                            };
                            if (group.groupImage != null)
                            {
                                using (var ms = new MemoryStream(group.groupImage))
                                {
                                    group.groupImageObj = Image.FromStream(ms);
                                }
                            }

                            groupList.Add(group);
                        }
                    }

             
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: "+ex.Message);
            }
            return groupList;
        }


        public void insertMember(Group group, Account member)
        {

        }

       // public bool searchMember()


        public List<Account> getMembers(Group group/*, Account leader*/)
        {
            List<Account> members = new List<Account>();
            try
            {
                List<string> emails = new List<string>();
                using (MySqlConnection connection = new MySqlConnection(connect))
                {
                    connection.Open();

                    
                    string query = "SELECT `groupMemberEmail` FROM `groupmember` WHERE `group_ID` = @ID;";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ID", group.group_ID);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string email = reader.GetString("groupMemberEmail");
                            emails.Add(email);
                        }
                    }

                    connection.Close();
                }

                using (MySqlConnection connection = new MySqlConnection(connect))
                {
                    connection.Open();
                   
                    

                    foreach(string email in emails)
                    {
                        string query2 = "SELECT * FROM `account` WHERE `email` = @email;";
                        MySqlCommand command2 = new MySqlCommand(query2, connection);
                        command2.Parameters.AddWithValue("@email", email);

                        using (MySqlDataReader inRead = command2.ExecuteReader())
                        {
                            while (inRead.Read())
                            {
                                string temp = inRead.GetString("status");
                                DBManager convert = new DBManager();
                                Account member = new Account
                                {
                                    accountID = Convert.ToInt32(inRead["idAccount"]),
                                    username = inRead.GetString("username"),
                                    contactNumber = inRead.GetString("contactNumber"),
                                    status = convert.GetStatusFromString(temp),
                                    accountImage = inRead["accountProfile"] == DBNull.Value ? null : (byte[])inRead["accountProfile"]
                                    

                                };

                                if (member.accountImage != null)
                                {
                                    using (var ms = new MemoryStream(member.accountImage))
                                    {
                                        member.accountProfile = Image.FromStream(ms);
                                    }
                                }
                                member.email = email;
                                members.Add(member);
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
            return members;
        }












    }
}
