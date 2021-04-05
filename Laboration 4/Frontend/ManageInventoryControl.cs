using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboration_4
{
    public partial class ManageInventoryControl : UserControl
    {
        //Data sourses for the progam
        BindingList<Product> InventoryList;

        public ManageInventoryControl()
        {
            InitializeComponent();

            InventoryList = new BindingList<Product>()
            {
            new Product (){ ItemNumber = 0001, Name ="Commentarii de Bello Gallico et Civili", Price = 449, Quantity =2, Type = Type.Bok},
            new Product (){ ItemNumber = 0002, Name ="How to Read a Book", Price = 149, Quantity =5, Type = Type.Bok}
            };
            InventoryListSource = new BindingSource();
            InventoryListSource.DataSource = InventoryList;
        }

    }
}
