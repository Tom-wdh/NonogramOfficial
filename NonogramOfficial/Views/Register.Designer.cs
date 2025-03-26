namespace NonogramOfficial
{
    partial class Register
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
            textBox_username = new TextBox();
            textBox_password = new TextBox();
            buttonCreateUser = new Button();
            buttonClose = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(313, 56);
            label1.Name = "label1";
            label1.Size = new Size(167, 54);
            label1.TabIndex = 0;
            label1.Text = "Register";
            // 
            // textBox_username
            // 
            textBox_username.Location = new Point(324, 140);
            textBox_username.Name = "textBox_username";
            textBox_username.PlaceholderText = "name";
            textBox_username.Size = new Size(156, 23);
            textBox_username.TabIndex = 1;
            // 
            // textBox_password
            // 
            textBox_password.Location = new Point(326, 189);
            textBox_password.Name = "textBox_password";
            textBox_password.PlaceholderText = "password";
            textBox_password.Size = new Size(154, 23);
            textBox_password.TabIndex = 2;
            // 
            // buttonCreateUser
            // 
            buttonCreateUser.Location = new Point(324, 235);
            buttonCreateUser.Name = "buttonCreateUser";
            buttonCreateUser.Size = new Size(156, 23);
            buttonCreateUser.TabIndex = 3;
            buttonCreateUser.Text = "Create Account";
            buttonCreateUser.UseVisualStyleBackColor = true;
            buttonCreateUser.Click += buttonRegisterUser_Click;
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(325, 270);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(155, 23);
            buttonClose.TabIndex = 4;
            buttonClose.Text = "Go back";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonClose);
            Controls.Add(buttonCreateUser);
            Controls.Add(textBox_password);
            Controls.Add(textBox_username);
            Controls.Add(label1);
            Name = "Register";
            Text = "Register";
            Load += Register_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox_username;
        private TextBox textBox_password;
        private Button buttonCreateUser;
        private Button buttonClose;
    }
}