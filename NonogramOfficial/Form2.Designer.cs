namespace NonogramOfficial
{
    partial class Form2
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
            Tutorial = new Label();
            tutorialText = new Label();
            tutorialGif = new PictureBox();
            nextButton = new Button();
            ((System.ComponentModel.ISupportInitialize)tutorialGif).BeginInit();
            SuspendLayout();
            // 
            // Tutorial
            // 
            Tutorial.AutoSize = true;
            Tutorial.Font = new Font("Segoe UI", 30F);
            Tutorial.Location = new Point(293, 2);
            Tutorial.Name = "Tutorial";
            Tutorial.Size = new Size(195, 67);
            Tutorial.TabIndex = 0;
            Tutorial.Text = "Tutorial";
            Tutorial.Click += Tutorial_Click;
            // 
            // tutorialText
            // 
            tutorialText.AutoSize = true;
            tutorialText.Location = new Point(129, 59);
            tutorialText.Name = "tutorialText";
            tutorialText.Size = new Size(514, 60);
            tutorialText.TabIndex = 1;
            tutorialText.Text = "If the clue is \"3\", you must fill three connected squares in that row or column.\r\nUse the grid's size and other clues to determine the exact placement!\r\nIn the example below the clue is \"5\".\r\n";
            tutorialText.Click += tutorialText_Click;
            // 
            // tutorialGif
            // 
            tutorialGif.Image = Properties.Resources.tutorial1;
            tutorialGif.Location = new Point(373, 178);
            tutorialGif.Name = "tutorialGif";
            tutorialGif.Size = new Size(37, 260);
            tutorialGif.TabIndex = 2;
            tutorialGif.TabStop = false;
            // 
            // nextButton
            // 
            nextButton.Location = new Point(684, 409);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(94, 29);
            nextButton.TabIndex = 3;
            nextButton.Text = "Next ->";
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += nextButton_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(nextButton);
            Controls.Add(tutorialGif);
            Controls.Add(tutorialText);
            Controls.Add(Tutorial);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)tutorialGif).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Tutorial;
        private Label tutorialText;
        private PictureBox tutorialGif;
        private Button nextButton;
    }
}