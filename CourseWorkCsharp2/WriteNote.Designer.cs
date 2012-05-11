namespace CourseWorkCsharp2
{
    partial class WriteNote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WriteNote));
            this.noteText = new System.Windows.Forms.RichTextBox();
            this.boldButton = new System.Windows.Forms.Button();
            this.underlineButton = new System.Windows.Forms.Button();
            this.italicButton = new System.Windows.Forms.Button();
            this.fontBox = new System.Windows.Forms.ComboBox();
            this.notebooksBox = new System.Windows.Forms.ComboBox();
            this.tagsBox = new System.Windows.Forms.TextBox();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.tagsLabel = new System.Windows.Forms.Label();
            this.notebookLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAndCloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsOwnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeWithoutSavingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.styleLabel = new System.Windows.Forms.Label();
            this.alignmentLabel = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // noteText
            // 
            this.noteText.Location = new System.Drawing.Point(13, 75);
            this.noteText.Name = "noteText";
            this.noteText.Size = new System.Drawing.Size(856, 442);
            this.noteText.TabIndex = 7;
            this.noteText.Text = "";
            // 
            // boldButton
            // 
            this.boldButton.Location = new System.Drawing.Point(14, 46);
            this.boldButton.Name = "boldButton";
            this.boldButton.Size = new System.Drawing.Size(27, 23);
            this.boldButton.TabIndex = 1;
            this.boldButton.Text = "B";
            this.boldButton.UseVisualStyleBackColor = true;
            this.boldButton.Click += new System.EventHandler(this.boldButton_Click);
            // 
            // underlineButton
            // 
            this.underlineButton.Location = new System.Drawing.Point(70, 46);
            this.underlineButton.Name = "underlineButton";
            this.underlineButton.Size = new System.Drawing.Size(27, 23);
            this.underlineButton.TabIndex = 3;
            this.underlineButton.Text = "U";
            this.underlineButton.UseVisualStyleBackColor = true;
            // 
            // italicButton
            // 
            this.italicButton.Location = new System.Drawing.Point(42, 46);
            this.italicButton.Name = "italicButton";
            this.italicButton.Size = new System.Drawing.Size(27, 23);
            this.italicButton.TabIndex = 2;
            this.italicButton.Text = "I";
            this.italicButton.UseVisualStyleBackColor = true;
            this.italicButton.Click += new System.EventHandler(this.italicButton_Click);
            // 
            // fontBox
            // 
            this.fontBox.FormattingEnabled = true;
            this.fontBox.Items.AddRange(new object[] {
            "Normal",
            "Title 1",
            "Title 2",
            "Title 3",
            "Paragraph"});
            this.fontBox.Location = new System.Drawing.Point(219, 47);
            this.fontBox.Name = "fontBox";
            this.fontBox.Size = new System.Drawing.Size(126, 21);
            this.fontBox.TabIndex = 7;
            this.fontBox.Text = "Font";
            this.fontBox.SelectedIndexChanged += new System.EventHandler(this.fontChanged);
            // 
            // notebooksBox
            // 
            this.notebooksBox.FormattingEnabled = true;
            this.notebooksBox.Location = new System.Drawing.Point(747, 48);
            this.notebooksBox.Name = "notebooksBox";
            this.notebooksBox.Size = new System.Drawing.Size(121, 21);
            this.notebooksBox.TabIndex = 10;
            // 
            // tagsBox
            // 
            this.tagsBox.Location = new System.Drawing.Point(641, 49);
            this.tagsBox.Name = "tagsBox";
            this.tagsBox.Size = new System.Drawing.Size(100, 20);
            this.tagsBox.TabIndex = 9;
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(535, 48);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(100, 20);
            this.titleBox.TabIndex = 8;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(535, 29);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(27, 13);
            this.titleLabel.TabIndex = 9;
            this.titleLabel.Text = "Title";
            // 
            // tagsLabel
            // 
            this.tagsLabel.AutoSize = true;
            this.tagsLabel.Location = new System.Drawing.Point(641, 28);
            this.tagsLabel.Name = "tagsLabel";
            this.tagsLabel.Size = new System.Drawing.Size(31, 13);
            this.tagsLabel.TabIndex = 10;
            this.tagsLabel.Text = "Tags";
            // 
            // notebookLabel
            // 
            this.notebookLabel.AutoSize = true;
            this.notebookLabel.Location = new System.Drawing.Point(747, 29);
            this.notebookLabel.Name = "notebookLabel";
            this.notebookLabel.Size = new System.Drawing.Size(54, 13);
            this.notebookLabel.TabIndex = 11;
            this.notebookLabel.Text = "Notebook";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(172, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "R";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(116, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "L";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(144, 46);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(27, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "C";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(881, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.saveAndCloseToolStripMenuItem,
            this.saveAsOwnToolStripMenuItem,
            this.closeWithoutSavingToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAndCloseToolStripMenuItem
            // 
            this.saveAndCloseToolStripMenuItem.Name = "saveAndCloseToolStripMenuItem";
            this.saveAndCloseToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.saveAndCloseToolStripMenuItem.Text = "Save and close";
            this.saveAndCloseToolStripMenuItem.Click += new System.EventHandler(this.saveAndCloseToolStripMenuItem_Click);
            // 
            // saveAsOwnToolStripMenuItem
            // 
            this.saveAsOwnToolStripMenuItem.Name = "saveAsOwnToolStripMenuItem";
            this.saveAsOwnToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.saveAsOwnToolStripMenuItem.Text = "Save as own";
            this.saveAsOwnToolStripMenuItem.Click += new System.EventHandler(this.saveAsOwnToolStripMenuItem_Click);
            // 
            // closeWithoutSavingToolStripMenuItem
            // 
            this.closeWithoutSavingToolStripMenuItem.Name = "closeWithoutSavingToolStripMenuItem";
            this.closeWithoutSavingToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.closeWithoutSavingToolStripMenuItem.Text = "Close without saving";
            this.closeWithoutSavingToolStripMenuItem.Click += new System.EventHandler(this.closeWithoutSavingToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // styleLabel
            // 
            this.styleLabel.AutoSize = true;
            this.styleLabel.Location = new System.Drawing.Point(40, 27);
            this.styleLabel.Name = "styleLabel";
            this.styleLabel.Size = new System.Drawing.Size(30, 13);
            this.styleLabel.TabIndex = 16;
            this.styleLabel.Text = "Style";
            // 
            // alignmentLabel
            // 
            this.alignmentLabel.AutoSize = true;
            this.alignmentLabel.Location = new System.Drawing.Point(132, 27);
            this.alignmentLabel.Name = "alignmentLabel";
            this.alignmentLabel.Size = new System.Drawing.Size(53, 13);
            this.alignmentLabel.TabIndex = 17;
            this.alignmentLabel.Text = "Alignment";
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "help.chm";
            // 
            // WriteNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 529);
            this.Controls.Add(this.alignmentLabel);
            this.Controls.Add(this.styleLabel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.notebookLabel);
            this.Controls.Add(this.tagsLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.tagsBox);
            this.Controls.Add(this.notebooksBox);
            this.Controls.Add(this.fontBox);
            this.Controls.Add(this.italicButton);
            this.Controls.Add(this.underlineButton);
            this.Controls.Add(this.boldButton);
            this.Controls.Add(this.noteText);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "WriteNote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Write a note";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WriteNote_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox noteText;
        private System.Windows.Forms.Button boldButton;
        private System.Windows.Forms.Button underlineButton;
        private System.Windows.Forms.Button italicButton;
        private System.Windows.Forms.ComboBox fontBox;
        private System.Windows.Forms.ComboBox notebooksBox;
        private System.Windows.Forms.TextBox tagsBox;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label tagsLabel;
        private System.Windows.Forms.Label notebookLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAndCloseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeWithoutSavingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label styleLabel;
        private System.Windows.Forms.Label alignmentLabel;
        private System.Windows.Forms.ToolStripMenuItem saveAsOwnToolStripMenuItem;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}