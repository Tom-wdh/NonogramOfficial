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
using NonogramOfficial.Managers;

namespace NonogramOfficial
{
    public partial class Login : Form
    {
        private readonly UserManager _userManager;

        

        public Login(UserManager userManager)
        {
            InitializeComponent();
            _userManager = userManager;

        }

        private void buttonGoToRegisterForm_Click(object sender, EventArgs e)
        {
            var registerForm = new Register(_userManager);
            registerForm.Show();
            this.Close();
        }


        private async void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text.Trim();
            string password = passwordTextBox.Text;

            bool success = await _userManager.LoginUserAsync(username, password);
            if (success)
            {
                MessageBox.Show("Inloggen geslaagd!");
            }
            else
            {
                MessageBox.Show("Inloggen mislukt!");
            }
        }
    }
}
