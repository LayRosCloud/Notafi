using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;

namespace NotafiThree.Model.DealData
{
    public class DealService : DatabaseModel<DealService>
    {
        public Deal Deal {get; private set;}
        public int Number {get; private set;}
        public Service Service {get; private set;}
        
        private int _dealId;
        private int _serviceId;

        public double Sum { get
            {
                return Number * Service.PriceWithDiscount;
            } 
        }

        public DealService(int id, int number, Deal deal, Service service) : base(id)
        {
            Number = number;
            Deal = deal;
            Service = service;
            _dealId = deal == null ? 0 : deal.Id;
            _serviceId = deal == null ? 0 : deal.Id;
        }

        public void SetDealOnId()
        {
            Deal = (from x in DataSet.GetDeals() where x.Id == _dealId select x).FirstOrDefault();
        }
        public void SetServiceOnId()
        {
            Service = (from x in DataSet.GetServices() where x.Id == _serviceId select x).FirstOrDefault();
        }

        public DealService(int id, int number, int dealId, int serviceId)
            : this(id, number, null, null)
        {
            _dealId = dealId;
            _serviceId = serviceId;
        }

        public override void Insert()
        {
            var dv = new Dictionary<string, object>()
            {
                {"@dealId", Deal.Id},
                {"@serviceId", Service.Id},
                {"@number", Number}
            };
            ExecuteQuery("INSERT INTO `DealService`( `DealID`, `ServiceID`, `Number`) VALUES (@dealId, @serviceId, @number)", dv);
        }

        public override void Update()
        {
            var dv = new Dictionary<string, object>()
            {
                {"@dealId", Deal.Id},
                {"@serviceId", Service.Id},
                {"@number", Number},
                {"@id", Id}
            };
            ExecuteQuery("UPDATE `DealService` SET `DealID`=@dealId,`ServiceID`=@serviceId,`Number`=@number WHERE Id = @id", dv);
        }

        protected override DealService SelectCurrentObject(MySqlDataReader reader)
        {
            var id = reader.GetInt32(0);
            var dealId = reader.GetInt32(1);
            var serviceId = reader.GetInt32(2);
            var number = reader.GetInt32(3);

            return new DealService(id, number, dealId, serviceId);
        }
    }
}
