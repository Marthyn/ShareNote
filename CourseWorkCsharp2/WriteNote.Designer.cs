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
            this.noteText = new System.Windows.Forms.RichTextBox();
            this.boldButton = new System.Windows.Forms.Button();
            this.underlineButton = new System.Windows.Forms.Button();
            this.italicButton = new System.Windows.Forms.Button();
            this.fontBox = new System.Windows.Forms.ComboBox();
            this.notebooksBox = new System.Windows.Forms.ComboBox();
            this.tagsBox = new System.Windows.Forms.TextBox();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // noteText
            // 
            this.noteText.Location = new System.Drawing.Point(13, 75);
            this.noteText.Name = "noteText";
            this.noteText.Size = new System.Drawing.Size(856, 442);
            this.noteText.TabIndex = 0;
            this.noteText.Text = "";
            // 
            // boldButton
            // 
            this.boldButton.Location = new System.Drawing.Point(13, 46);
            this.boldButton.Name = "boldButton";
            this.boldButton.Size = new System.Drawing.Size(27, 23);
            this.boldButton.TabIndex = 1;
            this.boldButton.Text = "B";
            this.boldButton.UseVisualStyleBackColor = true;
            this.boldButton.Click += new System.EventHandler(this.boldButton_Click);
            // 
            // underlineButton
            // 
            this.underlineButton.Location = new System.Drawing.Point(79, 46);
            this.underlineButton.Name = "underlineButton";
            this.underlineButton.Size = new System.Drawing.Size(27, 23);
            this.underlineButton.TabIndex = 3;
            this.underlineButton.Text = "U";
            this.underlineButton.UseVisualStyleBackColor = true;
            // 
            // italicButton
            // 
            this.italicButton.Location = new System.Drawing.Point(46, 46);
            this.italicButton.Name = "italicButton";
            this.italicButton.Size = new System.Drawing.Size(27, 23);
            this.italicButton.TabIndex = 4;
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
            this.fontBox.TabIndex = 5;
            this.fontBox.Text = "Font";
            this.fontBox.SelectedIndexChanged += new System.EventHandler(this.fontChanged);
            // 
            // notebooksBox
            // 
            this.notebooksBox.FormattingEnabled = true;
            this.notebooksBox.Location = new System.Drawing.Point(747, 48);
            this.notebooksBox.Name = "notebooksBox";
            this.notebooksBox.Size = new System.Drawing.Size(121, 21);
            this.notebooksBox.TabIndex = 6;
            // 
            // tagsBox
            // 
            this.tagsBox.Location = new System.Drawing.Point(641, 49);
            this.tagsBox.Name = "tagsBox";
            this.tagsBox.Size = new System.Drawing.Size(100, 20);
            this.tagsBox.TabIndex = 7;
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(535, 48);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(100, 20);
            this.titleBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(535, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(641, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tags";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(747, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Notebook";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(178, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "R";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(112, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "L";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(145, 46);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(27, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "C";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // WriteNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 529);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.tagsBox);
            this.Controls.Add(this.notebooksBox);
            this.Controls.Add(this.fontBox);
            this.Controls.Add(this.italicButton);
            this.Controls.Add(this.underlineButton);
            this.Controls.Add(this.boldButton);
            this.Controls.Add(this.noteText);
            this.Name = "WriteNote";
            this.Text = "WriteNote";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}