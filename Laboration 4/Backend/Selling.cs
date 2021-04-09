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
        BindingList<SaleInfo> _saleInfoList;
        BindingSource _basketBindingSource;
        BindingSource _saleInfoBindingSource;
        private Inventory _inventory;

        public Selling(Inventory inventory)
        {
            //Create binding list and binding source for inventory
            _basketList = new BindingList<SaleInfo>();
            _basketBindingSource = new BindingSource(_basketList, null);
            _inventory = inventory;
            _saleInfoList = new BindingList<SaleInfo>();
            _saleInfoBindingSource = new BindingSource(_saleInfoList, null);

        }

        public BindingSource BasketLoad()
        {
           return _basketBindingSource;
            
        }

        public BindingSource SaleInfoLoad()
        {
            return _saleInfoBindingSource;

        }

        public bool AddToBasketBuy(int itemNumber)
        {
            Product product = _inventory.ProductIDSearch(itemNumber);

            var itemInBasket = _basketList.FirstOrDefault(b => b.ItemNumber == itemNumber);

            if (itemInBasket != null)
            {
                var index = _basketList.IndexOf(itemInBasket);
                
                //Check that we have more product
                if(_basketList[index].Quantity < product.Quantity)
                {
                    _basketList[index].Quantity++;
                }
                else
                {
                    return false;
                }
                
            }
            else
            {
                if (product.Quantity > 0)
                {
                    SaleInfo saleInfo = new SaleInfo(product.Type, itemNumber, product.Name, product.Price, 1, DateTime.Now, GetSaleId(), Status.InBasket);
                    _basketList.Add(saleInfo);
                }
            }
            return true;
        }

        public bool AddToBasketReturn(int saleID)
        {
            SaleInfo _sale = SaleIDSearch(saleID);

            var itemInBasket = _basketList.FirstOrDefault(b => b.SaleID == saleID);

            if (itemInBasket != null)
            {
                var index = _basketList.IndexOf(itemInBasket);

                //Check that we have more product
                if (_basketList[index].Quantity < _sale.Quantity)
                {
                    _basketList[index].Quantity++;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                if (_sale.Quantity > 0)
                {
                    SaleInfo saleInfo = new SaleInfo(_sale.Type, _sale.ItemNumber, _sale.Name, _sale.Price, 1, _sale.Date, _sale.SaleID, Status.InBasket);
                    _basketList.Add(saleInfo);
                }
            }
            return true;
        }

        public void RemoveFromBasket(SaleInfo saleInfo)
        {
            _basketList.Remove(saleInfo);
        }

        public void BuyItemsInBasket()
        {
            foreach(var item in _basketList)
            {
                item.Status = Status.Bought;
                _saleInfoList.Add(item);
                _inventory.ReduceStock(item.ItemNumber, item.Quantity);
            }

            _basketList.Clear();
        }

        public void ReturnItemsInBasket()
        {
            foreach (var item in _basketList)
            {
                foreach (var saleInfo in _saleInfoList)
                {
                    if (saleInfo.SaleID == item.SaleID)
                    {
                        UppdateSaleInfoList(item.SaleID, item.Quantity);
                        saleInfo.Status = Status.Repuchased;
                        _inventory.IncreaseStock(item.SaleID, item.Quantity);
                    }
                }
            }

            _basketList.Clear();
        }

        public void UppdateSaleInfoList(int saleID, int quantity)
        {
            var _saleID = SaleIDSearch(saleID);

            if (_saleID != null && _saleID.Status != Status.Repuchased)
            {
                int index = _saleInfoList.IndexOf(_saleID);
                _saleInfoList[index].Quantity = _saleInfoList[index].Quantity - quantity;
            }
        }

        internal SaleInfo SaleIDSearch(int saleID)
        {
            return _saleInfoList.FirstOrDefault(i => i.SaleID == saleID);
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