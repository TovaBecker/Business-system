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
    public partial class MainForm : Form
    {
        //Data sourses for the progam
        BindingList<Product> InventoryList;
        BindingSource InventoryListSource;

        public MainForm()
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

        private void inventoryControlMainView_Load(object sender, EventArgs e)
        {
            

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //ManageCheckoutControl checkout = new ManageCheckoutControl(InventoryListSource);
            ManageInventoryControl inventory = new ManageInventoryControl(InventoryListSource);
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}
