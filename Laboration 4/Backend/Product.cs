using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laboration_4
{
    internal class Product
    {
        //declare an instance variable that holds the ItemNumber 
        private Type _type;
        private int _itemNumber;
        private string _name;
        private double _price;
        private int _quantity;

        //Declare private static value
        static int itemNumberID = 1;

        public Product()
        {

        }

        public Product(string type, string itemNumber, string name, string price, string quantity)
        {
            _type = GetType(type);
            _itemNumber = Convert.ToInt32(itemNumber);
            _name = name;
            _price = price == "" ? 0 : Convert.ToDouble(price);
            _quantity = quantity == "" ? 0 : Convert.ToInt32(quantity);
        }

    public Product(Type type, int itemNumber, string name, double price, int quantity)
        {
            _type = type;
            _itemNumber = itemNumber;
            _name = name;
            _price = price;
            _quantity = quantity;
        }
        public Type Type
        {
            get => _type;
            set
            {//TODO
                _type = value;
            }
        }

        public int ItemNumber
        {
            get => _itemNumber;
            set
            {//TODO
                if (0 < value)
                {
                    _itemNumber = value;
                }
                else
                {
                    _itemNumber = SetItemID();
                }
                
            }
        }

        public string Name
        {
            get => _name;
            set
            {//TODO
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
            {//TODO

                //validate quantity
                if (value >= 0)
                    _quantity = value;
                else
                    _quantity = 0;
            }
        }

        public int Author
        {
            get => default;
            set
            {
            }
        }

        public int Genre
        {
            get => default;
            set
            {
            }
        }

        public int Format
        {
            get => default;
            set
            {
            }
        }

        public int Language
        {
            get => default;
            set
            {
            }
        }
        public int Playtime
        {
            get => default;
            set
            {
            }
        }
        public int Platform
        {
            get => default;
            set
            {
            }
        }

        private int SetItemID()
        {//TODO
            itemNumberID++;

            return itemNumberID;
        }

        private Type GetType(string type)
        {
            if (type == "Bok")
                return Type.Bok;
            if (type == "DVD")
                return Type.DVD;
            if (type == "Spel")
                return Type.Spel;

            throw new Exception("Type does not exists");

        }
       
    }
}