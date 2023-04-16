using NotafiThree.Data;
using NotafiThree.Model.DealData;
using NotafiThree.Model.PersonalityData;
using System;
using System.Collections.ObjectModel;
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
            dgDeals.ItemsSource = DataSet.GetDealResults().Where(x => x.Deal.Worker.Person.Id == SaveElementData.UserIntance.Person.Id);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _frame.Navigate(new CreatorDealPage(_frame));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DealResult dealResult = (sender as Button).DataContext as DealResult;
            if(dealResult != null)
            {
                dealResult.Deal.Delete();
                Init();
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            DealResult dealResult = ((Button)sender).DataContext as DealResult;
            _frame.Navigate(new MoreInfoDealPage(dealResult, _frame));
        }
    }
}
