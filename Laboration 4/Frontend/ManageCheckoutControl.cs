using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;

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

        //Declare a instance for printing receipt
        private Font receiptFont;
        private StreamReader receiptToPrint;

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
                                    "Artikelnummer måste anges i siffror",
                                    "Artikelnummer borttagen",
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
                    //Print the receipt for the buy to the user
                    printReceipt();

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

        private void printReceipt()
        {
            try
            {
                //Find and get file that is going to be converted to PDF
                receiptToPrint = new StreamReader(@"..\..\Receipt\Receipt.htm");
                try
                {
                    //Set print front propertis
                    receiptFont = new Font("Arial", 12);

                    //Create an instace for printing document
                    PrintDocument receipt = new PrintDocument();

                    //Get Pages that is to be convertet to PDF
                    receipt.PrintPage += new PrintPageEventHandler(this.receipt_PrintPage);

                    //Print the result
                    receipt.Print();
                }
                finally
                {
                    //Close the printing method
                    receiptToPrint.Close();
                }
            }
            catch (Exception ex)
            {
                //Show error message for user
                MessageBox.Show(ex.Message);
            }
        }

        private void receipt_PrintPage(object sender, PrintPageEventArgs ev)
        {
            //Set print propertis
            float linesPerPage = 0;
            float yPos = 0;
            int count = 0;
            float leftMargin = ev.MarginBounds.Left;
            float topMargin = ev.MarginBounds.Top;
            string line = null;

            //Calculate the number of lines per page
            linesPerPage = ev.MarginBounds.Height /
               receiptFont.GetHeight(ev.Graphics);

            //Print each line of the file
            while (count < linesPerPage &&
               ((line = receiptToPrint.ReadLine()) != null))
            {
                yPos = topMargin + (count *
                   receiptFont.GetHeight(ev.Graphics));
                ev.Graphics.DrawString(line, receiptFont, Brushes.Black,
                   leftMargin, yPos, new StringFormat());
                count++;
            }

            //If more lines exist then print another page
            if (line != null)
                ev.HasMorePages = true;
            else
                ev.HasMorePages = false;
        }

        private void ManageCheckoutControl_Load(object sender, EventArgs e)
        {

            //Set columns head in checkout grid
            checkoutDataGrid.Columns["Type"].HeaderText = "Typ";
            checkoutDataGrid.Columns["ItemNumber"].HeaderText = "Artikelnummer";
            checkoutDataGrid.Columns["Name"].HeaderText = "Namn";
            checkoutDataGrid.Columns["Price"].HeaderText = "Pris";
            checkoutDataGrid.Columns["Quantity"].HeaderText = "Antal";
            checkoutDataGrid.Columns["Author"].HeaderText = "Författare";
            checkoutDataGrid.Columns["Genre"].HeaderText = "Genre";
            checkoutDataGrid.Columns["Format"].HeaderText = "Format";
            checkoutDataGrid.Columns["Language"].HeaderText = "Språk";
            checkoutDataGrid.Columns["Platform"].HeaderText = "Plattform";
            checkoutDataGrid.Columns["Playtime"].HeaderText = "Speltid";

            //Set columns head in basket grid
            basketDataGridView.Columns["Type"].HeaderText = "Typ";
            basketDataGridView.Columns["ItemNumber"].HeaderText = "Artikelnummer";
            basketDataGridView.Columns["Name"].HeaderText = "Namn";
            basketDataGridView.Columns["Price"].HeaderText = "Pris";
            basketDataGridView.Columns["Quantity"].HeaderText = "Antal";
            basketDataGridView.Columns["Date"].Visible = false;
            basketDataGridView.Columns["SaleID"].Visible = false;
            basketDataGridView.Columns["Status"].Visible = false;
        }
    }
}
