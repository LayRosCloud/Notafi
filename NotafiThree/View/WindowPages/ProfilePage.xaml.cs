using NotafiThree.Data;
using NotafiThree.Model.PersonalityData;
using System.Windows.Controls;

namespace NotafiThree.View.WindowPages
{
    public partial class ProfilePage : Page
    {

        public ProfilePage()
        {
            InitializeComponent();
            DataContext = SaveElementData.UserIntance;

            cmbCountry.ItemsSource = new Country().GetAllRows();
            cmbRegion.ItemsSource = new Region(0, "").GetAllRows();
            cmbMailAddress.ItemsSource = new MailAddress(0, 0).SelectAll();
            cmbCity.ItemsSource = new City().GetAllRows();
            cmbStreet.ItemsSource = new Street(0, "").GetAllRows();
            cmbISW.ItemsSource = new IssuedByWhom(0, "", "").SelectAll();

            pass.Password = SaveElementData.UserIntance.Password;
            
        }

    }
}
