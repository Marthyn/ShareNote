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
    public partial class RegisterWindow : Form
    {
        SQLconnect data;
        String errors;
        public RegisterWindow()
        {
            InitializeComponent();
            data = new SQLconnect();
            List<University> universitys = data.returnUniversitys();
            foreach(University u in universitys)
            {
                universityBox.Items.Add(u);                
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                University uni = (University)universityBox.SelectedItem;
                if (data.addUser(new User(userNameField.Text, 0, firtnameField.Text, surnameField.Text, emailField.Text, passwordField.Text, uni.getUniversityId())))
                {
                    MessageBox.Show("You've successfully registered, you can now log in");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Something went wrong, try again");
                }
            }
        }

        private Boolean validate()
        {
            Boolean valid = true;
            errors = "";
            if (passwordField.Text.Length < 6)
            {
                valid = false;
                errors = errors + "Password is too short \r\n";
            }
            if (data.findUser("username",userNameField.Text).Count > 0)
            {
                valid = false;
                errors = errors + "Username already exists \r\n";
            }

            if (!errors.Equals(""))
            {
                MessageBox.Show(errors);
            }
            return valid;
        }
    }
}
