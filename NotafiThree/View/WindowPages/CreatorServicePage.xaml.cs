using NotafiThree.Data;
using NotafiThree.Model.DealData;
using System;
using System.Windows;
using System.Windows.Controls;

namespace NotafiThree.View.WindowPages
{
	public partial class CreatorServicePage : Page
	{
		private readonly Service _service;
		private readonly Frame _frame;
		public CreatorServicePage(Frame frame, Service service)
		{
			InitializeComponent();

			_frame = frame;
			if(service == null)
			{
				service = new Service(0, "", "", "", "", 1, 1);
				service.SetPriceOnId();
				service.SetDiscountOnId();
			}
			_service = service;

			Init();

			DataContext = _service;
		}

		private void Init()
		{
			price.ItemsSource = new Price(0, 0, DateTime.Now).SelectAll();
			discount.ItemsSource = new Discount(0, 0, DateTime.Now).SelectAll();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			Price p = price.SelectedItem as Price;
			Discount d = discount.SelectedItem as Discount;
			if(p == null || d == null)
			{
				MessageBox.Show("Не выбрано ничего");
				return;
			}
			var service = new Service(_service.Id, _service.Title, _service.Description, _service.ImageIcon, _service.TypeOfDocument, p.Id, d.Id);
			service.SetDiscountOnId();
			service.SetPriceOnId();

			if (service.Id == 0)
			{
				service.Insert();
			}
			else
			{
				service.Update();
			}

			_frame.Navigate(new ServiceControllerPage(_frame));
		}

		//discount
		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			double discValue = Convert.ToDouble(tbDiscount.Text.Replace(".", ","));
			var dc = new Discount(0, discValue, DateTime.Now);
			dc.Insert();
			tbDiscount.Text = "";
			Init();
		}

		//price
		private void Button_Click_2(object sender, RoutedEventArgs e)
		{
			double priceValue = Convert.ToDouble(tbPrice.Text.Replace(".", ","));
			Price pr = new Price(0, priceValue, DateTime.Now);
			pr.Insert();
			tbPrice.Text = "";
			Init();
		}
	}
}
