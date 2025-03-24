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
            nonogram.Location = new Point(289, 188);
            nonogram.Margin = new Padding(2);
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
            rowsCluesPanel.Margin = new Padding(4, 3, 4, 3);
            rowsCluesPanel.Name = "rowsCluesPanel";
            rowsCluesPanel.Size = new Size(83, 292);
            rowsCluesPanel.TabIndex = 1;
            // 
            // colCluesPanel
            // 
            colCluesPanel.Anchor = AnchorStyles.None;
            colCluesPanel.Location = new Point(292, 81);
            colCluesPanel.Margin = new Padding(4, 3, 4, 3);
            colCluesPanel.Name = "colCluesPanel";
            colCluesPanel.Size = new Size(295, 102);
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
            sizeComboBox.Location = new Point(14, 40);
            sizeComboBox.Margin = new Padding(4, 3, 4, 3);
            sizeComboBox.Name = "sizeComboBox";
            sizeComboBox.Size = new Size(140, 23);
            sizeComboBox.TabIndex = 4;
            sizeComboBox.SelectedIndexChanged += sizeComboBox_SelectedIndexChanged;
            // 
            // resetButton
            // 
            resetButton.Location = new Point(14, 81);
            resetButton.Margin = new Padding(4, 3, 4, 3);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(141, 27);
            resetButton.TabIndex = 5;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(14, 115);
            saveButton.Margin = new Padding(4, 3, 4, 3);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(141, 27);
            saveButton.TabIndex = 6;
            saveButton.Text = "Save Progress";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // loadButton
            // 
            loadButton.Location = new Point(14, 150);
            loadButton.Margin = new Padding(4, 3, 4, 3);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(141, 27);
            loadButton.TabIndex = 7;
            loadButton.Text = "Load Progress";
            loadButton.UseVisualStyleBackColor = true;
            loadButton.Click += loadButton_Click;
            // 
            // NonogramGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 512);
            Controls.Add(loadButton);
            Controls.Add(saveButton);
            Controls.Add(resetButton);
            Controls.Add(sizeComboBox);
            Controls.Add(timerLabel);
            Controls.Add(colCluesPanel);
            Controls.Add(rowsCluesPanel);
            Controls.Add(nonogram);
            Margin = new Padding(2);
            Name = "NonogramGame";
            Text = "NONOGRAM Puzzle";
            Load += NonogramGame_Load;
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
    }
}
