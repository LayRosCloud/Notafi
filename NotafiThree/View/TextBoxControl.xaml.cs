using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace NotafiThree.View
{
    public partial class TextBoxControl : UserControl
    {
        public TextBoxControl()
        {
            InitializeComponent();
        }

        public event RoutedEventHandler TextChanged;

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(TextBoxControl), new PropertyMetadata(""));

        public ImageSource ImageSource
        {
            get { return (ImageSource)GetValue(ImageSourceProperty); }
            set { SetValue(ImageSourceProperty, value); }
        }

        public static readonly DependencyProperty ImageSourceProperty =
            DependencyProperty.Register("ImageSource", typeof(ImageSource), typeof(TextBoxControl), new PropertyMetadata(null));

        public Thickness Thickness
        {
            get { return (Thickness)GetValue(ThinknessProperty); }
            set { SetValue(ThinknessProperty, value); }
        }

        public static readonly DependencyProperty ThinknessProperty =
            DependencyProperty.Register("Thickness", typeof(Thickness), typeof(TextBoxControl), new PropertyMetadata(new Thickness(0,0,0,0)));

        public bool IsReadOnly
        {
            get { return (bool)GetValue(IsReadOnlyProperty); }
            set { SetValue(IsReadOnlyProperty, value); }
        }

        public static readonly DependencyProperty IsReadOnlyProperty =
            DependencyProperty.Register("IsReadOnly", typeof(bool), typeof(TextBoxControl), new PropertyMetadata(false));


        public string Placeholder
        {
            get { return (string)GetValue(PlaceholderProperty); }
            set { SetValue(PlaceholderProperty, value); }
        }

        public static readonly DependencyProperty PlaceholderProperty =
            DependencyProperty.Register("Placeholder", typeof(string), typeof(TextBoxControl), new PropertyMetadata(""));

        public Visibility VisibilityImage
        {
            get { return (Visibility)GetValue(VisibilityImageProperty); }
            set { SetValue(VisibilityImageProperty, value); }
        }

        public static readonly DependencyProperty VisibilityImageProperty =
            DependencyProperty.Register("VisibilityImage", typeof(Visibility), typeof(TextBoxControl), new PropertyMetadata(Visibility.Visible));



        public int WidthImage
        {
            get { return (int)GetValue(WidthImageProperty); }
            set { SetValue(WidthImageProperty, value); }
        }

        public static readonly DependencyProperty WidthImageProperty =
            DependencyProperty.Register("WidthImage", typeof(int), typeof(TextBoxControl), new PropertyMetadata(75));

        public int MaxLength
        {
            get { return (int)GetValue(MaxLengthProperty); }
            set { SetValue(MaxLengthProperty, value); }
        }

        public static readonly DependencyProperty MaxLengthProperty =
            DependencyProperty.Register("MaxLength", typeof(int), typeof(TextBoxControl), new PropertyMetadata(10000));

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            placehold.Visibility = Visibility.Collapsed;
            btnVis.Visibility = Visibility.Collapsed;
            login.Focus();
        }


        private void login_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(TextChanged != null)
            {
                TextChanged.Invoke(sender, e);
            }
        }
    }
}
