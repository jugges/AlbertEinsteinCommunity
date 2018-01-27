using System;
using System.Collections.Generic;
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
            connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Program.dbDir);
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
                command.CommandText = "INSERT INTO Users ([username], [password], [email], birthDate, firstName, biography, job, sex, livingArea, permission) VALUES('" + user.Username + "', '" + user.Password + "', '" + user.Email + "', '" + user.BirthDate.ToShortDateString() + "', '" + user.FirstName + "', '" + user.Biography + "', '" + user.Job + "', '" + user.Sex + "', '" + user.LivingArea + "', 'user')";
                //command.CommandText = "INSERT INTO Users ([username], [password], [email], birthDate, privacy, firstName, biography, job, sex, livingArea) VALUES ('', '', '', '', '', '', '', '', '', '')";
                command.CommandType = CommandType.Text;
                connection.Open();

                command.ExecuteNonQuery();
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
                command.CommandText = "UPDATE Users SET [email] = '" + user.Email + "', [birthDate] = '" + user.BirthDate.ToShortDateString() + "', [firstName] = '" + user.FirstName + "', [biography] = '" + user.Biography + "', [job] = '" + user.Job + "', [sex] = '" + user.Sex + "', [livingArea] = '" + user.LivingArea + "' WHERE[username] = '" + user.Username + "'";
                command.CommandType = CommandType.Text;
                connection.Open();

                command.ExecuteNonQuery();
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

        public List<UserControl> LoadForumList(WelcomeForm welcomeForm)
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
                    ForumTile forumTile = new ForumTile(forum, welcomeForm)
                    {
                        ForumImage = (Image)rm.GetObject("_" + reader["forumPicture"])
                    };
                    list.Add(forumTile);
                }
                return list;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

        public List<UserControl> LoadThreadList(string forumName, WelcomeForm welcomeForm)
        {
            try
            {
                Controller controller = new Controller();
                List<UserControl> list = new List<UserControl>();
                list.Add(new AddTile(welcomeForm));
                command.CommandText = "SELECT * FROM Threads WHERE forumName='" + forumName + "' ORDER BY threadId DESC";
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
                    ThreadTile threadTile = new ThreadTile(thread, welcomeForm, thread.ThreadMaker.Username == welcomeForm.user.Username);
                    list.Add(threadTile);
                }
                return list;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

        public List<UserControl> LoadReplyList(int threadId, WelcomeForm welcomeForm, Thread threadInfo)
        {
            try
            {
                Controller controller = new Controller();
                List<UserControl> list = new List<UserControl>();
                list.Add(new AddTile(welcomeForm));
                command.CommandText = "SELECT * FROM Replies WHERE threadId=" + threadId + " ORDER BY replyId ASC";
                command.CommandType = CommandType.Text;
                connection.Open();

                OleDbDataReader reader = command.ExecuteReader();

                Reply threadContentReply = new Reply();
                threadContentReply.ThreadId = threadId;
                threadContentReply.ReplyDate = threadInfo.ThreadDate;
                threadContentReply.ReplyContent = threadInfo.ThreadContent;
                threadContentReply.ReplyMaker = controller.IdentifyUser(threadInfo.ThreadMaker.Username);
                threadContentReply.IsOp = true;
                bool isMineFirst = threadContentReply.ReplyMaker.Username == welcomeForm.user.Username;
                bool isMakerFirst = threadContentReply.ReplyMaker.Username == threadInfo.ThreadMaker.Username && !isMineFirst;
                ReplyTile replyTileFirst = new ReplyTile(threadContentReply, welcomeForm, isMineFirst, isMakerFirst);
                list.Add(replyTileFirst);

                while (reader.Read())
                {
                    Reply reply = new Reply();
                    reply.ThreadId = threadId;
                    reply.ReplyId = (int)reader["replyId"];
                    reply.ReplyDate = (DateTime)reader["replyDate"];
                    reply.ReplyContent = reader["replyContent"].ToString();
                    reply.ReplyMaker = controller.IdentifyUser(reader["replyMaker"].ToString());
                    bool isMine = reply.ReplyMaker.Username == welcomeForm.user.Username;
                    bool isMaker = reply.ReplyMaker.Username == threadInfo.ThreadMaker.Username && !isMine;
                    ReplyTile replyTile = new ReplyTile(reply, welcomeForm, isMine, isMaker);
                    list.Add(replyTile);
                }
                return list;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

        public Thread GetThread(int threadId)
        {
            try
            {
                Controller controller = new Controller();
                Thread thread = new Thread();
                command.CommandText = "SELECT * FROM Threads WHERE threadId=" + threadId;
                command.CommandType = CommandType.Text;
                connection.Open();

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    thread.ForumName = reader["forumName"].ToString();
                    thread.ThreadContent = reader["threadContent"].ToString();
                    thread.ThreadDate = (DateTime)reader["threadDate"];
                    thread.ThreadId = (int)reader["threadId"];
                    thread.ThreadName = reader["threadName"].ToString();
                    thread.ThreadMaker = controller.IdentifyUser(reader["threadMaker"].ToString());
                }
                return thread;
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

        public void AddReply(Reply reply)
        {
            try
            {
                command.CommandText = "INSERT INTO Replies (replyContent, threadId, replyMaker) VALUES(\"" + reply.ReplyContent + "\", " + reply.ThreadId + ", '" + reply.ReplyMaker.Username + "')";
                command.CommandType = CommandType.Text;
                connection.Open();

                command.ExecuteNonQuery();
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

        public void AddThread(Thread thread)
        {
            try
            {
                command.CommandText = "INSERT INTO Threads (forumName, threadName, threadMaker, threadContent) VALUES('" + thread.ForumName + "', '" + thread.ThreadName + "', '" + thread.ThreadMaker.Username + "', \"" + thread.ThreadContent + "\")";
                command.CommandType = CommandType.Text;
                connection.Open();

                command.ExecuteNonQuery();
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

        public void EditReply(Reply reply)
        {
            try
            {
                command.CommandText = "UPDATE Replies SET [replyContent] =  \"" + reply.ReplyContent + "\" WHERE[replyId] = " + reply.ReplyId;
                command.CommandType = CommandType.Text;
                connection.Open();

                command.ExecuteNonQuery();
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

        public void EditThread(Reply reply)
        {
            try
            {
                command.CommandText = "UPDATE Threads SET [threadContent] =  \"" + reply.ReplyContent + "\" WHERE[threadId] = " + reply.ThreadId;
                command.CommandType = CommandType.Text;
                connection.Open();

                command.ExecuteNonQuery();
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }
    }
}
