using NotafiThree.Data;
using NotafiThree.Model.DealData;
using NotafiThree.Model.PersonalityData;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace NotafiThree.View.WindowPages
{
    public partial class CreatorDealPage : Page
    {
        private readonly Frame _frame;

        public CreatorDealPage(Frame frame)
        {
            InitializeComponent();
            allClients.ItemsSource = DataSet.GetPersons().Where(x=> x.Id != SaveElementData.UserIntance.Person.Id);
            dpDate.Text = DateTime.Now.ToShortDateString();

            Person person = allClients.SelectedItem as Person;
            SetFullText(person);

            _frame = frame;
        }

        private void CreateDeal(object sender, RoutedEventArgs e)
        {
            Person person = allClients.SelectedItem as Person;
            Worker worker = DataSet.GetWorkers().Where(x => x.Person.Id == SaveElementData.UserIntance.Person.Id).FirstOrDefault();
            var value = Convert.ToDouble(commisionValue.Text);
            var date = dpDate.SelectedDate.Value;
            if (person == null || worker == null)
            {
                return;
            }
			Deal deal = new Deal(0, value, date, person, worker);
			deal.Insert();
			var dealId = deal.GetLastId();
			foreach (var item in DataSet.GetFavoritesService())
			{
				var serviceDeal = new DealService(0, item.Number, dealId, item.ServiceID);
				serviceDeal.SetDealOnId();
				serviceDeal.SetServiceOnId();
				serviceDeal.Insert();
			}
			var dealResult = new DealResult(0, dealId, 2);
			dealResult.SetDealOnId();
			dealResult.SetResultOnId();
			dealResult.Insert();
			_frame.Navigate(new DealControllerPage(_frame));
		}

        private void allClients_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Person person = allClients.SelectedItem as Person;
            SetFullText(person);
        }

        private void SetFullText(Person person)
        {
            if (person != null)
            {
                fullDataOfClient.Text = person.ToString();
            }
        }
    }
}
