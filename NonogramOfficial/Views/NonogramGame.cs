using System;
using System.Windows.Forms;
using NonogramOfficial;
using NonogramOfficial.Helpers;
using NonogramPuzzle.Controllers;

namespace NonogramPuzzle
{
    public partial class NonogramGame : Form
    {
        private NonogramController controller;
        private AppSettings _settings;

        public NonogramGame()
        {
            InitializeComponent();
            _settings = AppSettings.LoadSettings();
            controller = new NonogramController(nonogram, rowsCluesPanel, colCluesPanel, timerLabel);
            sizeComboBox.SelectedIndex = _settings.DefaultGameSize;
            controller.InitializeGame();
        }

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
            controller.ChangeGridSize(newSize);
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to reset the puzzle?", "Reset Puzzle", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                controller.ResetGame();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to save your progress?", "Save Progress", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                controller.SaveGame();
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to load your progress?", "Load Progress", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                controller.LoadGame();
            }
        }
    }
}
