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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hoofdpagina));
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            colorDialog1 = new ColorDialog();
            buttonLogin = new Button();
            buttonRegister = new Button();
            SettingsButton = new Button();
            label2 = new Label();
            UserPictureBox = new PictureBox();
            buttonLogout = new Button();
            ((System.ComponentModel.ISupportInitialize)UserPictureBox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 40F);
            label1.Location = new Point(245, 28);
            label1.Name = "label1";
            label1.Size = new Size(358, 89);
            label1.TabIndex = 0;
            label1.Text = "Nonogram";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 30F);
            button1.Location = new Point(291, 129);
            button1.Name = "button1";
            button1.Size = new Size(238, 79);
            button1.TabIndex = 1;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += StartButton_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 30F);
            button2.Location = new Point(291, 297);
            button2.Name = "button2";
            button2.Size = new Size(238, 79);
            button2.TabIndex = 2;
            button2.Text = "Quit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += buttonQuit_Click;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(384, 383);
            buttonLogin.Margin = new Padding(3, 4, 3, 4);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(145, 31);
            buttonLogin.TabIndex = 3;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // buttonRegister
            // 
            buttonRegister.Location = new Point(291, 383);
            buttonRegister.Margin = new Padding(3, 4, 3, 4);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(86, 31);
            buttonRegister.TabIndex = 4;
            buttonRegister.Text = "Register";
            buttonRegister.UseVisualStyleBackColor = true;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // SettingsButton
            // 
            SettingsButton.Font = new Font("Segoe UI", 29F);
            SettingsButton.Location = new Point(255, 160);
            SettingsButton.Margin = new Padding(3, 2, 3, 2);
            SettingsButton.Name = "SettingsButton";
            SettingsButton.Size = new Size(208, 59);
            SettingsButton.TabIndex = 6;
            SettingsButton.Text = "Settings";
            SettingsButton.UseVisualStyleBackColor = true;
            SettingsButton.Click += SettingsButton_Click;

            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 40F);
            label2.Location = new Point(245, 31);
            label2.Name = "label2";
            label2.Size = new Size(358, 89);
            label2.TabIndex = 0;
            label2.Text = "Nonogram";
            // 
            // UserPictureBox
            // 
            UserPictureBox.BorderStyle = BorderStyle.FixedSingle;
            UserPictureBox.Image = (Image)resources.GetObject("UserPictureBox.Image");
            UserPictureBox.Location = new Point(14, 368);
            UserPictureBox.Margin = new Padding(3, 4, 3, 4);
            UserPictureBox.Name = "UserPictureBox";
            UserPictureBox.Size = new Size(58, 66);
            UserPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            UserPictureBox.TabIndex = 7;
            UserPictureBox.TabStop = false;
            UserPictureBox.Click += buttonProfileSettings_Click;
            // 
            // buttonLogout
            // 
            buttonLogout.Location = new Point(694, 410);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(94, 29);
            buttonLogout.TabIndex = 8;
            buttonLogout.Text = "Logout";
            buttonLogout.UseVisualStyleBackColor = true;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // Hoofdpagina
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(buttonLogout);
            Controls.Add(UserPictureBox);
            Controls.Add(SettingsButton);
            Controls.Add(buttonRegister);
            Controls.Add(buttonLogin);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Hoofdpagina";
            Text = "Nonogram game";
            Load += Hoofdpagina_Load;
            ((System.ComponentModel.ISupportInitialize)UserPictureBox).EndInit();
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
        private Button SettingsButton;
        private Label label2;
        private PictureBox UserPictureBox;
        private Button buttonLogout;
    }
}
