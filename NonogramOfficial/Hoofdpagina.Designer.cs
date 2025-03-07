namespace NonogramOfficial
{
    partial class Hoofdpagina
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            colorDialog1 = new ColorDialog();
            buttonLogin = new Button();
            buttonRegister = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 40F);
            label1.Location = new Point(214, 21);
            label1.Name = "label1";
            label1.Size = new Size(290, 72);
            label1.TabIndex = 0;
            label1.Text = "Nonogram";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 30F);
            button1.Location = new Point(255, 112);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(208, 59);
            button1.TabIndex = 1;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += StartButton_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 30F);
            button2.Location = new Point(255, 196);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(208, 59);
            button2.TabIndex = 2;
            button2.Text = "Quit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += buttonQuit_Click;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(613, 303);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(75, 23);
            buttonLogin.TabIndex = 3;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // buttonRegister
            // 
            buttonRegister.Location = new Point(532, 303);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(75, 23);
            buttonRegister.TabIndex = 4;
            buttonRegister.Text = "Register";
            buttonRegister.UseVisualStyleBackColor = true;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // Hoofdpagina
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(buttonRegister);
            Controls.Add(buttonLogin);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Hoofdpagina";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private ColorDialog colorDialog1;
        private Button buttonLogin;
        private Button buttonRegister;
    }
}
