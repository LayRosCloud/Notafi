using System;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows;
using NotafiThree.Scripts;
using NotafiThree.Model.PersonalityData;
using System.Collections.Generic;
using System.Linq;
using NotafiThree.Data;

namespace NotafiThree.View.Auth
{
    public partial class RegisterPage : Page
    {
        #region Fields
        private readonly Frame _frame;
        private readonly GeneratorCodeAccepted _generatorAdapter;

        private readonly ErrorContainerController _errorController;
        private readonly VisibilityController _visibleController;
        private readonly RadioButtonController _controllerRadio;

        private User _user;
        private Person _person;

        private List<Country> _countryList;
        private List<Region> _regionList;
        private List<MailAddress> _mailAddressesList;
        private List<City> _cityList;
        private List<Street> _streetList;
        #endregion

        public RegisterPage(Frame frame)
        {
            InitializeComponent();
            _frame = frame;
            
            _generatorAdapter = new GeneratorCodeAccepted();
            _errorController = new ErrorContainerController(errorContainer, errorText);
            _controllerRadio = new RadioButtonController(male, woman);

            _visibleController = new VisibilityController(spFirstStep, spSecondStep, spThirdStep, messageAccepted);

            Init();
        }

        private void Init()
        {
            IssuedByWhom isw = new IssuedByWhom(0, "", "");

            cmbISW.ItemsSource = isw.SelectAll();

            cmbCountry.ItemsSource = _countryList = (new Country(1, "")).GetAllRows();
            cmbRegion.ItemsSource = _regionList = (new Region(1, "")).GetAllRows();

            cmbMailAddress.ItemsSource = _mailAddressesList = (new MailAddress(1, 0)).SelectAll();

            cmbCity.ItemsSource = _cityList = (new City(1, "")).GetAllRows();
            cmbStreet.ItemsSource = _streetList = (new Street(1, "")).GetAllRows();

        }

        private void InputOnlyNumber(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
        }

        private void ChangeVisibleAccept(object sender, RoutedEventArgs e)
        {
            var tempVis = new VisibilityController(spFirstAccept, spSecondAccept);
            tempVis.SetVisibleAtIndex(1);

            _generatorAdapter.GenerateCode();

            MessageBox.Show($"Ваш код: {_generatorAdapter.Code}");
        }

        private void AcceptedTelegramBot(object sender, RoutedEventArgs e)
        {
            var codeUser = number1.Text + number2.Text + number3.Text + number4.Text + number5.Text + number6.Text;
            
            if(codeUser == _generatorAdapter.Code)
            {
                _visibleController.SetVisible(spSecondStep);
            }
            else
            {
                MessageBox.Show("Вы ввели неверный код!");
            }
        }

        private void ChangeSex(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
           
            _controllerRadio.CheckOnButton(btn);
        }

        private void RegisterUserFirstStep(object sender, RoutedEventArgs e)
        {
            string login = tbLogin.Text;
            string email = tbEmail.Text;
            string password = pass.Password;
            string passwordRepeat = passRepeat.Password;

            bool existsError = false;

            if (login.Length < 6)
            {
                _errorController.SetText("Ваш логин был менее 6 символов");
                existsError = true;
            }
            else if (!email.Contains("@"))
            {
                _errorController.SetText("Ваша почта введена некорректна");
                existsError = true;
            }
            else if (password != passwordRepeat)
            {
                _errorController.SetText("Ваши пароли не совпадают");
                existsError = true;
            }

            if (existsError)
            {
                return;
            }
            _user = new User(0, 0, login, password, email, 1);
            _user.SetRoleOnOnId();
            _visibleController.SetVisible(messageAccepted);
        }

        private void RegisterUserSecondStep(object sender, RoutedEventArgs e)
        {
            string firstName = fName.Text;
            string lastName = lName.Text;
            string patron = patronymic.Text;

            DateTime? date = birth.SelectedDate;

            string ph = phone.Text;
            string serie = series.Text;
            string number = numberOfPassport.Text;

            IssuedByWhom isw = cmbISW.SelectedItem as IssuedByWhom;

            bool existsError = false;

            if (firstName.Length == 0)
            {
                _errorController.SetText("Введите имя!");
                existsError = true;
            }
            else if (lastName.Length == 0)
            {
                _errorController.SetText("Введите Фамилию!");
                existsError = true;
            }
            else if (date == null)
            {
                _errorController.SetText("Введите дату рождения!");
                existsError = true;
            }
            else if (serie.Length != 4)
            {
                _errorController.SetText("Вы ввели не всю серию паспорта");
                existsError = true;
            }
            else if (number.Length != 6)
            {
                _errorController.SetText("Вы ввели не весь номер паспорта");
                existsError = true;
            }
            else if (isw == null)
            {
                _errorController.SetText("Выберите кем выдан ваш паспорт");
                existsError = true;
            }

            if (existsError)
            {
                return;
            }

            _visibleController.SetVisible(spThirdStep);

            _person = new Person(0, lastName, firstName, patron, ph, 0, date.Value, Convert.ToInt32(serie), Convert.ToInt32(number), null, isw);
        }

        private void RegisterUserThirdStep(object sender, RoutedEventArgs e)
        {
            string countryText = cmbCountry.Text;
            string regionText = cmbRegion.Text;
            string mailAddressText = cmbMailAddress.Text;
            string cityText = cmbCity.Text;
            string streetText = cmbStreet.Text;

            Country country = (from x in _countryList where x.Name == countryText select x).FirstOrDefault();
            Region region = (from x in _regionList where x.Name == regionText select x).FirstOrDefault();
            MailAddress mailAddress = (from x in _mailAddressesList where x.Name == Convert.ToInt32(mailAddressText) select x).FirstOrDefault();
            City city = (from x in _cityList where x.Name == cityText select x).FirstOrDefault();
            Street street = (from x in _streetList where x.Name == streetText select x).FirstOrDefault();

            if(country == null)
            {
                country = new Country(0, countryText);
                country.Insert();
                country.SetId(country.GetLastId());
            }

            if (region == null)
            {
                region = new Region(0, regionText);
                region.Insert();
                region.SetId(region.GetLastId());
            }
            
            if (mailAddress == null)
            {
                int mail = Convert.ToInt32(mailAddressText);
                mailAddress = new MailAddress(0, mail);
                mailAddress.Insert();
                mailAddress.SetId(mailAddress.GetLastId());
            }

            if (city == null)
            {
                city = new City(0, cityText);
                city.Insert();
                city.SetId(city.GetLastId());
            }

            if (street == null)
            {
                street = new Street(0, streetText);
                street.Insert();
                street.SetId(street.GetLastId());
            }

            int home = Convert.ToInt32(tbNumberOfHome.Text);
            int apart = Convert.ToInt32(tbApartament.Text);

            Address address = new Address(0, country, region, mailAddress, city, street, tbCorpus.Text, home, apart);
            address.Insert();
            address.SetId(address.GetLastId());

            _person.Address = address;
            _person.Insert();
            _person.SetId(_person.GetLastId());

            _user.Person = _person;
            _user.Insert();
            MessageBox.Show("Вы успешно зарегистрировались!");
            _frame.GoBack();
        }
    }
}