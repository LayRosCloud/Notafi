using System.Collections.Generic;
using System.Windows;

namespace NotafiThree.Scripts
{
    internal class VisibilityController
    {
        private readonly List<UIElement> _listViews;
        
        public VisibilityController(params UIElement[] elements) 
        {
            _listViews = new List<UIElement>();
            foreach(var element in elements)
            {
                _listViews.Add(element);
            }
        }

        public void SetVisibleAtIndex(int index)
        {
            SetVisible(_listViews[index]);
        }

        public void SetVisible(UIElement element)
        {
            foreach (var elem in _listViews)
            {
                elem.Visibility = Visibility.Collapsed;

                if (elem == element)
                {
                    elem.Visibility = Visibility.Visible;
                }
            }
        }
    }
}
