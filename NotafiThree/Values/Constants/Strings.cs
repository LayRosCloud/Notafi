internal class Strings
{
    private readonly static string SERVER = "127.0.0.1";
    private readonly static string USER = "dmlUser";
    private readonly static string PASSWORD = "root";
    private readonly static string PORT = "3306";
    private readonly static string DATABASE = "notarius";

    public readonly static string CONNECTION = 
        $"server={SERVER};" +
        $"port={PORT};" +
        $"uid={USER};" +
        $"pwd={PASSWORD};" +
        $"database={DATABASE}";

    public readonly static string EXCEPTION_OPEN_CONNECT = "Исключение! Не удалось открыть доступ к базе данных, так как она уже открыта";
    public readonly static string EXCEPTION_CLOSE_CONNECT = "Исключение! Не удалось закрыть доступ к базе данных, так как она уже закрыта";

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

