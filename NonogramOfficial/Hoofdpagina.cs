using NonogramOfficial.Managers;

namespace NonogramOfficial
{
    public partial class Hoofdpagina : Form
    {

        private readonly UserManager _userManager;

        public Hoofdpagina(UserManager userManager)
        {
            InitializeComponent();
            _userManager = userManager;
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
            var InlogForm = new Login(_userManager);
            InlogForm.Show(); // Opent het login-scherm
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            var RegisterForm = new Register(_userManager);
            RegisterForm.Show(); // Opent het login-scherm
        }



    }
}
