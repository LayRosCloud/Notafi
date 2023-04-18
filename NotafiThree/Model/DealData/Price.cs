using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace NotafiThree.Model.DealData
{
    public class Price : DatabaseModel<Price>
    {
        public double Number { get; set; }
        public DateTime Date { get; set; }


        public Price(int id, double number, DateTime date) : base(id)
        {
            Number = number;
            Date = date;
        }

        public override void Insert()
        {
            var dv = new Dictionary<string, object>()
            {
                {"@number", Number},
                {"@date", Date}
            };
            
            ExecuteQuery("INSERT INTO `Price`(`Date`, `Number`) VALUES (@date, @number)",dv);
        }

        public override void Update()
        {
            var dv = new Dictionary<string, object>()
            {
                {"@number", Number},
                {"@date", Date},
                {"@id", Id}
            };

            ExecuteQuery("UPDATE `Price` SET `Date`= @date,`Number`= @number WHERE Id = @id",dv);
        }

        protected override Price SelectCurrentObject(MySqlDataReader reader)
        {
            int id = reader.GetInt32(0);
            DateTime date = reader.GetDateTime(1);
            double number = reader.GetDouble(2);

            return new Price(id, number, date);
        }
    }
}
