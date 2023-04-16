using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace NotafiThree.Model.PersonalityData
{
    public class IssuedByWhom : DatabaseModel<IssuedByWhom>
    {
        public string Code { get; private set; }
        public string Name { get; private set; }

        public string FullName => Code + " | " + Name;
        public IssuedByWhom(int id, string code, string name) : base(id)
        {
            Code = code;
            Name = name;
        }

        public override void Insert()
        {
            var dv = new Dictionary<string, object>(){
                {"@code", Code},
                {"@name", Name},
            };

            ExecuteQuery("INSERT INTO `IssuedByWhom`(`Code`, `Name`) VALUES (@code,@name)", dv);
        }

        public override void Update()
        {
            var dv = new Dictionary<string, object>(){
                {"@code", Code},
                {"@name", Name},
                {"@id", Id},
            };

            ExecuteQuery("UPDATE `IssuedByWhom` SET `Code`=@code,`Name`=@name WHERE Id = @id", dv);
        }

        protected override IssuedByWhom SelectCurrentObject(MySqlDataReader reader)
        {
            var id = reader.GetInt32(0);
            var code = reader.GetString(1);
            var name = reader.GetString(2);

            return new IssuedByWhom(id, code, name);
        }
    }
}
