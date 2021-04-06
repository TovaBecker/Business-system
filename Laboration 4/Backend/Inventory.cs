using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Laboration_4
{
    public class Inventory
    {
        //Data sourses for the progam
        BindingList<Product> _inventoryList;
        BindingSource _inventoryBindingSource;

        public Inventory()
        {
            //Create binding list and binding source for inventory
            _inventoryList = new BindingList<Product>();
            _inventoryBindingSource = new BindingSource(_inventoryList, null);

        }
        public BindingSource InventoryLoad()
        {
            //Start upp reding from CVS file
            using (var reader = new StreamReader(@"..\..\Database\inventory.csv"))
            {
                //Get rows and split into data from CVS file
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    //Create new prodokts and add produkts to inventoryList
                    if (values.Length == 11)
                    {
                        Product NewProduct = new Product(values[0], values[1], values[2], values[3], values[4], values[5], values[6], values[7], values[8], values[9], values[10]);

                        _inventoryList.Add(NewProduct);
                    }

                    
                }
                return _inventoryBindingSource;
            }
        }

        public void InventorySave()
        {
            //TODO
        }

        public void ProductAdd(Type type, int itemNumber, string name, double price, int quantity, string author, string genre, string format, string language, string platform, int playtime)
        {
            Product NewProduct = new Product(type, itemNumber, name, price, quantity, author, genre, format, language, platform, playtime);

            _inventoryList.Add(NewProduct);
        }

        public void ProductUppdate()
        {
            //TODO
        }

        public bool ProductDelete(int itemNumber)
        {
            Product item = ProductSearch(itemNumber);

                if(item != null)
            {
                if( 0 < item.Quantity)
                {
                    //Print do you relly want to do this
                    //TO DO
                }
                else
                {
                    return true;
                }
            }
            else
            {
                //Print error
                //TO DO
            }
            return false;

        }

        internal Product ProductSearch(int itemNumber)
        {
            foreach (var item in _inventoryList)
            {
                if (item.ItemNumber == itemNumber)
                {
                    return item;
                }

            }
            return null;
        }
    }
}