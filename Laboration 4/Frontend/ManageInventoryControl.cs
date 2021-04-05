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
        

        public ManageInventoryControl()
        {
            InitializeComponent();
        }
        public ManageInventoryControl(BindingSource inventoryListSource)
        {
            InitializeComponent();
            this.InventoryListSource = inventoryListSource;
            inventoryDataGridView.DataSource = InventoryListSource;

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var product = new Product();
            product.ItemNumber = int.Parse(itemNrTextBox.Text);
            product.Name = nameTextBox.Text;
            product.Price = int.Parse(priceTextBox.Text);
            product.Quantity = int.Parse(quantityTextBox.Text);

        }

        private void inventoryDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var product = (Product) inventoryDataGridView.Rows[e.RowIndex].DataBoundItem;
        }

        private void inventoryDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if( 1 < inventoryDataGridView.SelectedRows.Count)
            {
                var product = (Product)inventoryDataGridView.SelectedRows[0].DataBoundItem;
                itemNrTextBox.Text = $"{product.ItemNumber}";
                nameTextBox.Text = product.Name;
                priceTextBox.Text = $"{product.Price}";
                quantityTextBox.Text = $"{product.Quantity}";
            }
        }
    }
}
