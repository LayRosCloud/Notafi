using NotafiThree.Data;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace NotafiThree.Model
{
    public abstract class DictionaryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        private readonly string TABLE_NAME;
        public DictionaryModel(int id, string name, string tableName)
        {
            Id = id;
            Name = name;
            TABLE_NAME = tableName;
        }
        
        public void SetId(int value)
        {
            if(value < 1)
            {
                throw new ArgumentException();
            }

            Id = value;
        }

        public void Delete()
        {
            DeleteRow(TABLE_NAME);
        }

        public void Insert()
        {
            Dictionary<string, object> dv = new Dictionary<string, object>()
            {
                { "@name", Name }
            };

            ExecuteQuery($"INSERT INTO {TABLE_NAME}(`Name`) VALUES(@name)", dv);
        }

        public void Update()
        {
            Dictionary<string, object> dv = new Dictionary<string, object>()
            {
                { "@name", Name },
                { "@id", Id }
            };
            ExecuteQuery($"UPDATE `{TABLE_NAME}` SET `Name`=@name WHERE Id = @id", dv);
        }

        protected void DeleteRow(string tableName)
        {
            Dictionary<string, object> dv = new Dictionary<string, object>()
            {
                {"@id", Id }
            };
            ExecuteQuery($"DELETE FROM {tableName} WHERE Id = @id", dv);
        }

        protected void ExecuteQuery(string query, Dictionary<string, object> parameters)
        {
            DataManager dataManager = new DataManager();
            dataManager.ExecuteQuery(query, parameters);
            dataManager.CloseConnect();
        }

        protected List<T> GetAll<T>() where T:class
        {
            var dm = new DataManager();

            var resultList = new List<T>();

            var reader = dm.Read($"SELECT * FROM `{TABLE_NAME}`");

            Type type = typeof(T);

            Type[] types = { typeof(int), typeof(string) };
            ConstructorInfo cons = type.GetConstructor(types);

            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string name = reader.GetString(1);

                object[] parameters = { id, name };
                T tObj = (T)cons.Invoke(parameters);

                resultList.Add(tObj);
            }
            dm.Close();
            return resultList;
        }

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