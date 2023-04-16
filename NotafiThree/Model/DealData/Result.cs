using System.Collections.Generic;

namespace NotafiThree.Model.DealData
{
    public class Result : DictionaryModel
    {
        public Result(int id = 0, string name = "") : base(id, name, Strings.Tables.RESULT)
        {
            
        }

        public List<Result> GetAllRows()
        {
            return GetAll<Result>();
        }
    }
}
