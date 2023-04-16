using NotafiThree.Scripts;
using NotafiThree.View.Auth;
using System.Windows;
using System.Windows.Input;

namespace NotafiThree.View
{
    public partial class AuthMainContainer : Window
    {
        private WindowController _windowController;
        public AuthMainContainer()
        {
            InitializeComponent();
            fMain.Navigate(new AuthPage(this, fMain));
            _windowController = new WindowController(this);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _windowController.Close();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            _windowController.DragMoveWindow();
        }
    }
}
