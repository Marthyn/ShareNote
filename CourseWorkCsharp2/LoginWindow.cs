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
    public partial class LoginWindow : Form
    {
        SQLconnect SQL = null;
        public LoginWindow()
        {
            InitializeComponent();
            SQL = new SQLconnect();
        }

    
        private void RegisterLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterWindow registerWindow = new RegisterWindow();
            registerWindow.ShowDialog();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            String username = this.usernameField.Text;
            String password = this.passwordField.Text;


            if (SQL.checkLogin(username, password))
            {
                List<User> users = SQL.findUser("username", username);
                User user = users.ElementAt(0);
                MainWindow mainWindow = new MainWindow(user);
                mainWindow.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Your account details were not found or incorrect, please try again", "Login error");
                
            }

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by Marthyn Olthof", "About this program");
        }
    }
}
