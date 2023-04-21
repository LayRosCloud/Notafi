using NotafiThree.Data;
using NotafiThree.Model.DealData;
using NotafiThree.Model.PersonalityData;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace NotafiThree.View.WindowPages
{
    public partial class UserControllerPage : Page
    {
        private Frame _frame;
        public UserControllerPage(Frame frame)
        {
            InitializeComponent();
            Init();
            
            _frame = frame;
        }

        private void Init()
        {
			users.ItemsSource = DataSet.GetUsers().Where(x => x.Id != SaveElementData.UserIntance.Id 
            && x.Person.FullName.ToLower().Contains(finder.Text.ToLower()));
		}

		private void NavigateToChangeRoleUser(object sender, RoutedEventArgs e)
		{
            User user = users.SelectedItem as User;
            if(user != null)
            {
				_frame.Navigate(new ChangerRoleUser(user, _frame));
			}
		}

		private void Find(object sender, RoutedEventArgs e)
		{
            Init();
		}
	}
}
