namespace CourseWorkCsharp2
{
    partial class NotebookWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotebookWindow));
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameField = new System.Windows.Forms.TextBox();
            this.descriptionField = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.nonotesLabel = new System.Windows.Forms.Label();
            this.noNotesfield = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(61, 16);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 9;
            this.nameLabel.Text = "Name";
            // 
            // nameField
            // 
            this.nameField.Location = new System.Drawing.Point(102, 13);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(170, 20);
            this.nameField.TabIndex = 1;
            // 
            // descriptionField
            // 
            this.descriptionField.Location = new System.Drawing.Point(102, 40);
            this.descriptionField.Multiline = true;
            this.descriptionField.Name = "descriptionField";
            this.descriptionField.Size = new System.Drawing.Size(170, 80);
            this.descriptionField.TabIndex = 2;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(36, 40);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.descriptionLabel.TabIndex = 8;
            this.descriptionLabel.Text = "Description";
            // 
            // nonotesLabel
            // 
            this.nonotesLabel.AutoSize = true;
            this.nonotesLabel.Location = new System.Drawing.Point(31, 127);
            this.nonotesLabel.Name = "nonotesLabel";
            this.nonotesLabel.Size = new System.Drawing.Size(65, 13);
            this.nonotesLabel.TabIndex = 7;
            this.nonotesLabel.Text = "No. of notes";
            // 
            // noNotesfield
            // 
            this.noNotesfield.Location = new System.Drawing.Point(102, 127);
            this.noNotesfield.Name = "noNotesfield";
            this.noNotesfield.ReadOnly = true;
            this.noNotesfield.Size = new System.Drawing.Size(170, 20);
            this.noNotesfield.TabIndex = 3;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(196, 154);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 4;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(115, 154);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(75, 23);
            this.CloseBtn.TabIndex = 5;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // NotebookWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 184);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.noNotesfield);
            this.Controls.Add(this.nonotesLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.descriptionField);
            this.Controls.Add(this.nameField);
            this.Controls.Add(this.nameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NotebookWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notebook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.TextBox descriptionField;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label nonotesLabel;
        private System.Windows.Forms.TextBox noNotesfield;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button CloseBtn;
    }
}