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
        public RegisterWindow()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {

        }

        private Boolean validate()
        {
            Boolean valid = true;

            if (passwordField.Text.Length < 6)
            {
                valid = false;
            }

            return valid;
        }
    }
}
