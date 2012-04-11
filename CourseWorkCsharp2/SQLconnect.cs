using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;


namespace CourseWorkCsharp2
{
    class SQLconnect
    {
        SqlConnection con;

        public SQLconnect()
        {
            try
            {
                con = new SqlConnection("user id=username;" +
                                    "password=password;server=localhost;" +
                                    "Trusted_Connection=yes;" +
                                    "database=database; " +
                                    "connection timeout=30");
            }
            catch (Exception e)
            {
                Console.WriteLine("Connection failed");
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
            Console.WriteLine("arrived at checklogin");
            List<User> users = this.findUser("username", username);
            Console.WriteLine("found users");
            if (users.Count == 1)
            {
                User user = users.ElementAt(0);
                if (user.getPassword() == password)
                {
                    return true;
                }
            }
            return false;
        }

        public void addUser(String username, String email, String firstname, String surname, String password)
        {
            SqlParameter parUsername = new SqlParameter("@username", SqlDbType.VarChar);
            SqlParameter parEmail = new SqlParameter("@email", SqlDbType.VarChar);
            SqlParameter parFirstname = new SqlParameter("@firstname", SqlDbType.VarChar);
            SqlParameter parSurname = new SqlParameter("@surname", SqlDbType.VarChar);
            SqlParameter parPassword = new SqlParameter("@password", SqlDbType.VarChar);
            parUsername.Value = username;
            parEmail.Value = email;
            parFirstname.Value = firstname;
            parSurname.Value = surname;
            parPassword.Value = password;

            
            this.openCon();
            SqlCommand query = new SqlCommand("INSERT INTO users (username, email, firstname, surname, password) VALUES (@username, @email, @firstname, @surname, @password)");
            query.Parameters.Add(parUsername);
            query.Parameters.Add(parEmail);
            query.Parameters.Add(parFirstname);
            query.Parameters.Add(parSurname);
            query.Parameters.Add(parPassword);
            
            try
            {
                query.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine("Adding user failed");
            }
            this.closeCon();
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

        public List<User> findUser(String column, String searchQ)
        {
            SqlDataReader reader;
            List<User> userlist = new List<User>();

            SqlParameter parColumn = new SqlParameter("@Column", SqlDbType.VarChar);
            SqlParameter parSearchQ = new SqlParameter("@searchQ", SqlDbType.VarChar);
            parColumn.Value = column;
            parSearchQ.Value = searchQ;

            Console.WriteLine("Opening connection now");
            this.openCon();
            SqlCommand query = new SqlCommand("SELECT * FROM users WHERE @Column = @searchQ LIMIT 1", con);
            query.Parameters.Add(parColumn);
            query.Parameters.Add(parSearchQ);

            reader = query.ExecuteReader();
            while(reader.Read())
            {
                Console.WriteLine("next");
                User user = new User(reader["username"].ToString(), 
                                    Convert.ToInt32(reader["id"].ToString()), 
                                    reader["firstname"].ToString(), 
                                    reader["lastname"].ToString(), 
                                    reader["email"].ToString(),
                                    reader["password"].ToString());
                userlist.Add(user);
            }
            this.closeCon();
            return userlist;            
        }
    }
}
