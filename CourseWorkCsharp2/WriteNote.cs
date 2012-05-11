using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CourseWorkCsharp2
{
    public partial class WriteNote : Form
    {
        Note currentNote;
        User currentUser;
        SQLconnect data;
        public WriteNote(User currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            this.currentNote = new Note(0, this.noteText.Rtf, this.tagsBox.Text, this.titleBox.Text, 0, currentUser.getId());
            data = new SQLconnect();
            loadNotebooks();
            
        }
        
        public WriteNote(Note note, User currentUser)
        {
            data = new SQLconnect();
            InitializeComponent();
            this.currentNote = note;
            this.currentUser = currentUser;
            loadNotebooks();
            updateFields();
            
        }

        private void loadNotebooks()
        {
            int i = 0;
            this.notebooksBox.Items.Clear();
            List<Notebook> notebooks = data.getNotebooks(currentUser.getId());
            foreach (Notebook n in notebooks)
            {
                this.notebooksBox.Items.Add(n);
                if (this.currentNote.getNotebookId() == n.getId())
                {
                    this.notebooksBox.SelectedItem = this.notebooksBox.Items[i];
                }
                i++;
            }

        }

        private void updateFields()
        {
            this.noteText.Rtf = currentNote.getText();
            this.tagsBox.Text = currentNote.getTags();
            this.titleBox.Text = currentNote.getTitle();
            loadNotebooks();
        }
        public void WriteNote_FormClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!currentNote.getText().Equals(this.noteText.Rtf))
            {
                DialogResult = MessageBox.Show("Do you want to save changes to your text?", "My Application",
                                    MessageBoxButtons.YesNoCancel);
                if (DialogResult == DialogResult.Yes)
                {
                    if (currentNote.getUserId() == currentUser.getId() )
                    {
                        if (validate())
                        {
                            save();
                        }
                    }
                    else
                    {
                        MessageBox.Show("You cannot save a note from someone else, choose save as own");
                        e.Cancel = true;
                    }
                }
                if(DialogResult == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
                
            }
        }

        public void save()
        {
            Notebook notebook = (Notebook)this.notebooksBox.SelectedItem;
            this.currentNote = data.insertNote(new Note(currentNote.getId(), this.noteText.Rtf, this.titleBox.Text, this.tagsBox.Text, notebook.getId(), currentUser.getId()));
            updateFields();
        }

        private void fontChanged(object sender, EventArgs e)
        {
            Font oldfont, newfont;
            int i = this.fontBox.SelectedIndex;
            switch (i)
            {
                //normal
                case 0:
                    oldfont = this.noteText.SelectionFont;
                    newfont = new Font(oldfont.FontFamily, 8);
                    this.noteText.SelectionFont = newfont;
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
                case 4:
                    oldfont = this.noteText.SelectionFont;
                    newfont = new Font(oldfont.FontFamily, 10);
                    this.noteText.SelectionFont = newfont;
                break;
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

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentNote.getUserId() == currentUser.getId())
            {
                if (validate())
                {
                    save();
                }
            }
            else
            {
                MessageBox.Show("You cannot save a note from someone else, choose save as own");
            }
        }

        private void saveAndCloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentNote.getUserId() == currentUser.getId())
            {
                if (validate())
                {
                    save();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("You cannot save a note from someone else, choose save as own");
            }
        }

        private void closeWithoutSavingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveAsOwnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                currentNote.setId(0);
                save();
            }
        }

        private bool validate()
        {
            bool valid = true;
            String error = "";
            if (this.noteText.Text.Equals(""))
            {
                valid = false;
                error = error + "You haven't entered any text \r\n";
            }
            if (this.titleBox.Text.Equals(""))
            {
                valid = false;
                error = error + "You haven't entered a title \r\n";
            }
            if (this.notebooksBox.SelectedItem == null)
            {
                valid = false;
                error = error + "You must select a notebook \r\n";
            }
            if (!valid)
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            return valid;
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Console.WriteLine(Directory.GetCurrentDirectory());
            Help.ShowHelp(this, "C:\\Users\\Marthyn\\Documents\\Visual Studio 2010\\Projects\\CourseWorkCsharp2\\CourseWorkCsharp2\\resources\\help.chm", HelpNavigator.Find, "create note"); 
        }

    }
}
