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
    public partial class friendWindow : Form
    {
        User currentUser;
        User friend;
        SQLconnect data = new SQLconnect();
        public friendWindow(User currentUser, User friend)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            this.friend = friend;
            this.Text = "User: "+currentUser.getUsername();
            loadFields();
        }

        private void loadFields()
        {
            this.FirstnameField.Text = friend.getFirstname();
            this.usernameLabel.Text = friend.getUsername();
            this.LastnameField.Text = friend.getLastname();
            this.EmailField.Text = friend.getEmail();
            if (data.checkIfFriends(currentUser, friend))
            {
                friendsCheck.Checked = true;
            }
            else
            {
                friendsCheck.Checked = false;
            }
            List<University> unis = data.returnUniversitys();
            String uniname = "";
            foreach (University u in unis)
            {
                if (u.getUniversityId() == friend.getUniversityId())
                {
                    uniname = u.getName();
                }
            }
            this.universityField.Text = uniname;
        }

        private void friendButton_Click(object sender, EventArgs e)
        {
            if (friendsCheck.Checked)
            {
                MessageBox.Show("You already are friends");
            }
            else
            {
                if (data.insertFriend(currentUser, friend))
                {
                    MessageBox.Show("Friend added");
                    friendsCheck.Checked = true;
                }
                else
                {
                    friendsCheck.Checked = false;
                }
            }

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
