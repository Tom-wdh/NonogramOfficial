namespace NonogramOfficial
{
    partial class Tutorial
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
            tutorialText = new Label();
            tutorialGif = new PictureBox();
            nextButton = new Button();
            ((System.ComponentModel.ISupportInitialize)tutorialGif).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(281, -3);
            label1.Name = "label1";
            label1.Size = new Size(206, 67);
            label1.TabIndex = 0;
            label1.Text = "Tutorial:";
            label1.Click += label1_Click;
            // 
            // tutorialText
            // 
            tutorialText.AutoSize = true;
            tutorialText.Location = new Point(35, 64);
            tutorialText.Name = "tutorialText";
            tutorialText.Size = new Size(514, 60);
            tutorialText.TabIndex = 1;
            tutorialText.Text = "If the clue is \"3\", you must fill three connected squares in that row or column.\nUse the grid's size and other clues to determine the exact placement!\nIn the example below the clue is \"5\".";
            // 
            // tutorialGif
            // 
            tutorialGif.Image = Properties.Resources.nono5_ezgif_com_video_to_gif_converter;
            tutorialGif.Location = new Point(359, 193);
            tutorialGif.Name = "tutorialGif";
            tutorialGif.Size = new Size(41, 255);
            tutorialGif.TabIndex = 2;
            tutorialGif.TabStop = false;
            tutorialGif.Click += tutorialGif_Click;
            // 
            // nextButton
            // 
            nextButton.Location = new Point(694, 409);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(94, 29);
            nextButton.TabIndex = 3;
            nextButton.Text = "Next->";
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += nextButton_Click;
            // 
            // Tutorial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(nextButton);
            Controls.Add(tutorialGif);
            Controls.Add(tutorialText);
            Controls.Add(label1);
            Name = "Tutorial";
            Text = "Tutorial";
            ((System.ComponentModel.ISupportInitialize)tutorialGif).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label tutorialText;
        private PictureBox tutorialGif;
        private Button nextButton;
    }
}