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

namespace NonogramOfficial
{
    public partial class Login : Form
    {
        private readonly UserController _uc;

        

        public Login(UserController userManager)
        {
            InitializeComponent();
            _uc = userManager;

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
