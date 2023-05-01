internal class Strings
{
    private readonly static string SERVER = "127.0.0.1";
    private readonly static string USER = "root";
    private readonly static string PASSWORD = "";
    private readonly static string PORT = "3307";
    private readonly static string DATABASE = "notarius";

    public readonly static string CONNECTION = 
        $"server={SERVER};" +
        $"port={PORT};" +
        $"uid={USER};" +
        $"pwd={PASSWORD};" +
        $"database={DATABASE}";


    public readonly static string EXCEPTION_READER_IS_NULL = "Reader is not exists";
    public readonly static string ERROR_ENTER_LOGIN = "Ваш логин был менее 6 символов, пожалуйста проверьте корректность введеных данных!";
    public readonly static string ERROR_ENTER_PASSWORD = "Введите пароль!";
    public readonly static string ERROR_WRONG_DATA = "Ваш логин или пароль был введен некорректно, пожалуйста проверьте корректность введеных данных!";
    public readonly static string ERROR_CODE = "Вы ввели неверный код";
    public readonly static string ERROR_INPUT_EMAIL = "Ваша почта введена некорректна";
    public readonly static string ERROR_INPUT_REPEATPASSWORD = "Ваши пароли не совпадают";
    public readonly static string ERROR_INPUT_FIRSTNAME = "Введите имя!";
    public readonly static string ERROR_INPUT_LASTNAME = "Введите фамилию!";
    public readonly static string ERROR_INPUT_BIRTHDAY = "Введите дату рождения!";
    public readonly static string ERROR_INPUT_SERIES = "Вы ввели не всю серию паспорта";
    public readonly static string ERROR_INPUT_NUMBEROFPASSPORT = "Вы ввели не весь номер паспорта";
    public readonly static string ERROR_INPUT_ISW = "Выберите кем выдан ваш паспорт";
    public readonly static string COMPLETE_REG = "Вы успешно зарегистрировались!";
    public static class NavigationButtons
    {
        public readonly static string PATH_TO = "/Res/Images/";
        public readonly static string ICON_PROFILE = $"{PATH_TO}profileNavigate.png";
        public readonly static string ICON_SERVICE = $"{PATH_TO}serviceNavigate.png";
        public readonly static string ICON_DEAL = $"{PATH_TO}serviceNavigate.png";
        public readonly static string ICON_USERS = $"{PATH_TO}serviceNavigate.png";
        public readonly static string ICON_CONTROLLER_SERVICE = $"{PATH_TO}serviceNavigate.png";
        public readonly static string ICON_LOGOUT = $"{PATH_TO}logout.png";

        public readonly static string TITLE_PROFILE = "профиль";
        public readonly static string TITLE_SERVICE = "услуги";
        public readonly static string TITLE_DEAL = "сделки";
        public readonly static string TITLE_USERS = "пользователи";
        public readonly static string TITLE_CONTROLLER_SERVICE = "упр. услугами";
        public readonly static string TITLE_LOGOUT = "выйти";
	}

    public static class Tables
    {
        public readonly static string USER = "User";
        public readonly static string ROLE = "Role";
        public readonly static string STREET = "Street";
        public readonly static string REGION = "Region";
        public readonly static string COUNTRY = "Country";
        public readonly static string ADDRESS = "Address";
        public readonly static string MAIL_ADDRESS = "MailAddress";
        public readonly static string PERSON = "Person";
        public readonly static string SERVICE = "Service";
        public readonly static string ISSUED_BY_WHOM = "IssuedByWhom";
        public readonly static string WORKERS = "Workers";
        public readonly static string PRICE = "Price";
        public readonly static string DISCOUNT = "Discount";
        public readonly static string DEAL_SERVICE = "DealService";
        public readonly static string DEAL_RESULT = "DealResult";
        public readonly static string DEAL = "Deal";
        public readonly static string POST = "Post";
        public readonly static string CITY = "City";
        public readonly static string RESULT = "Result";
    }
}

