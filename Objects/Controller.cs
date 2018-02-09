using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Resources;
using System.Drawing;
using System.Windows.Forms;
using AlbertEinsteinCommunity.Properties;

namespace AlbertEinsteinCommunity
{
    public class Controller
    {
        SqlConnection connection;
        SqlCommand command;

        private void ConnectTo()
        {
            connection = new SqlConnection("Data Source=alberteinsteincom.ddns.net,1433; Uid=admin; Pwd = test1234;");
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

                SqlDataReader reader = command.ExecuteReader();

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

        public bool UsernameCheck(String username)
        {
            try
            {
                command.CommandText = "SELECT [username] FROM Users WHERE [username]='" + username + "'";
                command.CommandType = CommandType.Text;
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    return false;
                }
                return true;
            }
            finally
            {
                connection?.Close();
            }
        }

        public bool EmailCheck(String email)
        {
            try
            {
                command.CommandText = "SELECT [email] FROM Users WHERE [email]='" + email + "'";
                command.CommandType = CommandType.Text;
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    return false;
                }
                return true;
            }
            finally
            {
                connection?.Close();
            }
        }

        public User IdentifyUser(string username)
        {
            try
            {
                command.CommandText = "SELECT * FROM Users WHERE [username]='" + username + "'";
                command.CommandType = CommandType.Text;
                connection.Open();

                Controller controller = new Controller();
                SqlDataReader reader = command.ExecuteReader();
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
                    string permission = reader["permission"].ToString();
                    string forum;
                    if (permission == "specific")
                        forum = controller.GetSpecificPermission(username);
                    else
                        forum = null;
                    user.Permission = new Permission(permission, forum);
                }
                return user;
            }
            finally
            {
                connection?.Close();
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
                connection?.Close();
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

                SqlDataReader reader = command.ExecuteReader();

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
                connection?.Close();
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

                SqlDataReader reader = command.ExecuteReader();

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

                SqlDataReader reader = command.ExecuteReader();

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

                SqlDataReader reader = command.ExecuteReader();

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
                command.CommandText = "INSERT INTO Replies (replyContent,replyMaker,threadId) VALUES(@replyContent, @replyMaker, @threadId)";
                command.CommandType = CommandType.Text;
                command.Parameters.Add("@replyContent", SqlDbType.NVarChar);
                command.Parameters.Add("@replyMaker", SqlDbType.VarChar);
                command.Parameters.Add("@threadId", SqlDbType.Int);
                command.Parameters["@replyContent"].Value = reply.ReplyContent;
                command.Parameters["@replyMaker"].Value = reply.ReplyMaker.Username;
                command.Parameters["@threadId"].Value = reply.ThreadId;
                connection.Open();

                command.ExecuteNonQuery();
            }
            finally
            {
                if (connection != null)
                    connection.Close();
                command.Parameters.Clear();
            }
        }

        public void AddThread(Thread thread)
        {
            try
            {
                command.CommandText = "INSERT INTO Threads (forumName, threadName, threadMaker, threadContent) VALUES(@forumName, @threadName, @threadMaker, @threadContent)";
                command.CommandType = CommandType.Text;
                command.Parameters.Add("@forumName", SqlDbType.VarChar);
                command.Parameters.Add("@threadName", SqlDbType.VarChar);
                command.Parameters.Add("@threadMaker", SqlDbType.VarChar);
                command.Parameters.Add("@threadContent", SqlDbType.NVarChar);
                command.Parameters["@forumName"].Value = thread.ForumName;
                command.Parameters["@threadName"].Value = thread.ThreadName;
                command.Parameters["@threadMaker"].Value = thread.ThreadMaker.Username;
                command.Parameters["@threadContent"].Value = thread.ThreadContent;
                connection.Open();

                command.ExecuteNonQuery();
            }
            finally
            {
                if (connection != null)
                    connection.Close();
                command.Parameters.Clear();
            }
        }

        public void EditReply(Reply reply)
        {
            try
            {
                command.CommandText = "UPDATE Replies SET [replyContent] = @replyContent WHERE [replyId] = @replyId";
                command.CommandType = CommandType.Text;
                command.Parameters.Add("@replyContent", SqlDbType.NVarChar);
                command.Parameters.Add("@replyId", SqlDbType.Int);
                command.Parameters["@replyContent"].Value = reply.ReplyContent;
                command.Parameters["@replyId"].Value = reply.ReplyId;
                connection.Open();

                command.ExecuteNonQuery();
            }
            finally
            {
                if (connection != null)
                    connection.Close();
                command.Parameters.Clear();
            }
        }

        public void EditThread(Reply reply)
        {
            try
            {
                command.CommandText = "UPDATE Threads SET [threadContent] =  @threadContent WHERE[threadId] = @threadId";
                command.CommandType = CommandType.Text;
                command.Parameters.Add("@threadContent", SqlDbType.NVarChar);
                command.Parameters.Add("@threadId", SqlDbType.Int);
                command.Parameters["@threadContent"].Value = reply.ReplyContent;
                command.Parameters["@threadId"].Value = reply.ThreadId;
                connection.Open();

                command.ExecuteNonQuery();
            }
            finally
            {
                if (connection != null)
                    connection.Close();
                command.Parameters.Clear();
            }
        }

        public string GetSpecificPermission(string username)
        {
            try
            {
                command.CommandText = "SELECT [forum] FROM SpecificPermissions WHERE [username]='" + username + "'";
                command.CommandType = CommandType.Text;
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    return (reader["forum"].ToString());
                }
                return "error";
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

        public void DeleteThread(int threadId)
        {
            try
            {
                command.CommandText = "DELETE FROM Threads WHERE threadId=" + threadId;
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

        public void DeleteReply(int replyId)
        {
            try
            {
                command.CommandText = "DELETE FROM Replies WHERE replyId=" + replyId;
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
