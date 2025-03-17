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
            this.nonogram = new System.Windows.Forms.TableLayoutPanel();
            this.rowsCluesPanel = new System.Windows.Forms.Panel();
            this.colCluesPanel = new System.Windows.Forms.Panel();
            this.timerLabel = new System.Windows.Forms.Label();
            this.sizeComboBox = new System.Windows.Forms.ComboBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nonogram
            // 
            this.nonogram.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nonogram.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.nonogram.ColumnCount = 5;
            this.nonogram.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.nonogram.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.nonogram.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.nonogram.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.nonogram.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.nonogram.Location = new System.Drawing.Point(248, 163);
            this.nonogram.Margin = new System.Windows.Forms.Padding(2);
            this.nonogram.Name = "nonogram";
            this.nonogram.RowCount = 5;
            this.nonogram.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.nonogram.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.nonogram.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.nonogram.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.nonogram.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.nonogram.Size = new System.Drawing.Size(253, 253);
            this.nonogram.TabIndex = 0;
            // 
            // rowsCluesPanel
            // 
            this.rowsCluesPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rowsCluesPanel.Location = new System.Drawing.Point(173, 163);
            this.rowsCluesPanel.Name = "rowsCluesPanel";
            this.rowsCluesPanel.Size = new System.Drawing.Size(71, 253);
            this.rowsCluesPanel.TabIndex = 1;
            // 
            // colCluesPanel
            // 
            this.colCluesPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.colCluesPanel.Location = new System.Drawing.Point(250, 70);
            this.colCluesPanel.Name = "colCluesPanel";
            this.colCluesPanel.Size = new System.Drawing.Size(253, 88);
            this.colCluesPanel.TabIndex = 2;
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Location = new System.Drawing.Point(12, 9);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(49, 13);
            this.timerLabel.TabIndex = 3;
            this.timerLabel.Text = "00:00:00";
            // 
            // sizeComboBox
            // 
            this.sizeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sizeComboBox.FormattingEnabled = true;
            this.sizeComboBox.Items.AddRange(new object[] {
            "5x5",
            "10x10",
            "15x15",
            "20x20"});
            this.sizeComboBox.Location = new System.Drawing.Point(12, 35);
            this.sizeComboBox.Name = "sizeComboBox";
            this.sizeComboBox.Size = new System.Drawing.Size(121, 21);
            this.sizeComboBox.TabIndex = 4;
            this.sizeComboBox.SelectedIndexChanged += new System.EventHandler(this.sizeComboBox_SelectedIndexChanged);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(12, 70);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(121, 23);
            this.resetButton.TabIndex = 5;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(12, 100);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(121, 23);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save Progress";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(12, 130);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(121, 23);
            this.loadButton.TabIndex = 7;
            this.loadButton.Text = "Load Progress";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // NonogramGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 444);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.sizeComboBox);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.colCluesPanel);
            this.Controls.Add(this.rowsCluesPanel);
            this.Controls.Add(this.nonogram);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NonogramGame";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

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
