using MySql.Data.MySqlClient;
using NotafiThree.Data;
using System.Collections.Generic;
using System.Windows.Markup;
using System;

namespace NotafiThree.Model
{
    public abstract class DatabaseModel<T> where T : class
    {
        public int Id { get; set; }
        private readonly string TABLE_NAME;
        public DatabaseModel(int id)
        {
            Id = id;
            TABLE_NAME = typeof(T).Name;
        }

        public void Delete()
        {
            Dictionary<string, object> dv = new Dictionary<string, object>()
            {
                {"@id", Id }
            };
            ExecuteQuery($"DELETE FROM {TABLE_NAME} WHERE Id = @id", dv);
        }
        public void SetId(int value)
        {
            if(value < 1)
            {
                throw new ArgumentException();
            }

            Id = value;
        }
        public List<T> SelectAll()
        {
            DataManager dm = new DataManager();
            var list = new List<T>();

            var reader = dm.Read($"SELECT * FROM {TABLE_NAME}");
            while (reader.Read())
            {
                list.Add(SelectCurrentObject(reader));
            }
            dm.Close();
            return list;
        }

        protected void ExecuteQuery(string query, Dictionary<string, object> parameters)
        {
            DataManager dataManager = new DataManager();
            dataManager.ExecuteQuery(query, parameters);
            dataManager.CloseConnect();
        }

        public abstract void Insert();
        public abstract void Update();
        protected abstract T SelectCurrentObject(MySqlDataReader reader);

        public int GetLastId()
        {
            DataManager data = new DataManager();
            var reader = data.Read($"SELECT ID FROM {TABLE_NAME} ORDER BY ID DESC LIMIT 1");
            
            reader.Read();
            int id = reader.GetInt32(0);
            data.Close();
            return id;
        }
    }
}
