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
            loadFriends();
            loadNotes(currentUser.getId(), "userId");
        }

        public void MainWindow_GotFocus(object sender, EventArgs e)
        {
            loadNotebooks();
            loadFriends();
            loadNotes(currentUser.getId(), "userId"); 
        }

        private void loadFriends()
        {
            this.friendsList.Items.Clear();
            List<User> friends = data.getFriends(currentUser);
            foreach (User f in friends)
            {
                friendsList.Items.Add(f);
            }
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

        private void friendList_SelectedIndexChanged(object sender, EventArgs e)
        {

            User user = (User)friendsList.SelectedItem;
            if (user != null)
            {
                loadNotes(user.getId(), "userId");
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

        private void FriendsList_DoubleClick(object sender, EventArgs e)
        {
            User user = (User)friendsList.SelectedItem;
            if (user != null)
            {
                friendWindow friends = new friendWindow(currentUser, user);
                friends.ShowDialog();
            }
        }


        private void NotesOwnerList_DoubleClick(object sender, EventArgs e)
        {
            User user = (User)NotesOwnerList.SelectedItem;
            if (user != null)
            {
                friendWindow friends = new friendWindow(currentUser, user);
                friends.ShowDialog();
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
        private void searchGainFocus(object sender, EventArgs e)
        {
            this.searchbar.Text = "search";
        }

        private void myProfileInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserWindowedit edit = new UserWindowedit(currentUser);
            edit.ShowDialog();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void addFriendIcon_Click(object sender, EventArgs e)
        {
            SearchFriend friendwindow = new SearchFriend(this.currentUser);
            friendwindow.ShowDialog();
        }

        private void addNoteIcon_Click(object sender, EventArgs e)
        {
            WriteNote writewindow = new WriteNote(this.currentUser);
            writewindow.ShowDialog();
        }

        private void addNotebookIcon_Click(object sender, EventArgs e)
        {
            NotebookWindow notebookwindow = new NotebookWindow(currentUser);
            notebookwindow.ShowDialog();
        }

        private void editProfileIcon_Click(object sender, EventArgs e)
        {
            UserWindowedit edit = new UserWindowedit(currentUser);
            edit.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Note note = (Note)NotesList.SelectedItem;
            if (note != null)
            {
                WriteNote writeWindow = new WriteNote(note, currentUser);
                writeWindow.ShowDialog();
            }
        }



        private void helpToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:\\Users\\Marthyn\\Documents\\Visual Studio 2010\\Projects\\CourseWorkCsharp2\\CourseWorkCsharp2\\resources\\help.chm", HelpNavigator.Find, "create note");
        }

   



       
    }

   
}
