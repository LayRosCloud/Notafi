using System.IO;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using NotafiThree.Data;
using System.Linq;

namespace NotafiThree.Model.PersonalityData
{
    internal class User : DatabaseModel<User>
    {
        public Person Person { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public Role Role { get; set; }

        private int _roleId;
        private int _personId;

        public User(int id, Person person, string login, string password, string email, Role role) : base(id)
        {
            Person = person;
            Login = login;
            Password = password;
            Email = email;
            Role = role;
        }
        public User(int id, int person, string login, string password, string email, int role) 
            : this(id, null, login, password, email, null)
        {
            _roleId = role;
            _personId = person;
        }

        public void SetPersonOnId()
        {
            Person = (from x in DealData.DataSet.GetPersons() where x.Id == _personId select x).FirstOrDefault();
        }

        public void SetRoleOnOnId()
        {
            Role role = new Role(0, "");
            Role = (from x in role.GetAllRows() where x.Id == _roleId select x).FirstOrDefault();
        }

        public override void Insert()
        {
            var dv = new Dictionary<string, object>()
            {
                {"@login", Login},
                {"@password", Password},
                {"@email", Email},
                {"@roleId", Role.Id},
                {"@personId", Person.Id},
            };

            ExecuteQuery("INSERT INTO `User`(`PersonID`, `Login`, `Password`, `Email`, `RoleID`) VALUES (@personId,@login,@password,@email,@roleId)", dv);
        }

        public override void Update()
        {
            var dv = new Dictionary<string, object>()
            {
                {"@id", Id},
                {"@login", Login},
                {"@password", Password},
                {"@email", Email},
                {"@roleId", Role.Id},
                {"@personId", Person.Id},
            };

            ExecuteQuery("UPDATE `User` SET `PersonID`=@personId,`Login`=@login,`Password`=@password,`Email`=@email, `RoleID`=@roleId WHERE Id = @id", dv);
        }

        protected override User SelectCurrentObject(MySqlDataReader reader)
        {
            var id = reader.GetInt32(0);
            var personId = reader.GetInt32(1);
            var login = reader.GetString(2);
            var password = reader.GetString(3);
            var email = reader.GetString(4);
            var roleId = reader.GetInt32(5);

            return new User(id, personId, login, password, email, roleId);
        }
    }
}
