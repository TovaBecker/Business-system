﻿using System;
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
        BindingList<Product> InventoryList;
        BindingSource InventoryListSource;

        public MainForm()
        {
            InitializeComponent();
            InventoryList = new BindingList<Product>();
            InventoryListSource = new BindingSource();
            InventoryListSource.DataSource = InventoryList;

        }

        private void inventoryControlMainView_Load(object sender, EventArgs e)
        {
            

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}
