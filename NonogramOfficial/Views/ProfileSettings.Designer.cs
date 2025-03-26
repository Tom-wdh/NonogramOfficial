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
            passwordLabel.Location = new Point(112, 177);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(103, 20);
            passwordLabel.TabIndex = 0;
            passwordLabel.Text = "new password";
            // 
            // UserTextBox
            // 
            UserTextBox.Location = new Point(112, 127);
            UserTextBox.Margin = new Padding(3, 4, 3, 4);
            UserTextBox.Name = "UserTextBox";
            UserTextBox.Size = new Size(127, 27);
            UserTextBox.TabIndex = 1;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(112, 213);
            PasswordTextBox.Margin = new Padding(3, 4, 3, 4);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(127, 27);
            PasswordTextBox.TabIndex = 2;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(45, 432);
            SaveButton.Margin = new Padding(3, 4, 3, 4);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(86, 31);
            SaveButton.TabIndex = 3;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += UpdateProfileSettings_Click;
            // 
            // DeleteAccountButton
            // 
            DeleteAccountButton.Location = new Point(191, 432);
            DeleteAccountButton.Margin = new Padding(3, 4, 3, 4);
            DeleteAccountButton.Name = "DeleteAccountButton";
            DeleteAccountButton.Size = new Size(122, 31);
            DeleteAccountButton.TabIndex = 4;
            DeleteAccountButton.Text = "Delete Account";
            DeleteAccountButton.UseVisualStyleBackColor = true;
            DeleteAccountButton.Click += DeleteUser_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(112, 91);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "username";
            // 
            // ProfileSettings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 589);
            Controls.Add(DeleteAccountButton);
            Controls.Add(SaveButton);
            Controls.Add(PasswordTextBox);
            Controls.Add(UserTextBox);
            Controls.Add(label1);
            Controls.Add(passwordLabel);
            Margin = new Padding(3, 4, 3, 4);
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