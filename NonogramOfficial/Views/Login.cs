using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NonogramOfficial.Controllers;
using NonogramOfficial.Helpers;

namespace NonogramOfficial
{
    public partial class Login : Form
    {
        private readonly UserController _uc;
        private AppSettings _settings;



        public Login(UserController userManager)
        {
            InitializeComponent();
            _settings = AppSettings.LoadSettings();
            _uc = userManager;

        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (_settings != null && !string.IsNullOrEmpty(_settings.FontFamily))
            {
                FontHelper.ApplyGlobalFont(this, _settings.FontFamily);
            }
        }

        private void buttonGoToRegisterForm_Click(object sender, EventArgs e)
        {
            var registerForm = new Register(_uc);
            registerForm.Show();
            this.Close();
        }


        private async void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text.Trim();
            string password = passwordTextBox.Text;

            bool success = await _uc.LoginUserAsync(username, password);
            if (success)
            {
                MessageBox.Show("Inloggen geslaagd!");
                if (this.Owner is Hoofdpagina mainForm)
                {
                    //mainForm.UpdateLoggedInUserLabel();
                    
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Inloggen mislukt!");
            }
        }
    }
}
