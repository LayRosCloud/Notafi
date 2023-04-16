using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;

namespace NotafiThree.Model.PersonalityData
{
    public class Address : DatabaseModel<Address>
    {
        public Country Country{get; set;}
        public Region Region{get; set;}
        public MailAddress MailAddress{get; set;}
        public City City{get; set;}
        public Street Street{get; set;}
        public string Corpus{get; set;}
        public int HomeNumber{get; set;}
        public int Apartment{get; set;}

        private int _cityId;
        private int _streetId;
        private int _countryId;
        private int _regionId;
        private int _mailAddressId;

        public Address(int id, Country country, Region region, 
        MailAddress mail, City city, Street street, string corpus, int homeNumber,
        int apartment) : base(id)
        {
            Country = country;
            Region = region;
            MailAddress = mail;
            City = city;
            Street = street;
            Corpus = corpus;
            HomeNumber = homeNumber;
            Apartment = apartment;

            _countryId = country == null ? 0 : country.Id;
            _regionId = region == null ? 0 : region.Id;
            _mailAddressId = mail == null ? 0 : mail.Id;
            _cityId = city == null ? 0 : city.Id;
            _streetId = street == null ? 0 : street.Id;
        }
        
        public Address(int id, int countryId, int regionId, int mailId, int cityId, int streetId, string corpus, int homeNumber, int apartment)
        :this(id, null, null, null, null, null, corpus, homeNumber, apartment)
        {
            _countryId = countryId;
            _regionId = regionId;
            _mailAddressId = mailId;
            _cityId = cityId;
            _streetId = streetId;
        }

        public override void Insert()
        {
            var dv = new Dictionary<string, object>()
            {
                {"@countryId", Country.Id},
                {"@regionId", Region.Id},
                {"@mailId", MailAddress.Id},
                {"@cityId", City.Id},
                {"@streetId", Street.Id},
                {"@corpus", Corpus},
                {"@home", HomeNumber},
                {"@apart", Apartment}
            };
            ExecuteQuery("INSERT INTO `Address`(`CountryID`, `RegionID`, `MailAddressID`, `CityID`, `StreetID`, `Corpus`, `HomeNumber`, `Apartment`) VALUES (@countryId,@regionId,@mailId,@cityId,@streetId,@corpus,@home,@apart)", dv);
        }

        public override void Update()
        {
            var dv = new Dictionary<string, object>()
            {
                {"@countryId", Country.Id},
                {"@regionId", Region.Id},
                {"@mailId", MailAddress.Id},
                {"@cityId", City.Id},
                {"@streetId", Street.Id},
                {"@corpus", Corpus},
                {"@home", HomeNumber},
                {"@apart", Apartment},
                {"@id", Id},
            };
            ExecuteQuery("UPDATE `Address` SET `CountryID`=@countryId,`RegionID`=@regionId,`MailAddressID`=@mailId,`CityID`=@cityId,`StreetID`=@streetId,`Corpus`=@corpus,`HomeNumber`=@home,`Apartment`=@apart WHERE Id = @id",dv);
        }

        public void SetCountryOnId()
        {
            Country obj = new Country();
            Country = (from x in obj.GetAllRows() where x.Id == _countryId select x).FirstOrDefault();
        }

        public void SetRegionOnId()
        {
            Region obj = new Region(0, "");
            Region = (from x in obj.GetAllRows() where x.Id == _regionId select x).FirstOrDefault();
        }

        public void SetMailAddressOnId()
        {
            MailAddress obj = new MailAddress(0, 1);
            MailAddress = (from x in obj.SelectAll() where x.Id == _mailAddressId select x).FirstOrDefault();
        }
        public void SetCityOnId()
        {
            City obj = new City(0, "");
            City = (from x in obj.GetAllRows() where x.Id == _cityId select x).FirstOrDefault();
        }
        public void SetStreetOnId()
        {
            Street obj = new Street(0, "");
            Street = (from x in obj.GetAllRows() where x.Id == _streetId select x).FirstOrDefault();
        }

        protected override Address SelectCurrentObject(MySqlDataReader reader)
        {
            int id = reader.GetInt32(0);
            
            int countryId = reader.GetInt32(1);
            int regionId = reader.GetInt32(2);
            
            int mailAddressId = reader.GetInt32(3);
            
            int cityId = reader.GetInt32(4);
            int streetId = reader.GetInt32(5);
            
            string corpus = reader.IsDBNull(6) ? null : reader.GetString(6);
            int home = reader.GetInt32(7);
            int apartment = reader.GetInt32(8);

            return new Address(id, countryId, regionId, mailAddressId, cityId, streetId, corpus, home, apartment);
        }
    }
}
