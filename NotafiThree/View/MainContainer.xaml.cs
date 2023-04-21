using NotafiThree.Model;
using NotafiThree.View.WindowPages;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using System.Windows.Controls;
using NotafiThree.Scripts;
using NotafiThree.Data;

namespace NotafiThree.View
{
    public partial class MainContainer : Window
    {
        private bool _activeSlideMenu = true;
        private readonly WindowController _windowController;

        public MainContainer()
        {
            InitializeComponent();


            List<NavigationButton> lists = new List<NavigationButton>
            {
                new NavigationButton(Strings.NavigationButtons.ICON_PROFILE, 
                Strings.NavigationButtons.TITLE_PROFILE, 
                new ProfilePage(this)),

                new NavigationButton(Strings.NavigationButtons.ICON_SERVICE, 
                Strings.NavigationButtons.TITLE_SERVICE, 
                new ServicesPage(frame)),
                
                
            };
            
            if(SaveElementData.UserIntance.Role.Id == 2)
            {
                lists.Add(new NavigationButton(Strings.NavigationButtons.ICON_DEAL, 
                    Strings.NavigationButtons.TITLE_DEAL, 
                    new DealControllerPage(frame)));
            }
            else if(SaveElementData.UserIntance.Role.Id == 3)
            {
                lists.Add(new NavigationButton(Strings.NavigationButtons.ICON_USERS, 
                    Strings.NavigationButtons.TITLE_USERS, 
                    new UserControllerPage(frame)));

                lists.Add(new NavigationButton(Strings.NavigationButtons.ICON_CONTROLLER_SERVICE, 
                    Strings.NavigationButtons.TITLE_CONTROLLER_SERVICE, 
                    new ServiceControllerPage(frame)));
            }

            lists.Add(new NavigationButton(Strings.NavigationButtons.ICON_LOGOUT, Strings.NavigationButtons.TITLE_LOGOUT, null));

            navigationButtons.ItemsSource = lists;

            frame.Navigate(lists[1].NavigatePage);

            _windowController = new WindowController(this);

        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            _windowController.Close();
        }

        private void ChangeState(object sender, RoutedEventArgs e)
        {
            _windowController.ChangeSizeScreen();
        }

        private void Hide(object sender, RoutedEventArgs e)
        {
            _windowController.Hide();
        }

        private void DragWindow(object sender, MouseButtonEventArgs e)
        {
            _windowController.DragMoveWindow();
        }

        private void SetWidthViews(int value)
        {
            navigationButtons.Width = value;
            sad.Width = value;
            frame.Margin = new Thickness(value, 0, 0, 0);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _activeSlideMenu = !_activeSlideMenu;

            if (!_activeSlideMenu)
            {
                SetWidthViews(40);
                return;
            }

            SetWidthViews(200);
        }

        private void navigationButtons_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            NavigationButton navigation = navigationButtons.SelectedItem as NavigationButton;

            if(navigation == null)
            {
                return;
            }

			if (navigation.Text == Strings.NavigationButtons.TITLE_LOGOUT)
			{
				Window window = new AuthMainContainer();
				window.Show();
				Close();

				return;
			}

			frame.Navigate(navigation.NavigatePage);
		}
    }
}
