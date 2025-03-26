namespace NonogramOfficial.Views
{
    partial class StatisticsForm
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
            this.listViewStatistics = new System.Windows.Forms.ListView();
            this.columnHeaderGridSize = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderTimeTaken = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderSolvedDate = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // listViewStatistics
            // 
            this.listViewStatistics.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderGridSize,
            this.columnHeaderTimeTaken,
            this.columnHeaderSolvedDate});
            this.listViewStatistics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewStatistics.FullRowSelect = true;
            this.listViewStatistics.GridLines = true;
            this.listViewStatistics.Location = new System.Drawing.Point(0, 0);
            this.listViewStatistics.Name = "listViewStatistics";
            this.listViewStatistics.Size = new System.Drawing.Size(800, 450);
            this.listViewStatistics.TabIndex = 0;
            this.listViewStatistics.UseCompatibleStateImageBehavior = false;
            this.listViewStatistics.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderGridSize
            // 
            this.columnHeaderGridSize.Text = "Grid Size";
            this.columnHeaderGridSize.Width = 100;
            // 
            // columnHeaderTimeTaken
            // 
            this.columnHeaderTimeTaken.Text = "Time Taken";
            this.columnHeaderTimeTaken.Width = 200;
            // 
            // columnHeaderSolvedDate
            // 
            this.columnHeaderSolvedDate.Text = "Solved Date";
            this.columnHeaderSolvedDate.Width = 200;
            // 
            // StatisticsForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listViewStatistics);
            this.Name = "StatisticsForm";
            this.Text = "Solved Puzzles Statistics";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.ListView listViewStatistics;
        private System.Windows.Forms.ColumnHeader columnHeaderGridSize;
        private System.Windows.Forms.ColumnHeader columnHeaderTimeTaken;
        private System.Windows.Forms.ColumnHeader columnHeaderSolvedDate;

        #endregion
    }
}