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
    public partial class WriteNote : Form
    {
        public WriteNote()
        {
            InitializeComponent();
        }

        private void fontChanged(object sender, EventArgs e)
        {
            Font oldfont, newfont;
            int i = this.fontBox.SelectedIndex;
            switch (i)
            {
                //normal
                case 0:

                    break;
                //title 1
                case 1:
                    oldfont = this.noteText.SelectionFont;
                    newfont = new Font(oldfont.FontFamily, 20);
                    this.noteText.SelectionFont = newfont;
                break;

                //title 2
                case 2:
                    oldfont = this.noteText.SelectionFont;
                    newfont = new Font(oldfont.FontFamily, 18);
                    this.noteText.SelectionFont = newfont;
                break;

                //title 3
                case 3:
                    oldfont = this.noteText.SelectionFont;
                    newfont = new Font(oldfont.FontFamily, 16);
                    this.noteText.SelectionFont = newfont;
                break;

                //Paragraph
            }

        }

        private void boldButton_Click(object sender, EventArgs e)
        {
            Font oldFont, newFont;

            oldFont = this.noteText.SelectionFont;

            if (oldFont.Bold)
            {
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Bold);
            }
            else
            {
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Bold);
            }

            this.noteText.SelectionFont = newFont;
            this.noteText.Focus();
        }

        private void italicButton_Click(object sender, EventArgs e)
        {
            Font oldFont, newFont;

            oldFont = this.noteText.SelectionFont;

            if (oldFont.Italic)
            {
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Italic);
            }
            else
            {
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Italic);
            }

            this.noteText.SelectionFont = newFont;
            this.noteText.Focus();
        }

        private void buttonUnderline_Click(object sender, EventArgs e)
        {
            Font oldFont, newFont;

            oldFont = this.noteText.SelectionFont;

            if (oldFont.Underline)
            {
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Underline);
            }
            else
            {
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Underline);
            }

            this.noteText.SelectionFont = newFont;
            this.noteText.Focus();
        }

    }
}
