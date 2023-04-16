using MySql.Data.MySqlClient;
using NotafiThree.Model.DealData;
using System.Collections.Generic;
using System.Linq;

namespace NotafiThree.Model.PersonalityData
{
    internal class FavoriteService : DatabaseModel<FavoriteService>
    {
        public FavoriteService(int id, int person, int service, int number) : base(id)
        {
            PersonID = person;
            ServiceID = service;
            Number = number;
        }

        public int PersonID { get; set; }
        public int ServiceID { get; set; }
        public int Number { get; set; }

        public Person Person { get; set; }
        public Service Service { get; set; }

        public void SetServiceOnId()
        {
            Service = DataSet.GetServices().Where(x=> x.Id == ServiceID).FirstOrDefault();
        }

        public void SetPersonOnId()
        {
            Person = DataSet.GetPersons().Where(x => x.Id == PersonID).FirstOrDefault();
        }

        public override void Insert()
        {
            var parameters = new Dictionary<string, object>()
            {
                {"@person", PersonID },
                {"@service", ServiceID },
                {"@number", Number },
            };

            ExecuteQuery("INSERT INTO `FavoriteService`(`PersonID`, `ServiceID`, `Number`) VALUES (@person,@service,@number)",parameters);
        }

        public override void Update()
        {
            var parameters = new Dictionary<string, object>()
            {
                {"@person", PersonID },
                {"@id", Id },
                {"@service", ServiceID },
                {"@number", Number },
            };

            ExecuteQuery("UPDATE `FavoriteService` SET `PersonID`=@person,`ServiceID`=@service,`Number`=@number WHERE `ID`=@id", parameters);
        }

        protected override FavoriteService SelectCurrentObject(MySqlDataReader reader)
        {
            var id = reader.GetInt32(0);
            var person = reader.GetInt32(1);
            var service = reader.GetInt32(2);
            var number = reader.GetInt32(3);

            return new FavoriteService(id, person, service, number);
        }
    }
}
