namespace CourseWorkCsharp2
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newNotebookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFriendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myProfileInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notebooklist = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NotesList = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.NotesTagList = new System.Windows.Forms.ListBox();
            this.NotesOwnerList = new System.Windows.Forms.ListBox();
            this.Notes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.searchbar = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newNoteToolStripMenuItem,
            this.newNotebookToolStripMenuItem,
            this.addFriendToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newNoteToolStripMenuItem
            // 
            this.newNoteToolStripMenuItem.Name = "newNoteToolStripMenuItem";
            this.newNoteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newNoteToolStripMenuItem.Text = "New note";
            this.newNoteToolStripMenuItem.Click += new System.EventHandler(this.newNoteToolStripMenuItem_Click);
            // 
            // newNotebookToolStripMenuItem
            // 
            this.newNotebookToolStripMenuItem.Name = "newNotebookToolStripMenuItem";
            this.newNotebookToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newNotebookToolStripMenuItem.Text = "New notebook";
            this.newNotebookToolStripMenuItem.Click += new System.EventHandler(this.newNotebookToolStripMenuItem_Click);
            // 
            // addFriendToolStripMenuItem
            // 
            this.addFriendToolStripMenuItem.Name = "addFriendToolStripMenuItem";
            this.addFriendToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addFriendToolStripMenuItem.Text = "Add friend";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myProfileInfoToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // myProfileInfoToolStripMenuItem
            // 
            this.myProfileInfoToolStripMenuItem.Name = "myProfileInfoToolStripMenuItem";
            this.myProfileInfoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.myProfileInfoToolStripMenuItem.Text = "My profile info";
            this.myProfileInfoToolStripMenuItem.Click += new System.EventHandler(this.myProfileInfoToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // notebooklist
            // 
            this.notebooklist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.notebooklist.BackColor = System.Drawing.Color.WhiteSmoke;
            this.notebooklist.FormattingEnabled = true;
            this.notebooklist.Location = new System.Drawing.Point(6, 91);
            this.notebooklist.Name = "notebooklist";
            this.notebooklist.Size = new System.Drawing.Size(192, 355);
            this.notebooklist.TabIndex = 2;
            this.notebooklist.SelectedIndexChanged += new System.EventHandler(this.notebooklist_SelectedIndexChanged);
            this.notebooklist.DoubleClick += new System.EventHandler(this.notebookList_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Notebooks";
            // 
            // NotesList
            // 
            this.NotesList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.NotesList.BackColor = System.Drawing.Color.Beige;
            this.NotesList.FormattingEnabled = true;
            this.NotesList.Location = new System.Drawing.Point(203, 91);
            this.NotesList.MultiColumn = true;
            this.NotesList.Name = "NotesList";
            this.NotesList.Size = new System.Drawing.Size(180, 355);
            this.NotesList.TabIndex = 4;
            this.NotesList.Click += new System.EventHandler(this.EqualSelectedTitle);
            this.NotesList.DoubleClick += new System.EventHandler(this.NotesList_DoubleClick);
            // 
            // listBox3
            // 
            this.listBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(808, 91);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(195, 355);
            this.listBox3.TabIndex = 5;
            // 
            // NotesTagList
            // 
            this.NotesTagList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NotesTagList.BackColor = System.Drawing.Color.Beige;
            this.NotesTagList.FormattingEnabled = true;
            this.NotesTagList.Location = new System.Drawing.Point(382, 91);
            this.NotesTagList.MultiColumn = true;
            this.NotesTagList.Name = "NotesTagList";
            this.NotesTagList.Size = new System.Drawing.Size(261, 355);
            this.NotesTagList.TabIndex = 6;
            this.NotesTagList.Click += new System.EventHandler(this.EqualSelectedTag);
            this.NotesTagList.DoubleClick += new System.EventHandler(this.NotesList_DoubleClick);
            // 
            // NotesOwnerList
            // 
            this.NotesOwnerList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NotesOwnerList.BackColor = System.Drawing.Color.Beige;
            this.NotesOwnerList.FormattingEnabled = true;
            this.NotesOwnerList.Location = new System.Drawing.Point(642, 91);
            this.NotesOwnerList.MultiColumn = true;
            this.NotesOwnerList.Name = "NotesOwnerList";
            this.NotesOwnerList.Size = new System.Drawing.Size(160, 355);
            this.NotesOwnerList.TabIndex = 7;
            this.NotesOwnerList.Click += new System.EventHandler(this.EqualSelectedOwner);
            this.NotesOwnerList.DoubleClick += new System.EventHandler(this.NotesList_DoubleClick);
            // 
            // Notes
            // 
            this.Notes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Notes.AutoSize = true;
            this.Notes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Notes.Location = new System.Drawing.Point(477, 50);
            this.Notes.Name = "Notes";
            this.Notes.Size = new System.Drawing.Size(53, 18);
            this.Notes.TabIndex = 8;
            this.Notes.Text = "Notes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(269, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Title";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(705, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Owner";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(488, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tags";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(895, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Friends";
            // 
            // searchbar
            // 
            this.searchbar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.searchbar.Location = new System.Drawing.Point(234, 27);
            this.searchbar.Name = "searchbar";
            this.searchbar.Size = new System.Drawing.Size(538, 20);
            this.searchbar.TabIndex = 13;
            this.searchbar.Text = "search";
            this.searchbar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchbar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.searchbar_click);
            this.searchbar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchbar_Enter);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1008, 460);
            this.Controls.Add(this.searchbar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Notes);
            this.Controls.Add(this.NotesOwnerList);
            this.Controls.Add(this.NotesTagList);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.NotesList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.notebooklist);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1023, 449);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.Activated += new System.EventHandler(this.MainWindow_GotFocus);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ListBox notebooklist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox NotesList;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox NotesTagList;
        private System.Windows.Forms.ListBox NotesOwnerList;
        private System.Windows.Forms.Label Notes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newNotebookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFriendToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myProfileInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TextBox searchbar;
    }
}