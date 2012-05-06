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
    public partial class MainWindow : Form
    {
        User currentUser;
        SQLconnect data;
        public MainWindow(User currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            data = new SQLconnect();
            loadNotebooks();
            loadNotes(currentUser.getId(), "userId");
        }

        public void MainWindow_GotFocus(object sender, EventArgs e)
        {
            loadNotebooks();
            this.searchbar.Text = "";
            loadNotes(currentUser.getId(), "userId"); 
        }


        private void loadNotebooks()
        {
            notebooklist.Items.Clear();
            List<Notebook> notebooks = data.getNotebooks(currentUser.getId());
            foreach (Notebook n in notebooks)
            {
                notebooklist.Items.Add(n);
            }
            notebooklist.Items.Add(new Notebook(0, currentUser.getId(), "All Notes", "none"));
        }

        private void loadNotes(int id, String type)
        {
            NotesList.Items.Clear();
            NotesTagList.Items.Clear();
            NotesOwnerList.Items.Clear();
            List<Note> notes = data.getNotes(id, type);
            foreach (Note n in notes)
            {
                NotesList.Items.Add(n);
                NotesTagList.Items.Add(n.getTags());
                List<User> users = data.findUser("userId", n.getUserId().ToString());
                NotesOwnerList.Items.Add(users.ElementAt(0));
                
            }
        }

        private void loadNotes(String keyword)
        {
            NotesList.Items.Clear();
            NotesTagList.Items.Clear();
            NotesOwnerList.Items.Clear();
            List<Note> notes = data.SearchNotes(keyword);
            foreach (Note n in notes)
            {
                NotesList.Items.Add(n);
                NotesTagList.Items.Add(n.getTags());
                List<User> users = data.findUser("userId", n.getUserId().ToString());
                NotesOwnerList.Items.Add(users.ElementAt(0));
            }
        }

      

        private void notebooklist_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Notebook notebook = (Notebook)notebooklist.SelectedItem;
            if (notebook != null)
            {
                if (notebook.getId() == 0)
                {
                    loadNotes(currentUser.getId(), "userId");
                }
                else
                {
                    loadNotes(notebook.getId(), "notebookId");
                }
            }
        }

        private void NotesList_DoubleClick(object sender, EventArgs e)
        {
            Note note = (Note)NotesList.SelectedItem;
            if (note != null)
            {
                WriteNote writeWindow = new WriteNote(note, currentUser);
                writeWindow.ShowDialog();
            }
        }

        private void notebookList_DoubleClick(object sender, EventArgs e)
        {
            Notebook notebook = (Notebook)notebooklist.SelectedItem;
            if (notebook != null || notebook.getId() != 0)
            {
                NotebookWindow notebookwindow = new NotebookWindow(notebook, currentUser);
                notebookwindow.ShowDialog();
            }
        }

        private void EqualSelectedTitle(object sender, EventArgs e)
        {
            int i = this.NotesList.SelectedIndex;
            if (i >= 0)
            {
                this.NotesOwnerList.SetSelected(i, true);
                this.NotesTagList.SetSelected(i, true);
            }
        }
        private void EqualSelectedTag(object sender, EventArgs e)
        {
            int i = this.NotesTagList.SelectedIndex;
            if (i >= 0)
            {
                this.NotesList.SetSelected(i, true);
                this.NotesOwnerList.SetSelected(i, true);
            }
        }
        private void EqualSelectedOwner(object sender, EventArgs e)
        {
            int i = this.NotesOwnerList.SelectedIndex;
            if (i >= 0)
            {
                this.NotesList.SetSelected(i, true);
                this.NotesTagList.SetSelected(i, true);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WriteNote writewindow = new WriteNote(this.currentUser);
            writewindow.ShowDialog();
        }

        private void newNotebookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NotebookWindow notebookwindow = new NotebookWindow(currentUser);
            notebookwindow.ShowDialog();
        }

        private void searchbar_Enter(object sender, EventArgs e)
        {
            loadNotes(this.searchbar.Text);
        }

        private void searchbar_click(object sender, EventArgs e)
        {
            this.searchbar.Text = "";
        }

        private void myProfileInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserWindowedit edit = new UserWindowedit(currentUser);
            edit.ShowDialog();
        }
    }

   
}
