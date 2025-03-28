using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using NonogramOfficial.Models;

namespace NonogramOfficial.Helpers
{
    public static class NonogramHelpers
    {
        public static List<CellState> GetCurrentState(TableLayoutPanel nonogram, int gridSize)
        {
            List<CellState> currentState = new List<CellState>();

            for (int row = 0; row < gridSize; row++)
            {
                for (int col = 0; col < gridSize; col++)
                {
                    Button cell = (Button)nonogram.GetControlFromPosition(col, row);
                    currentState.Add(new CellState
                    {
                        Row = row,
                        Col = col,
                        IsFilled = cell.BackColor == Color.Black,
                        IsMarked = cell.Text == "X"
                    });
                }
            }

            return currentState;
        }

        public static void SetCurrentState(TableLayoutPanel nonogram, List<CellState> currentState)
        {
            foreach (var cellState in currentState)
            {
                Button cell = (Button)nonogram.GetControlFromPosition(cellState.Col, cellState.Row);
                cell.BackColor = cellState.IsFilled ? Color.Black : Color.White;
                cell.Text = cellState.IsMarked ? "X" : string.Empty;
            }
        }

        public static bool IsPuzzleSolved(TableLayoutPanel nonogram, int[,] solution, int gridSize)
        {
            for (int row = 0; row < gridSize; row++)
            {
                for (int col = 0; col < gridSize; col++)
                {
                    Button cell = (Button)nonogram.GetControlFromPosition(col, row);
                    bool isFilled = cell.BackColor == Color.Black;

                    if (solution[row, col] == 1 && !isFilled)
                    {
                        return false;
                    }
                    if (solution[row, col] == 0 && isFilled)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static void DisableNonogram(TableLayoutPanel nonogram, int gridSize)
        {
            for (int row = 0; row < gridSize; row++)
            {
                for (int col = 0; col < gridSize; col++)
                {
                    Button cell = (Button)nonogram.GetControlFromPosition(col, row);
                    cell.Enabled = false;
                }
            }
        }

        public static List<int> GetCluesForLine(int[,] puzzle, int index, bool isRow)
        {
            List<int> clues = new List<int>();
            int count = 0;

            for (int i = 0; i < (isRow ? puzzle.GetLength(1) : puzzle.GetLength(0)); i++)
            {
                int value = isRow ? puzzle[index, i] : puzzle[i, index];
                if (value == 1)
                {
                    count++;
                }
                else if (count > 0)
                {
                    clues.Add(count);
                    count = 0;
                }
            }

            if (count > 0)
            {
                clues.Add(count);
            }

            if (clues.Count == 0)
            {
                clues.Add(0);
            }

            return clues;
        }
    }
}
