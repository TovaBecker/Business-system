using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Laboration_4
{
    public class Control
    {
        private Inventory _inventory;
        private Product _product;
        private Selling _selling;

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        public Control()
        {
            _inventory = new Inventory();
            _product = new Product(_inventory);
            _selling = new Selling(_inventory);
        }

        public Control(Inventory inventory)
        {
            _inventory = inventory;
        }


        public void Purchase()
        {
            //TODO
        }

        public void AddToBasket(int itemNumber)
        {
            _selling.AddToBasket(itemNumber);
        }
        public void Return()
        {
            //TODO
        }

        public void Delivery()
        {
            //TODO
        }

        internal Product Search(int itemNumber)
        {
            return _inventory.ProductIDSearch(itemNumber);
        }

        public void Search(string type, int itemNumber, string name, double price, int quantity, string author, string genre, string format, string language, string platform, int playtime)
        {
            _inventory.ProductSearch(type, itemNumber, name, price, quantity, author, genre, format, language, platform, playtime);
        }

        public void ClearSearch()
        {
            _inventory.ProductClearSearch();
        }

        public void NewProduct(Product newProduct)
        {
            _inventory.ProductAdd(newProduct);
        }

        public void UpdateProduct(Product updateProduct)
        {
            _inventory.ProductUppdate(updateProduct);
        }

        public bool RemoveProduct(int itemNumber)
        {
            return _inventory.ProductDelete(itemNumber);
        }
        public BindingSource LoadInventory()
        {
            return _inventory.InventoryLoad();
        }
        public BindingSource LoadBasket()
        {
            return _selling.BasketLoad();
        }

    }
}