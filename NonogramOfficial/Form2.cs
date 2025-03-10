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
    public partial class Form2 : Form
    {
        Image tutorial2 = Properties.Resources.tutorial2;
        public Form2()
        {
            InitializeComponent();
        }

        private void tutorialText_Click(object sender, EventArgs e)
        {

        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            tutorialText.Text = "";
            tutorialGif.Image = tutorial2;
        }
    }
}
