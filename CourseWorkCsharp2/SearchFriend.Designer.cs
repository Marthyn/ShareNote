namespace CourseWorkCsharp2
{
    partial class SearchFriend
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchFriend));
            this.usernameLabel = new System.Windows.Forms.Label();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.Users = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(12, 9);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(153, 24);
            this.usernameLabel.TabIndex = 19;
            this.usernameLabel.Text = "Search for a user";
            // 
            // searchBar
            // 
            this.searchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBar.Location = new System.Drawing.Point(12, 43);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(290, 24);
            this.searchBar.TabIndex = 20;
            this.searchBar.Text = "search by username";
            this.searchBar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchBar.GotFocus += new System.EventHandler(this.searchbar_click);
            this.searchBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchbar_Enter);
            this.searchBar.LostFocus += new System.EventHandler(this.searchGainFocus);
            // 
            // Users
            // 
            this.Users.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Users.BackColor = System.Drawing.Color.White;
            this.Users.FormattingEnabled = true;
            this.Users.Location = new System.Drawing.Point(12, 72);
            this.Users.MultiColumn = true;
            this.Users.Name = "Users";
            this.Users.Size = new System.Drawing.Size(290, 186);
            this.Users.TabIndex = 21;
            this.Users.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Users_MouseDoubleClick);
            // 
            // SearchFriend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 274);
            this.Controls.Add(this.Users);
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.usernameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(330, 312);
            this.MinimumSize = new System.Drawing.Size(330, 312);
            this.Name = "SearchFriend";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search user";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.ListBox Users;
    }
}