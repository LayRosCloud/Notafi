using MySql.Data.MySqlClient;
using NotafiThree.Data;
using System.Collections.Generic;

namespace NotafiThree.Model.PersonalityData
{
    public class MailAddress : DatabaseModel<MailAddress>
    {
        public int Name { get; private set; }
        public MailAddress(int id, int name) : base(id)
        {
            Name = name;
        }

        public sealed override void Insert()
        {
            Dictionary<string, object> dv = new Dictionary<string, object>()
            {
                { "@name", Name },
            };
            ExecuteQuery($"INSERT INTO `{Strings.Tables.MAIL_ADDRESS}`(`Name`) VALUES (@name)", dv);
        }

        public sealed override void Update()
        {
            Dictionary<string, object> dv = new Dictionary<string, object>()
            {
                { "@name", Name },
                { "@id", Id }
            };
            ExecuteQuery($"UPDATE `{Strings.Tables.MAIL_ADDRESS}` SET `Name`=@name WHERE Id = @id", dv);
        }

        protected override MailAddress SelectCurrentObject(MySqlDataReader reader)
        {
            int id = reader.GetInt32(0);
            int name = reader.GetInt32(1);

            return new MailAddress(id, name);
        }
    }
}
