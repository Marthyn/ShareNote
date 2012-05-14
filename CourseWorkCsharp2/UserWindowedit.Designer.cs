namespace CourseWorkCsharp2
{
    partial class UserWindowedit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserWindowedit));
            this.usernameLabel = new System.Windows.Forms.Label();
            this.FirstnameField = new System.Windows.Forms.TextBox();
            this.firstnameLabel = new System.Windows.Forms.Label();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.EmailField = new System.Windows.Forms.TextBox();
            this.LastnameField = new System.Windows.Forms.TextBox();
            this.lastnameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.oldpasswordLabel = new System.Windows.Forms.Label();
            this.UniversityField = new System.Windows.Forms.ComboBox();
            this.universityLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.newPasswordfield = new System.Windows.Forms.TextBox();
            this.newPasswordField2 = new System.Windows.Forms.TextBox();
            this.newpasswordLabel1 = new System.Windows.Forms.Label();
            this.newpasswordLabel2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(11, 8);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(105, 24);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "user_name";
            // 
            // FirstnameField
            // 
            this.FirstnameField.Location = new System.Drawing.Point(99, 59);
            this.FirstnameField.Name = "FirstnameField";
            this.FirstnameField.Size = new System.Drawing.Size(206, 20);
            this.FirstnameField.TabIndex = 0;
            // 
            // firstnameLabel
            // 
            this.firstnameLabel.AutoSize = true;
            this.firstnameLabel.Location = new System.Drawing.Point(12, 62);
            this.firstnameLabel.Name = "firstnameLabel";
            this.firstnameLabel.Size = new System.Drawing.Size(57, 13);
            this.firstnameLabel.TabIndex = 2;
            this.firstnameLabel.Text = "First Name";
            // 
            // passwordField
            // 
            this.passwordField.HideSelection = false;
            this.passwordField.Location = new System.Drawing.Point(99, 137);
            this.passwordField.Name = "passwordField";
            this.passwordField.PasswordChar = '*';
            this.passwordField.Size = new System.Drawing.Size(206, 20);
            this.passwordField.TabIndex = 3;
            // 
            // EmailField
            // 
            this.EmailField.Location = new System.Drawing.Point(99, 111);
            this.EmailField.Name = "EmailField";
            this.EmailField.Size = new System.Drawing.Size(206, 20);
            this.EmailField.TabIndex = 2;
            // 
            // LastnameField
            // 
            this.LastnameField.Location = new System.Drawing.Point(99, 85);
            this.LastnameField.Name = "LastnameField";
            this.LastnameField.Size = new System.Drawing.Size(206, 20);
            this.LastnameField.TabIndex = 1;
            // 
            // lastnameLabel
            // 
            this.lastnameLabel.AutoSize = true;
            this.lastnameLabel.Location = new System.Drawing.Point(12, 88);
            this.lastnameLabel.Name = "lastnameLabel";
            this.lastnameLabel.Size = new System.Drawing.Size(58, 13);
            this.lastnameLabel.TabIndex = 6;
            this.lastnameLabel.Text = "Last Name";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(12, 114);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(32, 13);
            this.emailLabel.TabIndex = 7;
            this.emailLabel.Text = "Email";
            // 
            // oldpasswordLabel
            // 
            this.oldpasswordLabel.AutoSize = true;
            this.oldpasswordLabel.Location = new System.Drawing.Point(12, 140);
            this.oldpasswordLabel.Name = "oldpasswordLabel";
            this.oldpasswordLabel.Size = new System.Drawing.Size(72, 13);
            this.oldpasswordLabel.TabIndex = 8;
            this.oldpasswordLabel.Text = "Old Password";
            // 
            // UniversityField
            // 
            this.UniversityField.FormattingEnabled = true;
            this.UniversityField.Location = new System.Drawing.Point(99, 215);
            this.UniversityField.Name = "UniversityField";
            this.UniversityField.Size = new System.Drawing.Size(206, 21);
            this.UniversityField.TabIndex = 6;
            // 
            // universityLabel
            // 
            this.universityLabel.AutoSize = true;
            this.universityLabel.Location = new System.Drawing.Point(12, 218);
            this.universityLabel.Name = "universityLabel";
            this.universityLabel.Size = new System.Drawing.Size(53, 13);
            this.universityLabel.TabIndex = 10;
            this.universityLabel.Text = "University";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(230, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(149, 242);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // newPasswordfield
            // 
            this.newPasswordfield.HideSelection = false;
            this.newPasswordfield.Location = new System.Drawing.Point(99, 163);
            this.newPasswordfield.Name = "newPasswordfield";
            this.newPasswordfield.PasswordChar = '*';
            this.newPasswordfield.Size = new System.Drawing.Size(206, 20);
            this.newPasswordfield.TabIndex = 4;
            // 
            // newPasswordField2
            // 
            this.newPasswordField2.HideSelection = false;
            this.newPasswordField2.Location = new System.Drawing.Point(99, 189);
            this.newPasswordField2.Name = "newPasswordField2";
            this.newPasswordField2.PasswordChar = '*';
            this.newPasswordField2.Size = new System.Drawing.Size(206, 20);
            this.newPasswordField2.TabIndex = 5;
            // 
            // newpasswordLabel1
            // 
            this.newpasswordLabel1.AutoSize = true;
            this.newpasswordLabel1.Location = new System.Drawing.Point(12, 166);
            this.newpasswordLabel1.Name = "newpasswordLabel1";
            this.newpasswordLabel1.Size = new System.Drawing.Size(78, 13);
            this.newpasswordLabel1.TabIndex = 15;
            this.newpasswordLabel1.Text = "New Password";
            // 
            // newpasswordLabel2
            // 
            this.newpasswordLabel2.AutoSize = true;
            this.newpasswordLabel2.Location = new System.Drawing.Point(12, 192);
            this.newpasswordLabel2.Name = "newpasswordLabel2";
            this.newpasswordLabel2.Size = new System.Drawing.Size(87, 13);
            this.newpasswordLabel2.TabIndex = 16;
            this.newpasswordLabel2.Text = "New Password 2";
            // 
            // UserWindowedit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 274);
            this.Controls.Add(this.newpasswordLabel2);
            this.Controls.Add(this.newpasswordLabel1);
            this.Controls.Add(this.newPasswordField2);
            this.Controls.Add(this.newPasswordfield);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.universityLabel);
            this.Controls.Add(this.UniversityField);
            this.Controls.Add(this.oldpasswordLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.lastnameLabel);
            this.Controls.Add(this.LastnameField);
            this.Controls.Add(this.EmailField);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.firstnameLabel);
            this.Controls.Add(this.FirstnameField);
            this.Controls.Add(this.usernameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(330, 312);
            this.MinimumSize = new System.Drawing.Size(330, 312);
            this.Name = "UserWindowedit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit your profile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox FirstnameField;
        private System.Windows.Forms.Label firstnameLabel;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.TextBox EmailField;
        private System.Windows.Forms.TextBox LastnameField;
        private System.Windows.Forms.Label lastnameLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label oldpasswordLabel;
        private System.Windows.Forms.ComboBox UniversityField;
        private System.Windows.Forms.Label universityLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox newPasswordfield;
        private System.Windows.Forms.TextBox newPasswordField2;
        private System.Windows.Forms.Label newpasswordLabel1;
        private System.Windows.Forms.Label newpasswordLabel2;
    }
}