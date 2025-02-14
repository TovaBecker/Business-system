﻿using Laboration_4.Backend;
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
        //Declare an instance a Contol class varible for conecting inventory to Control class
        IControl _control;

        //Declare an instance a BindingSource class varible for saving a bindingSource varible.
        BindingSource _inventoryBindingSource;

        //Declare an instance a Product class varible for svaing selected item
        Product _selectedItem;

        internal Product NewProduct { get; private set; }

        public ManageInventoryControl(IControl control, BindingSource inventoryBindingSource)
        {
            InitializeComponent();

            //Get and set referans to the Contol class
            _control = control;

            //Conect ManageInventoryControl to Contol class and get binding source
            this._inventoryBindingSource = inventoryBindingSource;

            //Set binding source
            inventoryDataGrid.DataSource = _inventoryBindingSource;

            //Clear window
            clearWindow();
        }

        private void buttonAddInventory_Click(object sender, EventArgs e)
        {
            //Declare an instance int varibels for try
            int outItemNr = 0;
            double outPrice = 0;
            int outQuantity = 0;
            int outPlaytime = 0;

            if (nameTextBox.Text != "" && typeComboBox.SelectedItem == "Bok" || typeComboBox.SelectedItem == "Spel" || typeComboBox.SelectedItem == "DVD")
            {

                //Check if itemNrTextBox has a value
                if (false == int.TryParse(itemNrTextBox.Text, out outItemNr) || int.Parse(itemNrTextBox.Text) < 1)
                {
                    //Update product
                    int ID = _control.FindID();

                    //Set itemNrTextBox value to 0
                    itemNrTextBox.Text = $"{ID}";

                    //Show message that tells user prodoct price is set to zero
                    MessageBox.Show(
                                    $"Artikelnummer är satt till ett nytt id {ID} beroende på att det angivna värdet var felaktigt",
                                    "Info",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }

                //Check if quantity value is a int value or set it too zero
                if (false == double.TryParse(priceTextBox.Text, out outPrice))
                {
                    //Set priceTextBox value to 0
                    priceTextBox.Text = "0";

                    //Show message that tells user prodoct price is set to zero
                    MessageBox.Show(
                                    "Priset är satt till 0 beroende på att angivna värdet är felaktigt",
                                    "Info",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }

                //Check if quantity value is a int value or set it too zero
                if (false == int.TryParse(quantityTextBox.Text, out outQuantity))
                {
                    //Set quantityTextBox value to 0
                    quantityTextBox.Text = "0";

                    //Show message that tells user prodoct quantity is set to zero
                    MessageBox.Show(
                                    "Antal är satt till 0 beroende på att angivna värdet är felaktigt",
                                    "Info",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }

                //Check if playtime value is a int value or set it too zero
                if (typeComboBox.SelectedItem == "DVD" && false == int.TryParse(data1TextBox.Text, out outPlaytime))
                {
                    //Set playtimeTextBox value to 0
                    data1TextBox.Text = "0";

                    //Show message that tells user prodoct playtime is set to zero
                    MessageBox.Show(
                                    "Speltid är satt till 0 beroende på att angivna värdet är felaktigt",
                                    "Info",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }
                //Add new product
                Product NewProduct = fetchProduct();

                //Add new product
                Product addProduct = _control.NewProduct(NewProduct);

                //Check if product item number is the same as input
                if (addProduct.ItemNumber != NewProduct.ItemNumber)
                {
                    //Show message that tells user prodoct is added with another ID
                    MessageBox.Show(
                                    $"Atriklen är tillagd med ett annat nummer ({addProduct.ItemNumber})." +
                                    $"Nummret du angav är taget av en annan artikel",
                                    "Info",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }

                //Go through data and set buttons 
                dataChanged();
            }
            else
            {
                //Show message that tells user prodoct is added
                MessageBox.Show(
                                "Du behöver lägga in namn och välja typ för att skapa en ny artikel.",
                                "Info",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }

        private void buttonUpdateInventory_Click(object sender, EventArgs e)
        {
            //Declare and initziera two int varibles and one doubel varible
            int _itemNumber = 0;
            int _numberInt = 0;
            double _numberDouble = 0;

            //Check if there is a value in item number 
            if (itemNrTextBox.Text != "")
            {
                try
                {
                    //Set itemnnumber
                    _itemNumber = int.Parse(itemNrTextBox.Text);

                    //Check if value is in allowed span
                    if (0 <= _itemNumber && _itemNumber <= int.MaxValue)
                    {
                        //DO nothing
                    }
                    else
                    {
                        throw new Exception();
                    }

                }
                catch
                {
                    //Show message that tells user prodoct item number is not updated
                    MessageBox.Show(
                                    "Artikel uppdaterades inte beroende på att artikelnummer är felaktigt." +
                                    $"Artikelnummeret måste vara emellan 0 - {int.MaxValue}.",
                                    "Info",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }
                try
                {
                    //Set number
                    _numberDouble = double.Parse(priceTextBox.Text);

                    //Check if value is in allowed span
                    if (0 <= _numberDouble && _numberDouble <= double.MaxValue)
                    {
                        //DO nothing
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch
                {
                    //Show message that tells user prodoct price is not updated
                    MessageBox.Show(
                                    "Priset uppdaterades inte beroende på att det angivna värdet är felaktigt" +
                                    $"Priset måste vara emellan 0 - {double.MaxValue}.",
                                    "Info",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }
                try
                {
                    //Set number
                    _numberInt = int.Parse(quantityTextBox.Text);

                    //Check if value is in allowed span
                    if (0 <= _numberInt && _numberInt <= int.MaxValue)
                    {
                        //DO nothing
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch
                {
                    //Show message that tells user prodoct quantity is not updated
                    MessageBox.Show(
                                    "Antal uppdaterades inte beroende på att det angivna värdet är felaktigt" +
                                    $"Antal måste vara emellan 0 - {int.MaxValue}.",
                                    "Info",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }
                try
                {
                    if (typeComboBox.SelectedItem == "DVD")
                    {
                        //Set number
                        _numberInt = int.Parse(data1TextBox.Text);

                        //Check if value is in allowed span
                        if (0 <= _numberInt && _numberInt <= int.MaxValue)
                        {
                            //DO nothing
                        }
                        else
                        {
                            throw new Exception();
                        }
                    }

                }
                catch
                {
                    //Show message that tells user prodoct playtime is not updated
                    MessageBox.Show(
                                    "Speltiden uppdaterades inte beroende på att det angivna värdet är felaktigt" +
                                    $"Speltiden måste vara emellan 0 - {int.MaxValue}.",
                                    "Info",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }
            }
            else
            {
                //Show message that tells itemnumber is needed prodoct price is set to zero
                MessageBox.Show(
                                "Artikel uppdaterades inte." +
                                "Du måste ange artikelnummer för att uppdatera artikel.",
                                "Uppdaerades inte",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
            if (null != _control.Search(_itemNumber))
            {
                //Get data
                Product UpdateProduct = fetchProduct();

                //Update product
                _control.UpdateProduct(UpdateProduct);
            }



            //Show uppdate in list
            _inventoryBindingSource.ResetCurrentItem();

            //Go through data and set buttons 
            dataChanged();
        }

        private void buttonClearInventory_Click(object sender, EventArgs e)
        {
            //Clear window
            clearWindow();
        }
        private void buttonRemoveInventory_Click(object sender, EventArgs e)
        {
            //Declare item nubers as int
            int _itemNumber = 0;

            try
            {
                //If there is a value in item number set number
                if (itemNrTextBox.Text != "")
                {
                    _itemNumber = int.Parse(itemNrTextBox.Text);
                }
                else
                {
                    //Show message that tells user it did not enter a itemnumber
                    MessageBox.Show(
                                    "Du angav inte ett artikelnummer",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);
                }
            }
            catch (FormatException)
            {
                // Set the error if price is not a int
                itemNumberErrorProvider.SetError(this.itemNrTextBox, "Artikelnummer är endast siffror.");
            }
            var _removeProcuct = _control.Search(_itemNumber);

            if (_removeProcuct != null)
            {
                if (0 < _removeProcuct.Quantity)
                {
                    //Show message to ask user if it wants to remove prodoct with inventory
                    var result = MessageBox.Show(
                                    $"Vill du verkligen ta bort produkten \"{_removeProcuct.Name}\" med {_removeProcuct.Quantity} i lager?",
                                    "Ta bort produkt",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        bool sucess = _control.RemoveProduct(_itemNumber);

                        if (sucess == false)
                        {
                            //Show message that tells user the product is not removed
                            MessageBox.Show(
                                            "Det gick inte att ta bort produkten",
                                            "Error",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                        }
                        else
                        {
                            //Show message that tells user prodoct is removed
                            MessageBox.Show(
                                            "Produkten är raderad",
                                            "Info",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    bool sucess = _control.RemoveProduct(_itemNumber);

                    if (sucess == false)
                    {
                        //Show message that tells user the product is not removed
                        MessageBox.Show(
                                        "Det gick inte att ta bort produkten",
                                        "Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                //Show message that tells user it did not find the prduct
                MessageBox.Show(
                                "Det gick inte att hitta produkten",
                                "Avbruten",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

            //Clear window
            clearWindow();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            //Declare an instance int varibels for try
            int outItemNr = 0;
            int outPrice = 0;
            int outQuantity = 0;
            int outPlaytime = 0;

            //Check if itemNrTextBox has a value
            if (itemNrTextBox.Text != "" && false == int.TryParse(itemNrTextBox.Text, out outItemNr))
            {
                //Set itemNrTextBox value is removed
                itemNrTextBox.Text = "";

                //Show message that tells user prodoct artikelnummer is removed
                MessageBox.Show(
                                    "Artikelnummer är borttaget.\n" +
                                    "Det inte går att söka på det angivna värdet då artikelnummer måste anges i siffror",
                                    "Artikelnummer borttagen.",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
            }

            //Check if quantity value is a int value or set it too null
            if (priceTextBox.Text != "" && false == int.TryParse(priceTextBox.Text, out outPrice))
            {
                //Set priceTextBox value is removed
                priceTextBox.Text = "";

                //Show message that tells user prodoct price is is removed
                MessageBox.Show(
                                "Priset är borttaget.\n" +
                                    "Det går inte att söka på det angivna värdet då priset måste anges i siffror",
                                    "Priset borttagen.",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
            }

            //Check if quantity value is a int value or set it too null
            if (quantityTextBox.Text != "" && false == int.TryParse(quantityTextBox.Text, out outQuantity))
            {
                //Set quantityTextBox value is removed
                quantityTextBox.Text = "";

                //Show message that tells user prodoct quantity is removed
                MessageBox.Show(
                                "Antal är borttaget.\n" +
                                    "Det går inte att söka på det angivna värdet då antal måste anges i siffror",
                                    "Antal borttagen.",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
            }

            //Check if playtime value is a int value or set it too null
            if (typeComboBox.SelectedItem == "DVD" && false == int.TryParse(data1TextBox.Text, out outPlaytime))
            {
                //Set playtimeTextBox value is removed
                data1TextBox.Text = "";

                //Show message that tells user prodoct playtime is removed
                MessageBox.Show(
                                "Speltid är borttaget.\n" +
                                    "Det går inte att söka på det angivna värdet då speltid måste anges i antal minuter (siffror)",
                                    "Speltid borttagen.",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
            }

            //Get data from textboxes
            string type = "";
            int itemNumber = itemNrTextBox.Text == "" ? 0 : Convert.ToInt32(itemNrTextBox.Text);
            string name = nameTextBox.Text;
            double price = priceTextBox.Text == "" ? 0 : Convert.ToDouble(priceTextBox.Text);
            int quantity = quantityTextBox.Text == "" ? 0 : Convert.ToInt32(quantityTextBox.Text);
            string author = "";
            string genre = data2TextBox.Text;
            string format = data3TextBox.Text;
            string language = data4TextBox.Text;
            string platform = "";
            int playtime = 0;

            //Show data for the type of product and get data
            switch (typeComboBox.SelectedItem)
            {
                case "Bok":
                    type = "Bok";
                    author = data1TextBox.Text;
                    platform = "";
                    playtime = 0;
                    break;
                case "Spel":
                    type = "Spel";
                    author = "";
                    platform = data1TextBox.Text;
                    playtime = 0;
                    break;
                case "DVD":
                    type = "DVD";
                    author = "";
                    platform = "";
                    playtime = data1TextBox.Text == "" ? 0 : Convert.ToInt32(data1TextBox.Text);
                    break;
                default:
                    break;

            }

            //Search in grid
            _control.Search(type, itemNumber, name, price, quantity, author, genre, format, language, platform, playtime);

        }

        private Product fetchProduct()
        {
            //Get data from textboxes
            string type = "";
            int itemNumber = Convert.ToInt32(itemNrTextBox.Text);
            string name = nameTextBox.Text;
            string price = priceTextBox.Text;
            string quantity = quantityTextBox.Text;
            string author = "";
            string genre = data2TextBox.Text;
            string format = data3TextBox.Text;
            string language = data4TextBox.Text;
            string platform = "";
            string playtime = "";

            //Show data for the type of product and get data
            switch (typeComboBox.SelectedItem)
            {
                case "Bok":
                    type = "Bok";
                    author = data1TextBox.Text;
                    platform = "";
                    playtime = "";
                    break;
                case "Spel":
                    type = "Spel";
                    author = "";
                    platform = data1TextBox.Text;
                    playtime = "";
                    break;
                case "DVD":
                    type = "DVD";
                    author = "";
                    platform = "";
                    playtime = data1TextBox.Text;
                    break;
                default:
                    break;

            }
            //Add new product
            Product fetchProduct = new Product(type, itemNumber, name, price, quantity, author, genre, format, language, platform, playtime);

            return fetchProduct;
        }

        private void clearWindow()
        {
            //Clear all textboxes of data
            itemNrTextBox.Text = "";
            nameTextBox.Text = "";
            priceTextBox.Text = "";
            quantityTextBox.Text = "";
            data1TextBox.Text = "";
            data2TextBox.Text = "";
            data3TextBox.Text = "";
            data4TextBox.Text = "";

            //Remove selection of item in grid
            inventoryDataGrid.ClearSelection();

            //Set type to null
            typeComboBox.SelectedIndex = 0;

            //Remove the error from textboxes
            itemNumberErrorProvider.SetError(this.itemNrTextBox, String.Empty);
            priceErrorProvider.SetError(this.priceTextBox, String.Empty);
            quantityErrorProvider.SetError(this.quantityTextBox, String.Empty);
            playtimeErrorProvider.SetError(this.data1TextBox, String.Empty);

            //Show uppdate in list
            _inventoryBindingSource.ResetCurrentItem();

            //Clear search in grid
            _control.ClearSearch();

            //Set buttons
            dataChanged();
        }

        private Product ManageInventory_ShowProduct()
        {
            //Check that a row is selected in grid or return with null
            if (inventoryDataGrid.SelectedRows.Count < 1)
                return null;
            //Get selected product from row
            var product = (Product)inventoryDataGrid.SelectedRows[0].DataBoundItem;

            //Show the products data
            _selectedItem = product;
            itemNrTextBox.Text = $"{product.ItemNumber}";
            nameTextBox.Text = product.Name;
            priceTextBox.Text = $"{product.Price}";
            quantityTextBox.Text = $"{product.Quantity}";
            typeComboBox.Text = $"{product.Type}";

            //Show data for the type of product
            switch (_selectedItem.Type)
            {
                case Type.Bok:
                    data1TextBox.Text = $"{product.Author}";
                    data2TextBox.Text = $"{product.Genre}";
                    data3TextBox.Text = $"{product.Format}";
                    data4TextBox.Text = $"{product.Language}";
                    break;
                case Type.Spel:
                    data1TextBox.Text = $"{product.Platform}";
                    break;
                case Type.DVD:
                    data1TextBox.Text = $"{product.Playtime}";
                    break;
                default:
                    break;
            }
            return product;
        }
        private void ManageInventory_ViewData()
        {
            //Show data for the type of product
            switch (typeComboBox.SelectedItem)
            {
                case "Bok":
                    //Show textboxes and set labels
                    data1Label.Text = "Författare";
                    data1Label.Visible = true;
                    data1TextBox.Visible = true;

                    data2Label.Text = "Genre";
                    data2Label.Visible = true;
                    data2TextBox.Visible = true;

                    data3Label.Text = "Format";
                    data3Label.Visible = true;
                    data3TextBox.Visible = true;

                    data4Label.Text = "Språk";
                    data4Label.Visible = true;
                    data4TextBox.Visible = true;

                    //Show and hide columns
                    inventoryDataGrid.Columns["Author"].Visible = true;
                    inventoryDataGrid.Columns["Genre"].Visible = true;
                    inventoryDataGrid.Columns["Format"].Visible = true;
                    inventoryDataGrid.Columns["Language"].Visible = true;
                    inventoryDataGrid.Columns["Platform"].Visible = false;
                    inventoryDataGrid.Columns["Playtime"].Visible = false;

                    break;
                case "Spel":
                    //Show textbox and set label
                    data1Label.Text = "Plattform";
                    data1Label.Visible = true;
                    data1TextBox.Visible = true;

                    //Hide textboxes and set string to empty
                    data2Label.Text = "";
                    data2TextBox.Text = "";
                    data2Label.Visible = false;
                    data2TextBox.Visible = false;

                    data3Label.Text = "";
                    data4TextBox.Text = "";
                    data3Label.Visible = false;
                    data3TextBox.Visible = false;

                    data4Label.Text = "";
                    data4TextBox.Text = "";
                    data4Label.Visible = false;
                    data4TextBox.Visible = false;

                    //Show and hide columns
                    inventoryDataGrid.Columns["Author"].Visible = false;
                    inventoryDataGrid.Columns["Genre"].Visible = false;
                    inventoryDataGrid.Columns["Format"].Visible = false;
                    inventoryDataGrid.Columns["Language"].Visible = false;
                    inventoryDataGrid.Columns["Platform"].Visible = true;
                    inventoryDataGrid.Columns["Playtime"].Visible = false;

                    break;
                case "DVD":
                    //Show textbox and set label
                    data1Label.Text = "Speltid";
                    data1Label.Visible = true;
                    data1TextBox.Visible = true;

                    //Hide textboxes and set string to empty
                    data2Label.Text = "";
                    data2TextBox.Text = "";
                    data2Label.Visible = false;
                    data2TextBox.Visible = false;

                    data3Label.Text = "";
                    data4TextBox.Text = "";
                    data3Label.Visible = false;
                    data3TextBox.Visible = false;

                    data4Label.Text = "";
                    data4TextBox.Text = "";
                    data4Label.Visible = false;
                    data4TextBox.Visible = false;

                    //Show and hide columns
                    inventoryDataGrid.Columns["Author"].Visible = false;
                    inventoryDataGrid.Columns["Genre"].Visible = false;
                    inventoryDataGrid.Columns["Format"].Visible = false;
                    inventoryDataGrid.Columns["Language"].Visible = false;
                    inventoryDataGrid.Columns["Platform"].Visible = false;
                    inventoryDataGrid.Columns["Playtime"].Visible = true;

                    break;
                default:
                    //Hide textboxes and set string to empty
                    data1Label.Text = "";
                    data1TextBox.Text = "";
                    data1Label.Visible = false;
                    data1TextBox.Visible = false;

                    data2Label.Text = "";
                    data2TextBox.Text = "";
                    data2Label.Visible = false;
                    data2TextBox.Visible = false;

                    data3Label.Text = "";
                    data4TextBox.Text = "";
                    data3Label.Visible = false;
                    data3TextBox.Visible = false;

                    data4Label.Text = "";
                    data4TextBox.Text = "";
                    data4Label.Visible = false;
                    data4TextBox.Visible = false;

                    //Show columns
                    inventoryDataGrid.Columns["Author"].Visible = true;
                    inventoryDataGrid.Columns["Genre"].Visible = true;
                    inventoryDataGrid.Columns["Format"].Visible = true;
                    inventoryDataGrid.Columns["Language"].Visible = true;
                    inventoryDataGrid.Columns["Platform"].Visible = true;
                    inventoryDataGrid.Columns["Playtime"].Visible = true;
                    break;
            }
        }

        private void dataChanged()
        {
            //Declare item nubers as int
            int _itemNumber = 0;

            //If there is a value in item number set number
            if (itemNrTextBox.Text != "")
            {
                try
                {
                    //Convert itemnumber textbox text to a int
                    _itemNumber = int.Parse(itemNrTextBox.Text);
                }
                catch
                {
                    // Set the error if price is not a int
                    itemNumberErrorProvider.SetError(this.itemNrTextBox, $"Artikelnummer är endast siffror emellan 0 - {int.MaxValue}..");
                }
            }

            if (null != _control.Search(_itemNumber))
            {
                //Enabel button
                buttonUpdateInventory.Enabled = true;
                buttonRemoveInventory.Enabled = true;

                //Disabel add button
                buttonAddInventory.Enabled = false;

                //Disabel type droppdown
                typeComboBox.Enabled = false;
            }
            else
            {
                //Enabel add button
                buttonAddInventory.Enabled = true;

                //Disabel button
                buttonUpdateInventory.Enabled = false;
                buttonRemoveInventory.Enabled = false;

                //Enabel type droppdown
                typeComboBox.Enabled = true;
            }
        }

        private void inventoryDataGridView_CellClick(object sender, EventArgs e)
        {
            //Show products data in text boxes
            ManageInventory_ShowProduct();

            //Change grid for product information
            ManageInventory_ViewData();
        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Change grid for product information
            ManageInventory_ViewData();

            //Remove selection of item in grid
            inventoryDataGrid.ClearSelection();
        }
        private void itemNrTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //Check that a row is selected in grid or return with null
                if (0 < inventoryDataGrid.SelectedRows.Count)
                {
                    //Get selected product from row
                    var product = (Product)inventoryDataGrid.SelectedRows[0].DataBoundItem;

                    if (product != null)
                    {
                        //Check if data has changed 
                        if (itemNrTextBox.Text == "" || product.ItemNumber != int.Parse(itemNrTextBox.Text) && 0 <= int.Parse(itemNrTextBox.Text))
                        {
                            //Remove the error if itemnumber is a int
                            itemNumberErrorProvider.SetError(this.itemNrTextBox, String.Empty);
                        }
                        else if( product.ItemNumber == int.Parse(itemNrTextBox.Text))
                            {
                            //Remove the error if itemnumber is the same
                            itemNumberErrorProvider.SetError(this.itemNrTextBox, String.Empty);
                        }
                        else
                        {
                            throw new Exception();
                        }
                        //Go through data and set buttons 
                        dataChanged();
                    }
                }
                else
                {
                    //Check if data has changed 
                    if (itemNrTextBox.Text != "" && 0 <= int.Parse(itemNrTextBox.Text))
                    {
                        //Convert itemnumber textbox text to a int
                        int _itemNumber = int.Parse(itemNrTextBox.Text);

                        //Remove the error if itemnumber is a int
                        itemNumberErrorProvider.SetError(this.itemNrTextBox, String.Empty);

                        //Go through data and set buttons 
                        dataChanged();
                    }
                    else if(int.Parse(itemNrTextBox.Text) < 0)
                    {
                        throw new Exception();
                    }
                    else
                    {
                        //Remove the error if itemnumber is a int
                        itemNumberErrorProvider.SetError(this.itemNrTextBox, String.Empty);
                    }
                }
            }
            catch
            {
                // Set the error if itemnumber is not a int
                itemNumberErrorProvider.SetError(this.itemNrTextBox, $"Artikelnummer är endast siffror emellan 0 - {int.MaxValue}.");
            }
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            //Check that a row is selected in grid or return with null
            if (0 < inventoryDataGrid.SelectedRows.Count)
            {
                //Get selected product from row
                var product = (Product)inventoryDataGrid.SelectedRows[0].DataBoundItem;

                if (product != null)
                {
                    //Check if data has changed 
                    if (product.Name != nameTextBox.Text)
                    {
                        //Go through data and set buttons 
                        dataChanged();
                    }
                }
            }
        }

        private void priceTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //Check that a row is selected in grid or return with null
                if (0 < inventoryDataGrid.SelectedRows.Count)
                {
                    //Get selected product from row
                    var product = (Product)inventoryDataGrid.SelectedRows[0].DataBoundItem;

                    if (product != null)
                    {
                        //Check if data has changed 
                        if (priceTextBox.Text == "" || product.Price != double.Parse(priceTextBox.Text) && 0 <= double.Parse(priceTextBox.Text))
                        {
                            //Remove the error if price is a double
                            priceErrorProvider.SetError(this.priceTextBox, String.Empty);

                            //Go through data and set buttons 
                            dataChanged();
                        }
                        else if (product.Price == double.Parse(priceTextBox.Text))
                        {
                            //Remove the error if price is the same
                            priceErrorProvider.SetError(this.priceTextBox, String.Empty);
                        }
                        else
                        {
                            throw new Exception();
                        }
                    }
                }
                else
                {
                    //Check if data has changed 
                    if (priceTextBox.Text != "" && 0 <= double.Parse(priceTextBox.Text))
                    {
                        //Convert price textbox text to a double
                        double _price = double.Parse(priceTextBox.Text);

                        //Remove the error if price is a double
                        priceErrorProvider.SetError(this.priceTextBox, String.Empty);

                        //Go through data and set buttons 
                        dataChanged();
                    }
                    else if (int.Parse(priceTextBox.Text) < 0)
                    {
                        throw new Exception();
                    }
                    else
                    {
                        //Remove the error if price is a int
                        priceErrorProvider.SetError(this.priceTextBox, String.Empty);
                    }
                }
            }
            catch
            {
                // Set the error if price is not a double
                priceErrorProvider.SetError(this.priceTextBox, $"Pris är endast siffror emellan 0 - {double.MaxValue}.");
            }
        }

        private void quantityTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //Check that a row is selected in grid or return with null
                if (0 < inventoryDataGrid.SelectedRows.Count)
                {
                    //Get selected product from row
                    var product = (Product)inventoryDataGrid.SelectedRows[0].DataBoundItem;

                    if (product != null)
                    {
                        //Check if data has changed 
                        if (quantityTextBox.Text == "" || product.Quantity != int.Parse(quantityTextBox.Text) && 0 <= int.Parse(quantityTextBox.Text))
                        {
                            //Remove the error if quantity is a int
                            quantityErrorProvider.SetError(this.quantityTextBox, String.Empty);

                            //Go through data and set buttons 
                            dataChanged();
                        }
                        else if (product.Quantity == int.Parse(quantityTextBox.Text))
                        {
                            //Remove the error if quantity is the same
                            quantityErrorProvider.SetError(this.quantityTextBox, String.Empty);
                        }
                        else
                        {
                            throw new Exception();
                        }
                    }
                }
                else
                {
                    //Check if data has changed 
                    if (quantityTextBox.Text != "" && 0 <= int.Parse(quantityTextBox.Text))
                    {
                        //Convert quantity textbox text to a int
                        int _quantity = int.Parse(quantityTextBox.Text);

                        //Remove the error if quantity is a int
                        quantityErrorProvider.SetError(this.quantityTextBox, String.Empty);

                        //Go through data and set buttons 
                        dataChanged();
                    }
                    else if (int.Parse(quantityTextBox.Text) < 0)
                    {
                        throw new Exception();
                    }
                    else
                    {
                        //Remove the error if quantity is a int
                        quantityErrorProvider.SetError(this.quantityTextBox, String.Empty);
                    }
                }
            }
            catch
            {
                //Set the error if quantity is not a int
                quantityErrorProvider.SetError(this.quantityTextBox, $"Antal är endast siffror emellan 0 - {int.MaxValue}.");
            }
        }

        private void data1TextBox_TextChanged(object sender, EventArgs e)
       {
            //Check that a row is selected in grid or return with null
            if (0 < inventoryDataGrid.SelectedRows.Count)
            {
                //Get selected product from row
                var product = (Product)inventoryDataGrid.SelectedRows[0].DataBoundItem;

                if (product != null)
                {
                    //Show data for the type of product
                    switch (product.Type)
                    {
                        case Type.Bok:
                            //Check if data has changed 
                            if (product.Author != data1TextBox.Text)
                            {
                                //Go through data and set buttons 
                                dataChanged();

                                //Remove the error if type is bok
                                playtimeErrorProvider.SetError(this.data1TextBox, String.Empty);
                            }
                            break;
                        case Type.Spel:
                            //Check if data has changed 
                            if (product.Platform != data1TextBox.Text)
                            {
                                //Go through data and set buttons 
                                dataChanged();

                                //Remove the error if type is game
                                playtimeErrorProvider.SetError(this.data1TextBox, String.Empty);
                            }
                            break;
                        case Type.DVD:
                            try
                            {
                                //Check if data has changed 
                                if (data1TextBox.Text == "" || product.Playtime != int.Parse(data1TextBox.Text) && 0 <= int.Parse(data1TextBox.Text))
                                {
                                    //Remove the error if playtime is a int
                                    playtimeErrorProvider.SetError(this.data1TextBox, String.Empty);

                                    //Go through data and set buttons 
                                    dataChanged();
                                }
                                else if (product.Playtime == int.Parse(data1TextBox.Text))
                                {
                                    //Remove the error if playtime is the same
                                    playtimeErrorProvider.SetError(this.data1TextBox, String.Empty);
                                }
                                else
                                {
                                    throw new Exception();
                                }

                            }
                            catch
                            {
                                //Set the error if playtime is not a int
                                playtimeErrorProvider.SetError(this.data1TextBox, $"Speltid är antal minuter emellan 0 - {int.MaxValue}.");
                            }

                            break;
                        default:
                            break;
                    }
                }
            }
            else if (typeComboBox.SelectedItem == "Bok" || typeComboBox.SelectedItem == "Spel")
            {
                //Remove the error for playtime
                playtimeErrorProvider.SetError(this.data1TextBox, String.Empty);
            }
            else if (typeComboBox.SelectedItem == "DVD")
            {
                try
                { 
                    //Check if data has changed 
                    if (data1TextBox.Text != "" && 0 <= int.Parse(data1TextBox.Text))
                    {
                        //Convert playtime textbox text to a int
                        int _playtime = int.Parse(data1TextBox.Text);

                        //Remove the error if playtime is a int
                        playtimeErrorProvider.SetError(this.data1TextBox, String.Empty);

                        //Go through data and set buttons 
                        dataChanged();
                    }
                    else if (int.Parse(data1TextBox.Text) < 0)
                    {
                        throw new Exception();
                    }
                    else
                    {
                        //Remove the error if price is a int
                        itemNumberErrorProvider.SetError(this.data1TextBox, String.Empty);
                    }
                }
                catch
                {
                    //Set the error if playtime is not a int
                    playtimeErrorProvider.SetError(this.data1TextBox, $"Speltid är antal minuter emellan 0 - {int.MaxValue}.");
                }
            }
        }

        private void data2TextBox_TextChanged(object sender, EventArgs e)
        {
            //Check that a row is selected in grid or return with null
            if (0 < inventoryDataGrid.SelectedRows.Count)
            {
                //Get selected product from row
                var product = (Product)inventoryDataGrid.SelectedRows[0].DataBoundItem;

                if (product != null)
                {
                    //Check if data has changed 
                    if (product.Genre != data2TextBox.Text)
                    {
                        //Go through data and set buttons 
                        dataChanged();
                    }
                }
            }
        }

        private void data3TextBox_TextChanged(object sender, EventArgs e)
        {
            //Check that a row is selected in grid or return with null
            if (0 < inventoryDataGrid.SelectedRows.Count)
            {
                //Get selected product from row
                var product = (Product)inventoryDataGrid.SelectedRows[0].DataBoundItem;

                if (product != null)
                {
                    //Check if data has changed 
                    if (product.Format != data3TextBox.Text)
                    {
                        //Go through data and set buttons 
                        dataChanged();
                    }
                }
            }
        }

        private void data4TextBox_TextChanged(object sender, EventArgs e)
        {
            //Check that a row is selected in grid or return with null
            if (0 < inventoryDataGrid.SelectedRows.Count)
            {
                //Get selected product from row
                var product = (Product)inventoryDataGrid.SelectedRows[0].DataBoundItem;

                if (product != null)
                {
                    //Check if data has changed 
                    if (product.Language != data4TextBox.Text)
                    {
                        //Go through data and set buttons 
                        dataChanged();
                    }
                }
            }
        }

        private void ManageInventoryControl_Load(object sender, EventArgs e)
        {
            //Set columns head in inventory grid
            inventoryDataGrid.Columns["Type"].HeaderText = "Typ";
            inventoryDataGrid.Columns["ItemNumber"].HeaderText = "Artikelnummer";
            inventoryDataGrid.Columns["Name"].HeaderText = "Namn";
            inventoryDataGrid.Columns["Price"].HeaderText = "Pris";
            inventoryDataGrid.Columns["Quantity"].HeaderText = "Antal";
            inventoryDataGrid.Columns["Author"].HeaderText = "Författare";
            inventoryDataGrid.Columns["Genre"].HeaderText = "Genre";
            inventoryDataGrid.Columns["Format"].HeaderText = "Format";
            inventoryDataGrid.Columns["Language"].HeaderText = "Språk";
            inventoryDataGrid.Columns["Platform"].HeaderText = "Plattform";
            inventoryDataGrid.Columns["Playtime"].HeaderText = "Speltid";
        }
    }
}
