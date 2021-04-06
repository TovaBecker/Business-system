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

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        public Control()
        {
            _inventory = new Inventory();
        }

        public Control(Inventory inventory)
        {
            _inventory = inventory;
            _product = new Product(_inventory);
        }


        public void Purchase()
        {
            //TODO
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
            return _inventory.ProductSearch(itemNumber);
        }

        public void NewProduct()
        {
            //TODO
        }

        public void RemoveProduct()
        {
            //TODO
        }
        public BindingSource LoadInventory()
        {
            return _inventory.InventoryLoad();
        }

    }
}