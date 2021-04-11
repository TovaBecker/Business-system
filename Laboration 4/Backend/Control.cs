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
            //Create an inctance of inventory
            _inventory = new Inventory();

            //Create the lists used by the system
            _product = new Product(_inventory);
            _selling = new Selling(_inventory);
        }

        public Control(Inventory inventory)
        {
            //Set the instance of inventory
            _inventory = inventory;
        }

        public bool Purchase()
        {
            //Conect to selling class and execute method
            return _selling.BuyItemsInBasket();
        }

        public void ClearBasket()
        {
            //Conect to selling class and execute method
            _selling.ClearBasket();
        }

        public bool AddToBasketBuy(int itemNumber)
        {
            //Conect to selling class and execute method and send itemNumber
            return _selling.AddToBasketBuy(itemNumber);
        }
        public bool AddToBasketReturn(int saleID)
        {
            //Conect to selling class and execute method and send saleID
            return _selling.AddToBasketReturn(saleID);
        }

        public void RemoveFromBasket(SaleInfo saleInfo)
        {
            //Conect to selling class and execute method and send saleInfo
            _selling.RemoveFromBasket(saleInfo);
        }


        internal int GetValidID(string itemNumber)
        {
            //Conect to inventory class and execute method and send itemNumber
            return _inventory.SetItemID(itemNumber);
        }

        public void Return()
        {
            //Conect to selling class and execute method
            _selling.ReturnItemsInBasket();
        }

        public bool Delivery(int itemNumber, int quantity)
        {
            //Conect to inventory class and execute method and send itemNumber, quantity
            return _inventory.DeviveryQuantityAdd(itemNumber, quantity);
        }

        internal Product Search(int itemNumber)
        {
            //Conect to inventory class and execute method and send itemNumber
            return _inventory.ProductIDSearch(itemNumber);
        }

        public void Search(string type, int itemNumber, string name, double price, int quantity, string author, string genre, string format, string language, string platform, int playtime)
        {
            //Conect to inventory class and execute method and send data
            _inventory.ProductSearch(type, itemNumber, name, price, quantity, author, genre, format, language, platform, playtime);
        }

        public void ClearSearch()
        {
            //Conect to inventory class and execute method
            _inventory.ProductClearSearch();
        }

        public Product NewProduct(Product newProduct)
        {
            //Conect to inventory class and execute method and send product
            return _inventory.ProductAdd(newProduct);
        }

        public void UpdateProduct(Product updateProduct)
        {
            //Conect to inventory class and execute method and send updateProduct
            _inventory.ProductUppdate(updateProduct);
        }

        public bool RemoveProduct(int itemNumber)
        {
            //Conect to inventory class and execute method and send itemNumber
            return _inventory.ProductDelete(itemNumber);
        }

        public int FindID()
        {
            //Conect to inventory class and execute method and send a 1
            return _inventory.SetItemID("1");
        }

        public BindingSource LoadInventory()
        {
            //Conect to inventory class and execute method
            return _inventory.InventoryLoad();
        }

        public BindingSource LoadSaleHistory()
        {
            //Conect to inventory class and execute method
            return _selling.SaleHistoryLoad();
        }

        public BindingSource LoadBasket()
        {
            //Conect to inventory class and execute method
            return _selling.BasketLoad();
        }


        public void Save()
        {
            //Conect to inventory and selling class and execute methods for saving data files
            _inventory.InventorySave();
            _selling.SaleHistorySave();
        }

        public BindingSource GetTopTen(DateTime from, DateTime to)
        {
            //Conect to selling class and execute method
            return _selling.GetTopTen(from, to);
        }

        public Dictionary<string, int> GetTotalSale(DateTime from, DateTime to)
        {
            //Conect to selling class and execute method
            return _selling.GetTotalSale(from, to);
        }

    }
}