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
        BindingSource ProductBindingSource;

        internal Product NewProduct { get; private set; }

        public ManageInventoryControl()
        {
            InitializeComponent();
        }

        public ManageInventoryControl(BindingSource productBindingSource)
        {
            InitializeComponent();

            this.ProductBindingSource = productBindingSource;
            inventoryDataGrid.DataSource = ProductBindingSource;

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            NewProduct = new Product();
            NewProduct.ItemNumber = int.Parse(itemNrTextBox.Text);
            NewProduct.Name = nameTextBox.Text;
            NewProduct.Price = int.Parse(priceTextBox.Text);
            NewProduct.Quantity = int.Parse(quantityTextBox.Text);
            ProductBindingSource.Add(NewProduct);

        }

        private void inventoryDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var product = (Product) inventoryDataGrid.Rows[e.RowIndex].DataBoundItem;
        }

        private void inventoryDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if( 1 < inventoryDataGrid.SelectedRows.Count)
            {
                var product = (Product)inventoryDataGrid.SelectedRows[0].DataBoundItem;
                itemNrTextBox.Text = $"{product.ItemNumber}";
                nameTextBox.Text = product.Name;
                priceTextBox.Text = $"{product.Price}";
                quantityTextBox.Text = $"{product.Quantity}";
            }
        }

        private void infoTableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
