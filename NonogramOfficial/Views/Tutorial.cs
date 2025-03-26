﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NonogramPuzzle;

namespace NonogramOfficial
{
    public partial class Tutorial : Form
    {
        Image tutorial2 = Properties.Resources.tutorial2;
        int click = 0;
        public Tutorial()
        {
            InitializeComponent();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            tutorialText.Text = "When there are two numbers in a row or column, it means there are two separate groups of filled squares.\nExample:  If the clue is 2 2, it means:  \n- One group of 2 filled squares  \n- Another group of 2 filled squares  \n- At least one empty square between them  \nUse the grid size and other clues to figure out their exact positions!";
            tutorialGif.Image = tutorial2;
            click++;
            if (click == 2)
            {
                NonogramGame nonogramGameForm = new NonogramGame();
                this.Hide();
                nonogramGameForm.StartPosition = FormStartPosition.Manual; // Allow manual positioning
                nonogramGameForm.Location = this.Location;
                nonogramGameForm.Show();
                nonogramGameForm.FormClosed += (s, args) => this.Close();
            }
        }

        private void tutorialGif_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
