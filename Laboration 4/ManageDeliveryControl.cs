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
            deliveryTextBox.Text = "";
        }

        private void addDeliverButton_Click(object sender, EventArgs e)
        {
            //Declare a bool varibel for sucess
            bool _success;

            //Declare a int varibel for counting error in list
            int _errorQuantity = 0;

            //Save the text in textbox to a string varible
            string text = deliveryTextBox.Text;

            //create string array that saves input that did not go in
            string[] errorInput;

            //Split text into a array with a product itemnumer and quantity in same row
            string[] allLines = deliveryTextBox.Text.Split('\n');

            foreach (string line in allLines)
            {
                //Split row into a array with itemnumer and quantity
                string[] row = deliveryTextBox.Text.Split(',');

                try
                {
                    //Declare two int instance
                    int _itemnumer = int.Parse(row[0]);
                    int _quantity = int.Parse(row[1]);

                    //Add product
                    _success = _control.Delivery(_itemnumer, _quantity);
                }
                catch
                {
                    //errorInput[_errorQuantity] = $"{row[0]}, { row[1]}";

                    _errorQuantity++;
                }


                //if(_success == false)
                //{
                //    errorInput[_errorQuantity] = $"{row[0]}, { row[1]}";

                //    _errorQuantity++;
                //}
            }

            //deliveryTextBox.Text = $"Dessa las inte in: \n";
            //foreach (string line in errorInput)
            //{

            //    deliveryTextBox.Text = $"{deliveryTextBox.Text}{errorInput[line]}\n";
   

            //}
        }
    }
}
