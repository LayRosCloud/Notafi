using System;
using System.Windows.Controls;
using System.Windows;

namespace NotafiThree.Scripts
{
    internal class ErrorContainerController
    {
        private readonly Decorator _container;
        private readonly TextBlock _errorMessage;

        public ErrorContainerController(Decorator container,TextBlock errorMessage)
        {
            _container = container;
            _errorMessage = errorMessage;
        }

        public void SetText(string value)
        {
            _container.Visibility = Visibility.Visible;
            _errorMessage.Text = value;
        }

        public void Disable()
        {
            _container.Visibility = Visibility.Collapsed;
        }
    }
}
