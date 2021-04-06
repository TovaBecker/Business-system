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

        private void inventoryDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (inventoryDataGrid.SelectedRows.Count < 1)
                return;
            ManageInventory_ShowData();
        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ManageInventory_ShowData();
        }

        private void ManageInventory_ShowData()
        {
            var product = (Product)inventoryDataGrid.SelectedRows[0].DataBoundItem;
            itemNrTextBox.Text = $"{product.ItemNumber}";
            nameTextBox.Text = product.Name;
            priceTextBox.Text = $"{product.Price}";
            quantityTextBox.Text = $"{product.Quantity}";
            typeComboBox.Text = $"{product.Type}";

            //Show data for the type of product
            switch (typeComboBox.SelectedItem)
            {
                case "Bok":
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

                    data1TextBox.Text = $"{product.Author}";
                    data2TextBox.Text = $"{product.Genre}";
                    data3TextBox.Text = $"{product.Format}";
                    data4TextBox.Text = $"{product.Language}";

                    break;
                case "Spel":
                    data1Label.Text = "Plattform";
                    data1Label.Visible = true;
                    data1TextBox.Visible = true;

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

                    data1TextBox.Text = $"{product.Platform}";

                    break;
                case "DVD":
                    data1Label.Text = "Speltid";
                    data1Label.Visible = true;
                    data1TextBox.Visible = true;

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

                    data1TextBox.Text = $"{product.Playtime}";

                    break;
                default:
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
                    break;
            }
        }
    }
}
