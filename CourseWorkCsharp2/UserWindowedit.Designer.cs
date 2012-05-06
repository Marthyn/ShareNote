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
            this.usernameLabel = new System.Windows.Forms.Label();
            this.FirstnameField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.EmailField = new System.Windows.Forms.TextBox();
            this.LastnameField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UniversityField = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.newPasswordfield = new System.Windows.Forms.TextBox();
            this.newPasswordField2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(13, 13);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(105, 24);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "user_name";
            // 
            // FirstnameField
            // 
            this.FirstnameField.Location = new System.Drawing.Point(265, 60);
            this.FirstnameField.Name = "FirstnameField";
            this.FirstnameField.Size = new System.Drawing.Size(206, 20);
            this.FirstnameField.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name";
            // 
            // passwordField
            // 
            this.passwordField.HideSelection = false;
            this.passwordField.Location = new System.Drawing.Point(265, 138);
            this.passwordField.Name = "passwordField";
            this.passwordField.PasswordChar = '*';
            this.passwordField.Size = new System.Drawing.Size(206, 20);
            this.passwordField.TabIndex = 3;
            // 
            // EmailField
            // 
            this.EmailField.Location = new System.Drawing.Point(265, 112);
            this.EmailField.Name = "EmailField";
            this.EmailField.Size = new System.Drawing.Size(206, 20);
            this.EmailField.TabIndex = 4;
            // 
            // LastnameField
            // 
            this.LastnameField.Location = new System.Drawing.Point(265, 86);
            this.LastnameField.Name = "LastnameField";
            this.LastnameField.Size = new System.Drawing.Size(206, 20);
            this.LastnameField.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Old Password";
            // 
            // UniversityField
            // 
            this.UniversityField.FormattingEnabled = true;
            this.UniversityField.Location = new System.Drawing.Point(265, 216);
            this.UniversityField.Name = "UniversityField";
            this.UniversityField.Size = new System.Drawing.Size(206, 21);
            this.UniversityField.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(178, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "University";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(396, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(315, 243);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // newPasswordfield
            // 
            this.newPasswordfield.HideSelection = false;
            this.newPasswordfield.Location = new System.Drawing.Point(265, 164);
            this.newPasswordfield.Name = "newPasswordfield";
            this.newPasswordfield.PasswordChar = '*';
            this.newPasswordfield.Size = new System.Drawing.Size(206, 20);
            this.newPasswordfield.TabIndex = 13;
            // 
            // newPasswordField2
            // 
            this.newPasswordField2.HideSelection = false;
            this.newPasswordField2.Location = new System.Drawing.Point(265, 190);
            this.newPasswordField2.Name = "newPasswordField2";
            this.newPasswordField2.PasswordChar = '*';
            this.newPasswordField2.Size = new System.Drawing.Size(206, 20);
            this.newPasswordField2.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(178, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "New Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(178, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "New Password 2";
            // 
            // UserWindowedit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 274);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.newPasswordField2);
            this.Controls.Add(this.newPasswordfield);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UniversityField);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LastnameField);
            this.Controls.Add(this.EmailField);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FirstnameField);
            this.Controls.Add(this.usernameLabel);
            this.Name = "UserWindowedit";
            this.Text = "UserWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox FirstnameField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.TextBox EmailField;
        private System.Windows.Forms.TextBox LastnameField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox UniversityField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox newPasswordfield;
        private System.Windows.Forms.TextBox newPasswordField2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}