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


namespace WindowsFormsApp1.Classes
{
    public class GroupHandler
    {
        private const string connect = "server=127.0.0.1;uid=root;pwd=July072004;database=groucord;";

        public void InsertGroup(string imagePath,string groupName, Account groupLeader, List<Account> member)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connect))
                {
                    connection.Open();
                    byte[] imageData = File.ReadAllBytes(imagePath);
                    string name = groupName;
                    string email = groupLeader.email;



                   
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

                    MessageBox.Show("Group added successfullly");
                    connection.Close();
                }
            }
           
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
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

                    string query = "SELECT groupName, groupImage FROM group WHERE groupLeader = @leader";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Leader", leaderEmail);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Group group = new Group
                            {
                                group_name = reader.GetString("groupName"),
                                groupImage = reader["GroupImage"] == DBNull.Value ? null : (byte[])reader["groupImage"],
                                groupLeader = leaderEmail
                            };

                            groupList.Add(group);
                        }
                    }

                    MessageBox.Show("Group Retrieved Succcessfully");
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

    }
}
