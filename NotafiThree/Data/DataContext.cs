using MySql.Data.MySqlClient;

namespace NotafiThree.Data
{
    internal class DataContext
    {
        private readonly static MySqlConnection _connection 
            = new MySqlConnection(Strings.CONNECTION);

        public static MySqlConnection GetConnection => _connection;

        /// <summary>
        /// Позволяет открыть доступ к базе данных.
        /// </summary>
        public static void OpenConnection()
        {
            if (_connection.State == System.Data.ConnectionState.Open)
            {
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
                return;
            }

            _connection.Clone();
        }

        
    }
}
