using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CourseWorkCsharp2
{
    public class User
    {
        private int id;
        private String username;
        private String firstname;
        private String lastname;
        private String email;
        private String password;
        private int universityId;

        public User()
        {

        }

        public User(String username, int id, String firstname, String lastname, String email, String password, int universityId)
        {
            this.username = username;
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
            this.email = email;
            this.password = password ;
            this.universityId = universityId;
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

        public int getUniversityId()
        {
            return universityId;
        }

        public override string ToString()
        {
            return username;
        }
    }
}
