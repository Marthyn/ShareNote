namespace CourseWorkCsharp2
{
    partial class friendWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(friendWindow));
            this.universityLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.lastnameLabel = new System.Windows.Forms.Label();
            this.LastnameField = new System.Windows.Forms.TextBox();
            this.EmailField = new System.Windows.Forms.TextBox();
            this.firstnameLabel = new System.Windows.Forms.Label();
            this.FirstnameField = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.universityField = new System.Windows.Forms.TextBox();
            this.friendLabel = new System.Windows.Forms.Label();
            this.friendsCheck = new System.Windows.Forms.CheckBox();
            this.friendButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // universityLabel
            // 
            this.universityLabel.AutoSize = true;
            this.universityLabel.Location = new System.Drawing.Point(178, 153);
            this.universityLabel.Name = "universityLabel";
            this.universityLabel.Size = new System.Drawing.Size(53, 13);
            this.universityLabel.TabIndex = 29;
            this.universityLabel.Text = "University";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(178, 127);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(32, 13);
            this.emailLabel.TabIndex = 27;
            this.emailLabel.Text = "Email";
            // 
            // lastnameLabel
            // 
            this.lastnameLabel.AutoSize = true;
            this.lastnameLabel.Location = new System.Drawing.Point(178, 101);
            this.lastnameLabel.Name = "lastnameLabel";
            this.lastnameLabel.Size = new System.Drawing.Size(58, 13);
            this.lastnameLabel.TabIndex = 26;
            this.lastnameLabel.Text = "Last Name";
            // 
            // LastnameField
            // 
            this.LastnameField.Location = new System.Drawing.Point(265, 98);
            this.LastnameField.Name = "LastnameField";
            this.LastnameField.ReadOnly = true;
            this.LastnameField.Size = new System.Drawing.Size(206, 20);
            this.LastnameField.TabIndex = 19;
            // 
            // EmailField
            // 
            this.EmailField.Location = new System.Drawing.Point(265, 124);
            this.EmailField.Name = "EmailField";
            this.EmailField.ReadOnly = true;
            this.EmailField.Size = new System.Drawing.Size(206, 20);
            this.EmailField.TabIndex = 20;
            // 
            // firstnameLabel
            // 
            this.firstnameLabel.AutoSize = true;
            this.firstnameLabel.Location = new System.Drawing.Point(178, 75);
            this.firstnameLabel.Name = "firstnameLabel";
            this.firstnameLabel.Size = new System.Drawing.Size(57, 13);
            this.firstnameLabel.TabIndex = 21;
            this.firstnameLabel.Text = "First Name";
            // 
            // FirstnameField
            // 
            this.FirstnameField.Location = new System.Drawing.Point(265, 72);
            this.FirstnameField.Name = "FirstnameField";
            this.FirstnameField.ReadOnly = true;
            this.FirstnameField.Size = new System.Drawing.Size(206, 20);
            this.FirstnameField.TabIndex = 17;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(13, 25);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(105, 24);
            this.usernameLabel.TabIndex = 18;
            this.usernameLabel.Text = "user_name";
            // 
            // universityField
            // 
            this.universityField.Location = new System.Drawing.Point(266, 150);
            this.universityField.Name = "universityField";
            this.universityField.ReadOnly = true;
            this.universityField.Size = new System.Drawing.Size(205, 20);
            this.universityField.TabIndex = 32;
            // 
            // friendLabel
            // 
            this.friendLabel.AutoSize = true;
            this.friendLabel.Location = new System.Drawing.Point(178, 175);
            this.friendLabel.Name = "friendLabel";
            this.friendLabel.Size = new System.Drawing.Size(63, 13);
            this.friendLabel.TabIndex = 33;
            this.friendLabel.Text = "Friends with";
            // 
            // friendsCheck
            // 
            this.friendsCheck.AutoSize = true;
            this.friendsCheck.Enabled = false;
            this.friendsCheck.Location = new System.Drawing.Point(269, 174);
            this.friendsCheck.Name = "friendsCheck";
            this.friendsCheck.Size = new System.Drawing.Size(15, 14);
            this.friendsCheck.TabIndex = 34;
            this.friendsCheck.UseVisualStyleBackColor = true;
            // 
            // friendButton
            // 
            this.friendButton.Location = new System.Drawing.Point(396, 195);
            this.friendButton.Name = "friendButton";
            this.friendButton.Size = new System.Drawing.Size(75, 23);
            this.friendButton.TabIndex = 35;
            this.friendButton.Text = "Add Friend";
            this.friendButton.UseVisualStyleBackColor = true;
            this.friendButton.Click += new System.EventHandler(this.friendButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(315, 195);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 36;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // friendWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 224);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.friendButton);
            this.Controls.Add(this.friendsCheck);
            this.Controls.Add(this.friendLabel);
            this.Controls.Add(this.universityField);
            this.Controls.Add(this.universityLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.lastnameLabel);
            this.Controls.Add(this.LastnameField);
            this.Controls.Add(this.EmailField);
            this.Controls.Add(this.firstnameLabel);
            this.Controls.Add(this.FirstnameField);
            this.Controls.Add(this.usernameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(494, 262);
            this.MinimumSize = new System.Drawing.Size(494, 262);
            this.Name = "friendWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label universityLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label lastnameLabel;
        private System.Windows.Forms.TextBox LastnameField;
        private System.Windows.Forms.TextBox EmailField;
        private System.Windows.Forms.Label firstnameLabel;
        private System.Windows.Forms.TextBox FirstnameField;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox universityField;
        private System.Windows.Forms.Label friendLabel;
        private System.Windows.Forms.CheckBox friendsCheck;
        private System.Windows.Forms.Button friendButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}