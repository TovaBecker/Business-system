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
        private int saleId = 1;

        public Selling(Inventory inventory)
        {
            //Create binding list and binding source for inventory
            _basketList = new BindingList<SaleInfo>();
            _basketBindingSource = new BindingSource(_basketList, null);
            _saleInfoList = new BindingList<SaleInfo>();
            _saleInfoBindingSource = new BindingSource(_saleInfoList, null);
            _topTenList = new BindingList<TopTen>();
            _topTenBindingSource = new BindingSource(_topTenList, null);
            _inventory = inventory;


        }

        public BindingSource BasketLoad()
        {
            //Send baskets binding source
            return _basketBindingSource;
        }

        public BindingSource SaleInfoLoad()
        {
            //Send saleInfo binding source
            return _saleInfoBindingSource;
        }

        public bool AddToBasketBuy(int itemNumber)
        {
            //Find product
            Product product = _inventory.ProductIDSearch(itemNumber);

            //Find product in basket
            var itemInBasket = _basketList.FirstOrDefault(b => b.ItemNumber == itemNumber);

            //Check if item is in basket
            if (itemInBasket != null)
            {
                //Get indext of item in basket grid
                var index = _basketList.IndexOf(itemInBasket);

                //Check that we have more product
                if (_basketList[index].Quantity < product.Quantity)
                {
                    //Inccrese quantity of the selected product
                    _basketList[index].Quantity++;
                    _basketList[index].Sum = _basketList[index].Price * _basketList[index].Quantity;
                }
                else
                {
                    //If product do mot exist in stock return false
                    return false;
                }
            }
            else
            {
                if (product != null)
                {
                    if (product.Quantity > 0)
                    {
                        //Create saleInfo object
                        SaleInfo saleInfo = new SaleInfo(product.Type, itemNumber, product.Name, product.Price, 1, product.Price, DateTime.Now, GetSaleId(), Status.InBasket);

                        //Add saleInfo object to basket list
                        _basketList.Add(saleInfo);
                    }
                    else
                    {
                        //If product do mot exist in stock return false
                        return false;
                    }
                }
            }
            //If product was added succesful return true
            return true;
        }

        public bool AddToBasketReturn(int saleID)
        {
            //Find the sale
            SaleInfo _sale = SaleIDSearch(saleID);

            //Get item
            var itemInBasket = _basketList.FirstOrDefault(b => b.SaleID == saleID);

            //Check if item is in basket
            if (itemInBasket == null)
            {
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
            }
            else
            {
                //If return exist in basket return false
                return false;
            }

            //If return exist return true
            return true;
        }

        public void RemoveFromBasket(SaleInfo saleInfo)
        {
            //Remove product from basket
            _basketList.Remove(saleInfo);
        }

        public bool BuyItemsInBasket()
        {
            //Double for total amount on Receipt
            double _total = 0;

            //Check if basketlist is empty
            if (_basketList.Count() == 0)
            {
                return false;
            }

            //Go thougt basket and add buy
            foreach (var item in _basketList)
            {
                //Add sum to total
                _total += item.Price * item.Quantity;

                //Set product status to bought
                item.Status = Status.Bought;

                //Add product to saleInfo list
                _saleInfoList.Add(item);

                //Remove the bought quantity from stock
                _inventory.ReduceStock(item.ItemNumber, item.Quantity);
            }

            //Print the receipt for the buy to the user
            using (PrintReceiptForm print = new PrintReceiptForm(_basketList, Convert.ToString(_total)))
            {
                print.ShowDialog();

            };

            //Clear basket
            ClearBasket();

            return true;
        }

        public void ReturnItemsInBasket()
        {
            //Go thought all products in basket
            foreach (var item in _basketList)
            {
                //Go thought all products in saleInfo
                foreach (var saleInfo in _saleInfoList)
                {
                    //Check saleID and that status is Bought
                    if (saleInfo.SaleID == item.SaleID && saleInfo.Status == Status.Bought)
                    {
                        //Uppdate status to repuchased
                        saleInfo.Status = Status.Repuchased;

                        //Increase stock in inventory
                        _inventory.IncreaseStock(item.ItemNumber, item.Quantity);
                    }
                }
            }

            //Clear basket
            ClearBasket();
        }
        internal SaleInfo SaleIDSearch(int saleID)
        {
            //Find and get the product
            return _saleInfoList.FirstOrDefault(i => i.SaleID == saleID);
        }

        private int GetSaleId()
        {
            //Declare an bool instance variabl
            bool idSet = false;

            //Find first free ID
            while (idSet == false)
            {
                //Get a unic ID
                if (null == SaleIDSearch(saleId))
                {
                    idSet = true;
                }
                else
                {
                    //Increese the default ID
                    saleId++;
                }
            }

            //Increese the default ID to be ready for next input
            saleId++;

            //Return a unic ID found by the system
            return saleId - 1;
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
                    if (values.Length == 9)
                    {
                        SaleInfo saleInfo = new SaleInfo(values[0], values[1], values[2], values[3], values[4], values[5], values[6], values[7], values[8]);

                        _saleInfoList.Add(saleInfo);
                    }
                }
            }
            return _saleInfoBindingSource;
        }
        public BindingSource GetTopTen(DateTime from, DateTime to)
        {
            //Clear the list
            _topTenList.Clear();

            //Create a list for the data
            var _data = new List<TopTen>();

            //Get sales that were bought between specified dates
            foreach (var sale in _saleInfoList.Where(i => i.Status == Status.Bought && from <= i.Date && i.Date <= to.AddDays(1)))
            {
                //Check if sale is in list
                var topTenValue = _data.FirstOrDefault(t => t.ItemNumber == sale.ItemNumber);

                if (topTenValue != null)
                {
                    //Get index of sale
                    int index = _data.IndexOf(topTenValue);

                    //Add sale quantity to sale
                    _data[index].Quantity += sale.Quantity;
                }
                else
                {
                    //Add sae to the list
                    _data.Add(new TopTen(sale.ItemNumber, sale.Name, sale.Quantity));
                }
            }
            //Order the list in descending order on quantity
            _data = _data.OrderByDescending(i => i.Quantity).ToList();

            //Get the 10 sales with higest quantity
            for (int i = 0; i < 10; i++)
            {
                if (_data.Count > i)
                {
                    //Add sale to list
                    _topTenList.Add(_data[i]);
                }
            }

            //Return binding source 
            return _topTenBindingSource;
        }

        public Dictionary<string, int> GetTotalSale(DateTime from, DateTime to)
        {
            //Create a dictionary with string and int
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            //Go thought sales that were bought between specified dates
            foreach (var sale in _saleInfoList.Where(i => i.Status == Status.Bought && from <= i.Date && i.Date <= to.AddDays(1)).OrderBy(i => i.Date).ToList())
            {
                //Declare an string instance for the date format
                string date = sale.Date.ToString("Y");

                //Check if date extist in dictionary
                if (dictionary.ContainsKey(date))
                {
                    //Uppdate extisting date with sale quantity
                    dictionary[date] += sale.Quantity;
                }
                else
                {
                    //Add a new date and set sale quantity
                    dictionary[date] = sale.Quantity;
                }

            }

            return dictionary;
        }

        public void SaleHistorySave()
        {
            //Check file
            Helper.dataFileCheck(@"..\..\Database\saleHistory.csv");

            //Open file
            using (var writer = new StreamWriter(@"..\..\Database\saleHistory.csv"))
            {
                //Write all items from saleInfo list into file
                foreach (var item in _saleInfoList)
                {
                    writer.WriteLine(
                        $"{item.Type}," +
                        $"{item.ItemNumber}," +
                        $"{item.Name}," +
                        $"{item.Price}," +
                        $"{item.Quantity}," +
                        $"{item.Sum}," +
                        $"{item.Date}," +
                        $"{item.SaleID}," +
                        $"{item.Status}");
                }
            }
        }
       
    }
}