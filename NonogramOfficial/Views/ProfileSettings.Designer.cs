namespace NonogramOfficial
{
    partial class ProfileSettings
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
            passwordLabel = new Label();
            UserTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            SaveButton = new Button();
            DeleteAccountButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(98, 133);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(82, 15);
            passwordLabel.TabIndex = 0;
            passwordLabel.Text = "new password";
            // 
            // UserTextBox
            // 
            UserTextBox.Location = new Point(98, 95);
            UserTextBox.Name = "UserTextBox";
            UserTextBox.Size = new Size(112, 23);
            UserTextBox.TabIndex = 1;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(98, 160);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(112, 23);
            PasswordTextBox.TabIndex = 2;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(39, 324);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 23);
            SaveButton.TabIndex = 3;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += UpdateProfileSettings_Click;
            // 
            // DeleteAccountButton
            // 
            DeleteAccountButton.Location = new Point(167, 324);
            DeleteAccountButton.Name = "DeleteAccountButton";
            DeleteAccountButton.Size = new Size(107, 23);
            DeleteAccountButton.TabIndex = 4;
            DeleteAccountButton.Text = "Delete Account";
            DeleteAccountButton.UseVisualStyleBackColor = true;
            DeleteAccountButton.Click += DeleteUser_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(98, 68);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "username";
            // 
            // ProfileSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(296, 442);
            Controls.Add(DeleteAccountButton);
            Controls.Add(SaveButton);
            Controls.Add(PasswordTextBox);
            Controls.Add(UserTextBox);
            Controls.Add(label1);
            Controls.Add(passwordLabel);
            Name = "ProfileSettings";
            Text = "Profile Settings";
            Load += ProfileSettings_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label passwordLabel;
        private TextBox UserTextBox;
        private TextBox PasswordTextBox;
        private Button SaveButton;
        private Button DeleteAccountButton;
        private Label label1;
    }
}