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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            buttonCreateUser = new Button();
            button1 = new Button();
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
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(324, 140);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "naam";
            textBox1.Size = new Size(156, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(326, 189);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "wachtwoord";
            textBox2.Size = new Size(154, 23);
            textBox2.TabIndex = 2;
            // 
            // buttonCreateUser
            // 
            buttonCreateUser.Location = new Point(324, 235);
            buttonCreateUser.Name = "buttonCreateUser";
            buttonCreateUser.Size = new Size(156, 23);
            buttonCreateUser.TabIndex = 3;
            buttonCreateUser.Text = "Account aanmaken";
            buttonCreateUser.UseVisualStyleBackColor = true;
            buttonCreateUser.Click += button1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(325, 270);
            button1.Name = "button1";
            button1.Size = new Size(155, 23);
            button1.TabIndex = 4;
            button1.Text = "Terug";
            button1.UseVisualStyleBackColor = true;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(buttonCreateUser);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Register";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button buttonCreateUser;
        private Button button1;
    }
}