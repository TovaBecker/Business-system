using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Laboration_4
{
    public partial class ManageCheckoutControl : UserControl
    {
        //Declare a instance a Contol class varible for conecting inventory to Control class
        Control _control;

        //Declare a instance a BindingSource class varible for saving a bindingSource varible.
        BindingSource _inventoryBindingSource;
        BindingSource _basketBindingSource;

        //Declare a instance a Product class varible for svaing selected item
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
            //Declare an instance bool varibels for success to adding to basket
            bool succesAdd = true;

            //Declare an instance int varibels for try
            int outNr = 0;

            //check if return radiobutton is checked
            if (returnRadioButton.Checked == true)
            {
                //Check if itemNrTextBox has a value
                if (itemNumberSearchextBox.Text != "" && true == int.TryParse(itemNumberSearchextBox.Text, out outNr) && 0 <= outNr)
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
                                    "Försäljnings ID måste anges i ett positivt heltal.",
                                    "Försäljnings ID borttagen.",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            else
            {
                //Check if itemNrTextBox has a value
                if (itemNumberSearchextBox.Text != "" && true == int.TryParse(itemNumberSearchextBox.Text, out outNr) && 0 <= outNr)
                {
                    //Add prodcut to basket
                    succesAdd = _control.AddToBasketBuy(outNr);

                    if (succesAdd == false)
                    {
                        //Show message that tells user itemnumber is removed
                        MessageBox.Show(
                                        "Det gick inte att lägga till artikel i varukorgen.\n" +
                                        "Artikel är slut på lagret.",
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
                                    "Det gick inte att lägga till artikel.\n" +
                                    "Artikelnummer är borttaget.\n" +
                                    "Artikelnummer måste anges i ett positivt heltal.",
                                    "Artikelnummer borttagen.",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }

            //Uppdate binding source and focus on search bok
            ResetView();
        }

        private void buttonRemoveCheckout_Click(object sender, EventArgs e)
        {
            //Check that user has selected a row in basket grid
            if (!(basketDataGridView.SelectedRows.Count < 1))
            {
                //Find item in basket grid
                var itemInBasket = (SaleInfo)basketDataGridView.SelectedRows[0].DataBoundItem;

                //Remove item form basket grid
                if (itemInBasket != null)
                    _control.RemoveFromBasket(itemInBasket);
            }

            //Uppdate binding source and focus on search bok
            ResetView();
        }

        private void buttonBuyCheckout_Click(object sender, EventArgs e)
        {
            //Check if return radiobutton is selected
            if (returnRadioButton.Checked == true)
            {
                //Return the items in basket grid
                _control.Return();
            }
            else
            {
                //Buy items in the basket grid
                if (_control.Purchase())
                {
                    //Open receipt in default window for printing
                    System.Diagnostics.Process.Start(@"..\..\Receipt\Receipt.pdf");
                    
                }
            }

            //Uppdate binding source and focus on search bok
            ResetView();
        }

        private void buyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Check if buy radiobutton is selected
            if (buyRadioButton.Checked == true)
            {
                //Set labels and view for return
                SearcIDhLabel.Text = "Artikelnummer";
                buttonBuyCheckout.Text = "Köp";
                checkoutDataGrid.Visible = true;

                //Remove items in grid
                _control.ClearBasket();
            }

            //Uppdate binding source and focus on search bok
            ResetView();
        }

        private void returnRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Check if return radiobutton is selected
            if (returnRadioButton.Checked == true)
            {
                //Set labels and view for return
                SearcIDhLabel.Text = "Försäljnings ID";
                buttonBuyCheckout.Text = "Återköp";
                checkoutDataGrid.Visible = false;

                //Remove items in grid
                _control.ClearBasket();
            }

            //Uppdate binding source and focus on search bok
            ResetView();
        }

        private void checkoutDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Get the item number of the selected row
            ManageCheckout_GetProduct();

            //Set item number
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
                //Check if there is text in the textbox
                if (itemNumberSearchextBox.Text != "")
                {
                    //Check if it is a number in the textbox
                    if (0 < int.Parse(itemNumberSearchextBox.Text))
                    {
                        //Make add button availeble to the user
                        buttonAddCheckout.Enabled = true;

                        // Remove error if price is a int
                        itemNumberErrorProviderAdd.SetError(this.itemNumberSearchextBox, "");
                    }
                }
            }
            catch
            {
                // Set the error if price is not a int
                itemNumberErrorProviderAdd.SetError(this.itemNumberSearchextBox, "Artikelnummer är endast siffror emellan 0 - {int.MaxValue}.");
            }
        }

        private void ResetView()
        {
            //Show uppdate in inventory grid
            _inventoryBindingSource.ResetBindings(true);

            //Show uppdate in basket grid
            _basketBindingSource.ResetBindings(true);

            //Focus on input textbox
            itemNumberSearchextBox.Focus();
        }
    }
}
