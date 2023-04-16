using System;
using System.Collections.Generic;

namespace NotafiThree.Model.PersonalityData
{
    public class Country : DictionaryModel
    {
        public Country(int id = 0, string name = "") : base(id, name, Strings.Tables.COUNTRY)
        {
        }

        public List<Country> GetAllRows()
        {
            return GetAll<Country>();
        }
    }
}
