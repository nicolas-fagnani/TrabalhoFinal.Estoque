using Estoque.Application.Services;

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
    }
}
