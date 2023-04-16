using System.Collections.Generic;
using NotafiThree.Model.PersonalityData;
using System;

namespace NotafiThree.Model.DealData
{
    internal class DataSet
    {
        public static List<Service> GetServices()
        {
            var serviceObj = new Service(0, "", "", "", "", null, null);
            var services = serviceObj.SelectAll();
           
            foreach(var service in services)
            {
                service.SetPriceOnId();
                service.SetDiscountOnId();
            }

            return services;
        }

        public static List<Deal> GetDeals()
        {
            var deal = new Deal(0, 0, DateTime.Now, null, null);
            var deals = deal.SelectAll();
            
            foreach(var d in deals){
                d.SetPersonOnId();
                d.SetWorkerOnId();
            }

            return deals;
        }
        
        public static List<DealService> GetDealServices()
        {
            var dealService = new DealService(0, 0, null, null);
            var deals = dealService.SelectAll();

            foreach(var deal in deals){
                deal.SetDealOnId();
                deal.SetServiceOnId();
            }

            return deals;
        }

        public static List<DealResult> GetDealResults(){
            var dealResult = new DealResult(0, 0, 0);
            var results = dealResult.SelectAll();
            
            foreach(var result in results){
                result.SetDealOnId();
                result.SetResultOnId();
            }

            return results;
        }

        public static List<Person> GetPersons()
        {
            var person = new Person(0, "","","", "", 0, DateTime.MinValue, 9, 0, null, null);
            var persons = person.SelectAll();
            
            foreach(var pers in persons)
            {
                pers.SetAddressOnId();
                pers.SetOnISWOnId();
            }
            
            return persons;
        }

        public static List<User> GetUsers()
        {
            var user = new User(0, null, "", "", "", null);
            var users = user.SelectAll();

            foreach(var us in users){
                us.SetPersonOnId();
                us.SetRoleOnOnId();
            }
            return users;
        }

        public static List<Worker> GetWorkers()
        {
            var worker = new Worker(0, 0, 0);
            var workers = worker.SelectAll();
            
            foreach(var work in workers){
                work.SetPersonOnId();
                work.SetPostOnId();
            }

            return workers;
        }

        public static List<Address> GetAddresses()
        {
            var address = new Address(0, null, null, null, null, null, "", 3, 2);
            var addresses = address.SelectAll();

            foreach(var addr in addresses)
            {
                addr.SetCountryOnId();
                addr.SetRegionOnId();
                addr.SetMailAddressOnId();
                addr.SetCityOnId();
                addr.SetStreetOnId();
            }

            return addresses;
        }

        public static List<FavoriteService> GetFavoritesService()
        {
            var favService = new FavoriteService(0, 0, 0, 0);
            var favServices = favService.SelectAll();

            foreach(var item in favServices)
            {
                item.SetPersonOnId();
                item.SetServiceOnId();
            }

            return favServices;
        }
    }
}
