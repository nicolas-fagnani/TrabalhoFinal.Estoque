using Estoque.Application.Services;
using Estoque.Forms.Pages;

namespace WinFormsApp1
{
    public partial class FormLogin : Form
    {

        private readonly UserService _userService;
        public FormLogin(UserService userService)
        {
            InitializeComponent();
            _userService = userService;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbEmail.Text) || string.IsNullOrEmpty(tbPassword.Text))
            {
                MessageBox.Show("Please fill in email and password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var user = _userService.GetByEmail(tbEmail.Text, tbPassword.Text);

            if (user != null)
            {
                MessageBox.Show($"Welcome, {user.Name}!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();

                var formMenu = new FormMenu(user.Name);
                formMenu.FormClosed += (s, args) => this.Close();
                formMenu.Show();
            }
            else
            {
                MessageBox.Show("Invalid email or password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblSingUp_Click(object sender, EventArgs e)
        {
            var formUser = new FormUser(_userService);
            formUser.ShowDialog();
        }
    }
}
