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
            _inventoryList = new BindingList<Product>();
            _inventoryList.Add(new Product() { Type = Type.Bok, ItemNumber = 1, Name = "Commentarii de Bello Gallico et Civili", Price = 449, Quantity = 2 });
            _inventoryBindingSource = new BindingSource(_inventoryList, null);

        }
        public BindingSource InventoryLoad()
        {
            using (var reader = new StreamReader(@"..\..\Database\inventory.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    if(values.Length == 11)
                    {
                        Product NewProduct = new Product(values[0], values[1], values[2], values[3], values[4]);

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

        public void ProductAdd(Type type, int itemNumber, string name, double price, int quantity)
        {
            Product NewProduct = new Product(type, itemNumber, name, price, quantity);

            _inventoryList.Add(NewProduct);
        }

        public void ProductUppdate()
        {
            //TODO
        }

        public void ProductDelete()
        {
            //TODO
        }
    }
}