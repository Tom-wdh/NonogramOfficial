using Microsoft.VisualBasic;
using NonogramOfficial.Controllers;
using NonogramOfficial.Helpers;
using NonogramOfficial.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NonogramOfficial.Views
{
    public partial class Settings : Form
    {

        private readonly SettingsController _settingsController;
        private readonly AppSettings _settings;

        public Settings(AppSettings settings)
        {
            InitializeComponent();
            _settingsController = new SettingsController();
            _settings = settings;
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            // Voeg lettertypen toe aan de lijst
            string[] fonts = { "Arial", "Verdana", "Tahoma", "Trebuchet MS", "Times New Roman", "Georgia", "Garamond", "Courier New", "Brush Script MT" };
            lettertypeComboBox.Items.AddRange(fonts);

            int gameSize = _settings.DefaultGameSize;
            switch (gameSize)
            {
                case 0: DefaultSize_comboBox.Text = "5x5"; break;
                case 1: DefaultSize_comboBox.Text = "10x10"; break;
                case 2: DefaultSize_comboBox.Text = "15x15"; break;
                case 3: DefaultSize_comboBox.Text = "20x20"; break;
                default:
                    // Optioneel: een default case indien nodig
                    break;
            }



            // Selecteer het huidige font
            lettertypeComboBox.SelectedItem = _settings.FontFamily;

            if (_settings != null && !string.IsNullOrEmpty(_settings.FontFamily))
            {
                FontHelper.ApplyGlobalFont(this, _settings.FontFamily);
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                _settings.FontFamily = lettertypeComboBox.SelectedItem.ToString();
                string updateItem = DefaultSize_comboBox.SelectedItem?.ToString();


                switch (updateItem)
                {
                    case "5x5":
                        _settings.DefaultGameSize = 0;
                        break;
                    case "10x10":
                        _settings.DefaultGameSize = 1;
                        break;
                    case "15x15":
                        _settings.DefaultGameSize = 2;
                        break;
                    case "20x20":
                        _settings.DefaultGameSize = 3;
                        break;
                    default:
                        // Handle all other cases
                        break;
                }
                _settings.SaveSettings();

                FontHelper.ApplyGlobalFont(Application.OpenForms[0], _settings.FontFamily);
                MessageBox.Show("Settings are saved!");
                this.Close();
            } catch (Exception err) {
                MessageBox.Show(err.ToString()); 
            }
        }

        
    }
}
