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
        static BindingList<Product> _inventoryList;
        static BindingSource _inventoryBindingSource;

        public Inventory()
        {
            //Create binding list and binding source for inventory
            _inventoryList = new BindingList<Product>();
            _inventoryBindingSource = new BindingSource(_inventoryList, null);

        }

        public bool DeviveryQuantityAdd(int itemNumber, int quantity)
        {
            //Find and get the product
            Product _product = ProductIDSearch(itemNumber);

            //Check ig product exist
            if (_product != null)
            {
                //Add quantity to product
                _product.Quantity = _product.Quantity + quantity;

                //Get the index of the product
                int index = _inventoryList.IndexOf(_product);

                //Uppdate the product in list
                _inventoryList[index] = _product;

                //If successful return true
                return true;
            }
            //If unsuccessful return false
            return false;
        }

        public Product ProductAdd(Product Product)
        {
            //Check if the ID is used
            if (ProductIDSearch(Product.ItemNumber) == null)
            {
                //Add the product
                _inventoryList.Add(Product);
            }
            else
            {
                //Create a new product with unic ID
                Product newProduct = new Product(Product.Type, SetItemID(Convert.ToString(Product.ItemNumber)), Product.Name, Product.Price, Product.Quantity, Product.Author, Product.Genre, Product.Format, Product.Language, Product.Platform, Product.Playtime);

                //Add product into inventory list
                _inventoryList.Add(newProduct);

                //Return the product created with unic ID
                return newProduct;
            }
            //Return the product that were sent in
            return Product;
        }

        public void ProductUppdate(Product updateProduct)
        {
            //Find and get the product
            Product oldProduct = ProductIDSearch(updateProduct.ItemNumber);

            //Check if product do exist 
            if (oldProduct != null)
            {
                //Find products index in inventory list
                int index = _inventoryList.IndexOf(oldProduct);

                //Add updated product into inventory list
                _inventoryList[index] = updateProduct;
            }
        }

        public bool ProductDelete(int itemNumber)
        {
            //Find and get the product
            Product deleteProduct = ProductIDSearch(itemNumber);

            //Check if product do exist 
            if (deleteProduct != null)
            {
                //Remove product from inventory list
                _inventoryList.Remove(deleteProduct);
                return true;
            }
            return false;
        }

        //Code inspierd from https://stackoverflow.com/questions/5843537/filtering-datagridview-without-changing-datasource
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
                filteredList = filteredList.Where(i => i.Name.ToLower().Contains(name.ToLower())).ToList();

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
            //Find and get the product
            return _inventoryList.FirstOrDefault(i => i.ItemNumber == itemNumber);
        }

        internal int SetItemID(string itemNumber)
        {
            //Convert string itemNumber to integer ID
            int id = int.Parse(itemNumber);

            //Check ID and find, get if a product has the ID
            if (0 < id && ProductIDSearch(id) == null)
            {
                //Return the ID if the ID is unic 
                return id;
            }

            //Declare an bool instance variabl
            bool idSet = false;

            //Find first free ID
            while (idSet == false)
            {
                //Get a unic ID
                if (null == ProductIDSearch(itemNumberID))
                {
                    idSet = true;
                }
                else
                {
                    //Increese the default ID
                    itemNumberID++;
                }
            }

            //Increese the default ID to be ready for next input
            itemNumberID++;

            //Return a unic ID found by the system
            return itemNumberID - 1;
        }

        public void ReduceStock(int itemNumber, int quantity)
        {
            //Find product
            var product = ProductIDSearch(itemNumber);

            //Check if product is in stock
            if (product != null && product.Quantity >= quantity)
            {
                //Decrease stock on item
                int index = _inventoryList.IndexOf(product);
                _inventoryList[index].Quantity = _inventoryList[index].Quantity - quantity;
            }
        }
        public void IncreaseStock(int itemNumber, int quantity)
        {
            //Find product
            var product = ProductIDSearch(itemNumber);

            //Increase stock on item
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

            _inventoryList = new BindingList<Product>();


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

            _inventoryBindingSource.DataSource = _inventoryList;

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

