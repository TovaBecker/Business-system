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
            _control = control;
        }

        private void ManageStatisticsControl_Load(object sender, EventArgs e)
        {
            
            //Set from date to a year before today
            fromDateTimePicker.Value = DateTime.Now.AddYears(-1);

            fillTotalSaleChart();
            dataGridView1.DataSource = _control.GetTopTen(fromDateTimePicker.Value, toDateTimePicker.Value);

        }

        private void fillTotalSaleChart()
        {
            TotalSale.Series["Antal"].Points.Clear();


            Dictionary<string, int> totalSaleList = _control.GetTotalSale(fromDateTimePicker.Value, toDateTimePicker.Value);

            foreach (var item in totalSaleList)
            {
                TotalSale.Series["Antal"].Points.AddXY(item.Key, item.Value);

            }
        }

        private void dateToLabel_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fromDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void staticSearchButton_Click(object sender, EventArgs e)
        {
            fillTotalSaleChart();
            dataGridView1.DataSource = _control.GetTopTen(fromDateTimePicker.Value, toDateTimePicker.Value);

        }
    }
}
