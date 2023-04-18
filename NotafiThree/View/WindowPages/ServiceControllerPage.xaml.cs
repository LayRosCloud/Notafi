using NotafiThree.Model.DealData;
using System;
using System.Windows.Controls;

namespace NotafiThree.View.WindowPages
{
    public partial class ServiceControllerPage : Page
    {
		private readonly Frame _frame;
        public ServiceControllerPage(Frame frame)
        {
            InitializeComponent();

			_frame = frame;

			Init();
			
        }

		private void Init()
		{
			services.ItemsSource = DataSet.GetServices();
		}

		private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			Service service = services.SelectedItem as Service;

			if(service != null)
			{
				service.Delete();
				Init();
			}
		}

		private void Button_Click_1(object sender, System.Windows.RoutedEventArgs e)
		{
			Service service = services.SelectedItem as Service;

			if (service != null)
			{
				_frame.Navigate(new CreatorServicePage(_frame, service));
			}
		}

		private void Button_Click_2(object sender, System.Windows.RoutedEventArgs e)
		{
			_frame.Navigate(new CreatorServicePage(_frame, null));
		}

		private void Button_Click_3(object sender, System.Windows.RoutedEventArgs e)
		{
			Init();
		}
	}
}
