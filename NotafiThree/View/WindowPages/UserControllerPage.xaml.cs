using NotafiThree.Data;
using NotafiThree.Model.DealData;
using NotafiThree.Model.PersonalityData;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            users.ItemsSource = DataSet.GetUsers().Where(x => x.Id != SaveElementData.UserIntance.Id);
            _frame = frame;
        }

		private void Button_Click(object sender, RoutedEventArgs e)
		{
            User user = users.SelectedItem as User;
            if(user != null)
            {
				_frame.Navigate(new ChangerRoleUser(user, _frame));
			}
		}
	}
}
