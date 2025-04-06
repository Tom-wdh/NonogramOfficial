using System.Text.Json;
using NonogramOfficial.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace NonogramOfficial.Views
{
    public partial class StatisticsForm : Form
    {
        public StatisticsForm()
        {
            InitializeComponent();
            LoadStatistics();
        }

        private void LoadStatistics()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "solved_games.json");

            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                var solvedGames = JsonSerializer.Deserialize<List<SolvedGameData>>(json) ?? new List<SolvedGameData>();

                foreach (var game in solvedGames)
                {
                    var listViewItem = new ListViewItem(new[]
                    {
                        game.GridSize.ToString() + "x" + game.GridSize.ToString(),
                        game.TimeTaken,
                        game.SolvedDate.ToString("g")
                    });
                    listViewStatistics.Items.Add(listViewItem);
                }
            }
            else
            {
                MessageBox.Show("No solved games found.");
            }
        }
    }
}
