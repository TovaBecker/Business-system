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
    public partial class ManageStatisticsControl : UserControl
    {
        private Control _control;
        public ManageStatisticsControl(Control control)
        {
            InitializeComponent();

            //Set the instance of control
            _control = control;
        }

        private void ManageStatisticsControl_Load(object sender, EventArgs e)
        {
            //Set to date to now
            toDateTimePicker.Value = DateTime.Now;
            toDateTimePicker.MaxDate = DateTime.Now;

            //Set from date to a year before today
            fromDateTimePicker.Value = DateTime.Now.AddYears(-1);
            fromDateTimePicker.MaxDate = DateTime.Now;

            //Create chart for total sale
            fillTotalSaleChart();
            //Get top ten products in between dates
            topTenDataGridView1.DataSource = _control.GetTopTen(fromDateTimePicker.Value, toDateTimePicker.Value);

            //Set columns head in grid
            topTenDataGridView1.Columns["ItemNumber"].HeaderText = "Artikelnummer";
            topTenDataGridView1.Columns["Name"].HeaderText = "Namn";
            topTenDataGridView1.Columns["Quantity"].HeaderText = "Antal";
        }

        private void fillTotalSaleChart()
        {
            //Set series points
            TotalSale.Series["Antal"].Points.Clear();

            //Get and data into a dictionary in beetwwn the dates
            Dictionary<string, int> totalSaleList = _control.GetTotalSale(fromDateTimePicker.Value, toDateTimePicker.Value);

            //Go thougt dictionary and set points
            foreach (var item in totalSaleList)
            {
                TotalSale.Series["Antal"].Points.AddXY(item.Key, item.Value);
            }
        }
        private void staticSearchButton_Click(object sender, EventArgs e)
        {
            //Check if dates are correct
            if (fromDateTimePicker.Value <= toDateTimePicker.Value)
            {
                //Create chart for total sale
                fillTotalSaleChart();
                //Get top ten products in between dates
                topTenDataGridView1.DataSource = _control.GetTopTen(fromDateTimePicker.Value, toDateTimePicker.Value);
            }
            else
            {
                //Show message that tells user the from date needs to be before to date
                MessageBox.Show(
                                "Från datumet måste vara innan till datumet",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

        }
    }
}
