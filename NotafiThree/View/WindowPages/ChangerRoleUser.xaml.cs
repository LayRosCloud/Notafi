using NotafiThree.Model.DealData;
using NotafiThree.Model.PersonalityData;
using System.Linq;
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

		private void UpdateRoleOfUser(object sender, RoutedEventArgs e)
		{
			Role role = roles.SelectedItem as Role;
			if(role != null)
			{
				_user.Role = role;
				_user.Update();

				Worker worker = DataSet.GetWorkers().Where(x => x.Person.Id == _user.Person.Id).FirstOrDefault();
				if(worker == null)
				{
					worker = new Worker(0, _user.Person.Id, 1);
					worker.SetPersonOnId();
					worker.SetPostOnId();
				}
				
				if(role.Id == 1)
				{
					worker.Delete();
				}
				else if(role.Id == 2 && worker.Id == 0)
				{
					worker.Insert();
				}

				_frame.Navigate(new UserControllerPage(_frame));
			}
        }
    }
}
