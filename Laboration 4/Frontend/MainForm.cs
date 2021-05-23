using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Laboration_4.Backend;

namespace Laboration_4
{
    public partial class MainForm : Form
    {
        //Data sourses for the progam
        BindingSource _inventoryBindingSource;
        BindingSource _saleHistoryBindingSource;
        BindingSource _basketBindingSource;
        IControl _control;
        private static FileSystemWatcher _watcher;

        public MainForm()
        {
            InitializeComponent();         

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                _watcher = new FileSystemWatcher(@"..\..\Database", "inventory.csv");
                _watcher.Changed += Watcher_Changed;
                _watcher.EnableRaisingEvents = true;

                _control = new Backend.Control(_watcher);

                //Loade the binding source in system
                _inventoryBindingSource = _control.LoadInventory();
                _saleHistoryBindingSource = _control.LoadSaleHistory();
                _basketBindingSource = _control.LoadBasket();

                
            }
            catch (Exception error)
            {
                //Show message that tells user file is not availebled
                MessageBox.Show(
                                $"{error.Message}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                //Close the program
                Application.Exit();
            }

            //Get and put ManageInventoryControl in inventory tab
            ManageInventoryControl inventory = new ManageInventoryControl(_control, _inventoryBindingSource);
            inventory.Dock = DockStyle.Fill;
            InventoryTab.Controls.Add(inventory);

            //Get and put ManageCheckoutControl in checkout tab
            ManageCheckoutControl checkout = new ManageCheckoutControl(_control, _inventoryBindingSource, _basketBindingSource);
            checkout.Dock = DockStyle.Fill;
            CheckoutTab.Controls.Add(checkout);

            //Get and put ManageDeliveryControl in delivery tab
            ManageDeliveryControl delivery = new ManageDeliveryControl(_control);
            delivery.Dock = DockStyle.Fill;
            deliveryTab.Controls.Add(delivery);

            //Get and put ManageStatisticsControl in statistics tab
            ManageStatisticsControl statistics = new ManageStatisticsControl(_control);
            statistics.Dock = DockStyle.Fill;
            StatisticsTab.Controls.Add(statistics);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Save data in files when form is closing
            _control.Save();
        }
        private void MainForm_FormClosed(object sender, FormClosingEventArgs e)
        {
            //Save data in files when form is closing
            _control.Save();
        }

        public void Watcher_Changed(object sender, FileSystemEventArgs e)
        {
            System.Threading.Thread.Sleep(2000);

            this.Invoke(new Action(() => _control.LoadInventory()));

        }

    }
}
