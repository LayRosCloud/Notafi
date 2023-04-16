using NotafiThree.Data;
using NotafiThree.Model.DealData;
using NotafiThree.Model.PersonalityData;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace NotafiThree.View.WindowPages
{
    public partial class FavoritesServicePage : Page
    {
        private readonly Frame _frame;
        public FavoritesServicePage(Frame frame)
        {
            InitializeComponent();
            Init();

            _frame = frame;

            backBtn.Content = "<-";
        }

        private void Init()
        {
            lvFavoriteServices.ItemsSource = DataSet.GetFavoritesService()
                .Where(x => x.Person.Id == SaveElementData.UserIntance.Person.Id)
                .ToList();
            tbSum.Text = DataSet.GetFavoritesService()
                .Where(x => x.Person.Id == SaveElementData.UserIntance.Person.Id)
                .Sum(x => x.Service.PriceWithDiscount).ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var favoriteService = (sender as Button).DataContext as FavoriteService;
            
            if(favoriteService != null)
            {
                favoriteService.Delete();
                Init();
            }
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            _frame.GoBack();
        }
    }
}
