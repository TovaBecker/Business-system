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
        Product _selectedItem;

        internal Product NewProduct { get; private set; }

        public ManageInventoryControl()
        {
            InitializeComponent();

            //Conect ManageInventoryControl to Contol class and get binding source
            this.inventoryBindingSource = _control.LoadInventory();

            //Set binding source
            inventoryDataGrid.DataSource = inventoryBindingSource;
        }

        private void buttonAddInventory_Click(object sender, EventArgs e)
        {
            //Add new product
            Product NewProduct = fetchProduct();

            //Add new product
            _control.NewProduct(NewProduct);

            //Go through data and set buttons 
            dataChanged();
        }

        private void buttonUpdateInventory_Click(object sender, EventArgs e)
        {
            //Declare item nubers as int
            int _itemNumber = 0;

            //If there is a value in item number set number
            if (itemNrTextBox.Text != "")
            {
                //Set itemnnumber
                _itemNumber = int.Parse(itemNrTextBox.Text);
            }

            if (null != _control.Search(_itemNumber))
            {
                //Get data
                Product UpdateProduct = fetchProduct();

                //Update product
                _control.UpdateProduct(UpdateProduct);
            }

            //Show uppdate in list
            inventoryBindingSource.ResetCurrentItem();

            //Go through data and set buttons 
            dataChanged();
        }

        private void buttonClearInventory_Click(object sender, EventArgs e)
        {
            //Clear window
            clearWindow();

            _control.ClearSearch();
        }
        private void buttonRemoveInventory_Click(object sender, EventArgs e)
        {
            //Declare item nubers as int
            int _itemNumber = 0;

            //If there is a value in item number set number
            if (itemNrTextBox.Text != "")
            {
                _itemNumber = int.Parse(itemNrTextBox.Text);
            }
            else
            {
                //TO DO
                //ERROR
            }

            if (null != _control.Search(_itemNumber))
            {
               bool sucess = _control.RemoveProduct(_itemNumber);

                //T= DO
                //ERROR if not working
            }

            //Show uppdate in list
            inventoryBindingSource.ResetCurrentItem();

            //Go through data and set buttons 
            dataChanged();

            //Clear window
            clearWindow();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
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

            //Go through data and set buttons 
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
                _itemNumber = int.Parse(itemNrTextBox.Text);
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
                if (nameTextBox.Text != "")
                {
                    //Enabel add button
                    buttonAddInventory.Enabled = true;
                }
                else
                {
                    //Disabel add button
                    buttonAddInventory.Enabled = false;
                }

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
            //Show products data in text boxes
            //ManageInventory_ShowProduct();

            //Change grid for product information
            ManageInventory_ViewData();

            //Enabel and disabel buttons
            buttonAddInventory.Enabled = false;
            buttonUpdateInventory.Enabled = false;
        }
        private void itemNrTextBox_TextChanged(object sender, EventArgs e)
        {
            //Go through data and set buttons 
            dataChanged();
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
            //Check that a row is selected in grid or return with null
            if (0 < inventoryDataGrid.SelectedRows.Count)
            {
                //Get selected product from row
                var product = (Product)inventoryDataGrid.SelectedRows[0].DataBoundItem;

                if (product != null)
                {
                    //Check if data has changed 
                    if (priceTextBox.Text == "" || product.Price != double.Parse(priceTextBox.Text))
                    {
                        //Go through data and set buttons 
                        dataChanged();
                    }
                }
            }
        }

        private void quantityTextBox_TextChanged(object sender, EventArgs e)
        {
            //Check that a row is selected in grid or return with null
            if (0 < inventoryDataGrid.SelectedRows.Count)
            {
                //Get selected product from row
                var product = (Product)inventoryDataGrid.SelectedRows[0].DataBoundItem;

                if (product != null)
                {
                    //Check if data has changed 
                    if (quantityTextBox.Text == "" || product.Quantity != int.Parse(quantityTextBox.Text))
                    {
                        //Go through data and set buttons 
                        dataChanged();
                    }
                }
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
                            }
                            break;
                        case Type.Spel:
                            //Check if data has changed 
                            if (product.Platform != data1TextBox.Text)
                            {
                                //Go through data and set buttons 
                                dataChanged();
                            }
                            break;
                        case Type.DVD:
                            //Check if data has changed 
                            if (data1TextBox.Text == "" || product.Playtime != int.Parse(data1TextBox.Text))
                            {
                                //Go through data and set buttons 
                                dataChanged();
                            }
                            break;
                        default:
                            break;
                    }   
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
    }
}
