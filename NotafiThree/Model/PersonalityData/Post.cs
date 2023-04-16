using System.Collections.Generic;

namespace NotafiThree.Model.PersonalityData
{
    public class Post : DictionaryModel
    {
        public Post(int id, string name) : base(id, name, Strings.Tables.POST)
        {
        }

        public List<Post> GetAllRows()
        {
            return GetAll<Post>();
        }
    }
}
