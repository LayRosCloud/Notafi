using System.Windows;
using System.Windows.Input;

namespace NotafiThree.Scripts
{
    internal class WindowController
    {
        private readonly Window _window;

        public WindowController(Window window)
        {
            _window = window;
        }

        public void Close()
        {
            _window.Close();
        }

        public void ChangeSizeScreen()
        {
            if(_window.WindowState== WindowState.Maximized) 
            { 
                _window.WindowState = WindowState.Normal;
                return;
            }

            _window.WindowState= WindowState.Maximized;
        }

        public void Hide()
        {
            _window.WindowState = WindowState.Minimized;
        }

        public void DragMoveWindow()
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
            {
                _window.DragMove();
            }
        }
    }
}
