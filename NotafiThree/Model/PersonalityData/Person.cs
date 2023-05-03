using System.Data;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System;
using NotafiThree.Model.DealData;
using System.Linq;

namespace NotafiThree.Model.PersonalityData
{
    public class Person : DatabaseModel<Person>
    {
        public string LastName{get; set;}
        public string FirstName{get; set;}
        public string Patronymic{get; set;}
        public Address Address{get; set;}
        public string Phone{get; set;}
        public int Sex{get; set;}
        public DateTime BirthDay{get; set;}
        public IssuedByWhom ISW{get; set;}
        public int Series{get; set;}
        public int NumberOfPassport{get; set;}

        private int _iswId;
        private int _addressId;

        public string FullName => $"{LastName} {FirstName} {Patronymic}";
        
        
        public Person(int id, string lname, string fname, string patronymic, 
        string phone, int sex, DateTime birthDay, int series, int numberOfPassport,
        Address address, IssuedByWhom isw) : base(id)
        {
            LastName = lname;
            FirstName = fname;
            Patronymic = patronymic;
            Phone = phone;
            Sex = sex;
            BirthDay = birthDay;
            Series = series;
            NumberOfPassport = numberOfPassport;
            Address = address;
            ISW = isw;

            _iswId = ISW == null ? 0 : ISW.Id;
            _addressId = Address == null ? 0 : Address.Id;
        }

        public Person(int id, string lname, string fname, string patronymic, 
        string phone, int sex, DateTime birthDay, int series, int numberOfPassport,
        int addressId, int iswId) 
        : this(id, lname, fname, patronymic, phone, sex, birthDay, series, numberOfPassport, null, null)
        {
            _iswId = iswId;
            _addressId = addressId;
        }

        public void SetAddressOnId(){
            Address = (from x in DealData.DataSet.GetAddresses() where x.Id == _addressId select x).FirstOrDefault();
        }

        public void SetOnISWOnId()
        {
            var isa = new IssuedByWhom(0, "", "");
            ISW = (from x in isa.SelectAll() where x.Id == _iswId select x).FirstOrDefault();
        }

        public override void Insert()
        {
            var dv = new Dictionary<string, object>()
            {
                {"@lname", LastName},
                {"@fname", FirstName},
                {"@patronymic", Patronymic},
                {"@sex", Sex},
                {"@birthday", BirthDay},
                {"@series", Series},
                {"@numberOfPassport", NumberOfPassport},
                {"@addressId", Address.Id},
                {"@iswId", ISW.Id},
                {"@phone", Phone},
            };
            ExecuteQuery("INSERT INTO `Person`(`LastName`, `FirstName`, `Patronymic`, `AddressID`, `Phone`, `Sex`, `BirthDay`, `Series`, `NumberOfPassport`, `ISW_ID`) VALUES (@lname,@fname,@patronymic,@addressId,@phone,@sex,@birthday,@series,@numberOfPassport,@iswId)", dv);
        }

        public override void Update()
        {
            var dv = new Dictionary<string, object>()
            {
                {"@lname", LastName},
                {"@fname", FirstName},
                {"@patronymic", Patronymic},
                {"@sex", Sex},
                {"@birthday", BirthDay},
                {"@series", Series},
                {"@numberOfPassport", NumberOfPassport},
                {"@addressId", Address.Id},
                {"@iswId", ISW.Id},
                {"@phone", Phone},
                {"@id", Id},
            };

            ExecuteQuery("UPDATE `Person` SET `LastName`=@lname,`FirstName`=@fname,`Patronymic`=@patronymic, `AddressID`=@addressId,`Phone`=@phone,`Sex`=@sex,`BirthDay`=@birthday,`Series`=@series, `NumberOfPassport`=@numberOfPassport,`ISW_ID`=@iswId WHERE Id = @id", dv);
        }

        protected override Person SelectCurrentObject(MySqlDataReader reader)
        {
            var id = reader.GetInt32(0);
            var lname = reader.GetString(1);
            var fname = reader.GetString(2);
            var patronymic = reader.IsDBNull(3) ? null :reader.GetString(3);
            var addressId = reader.GetInt32(4);
            var phone = reader.GetString(5);
            var sex = reader.GetInt32(6);
            var birthDay = reader.GetDateTime(7);
            var series = reader.GetInt32(8);
            var numberOfPassport = reader.GetInt32(9);
            var iswId = reader.GetInt32(10);

            return new Person(id, lname, fname, patronymic, phone, sex, birthDay, series, numberOfPassport, addressId, iswId);
        }

        public override string ToString()
        {
            string sex = Sex == 0 ? "м" : "ж";
            return $"Фамилия: {LastName}\n" +
                $"Имя: {FirstName}\n" +
                $"Отчество: {Patronymic}\n" +
                $"Пол: {sex}\n" +
                $"Дата рождения: {BirthDay.ToShortDateString()}\n" +
                $"Паспорт: {Series} {NumberOfPassport}\n" +
                $"Кем выдан: {ISW.Code} {ISW.Name}\n" +
                $"Место жительства: {Address.MailAddress.Name}, {Address.Country.Name}, {Address.Region.Name}, {Address.City.Name}, ул. {Address.Street.Name}, {Address.Corpus}, {Address.HomeNumber}, {Address.Apartment}";
        }
    }
}
