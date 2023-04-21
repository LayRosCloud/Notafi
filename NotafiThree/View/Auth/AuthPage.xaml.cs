using System.Windows.Controls;
using System.Windows;
using System.Linq;
using NotafiThree.Model.DealData;
using NotafiThree.Data;

namespace NotafiThree.View.Auth
{
    public partial class AuthPage : Page
    {
        private bool _isLogining = false;
        private Window _window;
        private Frame _frame;

        public AuthPage(Window window, Frame frame)
        {
            InitializeComponent();
            _window = window;
            _frame = frame;
        }

        private void EnterOnApplication(object sender, RoutedEventArgs e)
        {
            if(login.Text.Length < 6)
            {
                ShowErrorText(Strings.ERROR_ENTER_LOGIN);
                return;
            }

            errorBorder.Visibility = Visibility.Collapsed;

            if (_isLogining)
            {
                if (pass.Password.Length == 0)
                {
                    ShowErrorText(Strings.ERROR_ENTER_PASSWORD);
                    return;
                }

                var user = (from x in DataSet.GetUsers() where 
                            x.Login.ToLower() == login.Text.ToLower() 
                            && x.Password == pass.Password select x)
                            .FirstOrDefault();

                if (user != null)
                {
                    SaveElementData.UserIntance = user;
                    Window window = new MainContainer();
                    window.Show();

                    _window.Close();
                }
                else
                {
                    ShowErrorText(Strings.ERROR_WRONG_DATA);
                }

                return;
            }

            ChangeStateComponents();
        }

        private void HidePasswordField (object sender, RoutedEventArgs e)
        {
            ChangeStateComponents();
        }

        private void ShowErrorText(string error)
        {
            errorText.Text = error;
            errorBorder.Visibility = Visibility.Visible;
        }

        private void ChangeStateComponents()
        {
            _isLogining = !_isLogining;
            login.IsReadOnly = _isLogining;

            back.Visibility = _isLogining ? Visibility.Visible : Visibility.Collapsed;
            passContainer.Visibility = _isLogining ? Visibility.Visible : Visibility.Collapsed;
            enter.Content = _isLogining ? "Войти" : "Далее";
        }

        private void NavigateToRegister(object sender, RoutedEventArgs e)
        {
            _frame.Navigate(new RegisterPage(_frame));
        }
    }
}
