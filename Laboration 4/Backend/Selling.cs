using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Laboration_4
{
    public class Selling
    {
        //Data sourses for the progam
        BindingList<SaleInfo> _basketList;
        BindingSource _basketBindingSource;
        private Inventory _inventory;

        public Selling(Inventory inventory)
        {
            //Create binding list and binding source for inventory
            _basketList = new BindingList<SaleInfo>();
            _basketBindingSource = new BindingSource(_basketList, null);
            _inventory = inventory;

        }

        public BindingSource BasketLoad()
        {
           return _basketBindingSource;
            
        }

        public void Repurchase()
        {
            //TODO
        }

        public void Buy()
        {
            //TODO
        }

        public void AddToBasket(int itemNumber)
        {
            Product product = _inventory.ProductIDSearch(itemNumber);

            var itemInBasket = _basketList.FirstOrDefault(b => b.ItemNumber == itemNumber);

            if (itemInBasket != null)
            {
                var index = _basketList.IndexOf(itemInBasket);
                
                //Check that we have more product
                if(_basketList[index].Quantity< product.Quantity)
                {
                    _basketList[index].Quantity++;
                }
                
            }
            else
            {
                if (product.Quantity < 0)
                {
                    SaleInfo saleInfo = new SaleInfo(product.Type, itemNumber, product.Name, product.Price, 1, DateTime.Now, GetSaleId(), Status.InBasket);
                    _basketList.Add(saleInfo);
                }
                
            }
        }

        private int GetSaleId()
        {
            var saleId = 0;
            foreach(var saleInfo in _basketList)
            {
                if(saleInfo.SaleID > saleId)
                {
                    saleId = saleInfo.SaleID;
                }
            }
            return saleId++;
        }
    }
}