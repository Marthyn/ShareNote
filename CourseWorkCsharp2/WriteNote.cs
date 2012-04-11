using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ShareNote
{
    public partial class WriteNote : Form
    {
        public WriteNote()
        {
            InitializeComponent();
        }

        private void fontChanged(object sender, EventArgs e)
        {
            int i = this.fontBox.SelectedIndex;
            switch(i)
            {
                case 0:

                break;

                case 1:
                this.noteText.SelectionFont.SizeInPoints = 20;

        }
    }
}
