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
        //Declare private static value
        static int itemNumberID = 1;

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
                        Product NewProduct = new Product(values[0], SetItemID(values[1]), values[2], values[3], values[4], values[5], values[6], values[7], values[8], values[9], values[10]);

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

        public void ProductAdd(Product newProduct)
        {
            _inventoryList.Add(newProduct);
        }

        public void ProductUppdate(Product updateProduct)
        {
            Product oldProduct = ProductIDSearch(updateProduct.ItemNumber);

            if (oldProduct != null)
            {
                int index = _inventoryList.IndexOf(oldProduct);
                _inventoryList[index] = updateProduct;
            }
        }

        public bool ProductDelete(int itemNumber)
        {
            Product item = ProductIDSearch(itemNumber);

            if (item != null)
            {
                _inventoryList.Remove(item);
                return true;
            }
            return false;

        }

        internal void ProductSearch(string type, int itemNumber, string name, double price, int quantity, string author, string genre, string format, string language, string platform, int playtime)
        {
            //Declare and initialize filtered list
            var filteredList = _inventoryList.ToList();

            //Check and add search data
            if (!string.IsNullOrEmpty(type))
            {
                var searchType = GetType(type);
                filteredList = filteredList.Where(i => i.Type == searchType).ToList();
            }

            if (itemNumber > 0)
                filteredList = filteredList.Where(i => i.ItemNumber == itemNumber).ToList();

            if (!string.IsNullOrEmpty(name))
                filteredList = filteredList.Where(i => i.Name.ToLower().Contains(name.ToLower()) ).ToList();

            if (price > 0)
                filteredList = filteredList.Where(i => i.Price == price).ToList();

            if (quantity > 0)
                filteredList = filteredList.Where(i => i.Quantity == quantity).ToList();

            if (!string.IsNullOrEmpty(author))
                filteredList = filteredList.Where(i => i.Author.ToLower().Contains(author.ToLower())).ToList();

            if (!string.IsNullOrEmpty(genre))
                filteredList = filteredList.Where(i => i.Genre.ToLower().Contains(genre.ToLower())).ToList();

            if (!string.IsNullOrEmpty(format))
                filteredList = filteredList.Where(i => i.Format.ToLower().Contains(format.ToLower())).ToList();

            if (!string.IsNullOrEmpty(language))
                filteredList = filteredList.Where(i => i.Language.ToLower().Contains(language.ToLower())).ToList();

            if (!string.IsNullOrEmpty(platform))
                filteredList = filteredList.Where(i => i.Platform.ToLower().Contains(platform.ToLower())).ToList();

            if (playtime > 0)
                filteredList = filteredList.Where(i => i.Playtime == playtime).ToList();
            
            //Send filter 
            _inventoryBindingSource.DataSource = filteredList;
        }

        internal void ProductClearSearch()
        {
            _inventoryBindingSource.DataSource = _inventoryList;
        }

        internal Product ProductIDSearch(int itemNumber)
        {
            return _inventoryList.FirstOrDefault(i => i.ItemNumber == itemNumber);
        }

        internal int SetItemID(string itemNumber)
        {
            int id = int.Parse(itemNumber);

            if (0 < id && ProductIDSearch(id) == null)
            {
                return id;
            }

            //Declare an bool instance variabl
            bool idSet = false;

            //Find first free ID
            while (idSet == false)
            {
                if (null == ProductIDSearch(itemNumberID))
                {
                    idSet = true;
                }
                else
                {
                    itemNumberID++;
                }
            }

            itemNumberID++;

            return itemNumberID - 1;
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

    