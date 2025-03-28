using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using NonogramOfficial.Helpers;

namespace NonogramOfficial.Initializers
{
    public static class CluesInitializer
    {
        public static void InitializeClues(Panel rowsCluesPanel, Panel colCluesPanel, int[,] solution, int gridSize)
        {
            rowsCluesPanel.SuspendLayout();
            colCluesPanel.SuspendLayout();
            rowsCluesPanel.Controls.Clear();
            colCluesPanel.Controls.Clear();
            int rowHeight = rowsCluesPanel.Height / gridSize;
            int colWidth = colCluesPanel.Width / gridSize;

            for (int row = 0; row < gridSize; row++)
            {
                List<int> rowClues = NonogramHelpers.GetCluesForLine(solution, row, true);
                Label rowClueLabel = new Label
                {
                    Text = string.Join(" ", rowClues),
                    AutoSize = true,
                    TextAlign = ContentAlignment.MiddleRight,
                    Location = new Point(0, row * rowHeight),
                    Size = new Size(rowsCluesPanel.Width, rowHeight)
                };
                rowsCluesPanel.Controls.Add(rowClueLabel);
            }

            for (int col = 0; col < gridSize; col++)
            {
                List<int> colClues = NonogramHelpers.GetCluesForLine(solution, col, false);
                Panel colCluePanel = new Panel
                {
                    Location = new Point(col * colWidth, 0),
                    Size = new Size(colWidth, colCluesPanel.Height)
                };

                for (int i = 0; i < colClues.Count; i++)
                {
                    Label colClueLabel = new Label
                    {
                        Text = colClues[i].ToString(),
                        AutoSize = true,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Location = new Point(0, i * (colCluesPanel.Height / colClues.Count))
                    };
                    colCluePanel.Controls.Add(colClueLabel);
                }

                colCluesPanel.Controls.Add(colCluePanel);
            }

            rowsCluesPanel.ResumeLayout();
            colCluesPanel.ResumeLayout();
        }
    }
}
