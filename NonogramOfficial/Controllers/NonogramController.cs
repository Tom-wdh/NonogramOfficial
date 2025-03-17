using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using NonogramPuzzle.Helpers;
using NonogramPuzzle.Initializers;
using NonogramPuzzle.Models;
using Timer = System.Windows.Forms.Timer;

namespace NonogramPuzzle.Controllers
{
    public class NonogramController
    {
        private int[,] puzzle = new int[0, 0];
        private int[,] solution = new int[0, 0];
        private Timer timer = new Timer();
        private DateTime startTime;
        private int gridSize = 5;
        private TableLayoutPanel nonogram;
        private Panel rowsCluesPanel;
        private Panel colCluesPanel;
        private Label timerLabel;
        private bool isPuzzleSolved = false;

        public NonogramController(TableLayoutPanel nonogram, Panel rowsCluesPanel, Panel colCluesPanel, Label timerLabel)
        {
            this.nonogram = nonogram;
            this.rowsCluesPanel = rowsCluesPanel;
            this.colCluesPanel = colCluesPanel;
            this.timerLabel = timerLabel;
        }

        public void InitializeGame()
        {
            isPuzzleSolved = false;
            PuzzleInitializer.InitializePuzzle(out puzzle, out solution, gridSize);
            NonogramInitializer.InitializeNonogram(nonogram, puzzle, gridSize, Cell_MouseDown);
            CluesInitializer.InitializeClues(rowsCluesPanel, colCluesPanel, puzzle, gridSize);
            TimerInitializer.InitializeTimer(ref timer, ref startTime, Timer_Tick);
        }

        public void ChangeGridSize(int newSize)
        {
            gridSize = newSize;
            InitializeGame();
        }

        public void ResetGame()
        {
            isPuzzleSolved = false;
            PuzzleInitializer.InitializePuzzle(out puzzle, out solution, gridSize);
            NonogramInitializer.InitializeNonogram(nonogram, puzzle, gridSize, Cell_MouseDown);
            CluesInitializer.InitializeClues(rowsCluesPanel, colCluesPanel, puzzle, gridSize);
            startTime = DateTime.Now;
            timer.Start();
        }

        public void SaveGame()
        {
            var saveData = new SaveData
            {
                Puzzle = puzzle,
                Solution = solution,
                Timer = (DateTime.Now - startTime).ToString(@"hh\:mm\:ss"),
                CurrentState = NonogramHelpers.GetCurrentState(nonogram, gridSize)
            };

            string json = JsonConvert.SerializeObject(saveData, Formatting.Indented);
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "puzzle_save.json");

            try
            {
                File.WriteAllText(filePath, json);
                MessageBox.Show("Progress saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to save progress: {ex.Message}");
            }
        }

        public void LoadGame()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "puzzle_save.json");

            if (File.Exists(filePath))
            {
                try
                {
                    string json = File.ReadAllText(filePath);
                    var saveData = JsonConvert.DeserializeObject<SaveData>(json);

                    puzzle = saveData.Puzzle;
                    solution = saveData.Solution;
                    gridSize = puzzle.GetLength(0);
                    startTime = DateTime.Now - TimeSpan.Parse(saveData.Timer);

                    NonogramInitializer.InitializeNonogram(nonogram, puzzle, gridSize, Cell_MouseDown);
                    CluesInitializer.InitializeClues(rowsCluesPanel, colCluesPanel, puzzle, gridSize);
                    NonogramHelpers.SetCurrentState(nonogram, saveData.CurrentState);
                    timer.Start();

                    MessageBox.Show("Progress loaded successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to load progress: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("No saved progress found.");
            }
        }


        private void Cell_MouseDown(object? sender, MouseEventArgs e)
        {
            if (isPuzzleSolved) return;

            Button clickedCell = (Button)sender!;
            Point position = (Point)clickedCell.Tag;

            if (e.Button == MouseButtons.Left)
            {
                if (clickedCell.BackColor == Color.White)
                {
                    clickedCell.BackColor = Color.Black;
                }
                else
                {
                    clickedCell.BackColor = Color.White;
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                clickedCell.Text = clickedCell.Text == "X" ? string.Empty : "X";
                clickedCell.ForeColor = Color.Black;
            }

            if (NonogramHelpers.IsPuzzleSolved(nonogram, solution, gridSize))
            {
                MessageBox.Show("Puzzle Solved!");
                NonogramHelpers.DisableNonogram(nonogram, gridSize);
                timer.Stop();
                isPuzzleSolved = true;
            }
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            if (isPuzzleSolved) return;

            TimeSpan elapsedTime = DateTime.Now - startTime;
            timerLabel.Text = elapsedTime.ToString(@"hh\:mm\:ss");
        }

    }
}
