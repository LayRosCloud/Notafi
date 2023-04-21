using Microsoft.Win32;
using NotafiThree.Data;
using NotafiThree.Model.DealData;
using NotafiThree.Scripts;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

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
            dgDeals.ItemsSource = 
                DataSet.GetDealResults().
                Where(x => x.Deal.Worker.Person.Id == SaveElementData.UserIntance.Person.Id 
                && x.Deal.Person.FullName.ToLower().Contains(finder.Text.ToLower()));
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
	}
}
