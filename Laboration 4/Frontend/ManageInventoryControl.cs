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
        Control _control = new Control();
        BindingSource inventoryBindingSource;

        internal Product NewProduct { get; private set; }

        public ManageInventoryControl()
        {
            InitializeComponent();

            this.inventoryBindingSource = _control.LoadInventory();
            inventoryDataGrid.DataSource = inventoryBindingSource;

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

    }
}
