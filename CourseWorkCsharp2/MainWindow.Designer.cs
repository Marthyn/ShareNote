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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newNotebookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFriendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myProfileInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notebooklist = new System.Windows.Forms.ListBox();
            this.notebookLabel = new System.Windows.Forms.Label();
            this.NotesList = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.readToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.friendsList = new System.Windows.Forms.ListBox();
            this.NotesTagList = new System.Windows.Forms.ListBox();
            this.NotesOwnerList = new System.Windows.Forms.ListBox();
            this.NotesLabel = new System.Windows.Forms.Label();
            this.friendsLabel = new System.Windows.Forms.Label();
            this.searchbar = new System.Windows.Forms.TextBox();
            this.addFriendIcon = new System.Windows.Forms.PictureBox();
            this.addNotebookIcon = new System.Windows.Forms.PictureBox();
            this.addNoteIcon = new System.Windows.Forms.PictureBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.editProfileIcon = new System.Windows.Forms.PictureBox();
            this.helpIcon = new System.Windows.Forms.PictureBox();
            this.notesTitleTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.menuBar.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addFriendIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addNotebookIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addNoteIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editProfileIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(1008, 24);
            this.menuBar.TabIndex = 1;
            this.menuBar.Text = "menuStrip1";
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
            this.addFriendToolStripMenuItem.Click += new System.EventHandler(this.addFriendToolStripMenuItem_Click);
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
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click_1);
            // 
            // notebooklist
            // 
            this.notebooklist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.notebooklist.BackColor = System.Drawing.SystemColors.ControlDark;
            this.notebooklist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notebooklist.FormattingEnabled = true;
            this.notebooklist.ItemHeight = 15;
            this.notebooklist.Location = new System.Drawing.Point(6, 99);
            this.notebooklist.Name = "notebooklist";
            this.notebooklist.Size = new System.Drawing.Size(195, 409);
            this.notebooklist.TabIndex = 2;
            this.notesTitleTooltip.SetToolTip(this.notebooklist, "Title of notebooks, double click to edit notebook, single click to show notes");
            this.notebooklist.SelectedIndexChanged += new System.EventHandler(this.notebooklist_SelectedIndexChanged);
            this.notebooklist.DoubleClick += new System.EventHandler(this.notebookList_DoubleClick);
            // 
            // notebookLabel
            // 
            this.notebookLabel.AutoSize = true;
            this.notebookLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notebookLabel.Location = new System.Drawing.Point(2, 74);
            this.notebookLabel.Name = "notebookLabel";
            this.notebookLabel.Size = new System.Drawing.Size(95, 20);
            this.notebookLabel.TabIndex = 3;
            this.notebookLabel.Text = "Notebooks";
            // 
            // NotesList
            // 
            this.NotesList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.NotesList.BackColor = System.Drawing.Color.White;
            this.NotesList.ContextMenuStrip = this.contextMenuStrip1;
            this.NotesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotesList.FormattingEnabled = true;
            this.NotesList.ItemHeight = 15;
            this.NotesList.Location = new System.Drawing.Point(205, 99);
            this.NotesList.MultiColumn = true;
            this.NotesList.Name = "NotesList";
            this.NotesList.Size = new System.Drawing.Size(200, 409);
            this.NotesList.TabIndex = 4;
            this.notesTitleTooltip.SetToolTip(this.NotesList, "Title of note, double click to open note");
            this.NotesList.Click += new System.EventHandler(this.EqualSelectedTitle);
            this.NotesList.DoubleClick += new System.EventHandler(this.NotesList_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readToolStripMenuItem,
            this.editToolStripMenuItem1,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 70);
            // 
            // readToolStripMenuItem
            // 
            this.readToolStripMenuItem.Name = "readToolStripMenuItem";
            this.readToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.readToolStripMenuItem.Text = "Read";
            this.readToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.editToolStripMenuItem1.Text = "Edit";
            this.editToolStripMenuItem1.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // friendsList
            // 
            this.friendsList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.friendsList.BackColor = System.Drawing.SystemColors.ControlDark;
            this.friendsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friendsList.FormattingEnabled = true;
            this.friendsList.ItemHeight = 15;
            this.friendsList.Location = new System.Drawing.Point(808, 99);
            this.friendsList.Name = "friendsList";
            this.friendsList.Size = new System.Drawing.Size(195, 409);
            this.friendsList.TabIndex = 5;
            this.notesTitleTooltip.SetToolTip(this.friendsList, "List of friends, double click to open user");
            this.friendsList.SelectedIndexChanged += new System.EventHandler(this.friendList_SelectedIndexChanged);
            this.friendsList.DoubleClick += new System.EventHandler(this.FriendsList_DoubleClick);
            // 
            // NotesTagList
            // 
            this.NotesTagList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.NotesTagList.BackColor = System.Drawing.Color.White;
            this.NotesTagList.ContextMenuStrip = this.contextMenuStrip1;
            this.NotesTagList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotesTagList.FormattingEnabled = true;
            this.NotesTagList.ItemHeight = 15;
            this.NotesTagList.Location = new System.Drawing.Point(404, 99);
            this.NotesTagList.MultiColumn = true;
            this.NotesTagList.Name = "NotesTagList";
            this.NotesTagList.Size = new System.Drawing.Size(200, 409);
            this.NotesTagList.TabIndex = 6;
            this.notesTitleTooltip.SetToolTip(this.NotesTagList, "Tags of note, double click to open note");
            this.NotesTagList.Click += new System.EventHandler(this.EqualSelectedTag);
            this.NotesTagList.DoubleClick += new System.EventHandler(this.NotesList_DoubleClick);
            // 
            // NotesOwnerList
            // 
            this.NotesOwnerList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.NotesOwnerList.BackColor = System.Drawing.Color.White;
            this.NotesOwnerList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotesOwnerList.FormattingEnabled = true;
            this.NotesOwnerList.ItemHeight = 15;
            this.NotesOwnerList.Location = new System.Drawing.Point(603, 99);
            this.NotesOwnerList.MultiColumn = true;
            this.NotesOwnerList.Name = "NotesOwnerList";
            this.NotesOwnerList.Size = new System.Drawing.Size(200, 409);
            this.NotesOwnerList.TabIndex = 7;
            this.notesTitleTooltip.SetToolTip(this.NotesOwnerList, "Owner of note, double click to open user");
            this.NotesOwnerList.Click += new System.EventHandler(this.EqualSelectedOwner);
            this.NotesOwnerList.DoubleClick += new System.EventHandler(this.NotesOwnerList_DoubleClick);
            // 
            // NotesLabel
            // 
            this.NotesLabel.AutoSize = true;
            this.NotesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotesLabel.Location = new System.Drawing.Point(201, 74);
            this.NotesLabel.Name = "NotesLabel";
            this.NotesLabel.Size = new System.Drawing.Size(56, 20);
            this.NotesLabel.TabIndex = 8;
            this.NotesLabel.Text = "Notes";
            // 
            // friendsLabel
            // 
            this.friendsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.friendsLabel.AutoSize = true;
            this.friendsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friendsLabel.Location = new System.Drawing.Point(804, 74);
            this.friendsLabel.Name = "friendsLabel";
            this.friendsLabel.Size = new System.Drawing.Size(69, 20);
            this.friendsLabel.TabIndex = 12;
            this.friendsLabel.Text = "Friends";
            // 
            // searchbar
            // 
            this.searchbar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.searchbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbar.Location = new System.Drawing.Point(202, 27);
            this.searchbar.Name = "searchbar";
            this.searchbar.Size = new System.Drawing.Size(801, 31);
            this.searchbar.TabIndex = 13;
            this.searchbar.Text = "search";
            this.searchbar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchbar.GotFocus += new System.EventHandler(this.searchbar_click);
            this.searchbar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchbar_Enter);
            this.searchbar.LostFocus += new System.EventHandler(this.searchGainFocus);
            // 
            // addFriendIcon
            // 
            this.addFriendIcon.Image = ((System.Drawing.Image)(resources.GetObject("addFriendIcon.Image")));
            this.addFriendIcon.Location = new System.Drawing.Point(88, 27);
            this.addFriendIcon.Name = "addFriendIcon";
            this.addFriendIcon.Size = new System.Drawing.Size(32, 32);
            this.addFriendIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addFriendIcon.TabIndex = 16;
            this.addFriendIcon.TabStop = false;
            this.addFriendIcon.Click += new System.EventHandler(this.addFriendIcon_Click);
            // 
            // addNotebookIcon
            // 
            this.addNotebookIcon.Image = ((System.Drawing.Image)(resources.GetObject("addNotebookIcon.Image")));
            this.addNotebookIcon.Location = new System.Drawing.Point(50, 27);
            this.addNotebookIcon.Name = "addNotebookIcon";
            this.addNotebookIcon.Size = new System.Drawing.Size(32, 32);
            this.addNotebookIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addNotebookIcon.TabIndex = 15;
            this.addNotebookIcon.TabStop = false;
            this.addNotebookIcon.Click += new System.EventHandler(this.addNotebookIcon_Click);
            // 
            // addNoteIcon
            // 
            this.addNoteIcon.Image = ((System.Drawing.Image)(resources.GetObject("addNoteIcon.Image")));
            this.addNoteIcon.Location = new System.Drawing.Point(12, 27);
            this.addNoteIcon.Name = "addNoteIcon";
            this.addNoteIcon.Size = new System.Drawing.Size(32, 32);
            this.addNoteIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addNoteIcon.TabIndex = 14;
            this.addNoteIcon.TabStop = false;
            this.addNoteIcon.Click += new System.EventHandler(this.addNoteIcon_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1008, 546);
            this.shapeContainer1.TabIndex = 17;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.SelectionColor = System.Drawing.SystemColors.Desktop;
            this.lineShape1.X1 = -1;
            this.lineShape1.X2 = 1008;
            this.lineShape1.Y1 = 66;
            this.lineShape1.Y2 = 66;
            // 
            // editProfileIcon
            // 
            this.editProfileIcon.Image = ((System.Drawing.Image)(resources.GetObject("editProfileIcon.Image")));
            this.editProfileIcon.Location = new System.Drawing.Point(126, 27);
            this.editProfileIcon.Name = "editProfileIcon";
            this.editProfileIcon.Size = new System.Drawing.Size(32, 32);
            this.editProfileIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.editProfileIcon.TabIndex = 18;
            this.editProfileIcon.TabStop = false;
            this.editProfileIcon.Click += new System.EventHandler(this.editProfileIcon_Click);
            // 
            // helpIcon
            // 
            this.helpIcon.Image = ((System.Drawing.Image)(resources.GetObject("helpIcon.Image")));
            this.helpIcon.Location = new System.Drawing.Point(164, 27);
            this.helpIcon.Name = "helpIcon";
            this.helpIcon.Size = new System.Drawing.Size(32, 32);
            this.helpIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.helpIcon.TabIndex = 19;
            this.helpIcon.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1008, 546);
            this.Controls.Add(this.helpIcon);
            this.Controls.Add(this.editProfileIcon);
            this.Controls.Add(this.addFriendIcon);
            this.Controls.Add(this.friendsLabel);
            this.Controls.Add(this.addNotebookIcon);
            this.Controls.Add(this.addNoteIcon);
            this.Controls.Add(this.searchbar);
            this.Controls.Add(this.NotesLabel);
            this.Controls.Add(this.NotesOwnerList);
            this.Controls.Add(this.NotesTagList);
            this.Controls.Add(this.friendsList);
            this.Controls.Add(this.NotesList);
            this.Controls.Add(this.notebookLabel);
            this.Controls.Add(this.notebooklist);
            this.Controls.Add(this.menuBar);
            this.Controls.Add(this.shapeContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuBar;
            this.MinimumSize = new System.Drawing.Size(1023, 449);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShareNote";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.MainWindow_GotFocus);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.addFriendIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addNotebookIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addNoteIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editProfileIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ListBox notebooklist;
        private System.Windows.Forms.Label notebookLabel;
        private System.Windows.Forms.ListBox NotesList;
        private System.Windows.Forms.ListBox friendsList;
        private System.Windows.Forms.ListBox NotesTagList;
        private System.Windows.Forms.ListBox NotesOwnerList;
        private System.Windows.Forms.Label NotesLabel;
        private System.Windows.Forms.Label friendsLabel;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newNotebookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFriendToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myProfileInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TextBox searchbar;
        private System.Windows.Forms.PictureBox addFriendIcon;
        private System.Windows.Forms.PictureBox addNotebookIcon;
        private System.Windows.Forms.PictureBox addNoteIcon;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.PictureBox editProfileIcon;
        private System.Windows.Forms.PictureBox helpIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem readToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolTip notesTitleTooltip;
    }
}