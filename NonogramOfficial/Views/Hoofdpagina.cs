using NonogramOfficial.Controllers;
using NonogramOfficial.Properties;
using NonogramOfficial.Views;
using NonogramPuzzle;
using Settings = NonogramOfficial.Views.Settings;

namespace NonogramOfficial
{
    public partial class Hoofdpagina : Form
    {

        private readonly UserController _uc;

        public Hoofdpagina(UserController _uc)
        {
            InitializeComponent();
            this._uc = _uc;
        }

        private void Hoofdpagina_Load(object sender, EventArgs e)
        {

        }


        private void StartButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Have you played before?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                NonogramGame nonogramGameForm = new NonogramGame();
                this.Hide();
                nonogramGameForm.StartPosition = FormStartPosition.Manual; // Allow manual positioning
                nonogramGameForm.Location = this.Location;
                nonogramGameForm.Show();
                nonogramGameForm.FormClosed += (s, args) => this.Close();
            }
            else
            {

                Tutorial newForm = new Tutorial();
                this.Hide();
                newForm.StartPosition = FormStartPosition.Manual; // Allow manual positioning
                newForm.Location = this.Location;
                newForm.Show();
                newForm.FormClosed += (s, args) => this.Close();

            }
        }

        private void SettingsButton_Click(Object sender, EventArgs e)
        {
            var currentSettings = AppSettings.LoadSettings();

            var SettingsForm = new Settings(currentSettings);
            SettingsForm.Show();
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        // door verwijzing naar Login pagina
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var InlogForm = new Login(_uc);
            InlogForm.Show(); // Opent het login-scherm
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            var RegisterForm = new Register(_uc);
            RegisterForm.Show(); // Opent het Register form
        }

        private void buttonProfileSettings_Click(object sender, EventArgs e)
        {
            if (_uc.LoggedInUser == null) {
                // open dialog needs to login first
                MessageBox.Show("Create account to use profile settings or login with account", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                var ProfileForm = new ProfileSettings(_uc);
                ProfileForm.Show(); // Opent het Profiel form
            }
        }

       
    }
}
