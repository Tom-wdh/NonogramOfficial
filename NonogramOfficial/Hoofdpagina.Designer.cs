namespace NonogramOfficial
{
    partial class HomePage
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
            Title = new Label();
            startButton = new Button();
            quitButton = new Button();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 40F);
            Title.Location = new Point(238, 29);
            Title.Name = "Title";
            Title.Size = new Size(358, 89);
            Title.TabIndex = 0;
            Title.Text = "Nonogram";
            // 
            // startButton
            // 
            startButton.Font = new Font("Segoe UI", 30F);
            startButton.Location = new Point(291, 150);
            startButton.Name = "startButton";
            startButton.Size = new Size(238, 79);
            startButton.TabIndex = 1;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += button1_Click;
            // 
            // quitButton
            // 
            quitButton.Font = new Font("Segoe UI", 30F);
            quitButton.Location = new Point(291, 261);
            quitButton.Name = "quitButton";
            quitButton.Size = new Size(238, 79);
            quitButton.TabIndex = 2;
            quitButton.Text = "Quit";
            quitButton.UseVisualStyleBackColor = true;
            quitButton.Click += button2_Click;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(quitButton);
            Controls.Add(startButton);
            Controls.Add(Title);
            Name = "HomePage";
            Text = "Nonogram";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Button startButton;
        private Button quitButton;
    }
}
