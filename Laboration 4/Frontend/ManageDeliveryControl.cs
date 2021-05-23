using Laboration_4.Backend;
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
        IControl _control;

        public ManageDeliveryControl(IControl control)
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
            //Declare a int varibel for counting error and success in list
            int _errorQuantity = 0;
            int _successQuantity = 0;

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
                            if ( _quantity <= 0)
                            {
                                //Throw error for saving line and add to _errorQuantity '
                                throw new Exception("Inte rätt värden");
                            }
                            else if(_control.Delivery(_itemnumer, _quantity) == false)
                            {
                                //Throw error for saving line and add to _errorQuantity '
                                throw new Exception("Inte rätt värden");
                            }
                            else
                            {
                                //Add to success
                                _successQuantity++;
                            }
                        }
                        else
                        {
                            //Throw error for saving line and add to _errorQuantity 
                            throw new Exception("Inte rätt värden");
                        }
                    }
                    catch
                    {
                        //Add error line too output for user
                        errorLines = $"{errorLines}\n{line}";
                        
                        //Add to error
                        _errorQuantity++;
                    }
                }
            }

            //Check if there is anny success in input
            if (0 < _successQuantity)
            {
                //Show message that tells user how many that was uppdated
                MessageBox.Show(
                                $"{_successQuantity} artiklar antal uppdaterades.\n",
                                "Leverans",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            //Check if there is anny error in input
            if (0 < _errorQuantity)
            {
                if (1 == _errorQuantity)
                {
                    //Show message that tells user itemnumber is removed
                    MessageBox.Show(
                                    $"Det gick inte att uppdatera {_errorQuantity} rad.\n" +
                                    "Artikelnummer och antal måste anges i positiva heltal med komma emellan.\n" +
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
                                    "Artikelnummer och antal måste anges i positiva heltal med komma emellan.\n" +
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
            //Clear textbox text 
            deliveryTextBox.Text = "";
        }
    }
}
