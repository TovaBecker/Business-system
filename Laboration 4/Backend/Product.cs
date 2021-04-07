using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Laboration_4
{
    public class Product
    {
        //Declare an instance variables 
        private Type _type;
        private int _itemNumber;
        private string _name;
        private double _price;
        private int _quantity;
        private string _author;
        private string _genre;
        private string _format;
        private string _language;
        private string _platform;
        private int _playtime;

        //Declare an instance variabl for inventory 
        private Inventory _inventory;

        public Product(Inventory inventory)
        {
            _inventory = inventory;
        }

        public Product( string type, int itemNumber, string name, string price, string quantity, string author, string genre, string format, string language, string platform, string playtime)
        {
            Type = GetType(type);
            ItemNumber = itemNumber;
            Name = name;
            Price = price == "" ? 0 : Convert.ToDouble(price);
            Quantity = quantity == "" ? 0 : Convert.ToInt32(quantity);
            Author = author;
            Genre = genre;
            Format = format;
            Language = language;
            Platform = platform;
            Playtime = playtime == "" ? 0 : Convert.ToInt32(playtime);
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

        public string Author
        {
            get => _author;
            set
            {
                _author = value; 
    }
}

        public string Genre
        {
            get => _genre;
            set
            {
                _genre = value;
            }
        }

        public string Format
        {
            get => _format;
            set
            {
                _format = value;
            }
        }

        public string Language
        {
            get => _language;
            set
            {
                _language = value;
            }
        }
       
        public string Platform
        {
            get => _platform;
            set
            {
                _platform = value;
                
            }
        }
        public int Playtime
        {
            get => _playtime;
            set
            {
                //validate plytime
                if (value >= 0)
                    _playtime = value;
                else
                    _playtime = 0;
            }
        }

        private Type GetType(string type)
        {
            if (type == "Bok")
                return Type.Bok;
            else if (type == "DVD")
                return Type.DVD;
            else if (type == "Spel")
                return Type.Spel;

            throw new Exception("Type does not exists");

        }
       
    }
}