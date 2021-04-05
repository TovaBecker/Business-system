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
        BindingSource productBindingSource;

        public MainForm()
        {
            InitializeComponent();
            InventoryList = new BindingList<Product>()
            InventoryList.Add(new Product() { Type = Type.Bok, ItemNumber = 1, Name = "Commentarii de Bello Gallico et Civili", Price = 449, Quantity = 2 });
            productBindingSource = new BindingSource();
            productBindingSource.DataSource = InventoryList;
        }

        private void inventoryControlMainView_Load(object sender, EventArgs e)
        {
            

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ManageCheckoutControl checkout = new ManageCheckoutControl(productBindingSource);
            ManageInventoryControl inventory = new ManageInventoryControl(productBindingSource);
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}
