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
                    MessageBox.Show("You've successfully registered, you can now log in", "Login succesfull");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Something went wrong, please try again or contact the helpdesk at help@sharenote.com","Register error");
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
                errors = errors + "The password you've entered is too short, it should be more than 6 signs long \r\n";
            }
            if (data.findUser("username",userNameField.Text).Count > 0)
            {
                valid = false;
                errors = errors + "The username you've chosen already exists, please chose another username \r\n";
            }

            if (!errors.Equals(""))
            {
                MessageBox.Show(errors,"Register error");
            }
            return valid;
        }
    }
}
