using Microsoft.Win32;
using NotafiThree.Data;
using NotafiThree.Model.DealData;
using NotafiThree.Scripts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace NotafiThree.View.WindowPages
{
    public partial class DealControllerPage : Page
    {
        private readonly Frame _frame;
        public DealControllerPage(Frame frame)
        {
            InitializeComponent();
            _frame = frame;
            Init();
        }

        private void Init()
        {
            var list = DataSet.GetDealResults().
                Where(x => x.Deal.Worker.Person.Id == SaveElementData.UserIntance.Person.Id
                && x.Deal.Person.FullName.ToLower().Contains(finder.Text.ToLower()));

            DateTime before = beforeDate.SelectedDate.Value;
            DateTime after = afterDate.SelectedDate.Value;

            DateTime now = DateTime.Now;

            dgDeals.ItemsSource = list.Where(x => x.Deal.Date >= before && x.Deal.Date <= after);
        }

        private void NavigateToCreatorDeal(object sender, RoutedEventArgs e)
        {
            _frame.Navigate(new CreatorDealPage(_frame));
        }

        private void DeleteDealRow(object sender, RoutedEventArgs e)
        {
            DealResult dealResult = (sender as Button).DataContext as DealResult;
            if(dealResult != null)
            {
                dealResult.Deal.Delete();
                Init();
            }
        }

        private void NavigateToMoreInformation(object sender, RoutedEventArgs e)
        {
            DealResult dealResult = ((Button)sender).DataContext as DealResult;
            _frame.Navigate(new MoreInfoDealPage(dealResult, _frame));
        }

        private void CreateExcelDocument(object sender, RoutedEventArgs e)
        {
            ExcelController controller = new ExcelController();
            controller.CreateList(DataSet.GetDealResults().Where(x=>x.Deal.Worker.Person.Id == SaveElementData.UserIntance.Person.Id));
            controller.SaveAs();
        }

            private void CreateWordDocument(object sender, RoutedEventArgs e)
		{
            var dealResult = dgDeals.SelectedItem as DealResult;

            if(dealResult == null)
            {
                return;
            }

            var controller = new WordController();
            controller.AddParagraph("Квитанция об оплате", "Строгий");
            controller.AddParagraph($"Исполнитель: {dealResult.Deal.Worker.Person.FullName}");
			controller.AddParagraph($"Клиент: {dealResult.Deal.Person.FullName}");
            controller.AddParagraph($"Дата рождения: {dealResult.Deal.Person.BirthDay.ToShortDateString()}");

            var adr = dealResult.Deal.Person.Address;

            string address = $"{adr.MailAddress.Name}, " +
                $"{adr.Country.Name}, {adr.Region.Name}, г. {adr.City.Name}, ул. {adr.Street.Name}, д. {adr.HomeNumber}, кв. {adr.Apartment}";
			controller.AddParagraph($"Адрес: {address}");
			controller.AddParagraph($"Дата заключения: {dealResult.Deal.Date.ToLongDateString()}");

            controller.AddParagraph($"\nСтатус сделки: {dealResult.Result.Name}");
            List<DealService> dealService = DataSet.GetDealServices().Where(x => x.Deal.Id == dealResult.Deal.Id).ToList();

			controller.CreateTable(dealService);
            controller.AddParagraph($"Сумма заказа: {dealService.Sum(x => x.Service.PriceWithDiscount * x.Number)} руб.");
            controller.AddParagraph($"Подпись: __________");

            var dialog = new SaveFileDialog();
            dialog.Filter = "Word file(*.docx)|*.docx";

            if (dialog.ShowDialog() == false)
            {
				return;
			}

			controller.SaveAsFile(dialog.FileName);
		}

		private void UpdateToUncompleteDeal(object sender, RoutedEventArgs e)
		{
			var dealResult = dgDeals.SelectedItem as DealResult;

			SetStatus(dealResult, 3);
		}

		private void UpdateToWaitingDeal(object sender, RoutedEventArgs e)
		{
			var dealResult = dgDeals.SelectedItem as DealResult;

			SetStatus(dealResult, 2);
		}

		private void UpdateToCompleteDeal(object sender, RoutedEventArgs e)
		{
			var dealResult = dgDeals.SelectedItem as DealResult;

            SetStatus(dealResult, 1);
		}

        private void SetStatus(DealResult dealResult, int id)
        {
			if (dealResult == null)
			{
				return;
			}

			dealResult.Result.Id = id;
			dealResult.Update();
			Init();
		}

		private void Refresh(object sender, RoutedEventArgs e)
		{
            Init();
		}

        private void dgDeals_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            var dealResult = e.Row.DataContext as DealResult;
            if (dealResult == null)
            {
                return;
            }

            if (dealResult.Result.Id == 1)
            {
                e.Row.Background = new SolidColorBrush(Colors.Green);
            }

            if (dealResult.Result.Id == 2)
            {
                e.Row.Background = new SolidColorBrush(Colors.Yellow);
            }

            if (dealResult.Result.Id == 3)
            {
                e.Row.Background = new SolidColorBrush(Colors.Red);
            }
        }
    }
}
