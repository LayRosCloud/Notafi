using NotafiThree.Data;
using NotafiThree.Model.PersonalityData;
using System.Windows;
using System.Windows.Controls;

namespace NotafiThree.View.WindowPages
{
    public partial class ProfilePage : Page
    {
        private Window _window;

        public ProfilePage(Window window)
        {
            InitializeComponent();
            DataContext = SaveElementData.UserIntance;
            _window = window;
            cmbCountry.ItemsSource = new Country().GetAllRows();
            cmbRegion.ItemsSource = new Region(0, "").GetAllRows();
            cmbMailAddress.ItemsSource = new MailAddress(0, 0).SelectAll();
            cmbCity.ItemsSource = new City().GetAllRows();
            cmbStreet.ItemsSource = new Street(0, "").GetAllRows();
            cmbISW.ItemsSource = new IssuedByWhom(0, "", "").SelectAll();

            pass.Password = SaveElementData.UserIntance.Password;
            
        }

		private void UpdateData(object sender, RoutedEventArgs e)
		{
            SaveElementData.UserIntance.Person.Address.Update();
            SaveElementData.UserIntance.Person.Update();
            SaveElementData.UserIntance.Update();
		}

		private void ExitFromProfile(object sender, RoutedEventArgs e)
		{
            AuthMainContainer auth = new AuthMainContainer();
            auth.Show();
            _window.Close();
		}
	}
}
