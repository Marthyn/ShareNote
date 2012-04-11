using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CourseWorkCsharp2
{
    class User
    {
        private int id;
        private String username;
        private String firstname;
        private String lastname;
        private String email;
        private String password;

        public User()
        {

        }

        public User(String username, int id, String firstname, String lastname, String email, String password)
        {
            this.username = username;
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
            this.email = email;
            this.password = password ;
        }

        public int getId()
        {
            return id;
        }

        public String getUsername()
        {
            return username;
        }

        public String getFirstname()
        {
            return firstname;
        }

        public String getLastname()
        {
            return lastname;
        }

        public String getEmail()
        {
            return email;
        }

        public String getPassword()
        {
            return password;
        }
    }
}
