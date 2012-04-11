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
            this.userNameField = new System.Windows.Forms.TextBox();
            this.surnameField = new System.Windows.Forms.TextBox();
            this.firtnameField = new System.Windows.Forms.TextBox();
            this.emailField = new System.Windows.Forms.TextBox();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Surnamelabel = new System.Windows.Forms.Label();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.universityField = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userNameField
            // 
            this.userNameField.Location = new System.Drawing.Point(178, 13);
            this.userNameField.Name = "userNameField";
            this.userNameField.Size = new System.Drawing.Size(149, 20);
            this.userNameField.TabIndex = 0;
            // 
            // surnameField
            // 
            this.surnameField.Location = new System.Drawing.Point(178, 117);
            this.surnameField.Name = "surnameField";
            this.surnameField.Size = new System.Drawing.Size(149, 20);
            this.surnameField.TabIndex = 1;
            // 
            // firtnameField
            // 
            this.firtnameField.Location = new System.Drawing.Point(178, 91);
            this.firtnameField.Name = "firtnameField";
            this.firtnameField.Size = new System.Drawing.Size(149, 20);
            this.firtnameField.TabIndex = 2;
            // 
            // emailField
            // 
            this.emailField.Location = new System.Drawing.Point(178, 65);
            this.emailField.Name = "emailField";
            this.emailField.Size = new System.Drawing.Size(149, 20);
            this.emailField.TabIndex = 3;
            // 
            // passwordField
            // 
            this.passwordField.Location = new System.Drawing.Point(178, 39);
            this.passwordField.Name = "passwordField";
            this.passwordField.Size = new System.Drawing.Size(149, 20);
            this.passwordField.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "First name";
            // 
            // Surnamelabel
            // 
            this.Surnamelabel.AutoSize = true;
            this.Surnamelabel.Location = new System.Drawing.Point(12, 120);
            this.Surnamelabel.Name = "Surnamelabel";
            this.Surnamelabel.Size = new System.Drawing.Size(49, 13);
            this.Surnamelabel.TabIndex = 9;
            this.Surnamelabel.Text = "Surname";
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(252, 349);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(75, 23);
            this.RegisterButton.TabIndex = 10;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // universityField
            // 
            this.universityField.Location = new System.Drawing.Point(178, 143);
            this.universityField.Name = "universityField";
            this.universityField.Size = new System.Drawing.Size(149, 20);
            this.universityField.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "University";
            // 
            // RegisterWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 384);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.universityField);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.Surnamelabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.emailField);
            this.Controls.Add(this.firtnameField);
            this.Controls.Add(this.surnameField);
            this.Controls.Add(this.userNameField);
            this.Name = "RegisterWindow";
            this.Text = "RegisterWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userNameField;
        private System.Windows.Forms.TextBox surnameField;
        private System.Windows.Forms.TextBox firtnameField;
        private System.Windows.Forms.TextBox emailField;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Surnamelabel;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.TextBox universityField;
        private System.Windows.Forms.Label label5;
    }
}