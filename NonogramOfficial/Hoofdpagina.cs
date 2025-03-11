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
            //UpdateLoggedInUserLabel();
        }

        //public void UpdateLoggedInUserLabel()
        //{
        //    if (_userManager.LoggedInUser != null)
        //    {
        //        usernameLabel.Text = $"Ingelogd als: {_userManager.LoggedInUser.Username}";
        //    }
        //    else
        //    {
        //        usernameLabel.Text = "Niet ingelogd.";
        //    }
        //}

        private void StartButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Have you played before?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

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

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        // door verwijzing naar Login pagina
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var InlogForm = new Login(_userManager);
            InlogForm.Owner = this;

            InlogForm.Show(); // Opent het login-scherm
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            var RegisterForm = new Register(_userManager);
            RegisterForm.Show(); // Opent het login-scherm
        }
    }
}
