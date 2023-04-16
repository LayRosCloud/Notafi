using System;
using System.Collections.Generic;

namespace NotafiThree.Model.PersonalityData
{
    public class Region : DictionaryModel
    {
        public Region(int id, string name) : base(id, name, Strings.Tables.REGION)
        {
        }

        public List<Region> GetAllRows()
        {
            return GetAll<Region>();
        }
    }
}
