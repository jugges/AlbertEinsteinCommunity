﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Resources;
using System.Drawing;
using System.Windows.Forms;
using AlbertEinsteinCommunity.Properties;

namespace AlbertEinsteinCommunity
{
    public class Controller
    {
        OleDbConnection connection;
        OleDbCommand command;

        private void ConnectTo()
        {
            connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\yuval\\source\\repos\\AlbertEinsteinCommunity\\AlbertEinsteinCommunity\\Database5.accdb");
            command = connection.CreateCommand();
        }

        public Controller()
        {
            ConnectTo();
        }

        public void RegisterUser(User user)
        {
            try
            {
                command.CommandText = "INSERT INTO Users ([username], [password], [email], birthDate, privacy, firstName, biography, job, sex, livingArea) VALUES('" + user.Username + "', '" + user.Password + "', '" + user.Email + "', '" + user.BirthDate.ToShortDateString() + "', '" + user.FirstName + "', '" + user.Biography + "', '" + user.Job + "', '" + user.Sex + "', '" + user.LivingArea + "')";
                //command.CommandText = "INSERT INTO Users ([username], [password], [email], birthDate, privacy, firstName, biography, job, sex, livingArea) VALUES ('', '', '', '', '', '', '', '', '', '')";
                command.CommandType = CommandType.Text;
                connection.Open();

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

        public string PasswordCheck(String username)
        {
            try
            {
                command.CommandText = "SELECT [password] FROM Users WHERE [username]='" + username + "'";
                command.CommandType = CommandType.Text;
                connection.Open();

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    return (reader["password"].ToString());
                }
                return "error";
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

        public User IdentifyUser(string username)
        {
            try
            {
                command.CommandText = "SELECT * FROM Users WHERE [username]='" + username + "'";
                command.CommandType = CommandType.Text;
                connection.Open();

                OleDbDataReader reader = command.ExecuteReader();
                User user = new User();

                while (reader.Read())
                {
                    user.Username = username;
                    user.Email = reader["email"].ToString();
                    user.Karma = int.Parse(reader["karma"].ToString());
                    user.RegisteringDate = DateTime.Parse(reader["registeringDate"].ToString());
                    try
                    {
                        user.BirthDate = DateTime.Parse(reader["birthDate"].ToString());
                    }
                    catch
                    {
                        // ignored
                    }
                    user.FirstName = reader["firstName"].ToString();
                    user.Biography = reader["biography"].ToString();
                    user.Job = reader["job"].ToString();
                    user.Sex = reader["sex"].ToString();
                    user.LivingArea = reader["livingArea"].ToString();
                }
                return user;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

        public void EditUser(User user)
        {
            try
            {
                command.CommandText = "UPDATE Users SET [email] = '"+user.Email+"', [birthDate] = '"+user.BirthDate.ToShortDateString()+ "', [firstName] = '" + user.FirstName + "', [biography] = '" + user.Biography + "', [job] = '" + user.Job + "', [sex] = '" + user.Sex + "', [livingArea] = '" + user.LivingArea + "' WHERE[username] = '" + user.Username + "'";
                command.CommandType = CommandType.Text;
                connection.Open();

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

        public List<UserControl> LoadForumList(ThreadList threadList)
        {
            try
            {
                ResourceManager rm = Resources.ResourceManager;
                Controller controller = new Controller();
                List<UserControl> list = new List<UserControl>();
                command.CommandText = "SELECT * FROM Forums";
                command.CommandType = CommandType.Text;
                connection.Open();

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Forum forum = new Forum();
                    forum.ForumName = reader["forumName"].ToString();
                    forum.ForumAdmin = controller.IdentifyUser(reader["forumAdmin"].ToString());
                    ForumTile forumTile = new ForumTile(forum,threadList)
                    {
                        ForumImage = (Image)rm.GetObject("_" + reader["forumPicture"])
                    };
                    list.Add(forumTile);
                }
                return list;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }
        public List<UserControl> LoadThreadList(string forumName)
        {
            try
            {
                Controller controller = new Controller();
                List<UserControl> list = new List<UserControl>();
                command.CommandText = "SELECT * FROM Threads WHERE forumName='"+forumName+"'";
                command.CommandType = CommandType.Text;
                connection.Open();

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Thread thread = new Thread();
                    thread.ForumName = reader["forumName"].ToString();
                    thread.ThreadContent = reader["threadContent"].ToString();
                    thread.ThreadDate = (DateTime)reader["threadDate"];
                    thread.ThreadId = (int)reader["threadId"];
                    thread.ThreadName = reader["threadName"].ToString();
                    thread.ThreadMaker = controller.IdentifyUser(reader["threadMaker"].ToString());
                    ThreadTile threadTile = new ThreadTile(thread);
                    list.Add(threadTile);
                }
                return list;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }
    }
}