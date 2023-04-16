using System;
using System.Windows.Controls;
using System.Windows.Media;

namespace NotafiThree.Scripts
{
    internal class MyRadioButton
    {
        private Button _button;
        private string _name;

        public MyRadioButton(Button button)
        {
            _button = button;
            _name = button.Name;
        }

        public bool IsChecked { get; private set; }
        public string Name => _name;

        public void OnCheck()
        {
            IsChecked = true;
            _button.Background = new SolidColorBrush(Colors.LightGreen);
        }

        public void OnDisableCheck()
        {
            IsChecked = false;
            _button.Background = new SolidColorBrush(Colors.White);
        }

    }
}
