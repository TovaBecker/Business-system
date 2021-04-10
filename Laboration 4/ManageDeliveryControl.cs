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
    public partial class ManageDeliveryControl : UserControl
    {
        //Declare an instance a Contol class varible for conecting inventory to Control class
        Control _control;

        public ManageDeliveryControl(Control control)
        {
            InitializeComponent();

            //Get and set referans to the Contol class
            _control = control;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clear textbox 
            clearTextBox();
        }

        private void addDeliverButton_Click(object sender, EventArgs e)
        {
            //Declare a int varibel for counting error in list
            int _errorQuantity = 0;

            //Split text into a array with a product itemnumer and quantity in same row
            string[] allLines = deliveryTextBox.Text.Split('\n');

            //Declare a string varibel for error message
            string errorText = $"Dessa leveranser las inte in:";
            string errorLines = "";

            foreach (string line in allLines)
            {
                if (line != errorText)
                {
                    //Split row into a array with itemnumer and quantity
                    string[] row = line.Split(',');

                    try
                    {
                        if (row.Count() == 2)
                        {
                            //Declare two int instance
                            int _itemnumer = int.Parse(row[0]);
                            int _quantity = int.Parse(row[1]);

                            //Add product
                            if (_control.Delivery(_itemnumer, _quantity) == false)
                            {
                                throw new Exception("Inte rätt värden");
                            }
                        }
                        else
                        {
                            throw new Exception("Inte rätt värden");
                        }
                    }
                    catch
                    {
                        errorLines = $"{errorLines}\n{line}";

                        _errorQuantity++;
                    }
                }
            }

            //Check if there is anny error in input
            if( 0 < _errorQuantity)
            {
                if(1 == _errorQuantity)
                {
                    //Show message that tells user itemnumber is removed
                    MessageBox.Show(
                                    $"Det gick inte att uppdatera {_errorQuantity} rad.\n" +
                                    "Varunummer och antal måste anges i siffror med komma emellan.\n" +
                                    "Kontrollera raden som visas i fönstret.",
                                    "Kontrollera inmatning",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                else
                {
                    //Show message that tells user itemnumber is removed
                    MessageBox.Show(
                                    $"Det gick inte att uppdatera {_errorQuantity} rader.\n" +
                                    "Varunummer och antal måste anges i siffror med komma emellan.\n" +
                                    "Kontrollera raderna som visas i fönstret.",
                                    "Kontrollera inmatning",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }

                //Print out error resualt to user
                deliveryTextBox.Text = errorText + errorLines;
            }
            else
            {
                //Clear textbox 
                clearTextBox();
            }
        }

        private void clearTextBox()
        {
            deliveryTextBox.Text = "";
        }
    }
}
