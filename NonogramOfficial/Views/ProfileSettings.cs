using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NonogramOfficial.Controllers;

namespace NonogramOfficial
{
    public partial class ProfileSettings : Form
    {
        private readonly UserController _uc;

        public ProfileSettings(UserController _uc)
        {
            InitializeComponent();
            this._uc = _uc;
        }

        private void ProfileSettings_Load(object sender, EventArgs e)
        {
            UserTextBox.Text = _uc.LoggedInUser.Username;
        }

        private async void UpdateProfileSettings_Click(object sender, EventArgs e)
        {
            string oldUsername = _uc.LoggedInUser.Username;
            string newUsername = UserTextBox.Text.Trim();
            string newPassword = PasswordTextBox.Text;

            bool updated = await _uc.UpdateUserAsync(oldUsername, newUsername, newPassword);
            if (updated)
            {
                MessageBox.Show("Profiel bijgewerkt!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Updaten mislukt!");
            }
        }

        private void DeleteUser_Click(object sender, EventArgs e)
        {
            // Bevestigingsdialoog
            var confirm = MessageBox.Show(
                "Áre you sure you want to delete this account?",
                "Delete account",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                // Probeer de gebruiker te verwijderen
                bool deleted = _uc.DeleteUser(_uc.LoggedInUser.Username);
                if (deleted)
                {
                    MessageBox.Show("Account deleted!");
                    // Sluit dit form, of ga terug naar een andere pagina
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Someting went wrong.Please contact developers of this application");
                }
            }
        }

    }
}
