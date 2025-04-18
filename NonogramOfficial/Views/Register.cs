﻿using NonogramOfficial.Controllers;
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
    public partial class Register : Form
    {
        private readonly UserController _userManager;
        private AppSettings _settings;

        public Register(UserController userManager)
        {
            InitializeComponent();
            _settings = AppSettings.LoadSettings();
            _userManager = userManager;
        }

        private void Register_Load(object sender, EventArgs e)
        {
            if (_settings != null && !string.IsNullOrEmpty(_settings.FontFamily))
            {
                FontHelper.ApplyGlobalFont(this, _settings.FontFamily);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void buttonRegisterUser_Click(object sender, EventArgs e)
        {
            string username = textBox_username.Text.Trim();
            string password = textBox_password.Text;

            bool success = await _userManager.RegisterUserAsync(username, password);

            if (success)
            {
                MessageBox.Show("Registratie succesvol!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Registratie mislukt! Gebruikersnaam bestaat al.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
