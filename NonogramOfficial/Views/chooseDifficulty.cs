using System;
using System.Windows.Forms;
using NonogramOfficial.Controllers;
using NonogramPuzzle;

namespace NonogramOfficial.Views
{
    public partial class chooseDifficulty : Form
    {
        public chooseDifficulty()
        {
            InitializeComponent();
        }

        private void buttonEasy_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to start a new game on easy mode?", "Start New Game", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                StartNewGame(5);
            }
        }

        private void buttonMedium_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to start a new game on medium mode?", "Start New Game", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                StartNewGame(10);
            }
        }

        private void buttonHard_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to start a new game on hard mode?", "Start New Game", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                StartNewGame(15);
            }
        }

        private void buttonExpert_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to start a new game on expert mode?", "Start New Game", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                StartNewGame(20);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            var hoofdpagina = new Hoofdpagina(new UserController());
            hoofdpagina.Show();
            hoofdpagina.FormClosed += (s, args) => Application.Exit();
            this.Hide();
        }

        private void buttonLoadGame_Click(object sender, EventArgs e)
        {
            var gameForm = new NonogramGame();
            gameForm.LoadSelectedGame();
            gameForm.FormClosed += (s, args) => Application.Exit();
            gameForm.Show();
            this.Hide();
        }

        private void StartNewGame(int gridSize)
        {
            var gameForm = new NonogramGame();
            gameForm.StartNewGame(gridSize);
            gameForm.FormClosed += (s, args) => Application.Exit();
            gameForm.Show();
            this.Hide();
        }
    }
}


