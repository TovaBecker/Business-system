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
        

        public MainForm()
        {
            InitializeComponent();
        }

        private void inventoryControlMainView_Load(object sender, EventArgs e)
        {
            

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ManageInventoryControl inventory = new ManageInventoryControl();
            inventory.Dock = DockStyle.Fill;
            InventoryTab.Controls.Add(inventory);

            ManageCheckoutControl checkout = new ManageCheckoutControl();
            checkout.Dock = DockStyle.Fill;
            CheckoutTab.Controls.Add(checkout);


            ManageStatisticsControl statistics = new ManageStatisticsControl();
            statistics.Dock = DockStyle.Fill;
            StatisticsTab.Controls.Add(statistics);
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}
