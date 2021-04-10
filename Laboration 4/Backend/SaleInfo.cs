using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Laboration_4.Backend;

namespace Laboration_4
{
    public class SaleInfo
    {
        //Declare an instance variables 
        private Type _type;
        private int _itemNumber;
        private string _name;
        private double _price;
        private int _quantity;
        private DateTime _date;
        private int _saleID;
        private Status _status;

        public SaleInfo()
        {

        }

        public SaleInfo(Type type, int itemNumber, string name, double price, int quantity, DateTime date, int saleID, Status status)
        {
            Type = type;
            ItemNumber = itemNumber;
            Name = name;
            Price = price;
            Quantity = quantity;
            Date = date;
            SaleID = saleID ;
            Status = status;
        }
        public SaleInfo(string type, string itemNumber, string name, string price, string quantity, string date, string saleID, string status)
        {
            Type = Helper.GetType(type);
            ItemNumber = Helper.ConvertInteger(itemNumber);
            Name = name;
            Price = Helper.ConvertDouble(price);
            Quantity = Helper.ConvertInteger(quantity);
            Date = Helper.ConvertDate(date);
            SaleID = Helper.ConvertInteger(saleID);
            Status = Helper.GetStatus(status);
        }

        public Type Type
        {
            get => _type;
            set
            {
                _type = value;
            }
        }

        public int ItemNumber
        {
            get => _itemNumber;
            set
            {
                _itemNumber = value;
            }
        }

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
            }
        }

        public double Price
        {
            get => _price;
            set
            {
                //validate price
                if (value >= 0)
                    _price = value;
                else
                    _price = 0;
            }
        }
        public int Quantity
        {
            get => _quantity;
            set
            {
                //validate quantity
                if (value >= 0)
                    _quantity = value;
                else
                    _quantity = 0;
            }
        }

        public DateTime Date
        {
            get => _date;
            set
            {
                _date = value;
            }
        }

        public int SaleID
        {
            get => _saleID;
            set
            {
                _saleID = value;
            }
        }

        public Status Status
        {
            get => _status;
            set
            {
                _status = value;
            }
        }

        
    }
}