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
            WriteNote writenotewindow = new WriteNote();
            writenotewindow.ShowDialog();
            /*
            if (SQL.checkLogin(username, password))
            {
                MessageBox.Show("Login succesful");
                
            }
            else
            {
                MessageBox.Show("Login failed");
                
            }
             */
        }
    }
}
