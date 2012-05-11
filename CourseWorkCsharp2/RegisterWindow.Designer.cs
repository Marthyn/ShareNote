namespace CourseWorkCsharp2
{
    partial class RegisterWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterWindow));
            this.userNameField = new System.Windows.Forms.TextBox();
            this.surnameField = new System.Windows.Forms.TextBox();
            this.firtnameField = new System.Windows.Forms.TextBox();
            this.emailField = new System.Windows.Forms.TextBox();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.firstnameLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.universityLabel = new System.Windows.Forms.Label();
            this.universityBox = new System.Windows.Forms.ComboBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userNameField
            // 
            this.userNameField.Location = new System.Drawing.Point(178, 59);
            this.userNameField.Name = "userNameField";
            this.userNameField.Size = new System.Drawing.Size(149, 20);
            this.userNameField.TabIndex = 0;
            // 
            // surnameField
            // 
            this.surnameField.Location = new System.Drawing.Point(178, 163);
            this.surnameField.Name = "surnameField";
            this.surnameField.Size = new System.Drawing.Size(149, 20);
            this.surnameField.TabIndex = 4;
            // 
            // firtnameField
            // 
            this.firtnameField.Location = new System.Drawing.Point(178, 137);
            this.firtnameField.Name = "firtnameField";
            this.firtnameField.Size = new System.Drawing.Size(149, 20);
            this.firtnameField.TabIndex = 3;
            // 
            // emailField
            // 
            this.emailField.Location = new System.Drawing.Point(178, 111);
            this.emailField.Name = "emailField";
            this.emailField.Size = new System.Drawing.Size(149, 20);
            this.emailField.TabIndex = 2;
            // 
            // passwordField
            // 
            this.passwordField.Location = new System.Drawing.Point(178, 85);
            this.passwordField.Name = "passwordField";
            this.passwordField.Size = new System.Drawing.Size(149, 20);
            this.passwordField.TabIndex = 1;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(117, 62);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(55, 13);
            this.usernameLabel.TabIndex = 5;
            this.usernameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(119, 88);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 6;
            this.passwordLabel.Text = "Password";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(100, 114);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(72, 13);
            this.emailLabel.TabIndex = 7;
            this.emailLabel.Text = "Email address";
            // 
            // firstnameLabel
            // 
            this.firstnameLabel.AutoSize = true;
            this.firstnameLabel.Location = new System.Drawing.Point(117, 140);
            this.firstnameLabel.Name = "firstnameLabel";
            this.firstnameLabel.Size = new System.Drawing.Size(55, 13);
            this.firstnameLabel.TabIndex = 8;
            this.firstnameLabel.Text = "First name";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(123, 166);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(49, 13);
            this.surnameLabel.TabIndex = 9;
            this.surnameLabel.Text = "Surname";
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(252, 212);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(75, 23);
            this.RegisterButton.TabIndex = 6;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // universityLabel
            // 
            this.universityLabel.AutoSize = true;
            this.universityLabel.Location = new System.Drawing.Point(119, 190);
            this.universityLabel.Name = "universityLabel";
            this.universityLabel.Size = new System.Drawing.Size(53, 13);
            this.universityLabel.TabIndex = 12;
            this.universityLabel.Text = "University";
            // 
            // universityBox
            // 
            this.universityBox.FormattingEnabled = true;
            this.universityBox.Location = new System.Drawing.Point(178, 187);
            this.universityBox.Name = "universityBox";
            this.universityBox.Size = new System.Drawing.Size(149, 21);
            this.universityBox.TabIndex = 5;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(241, 25);
            this.titleLabel.TabIndex = 13;
            this.titleLabel.Text = "Register your account";
            // 
            // RegisterWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 245);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.universityBox);
            this.Controls.Add(this.universityLabel);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.firstnameLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.emailField);
            this.Controls.Add(this.firtnameField);
            this.Controls.Add(this.surnameField);
            this.Controls.Add(this.userNameField);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(355, 283);
            this.MinimumSize = new System.Drawing.Size(355, 237);
            this.Name = "RegisterWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userNameField;
        private System.Windows.Forms.TextBox surnameField;
        private System.Windows.Forms.TextBox firtnameField;
        private System.Windows.Forms.TextBox emailField;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label firstnameLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Label universityLabel;
        private System.Windows.Forms.ComboBox universityBox;
        private System.Windows.Forms.Label titleLabel;
    }
}