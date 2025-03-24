
namespace NonogramOfficial
{
    partial class Login
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
            label1 = new Label();
            button1 = new Button();
            buttonRegister = new Button();
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 40F);
            label1.Location = new Point(295, 42);
            label1.Name = "label1";
            label1.Size = new Size(185, 72);
            label1.TabIndex = 0;
            label1.Text = "LOGIN";
            // 
            // button1
            // 
            button1.Location = new Point(316, 263);
            button1.Name = "button1";
            button1.Size = new Size(144, 37);
            button1.TabIndex = 1;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonLogin_Click;
            // 
            // buttonRegister
            // 
            buttonRegister.Location = new Point(316, 322);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(144, 39);
            buttonRegister.TabIndex = 2;
            buttonRegister.Text = "Create New User";
            buttonRegister.UseVisualStyleBackColor = true;
            buttonRegister.Click += buttonGoToRegisterForm_Click;
            // 
            // usernameTextBox
            // 
            usernameTextBox.ForeColor = SystemColors.WindowText;
            usernameTextBox.Location = new Point(314, 137);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.PlaceholderText = "name";
            usernameTextBox.Size = new Size(146, 23);
            usernameTextBox.TabIndex = 3;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(315, 188);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PlaceholderText = "password";
            passwordTextBox.Size = new Size(145, 23);
            passwordTextBox.TabIndex = 4;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Controls.Add(buttonRegister);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button buttonRegister;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
    }
}