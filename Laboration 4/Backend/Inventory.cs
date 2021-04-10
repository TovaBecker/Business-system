using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Laboration_4.Backend;

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

        public bool DeviveryQuantityAdd(int itemNumber, int quantity)
        {
            Product _product = ProductIDSearch(itemNumber);

            if (_product != null)
            {
                _product.Quantity = _product.Quantity + quantity;
                int index = _inventoryList.IndexOf(_product);
                _inventoryList[index] = _product;
                return true;
            }

            return false;
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
                var searchType = Helper.GetType(type);
                filteredList = filteredList.Where(i => i.Type == searchType).ToList();
            }

            if (itemNumber > 0)
                filteredList = filteredList.Where(i => $"{i.ItemNumber}".ToLower().Contains($"{itemNumber}".ToLower())).ToList();

            if (!string.IsNullOrEmpty(name))
                filteredList = filteredList.Where(i => i.Name.ToLower().Contains(name.ToLower()) ).ToList();

            if (price > 0)
                filteredList = filteredList.Where(i => $"{i.Price }".ToLower().Contains($"{price}".ToLower())).ToList();

            if (quantity > 0)
                filteredList = filteredList.Where(i => $"{i.Quantity}".ToLower().Contains($"{quantity}".ToLower())).ToList();

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
                filteredList = filteredList.Where(i => $"{i.Playtime}".ToLower().Contains($"{playtime}".ToLower())).ToList();

            //Send filter 
            _inventoryBindingSource.DataSource = filteredList;
        }

        internal void ProductClearSearch()
        {
            //Reset datagrids source
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

        public void ReduceStock(int itemNumber, int quantity)
        {
            var product = ProductIDSearch(itemNumber);

            if(product != null && product.Quantity >= quantity)
            {
                int index = _inventoryList.IndexOf(product);
                _inventoryList[index].Quantity = _inventoryList[index].Quantity - quantity;
            }
        }
        public void IncreaseStock(int itemNumber, int quantity)
        {
            var product = ProductIDSearch(itemNumber);

                int index = _inventoryList.IndexOf(product);
                _inventoryList[index].Quantity = _inventoryList[index].Quantity + quantity;
            
        }

        public BindingSource InventoryLoad()
        {
            //Check file
            if (!Helper.dataFileCheck(@"..\..\Database\inventory.csv"))
            {
                return _inventoryBindingSource;
            }

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
            }
            return _inventoryBindingSource;
        }

        public void InventorySave()
        {
            //Check file
            Helper.dataFileCheck(@"..\..\Database\inventory.csv");

            //Open file
            using (var writer = new StreamWriter(@"..\..\Database\inventory.csv"))
            {
                //Write all items from inventory list
                foreach (var item in _inventoryList)
                {
                    writer.WriteLine(
                        $"{item.Type}," +
                        $"{item.ItemNumber}," +
                        $"{item.Name}," +
                        $"{item.Price}," +
                        $"{item.Quantity}," +
                        $"{item.Author}," +
                        $"{item.Genre}," +
                        $"{item.Format}," +
                        $"{item.Language}," +
                        $"{item.Platform}," +
                        $"{item.Playtime}");
                }
            }
        }
    }
}

    