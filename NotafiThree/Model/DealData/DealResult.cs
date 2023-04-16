using MySql.Data.MySqlClient;
using System;
using System.Linq;
using System.Collections.Generic;

namespace NotafiThree.Model.DealData
{
    public class DealResult : DatabaseModel<DealResult>
    {
        private int _dealId;
        private int _resultId;

        public Deal Deal { get; private set; }
        public Result Result { get; private set; }

        public DealResult(int id, Deal deal, Result result) : base(id)
        {
            Deal = deal;
            Result = result;

            _dealId = deal == null ? 0 : deal.Id;
            _resultId = result == null ? 0 : result.Id;
        }

        public DealResult(int id, int dealId, int resultId) : this(id, null, null)
        {
            _dealId = dealId;
            _resultId = resultId;
        }

        public void SetDealOnId()
        {
            Deal = (from x in DataSet.GetDeals() where x.Id == _dealId select x).FirstOrDefault();
        }
        public void SetResultOnId(){
            var res = new Result(0, "");
            Result = (from x in res.GetAllRows() where x.Id == _resultId select x).FirstOrDefault();
        }

        public override void Insert()
        {
            var dv = new Dictionary<string, object>()
            {
                {"@dealId", Deal.Id },
                {"@resultId", Result.Id }
            };
            ExecuteQuery("INSERT INTO `DealResult`(`DealID`, `ResultID`) VALUES (@dealId,@resultId)", dv);
        }

        public override void Update()
        {
            var dv = new Dictionary<string, object>()
            {
                {"@dealId", Deal.Id },
                {"@resultId", Result.Id },
                {"@id", Id }
            };
            ExecuteQuery("UPDATE `DealResult` SET `DealID`=@dealId,`ResultID`=@resultId WHERE Id = @id", dv);
        }

        protected override DealResult SelectCurrentObject(MySqlDataReader reader)
        {
            var id = reader.GetInt32(0);
            var dealId = reader.GetInt32(1);
            var resultId = reader.GetInt32(2);

            return new DealResult(id, dealId, resultId);
        }
    }
}