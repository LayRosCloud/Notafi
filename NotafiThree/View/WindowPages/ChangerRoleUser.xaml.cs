using NotafiThree.Model.PersonalityData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace NotafiThree.View.WindowPages
{
	/// <summary>
	/// Логика взаимодействия для ChangerRoleUser.xaml
	/// </summary>
	public partial class ChangerRoleUser : Page
	{
		private readonly User _user;
		private readonly Frame _frame;
		public ChangerRoleUser(User user, Frame frame)
		{
			InitializeComponent();
			roles.ItemsSource = new Role(0, "").GetAllRows().Where(x=>x.Id != 3);
			_user = user;
			_frame = frame;
			roles.SelectedIndex = _user.Role.Id - 1;
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			Role role = roles.SelectedItem as Role;
			if(role != null)
			{
				_user.Role = role;
				_user.Update();
				_frame.Navigate(new UserControllerPage(_frame));
			}
        }
    }
}
