using System.Collections.Generic;
using System.Windows.Controls;

namespace NotafiThree.Scripts
{
    internal class RadioButtonController
    {
        private bool _isCheckedFirst = true;
        private readonly List<MyRadioButton> _listButtons;
        public bool IsCheckedFirstButton => _isCheckedFirst;

        public RadioButtonController(params Button[] buttons)
        {
            _listButtons = new List<MyRadioButton>();

            foreach(var button in buttons)
            {
                _listButtons.Add(new MyRadioButton(button));
            }

            _listButtons[0].OnCheck();
        }
        public MyRadioButton GetCheckedButton()
        {
            foreach(var radioBtn in _listButtons)
            {
                if (radioBtn.IsChecked)
                {
                    return radioBtn;
                }
            }

            return null;
        } 

        public void CheckOnButton(Button button)
        {
            if (button != null)
            {
                foreach(var btn in _listButtons)
                {
                    btn.OnDisableCheck();

                    if(btn.Name == button.Name)
                    {
                        btn.OnCheck();
                    }
                }
            }
        }
    }
}
