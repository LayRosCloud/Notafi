using NotafiThree.Model.DealData;
using System.Linq;
using System.Windows.Controls;

namespace NotafiThree.View.WindowPages
{
    public partial class MoreInfoDealPage : Page
    {
        private readonly Frame _frame;
        private readonly DealResult _dealResult;
        public MoreInfoDealPage(DealResult dealResult, Frame frame)
        {
            InitializeComponent();
            _frame = frame;
            _dealResult = dealResult;
            btnBack.Content = "<-";
            infoAboutDeal.Text = $"{dealResult.Deal.Person.FullName}: {dealResult.Deal.Date}";
            Init();
        }

        private void Back(object sender, System.Windows.RoutedEventArgs e)
        {
            _frame.Navigate(new DealControllerPage(_frame));
        }

        private void Init()
        {
            var list = DataSet.GetDealServices().Where(x => x.Deal.Id == _dealResult.Deal.Id);
            allDealService.ItemsSource = list;
            sum.Text = list.Sum(x => x.Sum).ToString("N2");
        }

        private void DeleteDealService(object sender, System.Windows.RoutedEventArgs e)
        {
            DealService dealService = allDealService.SelectedItem as DealService;
            if(dealService != null)
            {
                dealService.Delete();
                Init();
            }
        }

        private void NavigateToCreatorDealService(object sender, System.Windows.RoutedEventArgs e)
        {
            _frame.Navigate(new AddingServiceOnDealPage(_dealResult, _frame));
        }
    }
}
