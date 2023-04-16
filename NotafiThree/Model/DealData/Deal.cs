using MySql.Data.MySqlClient;
using NotafiThree.Model.PersonalityData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace NotafiThree.Model.DealData
{
    public class Deal : DatabaseModel<Deal>
    {
        public double Commision { get; private set; }
        public DateTime Date { get; private set; }
        public Person Person { get; private set; }
        public Worker Worker { get; private set; }

        private int workerId;
        private int personId;

        public Deal(int id, double commision, DateTime date, Person person, Worker worker) : base(id)
        {
            Commision = commision;
            Date = date;
            Person = person;
            Worker = worker;

            workerId = worker == null ? 0 : worker.Id;
            personId = person == null ? 0 : person.Id;
        }

        public Deal(int id, double commision, DateTime date, int person, int worker)
            :this(id, commision, date, null, null)
        {
            workerId = worker;
            personId = person;
        }
        public void SetWorkerOnId()
        {
            Worker = (from x in DataSet.GetWorkers() where x.Id == workerId select x).FirstOrDefault();
        }

        public void SetPersonOnId()
        {
            Person = (from x in DataSet.GetPersons() where x.Id == personId select x).FirstOrDefault();
        }


        public override void Insert()
        {
            Dictionary<string, object> dv = new Dictionary<string, object>()
            {
                {"@date", Date},
                {"@commision", Commision },
                {"@workerId", Worker.Id},
                {"@personId", Person.Id},
            };
            ExecuteQuery("INSERT INTO `Deal`(`Date`, `WorkerID`, `PersonID`, `Comission`) VALUES (@date, @workerId, @personId, @commision)", dv);
        }

        public override void Update()
        {
            var dv = new Dictionary<string, object>()
            {
                {"@date", Date},
                {"@commision", Commision },
                {"@workerId", Worker.Id},
                {"@personId", Person.Id},
                {"@id", Id}
            };
            ExecuteQuery("UPDATE `Deal` SET `Date`=@date,`WorkerID`=@workerId,`PersonID`=@personId,`Comission`=@commision WHERE Id = @id", dv);
        }

        protected override Deal SelectCurrentObject(MySqlDataReader reader)
        {
            var id = reader.GetInt32(0);
            var date = reader.GetDateTime(1);
            var workerId = reader.GetInt32(2);
            var personId = reader.GetInt32(3);
            var commision = reader.GetDouble(4);

            return new Deal(id,commision, date, workerId, personId);
        }
    }
}
