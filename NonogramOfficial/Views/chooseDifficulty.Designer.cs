namespace NonogramOfficial.Views
{
    partial class chooseDifficulty
    {
        private System.ComponentModel.IContainer components = null;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel;
        private Button buttonEasy;
        private Button buttonMedium;
        private Button buttonHard;
        private Button buttonExpert;
        private Button buttonBack;
        private Button buttonLoadGame;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            tableLayoutPanel = new TableLayoutPanel();
            buttonEasy = new Button();
            buttonMedium = new Button();
            buttonHard = new Button();
            buttonExpert = new Button();
            buttonBack = new Button();
            buttonLoadGame = new Button();
            tableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(800, 50);
            label1.TabIndex = 0;
            label1.Text = "Choose your difficulty!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 4;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel.Controls.Add(buttonEasy, 0, 0);
            tableLayoutPanel.Controls.Add(buttonMedium, 1, 0);
            tableLayoutPanel.Controls.Add(buttonHard, 2, 0);
            tableLayoutPanel.Controls.Add(buttonExpert, 3, 0);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(0, 50);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 1;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel.Size = new Size(800, 300);
            tableLayoutPanel.TabIndex = 1;
            // 
            // buttonEasy
            // 
            buttonEasy.Anchor = AnchorStyles.None;
            buttonEasy.Location = new Point(27, 110);
            buttonEasy.Name = "buttonEasy";
            buttonEasy.Size = new Size(150, 80);
            buttonEasy.TabIndex = 0;
            buttonEasy.Text = "Easy (5x5)";
            buttonEasy.UseVisualStyleBackColor = true;
            buttonEasy.Click += buttonEasy_Click;
            // 
            // buttonMedium
            // 
            buttonMedium.Anchor = AnchorStyles.None;
            buttonMedium.Location = new Point(232, 110);
            buttonMedium.Name = "buttonMedium";
            buttonMedium.Size = new Size(150, 80);
            buttonMedium.TabIndex = 1;
            buttonMedium.Text = "Medium (10x10)";
            buttonMedium.UseVisualStyleBackColor = true;
            buttonMedium.Click += buttonMedium_Click;
            // 
            // buttonHard
            // 
            buttonHard.Anchor = AnchorStyles.None;
            buttonHard.Location = new Point(437, 110);
            buttonHard.Name = "buttonHard";
            buttonHard.Size = new Size(150, 80);
            buttonHard.TabIndex = 2;
            buttonHard.Text = "Hard (15x15)";
            buttonHard.UseVisualStyleBackColor = true;
            buttonHard.Click += buttonHard_Click;
            // 
            // buttonExpert
            // 
            buttonExpert.Anchor = AnchorStyles.None;
            buttonExpert.Location = new Point(642, 110);
            buttonExpert.Name = "buttonExpert";
            buttonExpert.Size = new Size(150, 80);
            buttonExpert.TabIndex = 3;
            buttonExpert.Text = "Expert (20x20)";
            buttonExpert.UseVisualStyleBackColor = true;
            buttonExpert.Click += buttonExpert_Click;
            // 
            // buttonBack
            // 
            buttonBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonBack.Location = new Point(12, 388);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(100, 50);
            buttonBack.TabIndex = 4;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // buttonLoadGame
            // 
            buttonLoadGame.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonLoadGame.Location = new Point(688, 388);
            buttonLoadGame.Name = "buttonLoadGame";
            buttonLoadGame.Size = new Size(100, 50);
            buttonLoadGame.TabIndex = 5;
            buttonLoadGame.Text = "Load Game";
            buttonLoadGame.UseVisualStyleBackColor = true;
            buttonLoadGame.Click += buttonLoadGame_Click;
            // 
            // chooseDifficulty
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonBack);
            Controls.Add(buttonLoadGame);
            Controls.Add(tableLayoutPanel);
            Controls.Add(label1);
            Name = "chooseDifficulty";
            Text = "chooseDifficulty";
            tableLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}


