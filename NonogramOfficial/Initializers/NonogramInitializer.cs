using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace NonogramPuzzle.Initializers
{
    public static class NonogramInitializer
    {
        public static void InitializeNonogram(TableLayoutPanel nonogram, int[,] puzzle, int gridSize, MouseEventHandler cellMouseDownHandler)
        {
            nonogram.SuspendLayout();
            nonogram.Controls.Clear();
            nonogram.ColumnCount = gridSize;
            nonogram.RowCount = gridSize;
            nonogram.ColumnStyles.Clear();
            nonogram.RowStyles.Clear();

            for (int i = 0; i < gridSize; i++)
            {
                nonogram.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F / gridSize));
                nonogram.RowStyles.Add(new RowStyle(SizeType.Percent, 100F / gridSize));
            }

            List<Button> buttons = new List<Button>();

            for (int row = 0; row < gridSize; row++)
            {
                for (int col = 0; col < gridSize; col++)
                {
                    Button cell = new Button
                    {
                        Dock = DockStyle.Fill,
                        Tag = new Point(row, col),
                        Margin = new Padding(0),
                        Padding = new Padding(0),
                        BackColor = puzzle[row, col] == 1 ? Color.Black : Color.White,
                        FlatStyle = FlatStyle.Flat
                    };
                    cell.FlatAppearance.BorderColor = Color.Black;
                    cell.FlatAppearance.BorderSize = 1;
                    cell.MouseDown += cellMouseDownHandler;
                    buttons.Add(cell);
                }
            }

            nonogram.Controls.AddRange(buttons.ToArray());
            nonogram.ResumeLayout();
        }
    }
}


