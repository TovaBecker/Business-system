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
        //Declare an instance a Contol class varible for conecting inventory to Control class
        Control _control;

        //Declare an instance a BindingSource class varible for saving a bindingSource varible.
        BindingSource _inventoryBindingSource;
        BindingSource _basketBindingSource;

        //Declare an instance a Product class varible for svaing selected item
        Product _selectedItem;


        public ManageCheckoutControl(Control control, BindingSource inventoryBindingSource, BindingSource basketBindingSource)
        {
            InitializeComponent();

            //Get and set referans to the Contol class
            _control = control;

            //Conect ManageInventoryControl to Contol class and get binding source
           this._inventoryBindingSource = inventoryBindingSource;

            //Conect ManageInventoryControl to Contol class and get binding source
            this._basketBindingSource = basketBindingSource;

            //Set binding source
            checkoutDataGrid.DataSource = _inventoryBindingSource;
            basketDataGridView.DataSource = _basketBindingSource;
        }
        
        private void buttonAddCheckout_Click(object sender, EventArgs e)
        {
            //Declare an instance bool varibels for succes to adding to basket
            bool succesAdd = true;

            //Declare an instance int varibels for try
            int outNr = 0;

            //check if return radiobutton is checked
            if (returnRadioButton.Checked == true)
            {
                //Check if itemNrTextBox has a value
                if (itemNumberSearchextBox.Text != "" && true == int.TryParse(itemNumberSearchextBox.Text, out outNr))
                {
                    //Add prodcut to basket
                    succesAdd = _control.AddToBasketReturn(outNr);

                    if (succesAdd == false)
                    {
                        //Show message that tells user itemnumber is removed
                        MessageBox.Show(
                                        "Det gick inte att lägga till försäljningen i varukorgen.\n" +
                                        "Fler varor såldes inte på det försäljnings ID.",
                                        "Inte i fler varor sålda",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                }
                else
                {
                    //Set itemNrTextBox value is removed
                    itemNumberSearchextBox.Text = "";

                    //Show message that tells user itemnumber is removed
                    MessageBox.Show(
                                    "Det gick inte att lägga till försäljningen.\n" +
                                    "Försäljnings ID är borttaget.\n" +
                                    "Försäljnings ID måste anges i siffror",
                                    "Försäljnings ID borttagen",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            else
            {
                //Check if itemNrTextBox has a value
                if (itemNumberSearchextBox.Text != "" && true == int.TryParse(itemNumberSearchextBox.Text, out outNr))
                {
                    //Add prodcut to basket
                    succesAdd = _control.AddToBasketBuy(outNr);

                    if (succesAdd == false)
                    {
                        //Show message that tells user itemnumber is removed
                        MessageBox.Show(
                                        "Det gick inte att lägga till varan i varukorgen.\n" +
                                        "Varan är slut på lagret.",
                                        "Inte i lager",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                }
                else
                {
                    //Set itemNrTextBox value is removed
                    itemNumberSearchextBox.Text = "";

                    //Show message that tells user itemnumber is removed
                    MessageBox.Show(
                                    "Det gick inte att lägga till varan.\n" +
                                    "Varunummer är borttaget.\n" +
                                    "Varunummer måste anges i siffror",
                                    "Varunummer borttagen",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }

            //Show uppdate in list
            _basketBindingSource.ResetCurrentItem();
        }

        private void buttonRemoveCheckout_Click(object sender, EventArgs e)
        {
            if (! (basketDataGridView.SelectedRows.Count < 1))
            {
                var itemInBasket = (SaleInfo)basketDataGridView.SelectedRows[0].DataBoundItem;

                if (itemInBasket != null)
                    _control.RemoveFromBasket(itemInBasket);
            }

        }

        private void buttonBuyCheckout_Click(object sender, EventArgs e)
        {
            if (returnRadioButton.Checked == true)
            {
                _control.Return();
            }
            else
            {
                _control.Purchase();
            }

            //Show uppdate in list
            _inventoryBindingSource.ResetCurrentItem();
        }

        private void buyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (buyRadioButton.Checked == true)
            {
                //Set labels and view for return
                SearcIDhLabel.Text = "Varunummer";
                buttonBuyCheckout.Text = "Köp";
                checkoutDataGrid.Visible = true;

                //Remove items in grid
                _control.ClearBasket();
            }

            //Show uppdate in list
            _inventoryBindingSource.ResetCurrentItem();
        }

        private void returnRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (returnRadioButton.Checked == true)
            {
                //Set labels and view for return
                SearcIDhLabel.Text = "Försäljnings ID";
                buttonBuyCheckout.Text = "Återköp";
                checkoutDataGrid.Visible = false;

                //Remove items in grid
                _control.ClearBasket();
            }

            //Show uppdate in list
            _inventoryBindingSource.ResetCurrentItem();
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
                if (itemNumberSearchextBox.Text != "")
                {
                    if (0 < int.Parse(itemNumberSearchextBox.Text))
                    {
                        buttonAddCheckout.Enabled = true;

                        // Remove error if price is a int
                        itemNumberErrorProviderAdd.SetError(this.itemNumberSearchextBox, "");
                    }
                }
            }
            catch (FormatException)
            {
                // Set the error if price is not a int
                itemNumberErrorProviderAdd.SetError(this.itemNumberSearchextBox, "Varunummer är endast siffror.");
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
