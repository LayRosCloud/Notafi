using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace NotafiThree.Data
{
    internal class DataManager
    {

        private MySqlDataReader _reader;
        public DataManager()
        {
            DataContext.OpenConnection();
        }
        ~DataManager()
        {
            CloseConnect();
        }

        public int ExecuteQuery(string query)
        {
            var command = new MySqlCommand(query, DataContext.GetConnection);

            return command.ExecuteNonQuery();
        }

        public int ExecuteQuery(string query, Dictionary<string, object> parameters)
        {
            var command = new MySqlCommand(query, DataContext.GetConnection);

            foreach (var parameter in parameters)
            {
                command.Parameters.AddWithValue(parameter.Key, parameter.Value);
            }

            return command.ExecuteNonQuery();
        }

        public MySqlDataReader Read(string query)
        {
            var command = new MySqlCommand(query, DataContext.GetConnection);

            _reader = command.ExecuteReader();

            return _reader;
        }

        public MySqlDataReader Read(string query, Dictionary<string, object> parameters)
        {
            MySqlCommand command = new MySqlCommand(query, DataContext.GetConnection);

            foreach (var parameter in parameters)
            {
                command.Parameters.AddWithValue(parameter.Key, parameter.Value);
            }

            _reader = command.ExecuteReader();

            return _reader;
        }

        public void Close()
        {
            if(_reader == null)
            {
                throw new System.Exception("Reader is not exists");
            }

            _reader.Close();
            CloseConnect();
        }

        public void CloseConnect()
        {
            DataContext.CloseConnection();
        }
    }
}
