using System.Collections.Generic;

namespace NotafiThree.Model.PersonalityData
{
    public class Role : DictionaryModel
    {
        public Role(int id, string name) : base(id, name, Strings.Tables.ROLE)
        {
        }

        public List<Role> GetAllRows()
        {
            return GetAll<Role>();
        }
    }
}
