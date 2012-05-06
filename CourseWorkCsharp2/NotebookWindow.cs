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
    public partial class NotebookWindow : Form
    {
        User currentUser;
        Notebook currentNotebook;
        SQLconnect data = new SQLconnect();
        public NotebookWindow(User user)
        {
            InitializeComponent();
            this.currentUser = user;
            this.currentNotebook = new Notebook(0, currentUser.getId(), "", "");
        }

        public NotebookWindow(Notebook notebook, User user)
        {
            this.currentNotebook = notebook;
            this.currentUser = user;
            InitializeComponent();
            loadFields();
        }

        private void loadFields()
        {
            this.nameField.Text = currentNotebook.getName();
            this.descriptionField.Text = currentNotebook.getDescription();
            List<Note> notes = data.getNotes(currentNotebook.getId(), "notebookId");
            this.noNotesfield.Text = notes.Count.ToString();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            data.insertNotebook(new Notebook(currentNotebook.getId(), currentNotebook.getUserId(), this.nameField.Text, this.descriptionField.Text));
            this.Close();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
