using System.Windows.Forms;

namespace NonogramPuzzle
{
    partial class NonogramGame
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
            nonogram = new TableLayoutPanel();
            rowsCluesPanel = new Panel();
            colCluesPanel = new Panel();
            timerLabel = new Label();
            sizeComboBox = new ComboBox();
            resetButton = new Button();
            saveButton = new Button();
            loadButton = new Button();
            comboBoxLabel = new Label();
            buttonStatistics = new Button();
            buttonMainMenu = new Button();
            solveButton = new Button();
            SuspendLayout();
            // 
            // nonogram
            // 
            nonogram.Anchor = AnchorStyles.None;
            nonogram.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            nonogram.ColumnCount = 5;
            nonogram.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            nonogram.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            nonogram.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            nonogram.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            nonogram.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            nonogram.Location = new Point(290, 188);
            nonogram.Margin = new Padding(3, 2, 3, 2);
            nonogram.Name = "nonogram";
            nonogram.RowCount = 5;
            nonogram.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            nonogram.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            nonogram.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            nonogram.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            nonogram.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            nonogram.Size = new Size(295, 292);
            nonogram.TabIndex = 0;
            // 
            // rowsCluesPanel
            // 
            rowsCluesPanel.Anchor = AnchorStyles.None;
            rowsCluesPanel.Location = new Point(202, 188);
            rowsCluesPanel.Margin = new Padding(4);
            rowsCluesPanel.Name = "rowsCluesPanel";
            rowsCluesPanel.Size = new Size(83, 292);
            rowsCluesPanel.TabIndex = 1;
            // 
            // colCluesPanel
            // 
            colCluesPanel.Anchor = AnchorStyles.None;
            colCluesPanel.Location = new Point(291, 81);
            colCluesPanel.Margin = new Padding(4);
            colCluesPanel.Name = "colCluesPanel";
            colCluesPanel.Size = new Size(295, 101);
            colCluesPanel.TabIndex = 2;
            // 
            // timerLabel
            // 
            timerLabel.AutoSize = true;
            timerLabel.Location = new Point(14, 10);
            timerLabel.Margin = new Padding(4, 0, 4, 0);
            timerLabel.Name = "timerLabel";
            timerLabel.Size = new Size(49, 15);
            timerLabel.TabIndex = 3;
            timerLabel.Text = "00:00:00";
            // 
            // sizeComboBox
            // 
            sizeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            sizeComboBox.FormattingEnabled = true;
            sizeComboBox.Items.AddRange(new object[] { "5x5", "10x10", "15x15", "20x20" });
            sizeComboBox.Location = new Point(15, 69);
            sizeComboBox.Margin = new Padding(4);
            sizeComboBox.Name = "sizeComboBox";
            sizeComboBox.Size = new Size(140, 23);
            sizeComboBox.TabIndex = 4;
            sizeComboBox.SelectedIndexChanged += sizeComboBox_SelectedIndexChanged;
            // 
            // resetButton
            // 
            resetButton.Location = new Point(14, 105);
            resetButton.Margin = new Padding(4);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(141, 26);
            resetButton.TabIndex = 5;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(14, 140);
            saveButton.Margin = new Padding(4);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(141, 26);
            saveButton.TabIndex = 6;
            saveButton.Text = "Save Progress";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // loadButton
            // 
            loadButton.Location = new Point(14, 174);
            loadButton.Margin = new Padding(4);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(141, 26);
            loadButton.TabIndex = 7;
            loadButton.Text = "Load Progress";
            loadButton.UseVisualStyleBackColor = true;
            loadButton.Click += loadButton_Click;
            // 
            // comboBoxLabel
            // 
            comboBoxLabel.AutoSize = true;
            comboBoxLabel.Font = new Font("Segoe UI", 9F);
            comboBoxLabel.Location = new Point(15, 50);
            comboBoxLabel.Name = "comboBoxLabel";
            comboBoxLabel.Size = new Size(197, 15);
            comboBoxLabel.TabIndex = 8;
            comboBoxLabel.Text = "New game? - Choose your difficulty";
            // 
            // buttonStatistics
            // 
            buttonStatistics.Location = new Point(12, 440);
            buttonStatistics.Name = "buttonStatistics";
            buttonStatistics.Size = new Size(141, 26);
            buttonStatistics.TabIndex = 9;
            buttonStatistics.Text = "Statistics";
            buttonStatistics.UseVisualStyleBackColor = true;
            buttonStatistics.Click += buttonStatistics_Click;
            // 
            // buttonMainMenu
            // 
            buttonMainMenu.Location = new Point(12, 474);
            buttonMainMenu.Name = "buttonMainMenu";
            buttonMainMenu.Size = new Size(141, 26);
            buttonMainMenu.TabIndex = 10;
            buttonMainMenu.Text = "Main menu";
            buttonMainMenu.UseVisualStyleBackColor = true;
            buttonMainMenu.Click += buttonMainMenu_Click;
            // 
            // solveButton
            // 
            solveButton.Location = new Point(683, 474);
            solveButton.Name = "solveButton";
            solveButton.Size = new Size(141, 26);
            solveButton.TabIndex = 11;
            solveButton.Text = "Solve puzzle";
            solveButton.UseVisualStyleBackColor = true;
            solveButton.Click += solveButton_Click;
            // 
            // NonogramGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 512);
            Controls.Add(solveButton);
            Controls.Add(buttonMainMenu);
            Controls.Add(buttonStatistics);
            Controls.Add(comboBoxLabel);
            Controls.Add(loadButton);
            Controls.Add(saveButton);
            Controls.Add(resetButton);
            Controls.Add(sizeComboBox);
            Controls.Add(timerLabel);
            Controls.Add(colCluesPanel);
            Controls.Add(rowsCluesPanel);
            Controls.Add(nonogram);
            Margin = new Padding(3, 2, 3, 2);
            Name = "NonogramGame";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();

        }




        #endregion

        private System.Windows.Forms.TableLayoutPanel nonogram;
        private Panel rowsCluesPanel;
        private Panel colCluesPanel;
        private Label timerLabel;
        private ComboBox sizeComboBox;
        private Button resetButton;
        private Button saveButton;
        private Button loadButton;
        private Label comboBoxLabel;
        private Button buttonStatistics;
        private Button buttonMainMenu;
        private Button solveButton;
    }
}
