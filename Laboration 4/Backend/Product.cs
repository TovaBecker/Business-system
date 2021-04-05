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
            get => default;
            set
            {//TODO
                _type = value;
            }
        }

        public int ItemNumber
        {
            get => default;
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
            get => default;
            set
            {//TODO
                _name = value;
            }
        }

        public double Price
        {
            get => default;
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
            get => default;
            set
            {//TODO

                //validate quantity
                if (value >= 0)
                    _quantity = value;
                else
                    _quantity = 0;
            }
        }

        private int SetItemID()
        {//TODO
            itemNumberID++;

            return itemNumberID;
        }
       
    }
}