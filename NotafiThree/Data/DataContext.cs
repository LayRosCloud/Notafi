using MySql.Data.MySqlClient;

namespace NotafiThree.Data
{
    internal class DataContext
    {
        private readonly static MySqlConnection _connection = new MySqlConnection(Strings.CONNECTION);

        public static MySqlConnection GetConnection => _connection;

        /// <summary>
        /// Позволяет открыть доступ к базе данных.
        /// </summary>
        public static void OpenConnection()
        {
            if (_connection.State == System.Data.ConnectionState.Open)
            {
                //throw new ChangeStateConnectionException(Strings.EXCEPTION_OPEN_CONNECT);
                return;
            }

            _connection.Open();
        }

        /// <summary>
        /// Позволяет закрыть доступ к базе данных.
        /// </summary>
        public static void CloseConnection()
        {
            if (_connection.State == System.Data.ConnectionState.Closed)
            {
                //throw new ChangeStateConnectionException(Strings.EXCEPTION_CLOSE_CONNECT);
                return;
            }

            _connection.Clone();
        }

        
    }
}
