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
    public partial class SearchFriend : Form
    {
        User currentUser;
        SQLconnect data = new SQLconnect();
        public SearchFriend(User currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
        }

        private void searchbar_Enter(object sender, EventArgs e)
        {
            loadUsers(this.searchBar.Text);
        }

        private void Users_MouseDoubleClick(object sender, EventArgs e)
        {
            User user = (User)Users.SelectedItem;
            if (user != null)
            {
                friendWindow friends = new friendWindow(currentUser, user);
                friends.ShowDialog();
            }
        }

        private void searchbar_click(object sender, EventArgs e)
        {
            this.searchBar.Text = "";
        }
        private void searchGainFocus(object sender, EventArgs e)
        {
            this.searchBar.Text = "search by username";
        }

        private void loadUsers(String q)
        {
            Users.Items.Clear();
            List<User> users = data.searchUser("username",q);
            foreach (User u in users)
            {
                Users.Items.Add(u);
            }
        }


    }
}
