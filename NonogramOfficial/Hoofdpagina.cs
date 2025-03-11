using NonogramOfficial.Controllers;

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

        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            this.Close();
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
