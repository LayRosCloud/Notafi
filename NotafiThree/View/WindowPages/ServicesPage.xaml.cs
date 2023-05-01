using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using NotafiThree.Data;
using NotafiThree.Model.DealData;
using NotafiThree.Model.PersonalityData;
using NotafiThree.Scripts;

namespace NotafiThree.View.WindowPages
{
    public partial class ServicesPage : Page
    {
        private readonly List<Service> _sourceList = 
            new List<Service>(DataSet.GetServices());

        private readonly SortingAdapter _sortAdapter;
        private readonly Frame _frame;

        private bool _ask = true;
        public ServicesPage(Frame frame)
        {
            InitializeComponent();

            _frame = frame;

            listServices.ItemsSource = _sourceList;
            _sortAdapter = new SortingAdapter();
            countWrites.Text = $"Найдено {_sourceList.Count} из {_sourceList.Count}";
        }

        private void finder_TextChanged(object sender, RoutedEventArgs e)
        {
            viewChanged.Visibility = Visibility.Visible;
        }

        private void orderby_Click(object sender, RoutedEventArgs e)
        {
            _ask = !_ask;
            
            if (_ask)
            {
                orderby.Source = new BitmapImage(new Uri("/Res/Images/generic.png", UriKind.Relative));
            }
            else
            {
                orderby.Source = new BitmapImage(new Uri("/Res/Images/genericDesc.png", UriKind.Relative));
            }
            viewChanged.Visibility = Visibility.Visible;
        }

        private void viewChanged_Click(object sender, RoutedEventArgs e)
        {
            var list = _sortAdapter.Sort(finder.Text, _ask);
            listServices.ItemsSource = list;
            viewChanged.Visibility = Visibility.Collapsed;
            countWrites.Text = $"Найдено {list.Count} из {_sourceList.Count}";
        }

        private void NavigateToFavoriteServices(object sender, RoutedEventArgs e)
        {
            _frame.Navigate(new FavoritesServicePage(_frame));
        }

        private void AddServiceToFavoriteList(object sender, RoutedEventArgs e)
        {
            Service service = (sender as Button).DataContext as Service;

            if (service != null)
            {
                var favorite = new FavoriteService(0, SaveElementData.UserIntance.Person.Id, service.Id, 1);
                
                favorite.Insert();
            }
        }
    }
}
