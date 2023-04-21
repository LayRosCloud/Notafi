using NotafiThree.Model.DealData;
using System;
using System.Windows.Controls;

namespace NotafiThree.View.WindowPages
{
    public partial class AddingServiceOnDealPage : Page
    {
        private readonly DealResult _deal;
        private readonly Frame _frame;
        public AddingServiceOnDealPage(DealResult deal, Frame frame)
        {
            InitializeComponent();

            _deal = deal;
            _frame = frame;

            services.ItemsSource = DataSet.GetServices();
            Service service = services.SelectedItem as Service;

            SetText(service);
        }

        private void AddServiceToDeal(object sender, System.Windows.RoutedEventArgs e)
        {
            DealService dealService = new DealService(0, Convert.ToInt32(number.Text), _deal.Deal, services.SelectedItem as Service);
            dealService.Insert();
            _frame.Navigate(new MoreInfoDealPage(_deal, _frame));
        }

        private void services_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Service service = services.SelectedItem as Service;

            SetText(service);
        }

        public void SetText(Service service)
        {
            if (service != null)
            {
                title.Text = service.Title;
                description.Text = service.Description;
                price.Text = service.Price.Number.ToString();
                discount.Text = service.Discount.Number.ToString();
                typeDoc.Text = service.TypeOfDocument;
            }
        }
    }
}
