using System;
using System.Drawing;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using NonogramOfficial.Controllers;
using NonogramOfficial;
using NonogramOfficial.Helpers;
using NonogramOfficial.Initializers;
using NonogramOfficial.Models;
using Timer = System.Windows.Forms.Timer;

namespace NonogramOfficial.Controllers
{
    public interface IGameInitializer
    {
        void InitializeGame();
        void ChangeGridSize(int newSize);
    }

    public interface IGameSaver
    {
        void SaveGame(string saveName);
        void LoadGame(string saveName);
    }

    public interface IGameResetter
    {
        void ResetGame();
    }

    public class NonogramController : IGameInitializer, IGameSaver, IGameResetter
    {
        private int[,] puzzle = new int[0, 0];
        private int[,] solution = new int[0, 0];
        private Timer timer = new Timer();
        private DateTime startTime;
        private int gridSize = 5;
        private TableLayoutPanel nonogram;
        private readonly Panel rowsCluesPanel;
        private readonly Panel colCluesPanel;
        private readonly Label timerLabel;
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
            CluesInitializer.InitializeClues(rowsCluesPanel, colCluesPanel, solution, gridSize);
            TimerInitializer.InitializeTimer(ref timer, ref startTime, Timer_Tick);
        }

        public void ChangeGridSize(int newSize)
        {
            gridSize = newSize;
            ResetGame();
        }

        public void ResetGame()
        {
            isPuzzleSolved = false;
            PuzzleInitializer.InitializePuzzle(out puzzle, out solution, gridSize);

            var parent = nonogram.Parent;
            var location = nonogram.Location;
            var size = nonogram.Size;
            var dock = nonogram.Dock;
            var margin = nonogram.Margin;
            var padding = nonogram.Padding;

            parent.Controls.Remove(nonogram);

            var newNonogram = new TableLayoutPanel
            {
                Location = location,
                Size = size,
                Dock = dock,
                Margin = margin,
                Padding = padding
            };

            parent.Controls.Add(newNonogram);
            nonogram = newNonogram;

            NonogramInitializer.InitializeNonogram(nonogram, puzzle, gridSize, Cell_MouseDown);
            CluesInitializer.InitializeClues(rowsCluesPanel, colCluesPanel, solution, gridSize);
            startTime = DateTime.Now;
            timer.Start();
        }

        public void SolvePuzzle()
        {
            var result = MessageBox.Show("Are you sure you want to solve the puzzle?", "Solve Puzzle", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes) return;
            {
                Task.Run(() =>
                {
                    for (int row = 0; row < gridSize; row++)
                    {
                        for (int col = 0; col < gridSize; col++)
                        {
                            Button cell = (Button)nonogram.GetControlFromPosition(col, row);
                            cell.Invoke((MethodInvoker)delegate
                            {
                                cell.BackColor = solution[row, col] == 1 ? Color.Black : Color.White;
                            });
                        }
                    }

                    isPuzzleSolved = true;
                    timer.Stop();
                    MessageBox.Show("Puzzle Solved, but it will not be saved!");
                });
            }
        }

        public void SaveGame(string saveName)
        {
            var saveData = new SaveData
            {
                Puzzle = ArrayConverter.ToJagged(puzzle),
                Solution = ArrayConverter.ToJagged(solution),
                Timer = (DateTime.Now - startTime).ToString(@"hh\:mm\:ss"),
                CurrentState = NonogramHelpers.GetCurrentState(nonogram, gridSize)
            };

            string json = JsonSerializer.Serialize(saveData, new JsonSerializerOptions { WriteIndented = true });
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"{saveName}_puzzle_save.json");

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

        public void LoadGame(string saveName)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"{saveName}_puzzle_save.json");

            if (File.Exists(filePath))
            {
                try
                {
                    string json = File.ReadAllText(filePath);
                    var saveData = JsonSerializer.Deserialize<SaveData>(json);

                    puzzle = ArrayConverter.To2D(saveData.Puzzle);
                    solution = ArrayConverter.To2D(saveData.Solution);
                    gridSize = puzzle.GetLength(0);
                    startTime = DateTime.Now - TimeSpan.Parse(saveData.Timer);

                    NonogramInitializer.InitializeNonogram(nonogram, puzzle, gridSize, Cell_MouseDown);
                    CluesInitializer.InitializeClues(rowsCluesPanel, colCluesPanel, solution, gridSize);
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

        public void DeleteSave(string saveName)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"{saveName}_puzzle_save.json");

            if (File.Exists(filePath))
            {
                try
                {
                    File.Delete(filePath);
                    MessageBox.Show("Save deleted successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to delete save: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Save file not found.");
            }
        }

        private void SaveSolvedGame()
        {
            var solvedGameData = new SolvedGameData
            {
                GridSize = gridSize,
                TimeTaken = (DateTime.Now - startTime).ToString(@"hh\:mm\:ss"),
                SolvedDate = DateTime.Now
            };

            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "solved_games.json");
            List<SolvedGameData> solvedGames;

            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                solvedGames = JsonSerializer.Deserialize<List<SolvedGameData>>(json) ?? new List<SolvedGameData>();
            }
            else
            {
                solvedGames = new List<SolvedGameData>();
            }

            solvedGames.Add(solvedGameData);

            string updatedJson = JsonSerializer.Serialize(solvedGames, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, updatedJson);
        }

        private void Cell_MouseDown(object? sender, MouseEventArgs e)
        {
            if (isPuzzleSolved) return;

            Button clickedCell = (Button)sender!;
            Point position = (Point)clickedCell.Tag;

            if (e.Button == MouseButtons.Left)
            {
                clickedCell.BackColor = clickedCell.BackColor == Color.White ? Color.Black : Color.White;
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
                SaveSolvedGame();
            }
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            if (isPuzzleSolved) return;

            TimeSpan elapsedTime = DateTime.Now - startTime;
            timerLabel.Text = elapsedTime.ToString(@"hh\:mm\:ss");
        }

        public List<string> GetSavedGames()
        {
            string saveDirectory = AppDomain.CurrentDomain.BaseDirectory;
            var saveFiles = Directory.GetFiles(saveDirectory, "*_puzzle_save.json");
            var saveNames = new List<string>();

            foreach (var file in saveFiles)
            {
                saveNames.Add(Path.GetFileNameWithoutExtension(file).Replace("_puzzle_save", ""));
            }

            return saveNames;
        }

        public void ReturnToMainMenu(Form currentForm)
        {
            var mainMenu = new Hoofdpagina(new UserController());
            mainMenu.FormClosed += (s, args) => Application.Exit();
            mainMenu.Show();
            currentForm.Hide();
        }
    }
}
