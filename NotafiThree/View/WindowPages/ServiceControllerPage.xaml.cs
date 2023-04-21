using NotafiThree.Model.DealData;
using System;
using System.Windows.Controls;
using System.Linq;

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
			services.ItemsSource = DataSet.GetServices().Where(x=> x.Title.ToLower().Contains(finder.Text.ToLower()));
		}

		private void DeleteService(object sender, System.Windows.RoutedEventArgs e)
		{
			Service service = services.SelectedItem as Service;

			if(service != null)
			{
				service.Delete();
				Init();
			}
		}

		private void UpdateService(object sender, System.Windows.RoutedEventArgs e)
		{
			Service service = services.SelectedItem as Service;

			if (service != null)
			{
				_frame.Navigate(new CreatorServicePage(_frame, service));
			}
		}

		private void CreateService(object sender, System.Windows.RoutedEventArgs e)
		{
			_frame.Navigate(new CreatorServicePage(_frame, null));
		}

		private void Refresh(object sender, System.Windows.RoutedEventArgs e)
		{
			Init();
		}

    }
}
