using System;
using System.Windows.Controls;

namespace NotafiThree.Model
{
    internal class NavigationButton
    {
        public string ImageSource { get; private set; }
        public string Text { get; private set; }
        public Page NavigatePage  { get; private set; }

        public NavigationButton(string image, string text, Page page)
        {
            ImageSource = image;
            Text = text;
            NavigatePage = page;
        }
    }
}
