using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;



namespace CourseWorkCsharp2
{
    class SQLconnect
    {
        SqlConnection con;

        public SQLconnect()
        {
            try
            {
                
                con = new SqlConnection("Data Source=MARTHYN-PC\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
            }
            catch (Exception e)
            {
                Console.WriteLine("Connection failed");
                Console.WriteLine(e.Message);
            }
        }
        public SQLconnect(String user, String password, String database, String server)
        {
            try
            {
                String connectionString = "user id=" + user + ";password=" + password + ";server=" + server + ";Trusted_Connection=yes;database=" + database + "connection timeout=30";
                con = new SqlConnection(connectionString);
            }
            catch (Exception e)
            {
                Console.WriteLine("Connection failed");
            }
        }

        private bool openCon()
        {
            try
            {
                con.Open();
                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine("Connection could not be opened");
                return false;
            }
        }

        private bool closeCon()
        {
            try
            {
                con.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Connection could not be closed");
                return false;
            }
        }

        public Boolean checkLogin(String username, String password)
        {
            List<User> users = this.findUser("username", username);
            if (users.Count > 0)
            {
                if (users.Count == 1)
                {
                    User user = users.ElementAt(0);
                    if (user.getPassword() == password)
                    {
                        return true;
                    }
                }
            }
            return false;
        }


        public bool addUser(User user)
        {
            String sql;
            if (user.getId() > 0)
            {
                sql = "UPDATE users SET username = @username, email = @email, firstname = @firstname, lastname = @surname, password = @password, universityId = @universityId WHERE userId = @userId";
            }
            else
            {
                sql = "INSERT INTO users (username, email, firstname, lastname, password,universityId)" +
                          "VALUES (@username, @email, @firstname, @surname, @password,@universityId)";
            }
            SqlCommand query = new SqlCommand(sql,con);
            SqlParameter parUsername = new SqlParameter("@username", SqlDbType.VarChar, 50);
            SqlParameter parEmail = new SqlParameter("@email", SqlDbType.VarChar, 50);
            SqlParameter parFirstname = new SqlParameter("@firstname", SqlDbType.VarChar, 50);
            SqlParameter parSurname = new SqlParameter("@surname", SqlDbType.VarChar, 50);
            SqlParameter parPassword = new SqlParameter("@password", SqlDbType.VarChar, 50);
            SqlParameter parUniversity = new SqlParameter("@universityId", SqlDbType.Int);
            SqlParameter parUserId = new SqlParameter("@userId", SqlDbType.Int);
            parUsername.Value = user.getUsername();
            parEmail.Value = user.getEmail();
            parFirstname.Value = user.getFirstname();
            parSurname.Value = user.getLastname();
            parPassword.Value = user.getPassword();
            parUniversity.Value = user.getUniversityId();
            parUserId.Value = user.getId();

            query.Parameters.Add(parUsername);
            query.Parameters.Add(parEmail);
            query.Parameters.Add(parFirstname);
            query.Parameters.Add(parSurname);
            query.Parameters.Add(parPassword);
            query.Parameters.Add(parUniversity);
            query.Parameters.Add(parUserId);
            Console.WriteLine(query.CommandText);
            try
            {
                this.openCon();
                query.ExecuteScalar();
                this.closeCon();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Adding user failed");
                Console.WriteLine(e.Message);
                this.closeCon();            
                return false;
            }
            
        }

        public void deleteUser(String id)
        {
            SqlParameter parId = new SqlParameter("@id", SqlDbType.Int);
            parId.Value = id;

            this.openCon();
            SqlCommand query = new SqlCommand("DELETE * FROM users WHERE id = @id");
            query.Parameters.Add(parId);
            try
            {
                query.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine("Deleting user failed");
            }
            this.closeCon();
        }

        public List<User> searchUser(String column, String searchQ)
        {
            SqlDataReader reader;
            List<User> userlist = new List<User>();

            SqlCommand query = new SqlCommand("SELECT * FROM users WHERE " + column + " LIKE '%'+@searchQ+'%'", con);

            SqlParameter parSearchQ = new SqlParameter("searchQ", SqlDbType.VarChar);
            parSearchQ.Value = searchQ;
            query.Parameters.Add(parSearchQ);

            this.openCon();
            try
            {
                reader = query.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine("next");
                    User user = new User(reader["username"].ToString(),
                                        Convert.ToInt32(reader["userId"].ToString()),
                                        reader["firstname"].ToString(),
                                        reader["lastname"].ToString(),
                                        reader["email"].ToString(),
                                        reader["password"].ToString(),
                                        Convert.ToInt32(reader["universityId"].ToString()));
                    userlist.Add(user);
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            this.closeCon();
            return userlist;
        }

        public List<User> findUser(String column, String searchQ)
        {
            SqlDataReader reader;
            List<User> userlist = new List<User>();

            SqlCommand query = new SqlCommand("SELECT TOP 1 * FROM users WHERE "+column+"= @searchQ", con);

            SqlParameter parSearchQ = new SqlParameter("searchQ", SqlDbType.VarChar);
            parSearchQ.Value = searchQ;
            query.Parameters.Add(parSearchQ);
              
            this.openCon();
            try
            {
                reader = query.ExecuteReader();
            
                while(reader.Read())
                {
                    Console.WriteLine("next");
                    User user = new User(reader["username"].ToString(), 
                                        Convert.ToInt32(reader["userId"].ToString()), 
                                        reader["firstname"].ToString(), 
                                        reader["lastname"].ToString(), 
                                        reader["email"].ToString(),
                                        reader["password"].ToString(),
                                        Convert.ToInt32(reader["universityId"].ToString()));
                    userlist.Add(user);
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            this.closeCon();
            return userlist;            
        }

        public Note insertNote(Note note)
        {
            String sql;
            if (note.getId() > 0)
            {
                sql = "UPDATE note " +
                             "SET notebookId = @notebookId, userId = @userId," +
                             "text = @text, tags = @tags, title= @title " +
                             "WHERE noteId = @noteId";
                
            }
            else
            {
                sql = "INSERT INTO note (notebookId, userId, text, tags, title)" +
                          "VALUES (@notebookId, @userId, @text, @tags, @title)";
            }
            SqlCommand query = new SqlCommand(sql, con);
            SqlParameter parNotebookId = new SqlParameter("@notebookId", SqlDbType.Int);
            SqlParameter parUserId = new SqlParameter("@userId", SqlDbType.VarChar, 50);
            SqlParameter parText = new SqlParameter("@text", SqlDbType.VarChar);
            SqlParameter parTags = new SqlParameter("@tags", SqlDbType.VarChar, 50);
            SqlParameter parTitle = new SqlParameter("@title", SqlDbType.VarChar, 50);
            SqlParameter parNoteId = new SqlParameter("@noteId", SqlDbType.Int);

            parNotebookId.Value = note.getNotebookId();
            parUserId.Value = note.getUserId();
            parText.Value = note.getText();
            parTags.Value = note.getTags();
            parTitle.Value = note.getTitle();
            parNoteId.Value = note.getId();
            
            query.Parameters.Add(parNotebookId);
            query.Parameters.Add(parUserId);
            query.Parameters.Add(parText);
            query.Parameters.Add(parTags);
            query.Parameters.Add(parTitle);
            query.Parameters.Add(parNoteId);
            
            Console.WriteLine(query.CommandText);
            try
            {
                this.openCon();
                query.ExecuteScalar();
                this.closeCon();
                
                if(note.getId()>0)
                {
                    List<Note> notes = getNotes(note.getId(),"noteId");
                    return notes.ElementAt(0);
                }                 
                else
                {
                    List<Note> notes = getNotes(note.getUserId(),"userId");
                    return notes.ElementAt(notes.Count-1);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Adding note failed");
                Console.WriteLine(e.Message);
                this.closeCon();
                return note;
            }
        }

        public void insertNotebook(Notebook notebook)
        {
            String sql;
            if (notebook.getId() > 0)
            {
                sql = "UPDATE notebook " +
                             "SET name = @name, description = @description " +
                             "WHERE notebookId = @notebookId";

            }
            else
            {
                sql = "INSERT INTO notebook (userId, name, description)" +
                          "VALUES (@userId, @name, @description)";
            }
            SqlCommand query = new SqlCommand(sql, con);
            SqlParameter parName = new SqlParameter("@name", SqlDbType.VarChar);
            SqlParameter parUserId = new SqlParameter("@userId", SqlDbType.Int);
            SqlParameter parDescription = new SqlParameter("@description", SqlDbType.VarChar);
            SqlParameter parNotebookId = new SqlParameter("@notebookId", SqlDbType.Int);

            parNotebookId.Value = notebook.getId();
            parUserId.Value = notebook.getUserId();
            parName.Value = notebook.getName();
            parDescription.Value = notebook.getDescription();

            query.Parameters.Add(parNotebookId);
            query.Parameters.Add(parUserId);
            query.Parameters.Add(parName);
            query.Parameters.Add(parDescription);

            try
            {
                this.openCon();
                query.ExecuteScalar();
                this.closeCon();
            }
            catch (Exception e)
            {
                Console.WriteLine("Adding note failed");
                Console.WriteLine(e.Message);
                this.closeCon();
            }
        }

        public List<University> returnUniversitys()
        {
            SqlDataReader reader;
            List<University> universitylist = new List<University>();

            SqlCommand query = new SqlCommand("SELECT * FROM university", con);
            this.openCon();
            try
            {
                reader = query.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine("next");
                    University university = new University(Convert.ToInt32(reader["universityId"].ToString()),
                                        reader["name"].ToString(),
                                        reader["location"].ToString());
                    universitylist.Add(university);
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            this.closeCon();
            return universitylist;
        }

        public List<Notebook> getNotebooks(int userId)
        {
            SqlDataReader reader;
            List<Notebook> notebooklist = new List<Notebook>();

            SqlCommand query = new SqlCommand("SELECT * FROM notebook WHERE userId = @userId", con);
            SqlParameter parUserId = new SqlParameter("@userId", SqlDbType.Int);
            parUserId.Value = userId;
            query.Parameters.Add(parUserId);
            this.openCon();
            try
            {
                reader = query.ExecuteReader();

                while (reader.Read())
                {
                    Notebook notebook = new Notebook(Convert.ToInt32(reader["notebookId"].ToString()),
                                        Convert.ToInt32(reader["userId"].ToString()),
                                        reader["name"].ToString(),
                                        reader["description"].ToString());
                    notebooklist.Add(notebook);
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            this.closeCon();
            return notebooklist;
        }

        public List<Note> getNotes(int id, String type)
        {
            SqlDataReader reader;
            List<Note> notelist = new List<Note>();

            SqlCommand query = new SqlCommand("SELECT * FROM note WHERE "+type+" = @id", con);
            SqlParameter parId = new SqlParameter("@id", SqlDbType.Int);
            parId.Value = id;
            query.Parameters.Add(parId);
            this.openCon();
            try
            {
                reader = query.ExecuteReader();

                while (reader.Read())
                {
                    Note note = new Note(Convert.ToInt32(reader["noteId"].ToString()),
                                        reader["text"].ToString(),
                                        reader["title"].ToString(),
                                        reader["tags"].ToString(),
                                        Convert.ToInt32(reader["notebookId"].ToString()),
                                        Convert.ToInt32(reader["userId"].ToString()));
                    notelist.Add(note);
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            this.closeCon();
            return notelist;
        }

        public List<Note> SearchNotes(String keyword)
        {
            SqlDataReader reader;
            List<Note> notelist = new List<Note>();

            SqlCommand query = new SqlCommand("SELECT DISTINCT note.noteId,note.text,note.title,note.tags,note.notebookId,note.userId " +
                                              "FROM note,users WHERE note.tags LIKE '%'+@keyword +'%' "+
                                              "OR note.title LIKE '%'+@keyword +'%' "+
                                              "OR users.username LIKE '%'+@keyword +'%' "+
                                              "AND note.userId = users.userId", con);
            SqlParameter parKeyword = new SqlParameter("@keyword", SqlDbType.VarChar);
            parKeyword.Value = keyword;
            query.Parameters.Add(parKeyword);
            this.openCon();
            try
            {
                reader = query.ExecuteReader();

                while (reader.Read())
                {
                    Note note = new Note(Convert.ToInt32(reader["noteId"].ToString()),
                                        reader["text"].ToString(),
                                        reader["title"].ToString(),
                                        reader["tags"].ToString(),
                                        Convert.ToInt32(reader["notebookId"].ToString()),
                                        Convert.ToInt32(reader["userId"].ToString()));
                    notelist.Add(note);
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            this.closeCon();
            return notelist;
        }

        public bool checkIfFriends(User user1, User user2)
        {
            SqlCommand query = new SqlCommand("SELECT * FROM friends WHERE user1 = @user1 AND user2 = @user2", con);

            SqlParameter parUser1 = new SqlParameter("user1", SqlDbType.Int);
            SqlParameter parUser2 = new SqlParameter("user2", SqlDbType.Int);
            parUser1.Value = user1.getId();
            parUser2.Value = user2.getId();
            query.Parameters.Add(parUser1);
            query.Parameters.Add(parUser2);

            try
            {
                this.openCon();
                SqlDataReader reader;
                reader = query.ExecuteReader();

                if (reader.HasRows)
                {
                    return true;
                }
                this.closeCon();

            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            this.closeCon();
            return false;
            
        }

        public List<User> getFriends(User user)
        {
            SqlDataReader reader;
            List<User> userlist = new List<User>();

            SqlCommand query = new SqlCommand("SELECT user2 FROM friends WHERE user1 = @userId", con);

            SqlParameter parUserId = new SqlParameter("userId", SqlDbType.Int);
            parUserId.Value = user.getId();
            query.Parameters.Add(parUserId);

            this.openCon();
            try
            {
                reader = query.ExecuteReader();
                List<String> ids = new List<String>();
                while (reader.Read())
                {
                    ids.Add(reader["user2"].ToString());
                }
                reader.Close();
                foreach(String s in ids)
                {
                    List<User> users = findUser("userId",s);
                    userlist.Add(users.ElementAt(0));
                }
            }

            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            this.closeCon();
            return userlist;            
        }

        public bool insertFriend(User user1, User user2)
        {
            String sql;
            String sql2;
            sql = "INSERT INTO friends (user1, user2)" +
                      "VALUES (@user1, @user2)";
            sql2 = "INSERT INTO friends (user1, user2)" +
                      "VALUES (@user2, @user1)";
            
            SqlCommand query = new SqlCommand(sql, con);
            SqlCommand query2 = new SqlCommand(sql2, con);
            SqlParameter parUser1 = new SqlParameter("@user1", SqlDbType.Int);
            SqlParameter parUser2 = new SqlParameter("@user2", SqlDbType.Int);
            SqlParameter parUser3 = new SqlParameter("@user1", SqlDbType.Int);
            SqlParameter parUser4 = new SqlParameter("@user2", SqlDbType.Int);

            parUser1.Value = user1.getId();
            parUser2.Value = user2.getId();
            parUser3.Value = user1.getId();
            parUser4.Value = user2.getId();

            query.Parameters.Add(parUser1);
            query.Parameters.Add(parUser2);
            query2.Parameters.Add(parUser3);
            query2.Parameters.Add(parUser4);

            try
            {
                this.openCon();
                query.ExecuteNonQuery();
                query2.ExecuteNonQuery();
                this.closeCon();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Adding friend failed");
                Console.WriteLine(e.Message);
                this.closeCon();
                return false;
            }
        }
        
    }


    
}
