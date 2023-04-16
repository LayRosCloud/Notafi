using System;
using System.Collections.Generic;

namespace NotafiThree.Model.PersonalityData
{
    public class Street : DictionaryModel
    {
        public Street(int id, string name) : base(id, name, Strings.Tables.STREET)
        {
        }

        public List<Street> GetAllRows()
        {
            return GetAll<Street>();
        }
    }
}
