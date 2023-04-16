using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System;
using System.Linq;
using System.Windows;

namespace NotafiThree.Model.DealData
{
    public class Service : DatabaseModel<Service>
    {
        public string Title { get; private set; }
        public string Description { get; private set; }
        public string ImageIcon { get; private set; }
        public string TypeOfDocument { get; private set; }

        private int _priceId;
        private int _discountId;

        public Price Price { get; private set; }
        public Discount Discount { get; private set; }

        public double PriceWithDiscount
        {
            get
            {
                return  Price.Number - Price.Number * (Discount.Number / 100) ;
            }
        }

        public Visibility VisibleDisc
        {
            get
            {
                return Discount.Id != 1 ? Visibility.Visible : Visibility.Collapsed;
            }
        }

        public Service(int id, string title, string description, string imageIcon, string typeOfDocument, Price price, Discount discount)
            : base(id)
        {
            Title = title;
            Description = description;
            ImageIcon = imageIcon;
            TypeOfDocument = typeOfDocument;
            
            Price = price;
            Discount = discount;
           
            _priceId = price == null ? 0 : price.Id;
            _discountId = discount == null ? 0 : discount.Id;
        }

        public Service(int id, string title, string description, string imageIcon, string typeOfDocument, int priceID, int discountID) 
            : this(id, title, description, imageIcon, typeOfDocument, null, null)
        {
            _priceId = priceID;
            _discountId = discountID;
        }

        public void SetPriceOnId()
        {
            Price price = new Price(0, 0, DateTime.MinValue);
            Price = (from x in price.SelectAll() where x.Id == _priceId select x).FirstOrDefault();
        }

        public void SetDiscountOnId()
        {
            Discount disc = new Discount(0, 0, DateTime.MinValue);
            Discount = (from x in disc.SelectAll() where x.Id == _discountId select x).FirstOrDefault();
        }

        public override void Insert()
        {
            var dv = new Dictionary<string, object>()
            {
                {"@title", Title},
                {"@description", Description},
                {"@imageIcon", ImageIcon},
                {"@typeOfDoc", TypeOfDocument},
                {"@priceId", Price.Id},
                {"@discountId", Discount.Id}
            };

            ExecuteQuery("INSERT INTO `Service`(`Title`, `Description`, `TypeOfDocument`, `PriceID`, `DiscountID`, `ImageIcon`) VALUES (@title,@description,@typeOfDoc,@priceId,@discountId,@imageIcon)",dv);
        }

        public override void Update()
        {
            var dv = new Dictionary<string, object>()
            {
                {"@title", Title},
                {"@description", Description},
                {"@imageIcon", ImageIcon},
                {"@typeOfDoc", TypeOfDocument},
                {"@priceId", Price.Id},
                {"@discountId", Discount.Id}
            };

            ExecuteQuery("UPDATE `Service` SET `Title`=@title,`Description`=@description,`TypeOfDocument`=@typeOfDoc,`PriceID`=@priceId,`DiscountID`=@discountId,`ImageIcon`=@imageIcon WHERE Id = @id",dv);
        }

        protected override Service SelectCurrentObject(MySqlDataReader reader)
        {
            var id = reader.GetInt32(0);

            var title = reader.GetString(1);
            string description = reader.IsDBNull(2) ? null : reader.GetString(2);
            var typeOfDocument = reader.GetString(3);

            var discountID = reader.GetInt32(4);
            var priceID = reader.GetInt32(5);

            string icon = reader.IsDBNull(6) ? null : reader.GetString(6);
            return new Service(id, title, description, icon, typeOfDocument, priceID, discountID);
        }
    }
}
