using NonogramOfficial.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NonogramOfficial
{
    public partial class Tutorial : Form
    {
        private AppSettings _settings;
        Image tutorial2 = Properties.Resources.tutorial2;
        
        public Tutorial()
        {
            InitializeComponent();
            _settings = AppSettings.LoadSettings();
        }
        private void Tutorial_Load(object sender, EventArgs e)
        {
            if (_settings != null && !string.IsNullOrEmpty(_settings.FontFamily))
            {
                FontHelper.ApplyGlobalFont(this, _settings.FontFamily);
            }
        }
        

        private void nextButton_Click(object sender, EventArgs e)
        {
            tutorialText.Text = "When there are two numbers in a row or column, it means there are two separate groups of filled squares.\nExample:  If the clue is 2 2, it means:  \n- One group of 2 filled squares  \n- Another group of 2 filled squares  \n- At least one empty square between them  \nUse the grid size and other clues to figure out their exact positions!";
            tutorialGif.Image = tutorial2;
        }

        private void tutorialGif_Click(object sender, EventArgs e)
        {

        }
    }
}
