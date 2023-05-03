using System.Windows.Input;

namespace Capstone
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            BindingContext = new LoginViewModel();
        }
    }

    public class LoginViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public ICommand LoginCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new Command(() =>
            {
                // Authenticate the user
            });
        }
    }

    public partial class SignUpPage : ContentPage
    {
        public SignUpPage()
        {
            
            BindingContext = new SignUpViewModel();
        }
    }

    public class SignUpViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public ICommand SignUpCommand { get; }

        public SignUpViewModel()
        {
            SignUpCommand = new Command(() =>
            {
                // Create a new user account
            });
        }
    }

 
}
