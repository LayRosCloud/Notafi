using Microsoft.Win32;
using NotafiThree.Data;
using NotafiThree.Model.DealData;
using System;
using System.IO;
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
			title.Text = _service.Title;
			description.Text = _service.Description;
			typeOfDocument.Text = _service.TypeOfDocument;
			price.SelectedValue = _service.Price.Id;
			discount.SelectedValue = _service.Discount.Id;

			Init();
		}

		private void Init()
		{
			price.ItemsSource = new Price(0, 0, DateTime.Now).SelectAll();
			discount.ItemsSource = new Discount(0, 0, DateTime.Now).SelectAll();
			price.SelectedValue = _service.Price.Id;
			discount.SelectedValue = _service.Discount.Id;
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			Service service = new Service(_service.Id, title.Text, description.Text, _service.ImageIcon, typeOfDocument.Text, (int)price.SelectedValue, (int)discount.SelectedValue);
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

		private void Button_Click_3(object sender, RoutedEventArgs e)
		{
			string newDirectory = Environment.CurrentDirectory;
			newDirectory = newDirectory.Remove(newDirectory.Length - 9, newDirectory.Length - (newDirectory.Length - 9));
			newDirectory += @"Res\Images\";
			
			FileDialog dialog = new OpenFileDialog();

			dialog.Filter = "Image (*.png)|*.png|Image (*.jpg)|*.jpg";
			if (dialog.ShowDialog() == false)
				return;

			string name = DateTime.UtcNow.Ticks + dialog.FileName.Split('\\')[dialog.FileName.Split('\\').Length - 1];
			File.Copy(dialog.FileName, newDirectory + name);
			_service.ImageIcon = $"/Res/Images/{name}";
		}
	}
}
