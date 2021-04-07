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
    public partial class ManageCheckoutControl : UserControl
    {
        Control _control = new Control();
        BindingSource basketBindingSource;
        BindingSource inventoryBindingSource;
        Product _selectedItem;

        public ManageCheckoutControl()
        {
            InitializeComponent();

            //Conect ManageInventoryControl to Contol class and get binding source
            this.inventoryBindingSource = _control.LoadInventory();

            //Conect ManageInventoryControl to Contol class and get binding source
            this.basketBindingSource = _control.LoadBasket();

            //Set binding source
            checkoutDataGrid.DataSource = inventoryBindingSource;
            basketDataGridView.DataSource = basketBindingSource;

            //Disabel buttons
            resetCheckoutButtons();
        }

        private void buttonAddCheckout_Click(object sender, EventArgs e)
        {
            var itemNumber = itemNumberSearchextBox.Text;

            _control.AddToBasket(Convert.ToInt32(itemNumber));

            //Show uppdate in list
            basketBindingSource.ResetCurrentItem();
        }

        private void buttonRemoveCheckout_Click(object sender, EventArgs e)
        {

        }

        private void buttonBuyCheckout_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonBuy_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonBuy.Checked == true)
            {
                buttonBuyCheckout.Text = "Köp";
            }
        }

        private void returnRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (returnRadioButton.Checked == true)
            {
                buttonBuyCheckout.Text = "Återköp";
            }
        }

        private void checkoutDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ManageCheckout_GetProduct();

            itemNumberSearchextBox.Text = $"{_selectedItem.ItemNumber}";
        }
        private void ManageCheckout_GetProduct()
        {
            //Get selected product from row
            var product = (Product)checkoutDataGrid.SelectedRows[0].DataBoundItem;
            
            //Get the products data
            _selectedItem = product;
        }

        private void itemNumberSearchextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (0 < int.Parse(itemNumberSearchextBox.Text))
                {
                    buttonAddCheckout.Enabled = true;
                }
            }
            catch (FormatException)
            {
                //Error
            }
        }

        private void resetCheckoutButtons()
        {
            //Disabel buttons
            buttonAddCheckout.Enabled = false;
            buttonRemoveCheckout.Enabled = false;
            buttonBuyCheckout.Enabled = false;
        }
    }
}
