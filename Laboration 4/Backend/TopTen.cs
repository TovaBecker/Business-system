using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_4.Backend
{
    class TopTen
    {
        private int _itemNumber;
        private string _name;
        private int _quantity;

        public TopTen(int itemNumber, string name, int quantity)
        {
            ItemNumber = itemNumber;
            Name = name;
            Quantity = quantity;
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
    }

    
}
