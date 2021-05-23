using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboration_4.Backend
{
    public interface IControl
    {
        bool Purchase();
        void ClearBasket();
        bool AddToBasketBuy(int itemNumber);
        bool AddToBasketReturn(int saleID);
        void RemoveFromBasket(SaleInfo saleInfo);
        void Return();
        bool Delivery(int itemNumber, int quantity);
        Product Search(int itemNumber);
        void Search(string type, int itemNumber, string name, double price, int quantity, string author, string genre, string format, string language, string platform, int playtime);

        void ClearSearch();

        Product NewProduct(Product newProduct);
        void UpdateProduct(Product updateProduct);
        bool RemoveProduct(int itemNumber);
        int FindID();
        BindingSource LoadInventory();
        BindingSource LoadSaleHistory();
        BindingSource LoadBasket();
        void Save();
        BindingSource GetTopTen(DateTime from, DateTime to);
        Dictionary<string, int> GetTotalSale(DateTime from, DateTime to);
    }
}
