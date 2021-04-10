using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Laboration_4.Backend;
using System.Threading.Tasks;

namespace Laboration_4
{
    public class Selling
    {
        //Data sourses for the progam
        BindingList<SaleInfo> _basketList;
        BindingList<SaleInfo> _saleInfoList;
        BindingList<TopTen> _topTenList;
        BindingSource _basketBindingSource;
        BindingSource _saleInfoBindingSource;
        BindingSource _topTenBindingSource;
        private Inventory _inventory;

        //Declare an instance int variabl
        int saleId = 1;

        public Selling(Inventory inventory)
        {
            //Create binding list and binding source for inventory
            _basketList = new BindingList<SaleInfo>();
            _basketBindingSource = new BindingSource(_basketList, null);
            _inventory = inventory;
            _saleInfoList = new BindingList<SaleInfo>();
            _saleInfoBindingSource = new BindingSource(_saleInfoList, null);
            _topTenList = new BindingList<TopTen>();
            _topTenBindingSource = new BindingSource(_topTenList, null);


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
            //Find the sale
            SaleInfo _sale = SaleIDSearch(saleID);

            //Chack if sale exist and not returned
            if (_sale != null && _sale.Status == Status.Bought)
            {
                //Add sale to the return basket
                _basketList.Add(_sale);
            }
            else
            {
                //If sale do not exist retun false
                return false;
            }

            //If product exist return true
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
            //Save buy for receipt
            ReceiptSave();

            //Clear basket
            ClearBasket();
        }

        public void ReturnItemsInBasket()
        {
            foreach (var item in _basketList)
            {
                foreach (var saleInfo in _saleInfoList)
                {
                    if (saleInfo.SaleID == item.SaleID)
                    {
                        saleInfo.Status = Status.Repuchased;
                        _inventory.IncreaseStock(item.SaleID, item.Quantity);
                    }
                }
            }

            //Clear basket
            ClearBasket();
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
            foreach(var saleInfo in _basketList)
            {
                if(saleInfo.SaleID > saleId)
                {
                    saleId = saleInfo.SaleID;
                }
            }
            return saleId++;
        }

        public void ClearBasket()
        {
            //Remove the content in basket
            _basketList.Clear();
        }

        public BindingSource SaleHistoryLoad()
        {
            //Check file
            if (!Helper.dataFileCheck(@"..\..\Database\saleHistory.csv"))
            {
                return _saleInfoBindingSource;
            }

            //Start upp reding from CVS file
            using (var reader = new StreamReader(@"..\..\Database\saleHistory.csv"))
            {
                //Get rows and split into data from CVS file
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    //Create new prodokts and add produkts to inventoryList
                    if (values.Length == 8)
                    {
                        SaleInfo saleInfo = new SaleInfo(values[0], values[1], values[2], values[3], values[4], values[5], values[6], values[7]);

                        _saleInfoList.Add(saleInfo);
                    }
                }
            }
            return _saleInfoBindingSource;
        }

        public void SaleHistorySave()
        {
            //Check file
            Helper.dataFileCheck(@"..\..\Database\saleHistory.csv");

            //Open file
            using (var writer = new StreamWriter(@"..\..\Database\saleHistory.csv"))
            {
                //Write all items from inventory list
                foreach (var item in _saleInfoList)
                {
                    writer.WriteLine(
                        $"{item.Type}," +
                        $"{item.ItemNumber}," +
                        $"{item.Name}," +
                        $"{item.Price}," +
                        $"{item.Quantity}," +
                        $"{item.Date}," +
                        $"{item.SaleID}," +
                        $"{item.Status}") ;
                }
            }
        }
        public void ReceiptSave()
        {
            //Declare a double instance
            double sumTotal = 0;
            //Check file
            Helper.dataFileCheck(@"..\..\Receipt\Receipt.htm");

            //Open file
            using (var writer = new StreamWriter(@"..\..\Receipt\Receipt.htm", false, System.Text.Encoding.UTF8))
            {
                //Write the receipt header
                writer.WriteLine($"<html><h1>Receipt</h1>\n { DateTime.Now}");
                writer.WriteLine($"");

                //Write the columns header
                writer.WriteLine($"Försäljnings ID\t" +
                        $"Artikelnummer\t" +
                        $"Namn\t" +
                        $"Antal\t" +
                        $"Pris\t" +
                        $"Summa");

                //Write all items from basket list
                foreach (var item in _basketList)
                {
                    writer.WriteLine(
                        $"{item.SaleID}\t" +
                        $"{item.ItemNumber}\t" +
                        $"{item.Type}, {item.Name}\t" +
                        $"{item.Quantity}\t" +
                        $"{item.Price}\t" +
                        $"{item.Quantity * item.Price}");

                    //Add line sum to the total sum
                    sumTotal += item.Quantity * item.Price;
                }

                //Write the receipt total sum
                writer.WriteLine(
                        $"\t" +
                        $"\t" +
                        $"\t" +
                        $"\t" +
                        $"Totalt: \t" +
                        $"{sumTotal.ToString("#.##")}</html>");

            }
        }

        public BindingSource GetTopTen(DateTime from, DateTime to)
        {
            _topTenList.Clear();
            foreach (var item in _saleInfoList.Where(i => i.Status == Status.Bought && from <= i.Date && i.Date <= to.AddDays(1)))
            {

                var topTenValue = _topTenList.FirstOrDefault(t => t.ItemNumber == item.ItemNumber);
                if (topTenValue != null)
                {
                    int index = _topTenList.IndexOf(topTenValue);
                    _topTenList[index].Quantity += item.Quantity;
                }
                else
                {
                    _topTenList.Add(new TopTen(item.ItemNumber, item.Name, item.Quantity));
                }

            }
            return _topTenBindingSource;
        }

        public Dictionary<string, int> GetTotalSale(DateTime from, DateTime to)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            foreach(var item in _saleInfoList.Where(i => i.Status == Status.Bought && from <= i.Date && i.Date <= to.AddDays(1)))
            {
                //Declare an string instance for the date format
                string date = item.Date.ToString("Y");
                
                if (dictionary.ContainsKey(date))
                {
                    dictionary[date] += item.Quantity;
                }
                else
                {
                    dictionary[date] = item.Quantity;
                }
                
            }

            return dictionary;
        }
    }
}