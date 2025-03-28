using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using NonogramOfficial.Controllers;
using NonogramOfficial;
using NonogramOfficial.Views;
using NonogramOfficial;
using NonogramOfficial.Helpers;

namespace NonogramOfficial.Views
{
    public partial class NonogramGame : Form
    {
        private readonly IGameInitializer gameInitializer;
        private readonly IGameSaver gameSaver;
        private readonly IGameResetter gameResetter;
        private readonly NonogramController controller;
        private AppSettings _settings;

        public NonogramGame()
        {
            InitializeComponent();
            _settings = AppSettings.LoadSettings();
            controller = new NonogramController(nonogram, rowsCluesPanel, colCluesPanel, timerLabel);
            gameInitializer = controller;
            gameSaver = controller;
            gameResetter = controller;
            sizeComboBox.SelectedIndex = 0; // Default to 5x5
            gameInitializer.InitializeGame();
        }

        public void StartNewGame(int gridSize)
        {
            gameInitializer.ChangeGridSize(gridSize);
        }

        public void LoadSelectedGame()
        {
            var savedGames = controller.GetSavedGames();
            if (savedGames.Count == 0)
            {
                MessageBox.Show("No saved games found.");
                return;
            }

            bool deleteSelected;
            string selectedSave = PromptLoad.ShowDialog("Select a save to load or delete:", "Load/Delete Game", savedGames, out deleteSelected);
            if (!string.IsNullOrEmpty(selectedSave))
            {
                if (deleteSelected)
                {
                    var result = MessageBox.Show($"Are you sure you want to delete the save '{selectedSave}'?", "Delete Save", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        controller.DeleteSave(selectedSave);
                    }
                }
                else
                {
                    gameSaver.LoadGame(selectedSave);
                }
            }
        }


            // load in user settings
            //sizeComboBox.SelectedIndex = _settings.DefaultGameSize;
            //controller.InitializeGame();
 

        private void NonogramGame_Load(object sender, EventArgs e)
        {
            if (_settings != null && !string.IsNullOrEmpty(_settings.FontFamily))
            {
                FontHelper.ApplyGlobalFont(this, _settings.FontFamily);
            }
        }

        private void sizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedSize = sizeComboBox.SelectedItem.ToString();
            int newSize = int.Parse(selectedSize.Split('x')[0]);
            gameInitializer.ChangeGridSize(newSize);
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to reset the puzzle?", "Reset Puzzle", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                gameResetter.ResetGame();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string saveName = Prompt.ShowDialog("Enter a name for your save:", "Save Game");
            if (!string.IsNullOrEmpty(saveName))
            {
                gameSaver.SaveGame(saveName);
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            LoadSelectedGame();
        }

        private void buttonStatistics_Click(object sender, EventArgs e)
        {
            var statisticsForm = new StatisticsForm();
            statisticsForm.Show(); // Opent het Statistics form
        }

        private void buttonMainMenu_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Would you like to save the game before returning to the main menu?", "Save Game", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes)
            {
                string saveName = Prompt.ShowDialog("Enter a name for your save:", "Save Game");
                if (!string.IsNullOrEmpty(saveName))
                {
                    gameSaver.SaveGame(saveName);
                }
                controller.ReturnToMainMenu(this);
            }
            else if (result == DialogResult.No)
            {
                controller.ReturnToMainMenu(this);
            }
        }

        private void solveButton_Click(object sender, EventArgs e)
        {
            controller.SolvePuzzle();
        }
    }
}
