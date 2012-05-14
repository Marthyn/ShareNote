using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CourseWorkCsharp2
{
    public partial class UserWindowedit : Form
    {
        User currentUser;
        SQLconnect data = new SQLconnect();
        public UserWindowedit(User user)
        {
            InitializeComponent();
            int i = 0;
            this.currentUser = user;
            loadFields();
            List<University> universitys = data.returnUniversitys();
            foreach (University u in universitys)
            {
                this.UniversityField.Items.Add(u);
                if (this.currentUser.getUniversityId() == u.getUniversityId())
                {
                    this.UniversityField.SelectedItem = this.UniversityField.Items[i];
                }
                i++;
            }
        }

        private void loadFields()
        {
            this.FirstnameField.Text = currentUser.getFirstname();
            this.usernameLabel.Text = currentUser.getUsername();
            this.LastnameField.Text = currentUser.getLastname();
            this.EmailField.Text = currentUser.getEmail();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                University uni = (University)this.UniversityField.SelectedItem;
                String password;
                if (!newPasswordfield.Text.Equals(""))
                {
                    password = newPasswordfield.Text;
                }
                else
                {
                    password = passwordField.Text;
                }
                data.addUser(new User(currentUser.getUsername(), currentUser.getId(),
                                 this.FirstnameField.Text, this.LastnameField.Text, this.EmailField.Text,
                                 password, uni.getUniversityId()));
                MessageBox.Show("Your profile has been succesfully updated", "User updated");
                List<User> users = data.findUser("userId", currentUser.getId().ToString());
                this.currentUser = users.ElementAt(0);
                loadFields();
            }
        }

        private bool validate()
        {
            Boolean valid = true;
            String errors = "";
            
            if(!passwordField.Text.Equals(currentUser.getPassword()))
            {
                valid = false;
                errors = errors + "Old password is not correct";
            }
            if (!newPasswordfield.Text.Equals(""))
            {
                if (this.newPasswordfield.Text.Length < 6)
                {
                    valid = false;
                    errors = errors + "Password is too short \r\n";
                }
                if(!newPasswordfield.Text.Equals(newPasswordField2.Text))
                {
                    valid = false;
                    errors = errors + "New Passwords are not equal \r\n";
                }
            }

            if (!errors.Equals(""))
            {
                MessageBox.Show(errors);
            }
            return valid;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
