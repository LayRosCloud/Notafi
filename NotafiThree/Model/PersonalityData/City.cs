using System;
using System.Collections.Generic;

namespace NotafiThree.Model.PersonalityData
{
    public class City : DictionaryModel
    {
        public City(int id = 0, string name = "") : base(id, name, Strings.Tables.CITY)
        {

        }

        public List<City> GetAllRows()
        {
            return GetAll<City>();
        }
    }
}
