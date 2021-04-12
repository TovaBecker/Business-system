using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Laboration_4
{
    //Code from https://foxlearn.com/articles/print-receipt-using-report-viewer-in-csharp-111.html
    public partial class PrintReceiptForm : Form
    {
        //Data sourses for the progam
        BindingList<SaleInfo> _basketList;

        //Declare an instance string variabl
        string _total;

        public PrintReceiptForm(BindingList<SaleInfo> dataSource, string total)
        {
            InitializeComponent();

            //Set saleInfoBindingSource
            _basketList = dataSource;

            //Set total
             _total = total;
        }

        private void PrintReceiptForm_Load(object sender, EventArgs e)
        {
            //Set data source to receipt report
            ReportDataSource source = new ReportDataSource("DataSetReceipt", _basketList);

            //Cler the old data source
            receiptViewer.LocalReport.DataSources.Clear();

            //Add the new data source
            receiptViewer.LocalReport.DataSources.Add(source);

            //Cerate parameters for the receipt report
            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pTotal", _total),
                new Microsoft.Reporting.WinForms.ReportParameter("pDate", DateTime.Now.ToString("g")),
            };

            ////Send parameters to receipt report
            this.receiptViewer.LocalReport.SetParameters(para);
            this.receiptViewer.RefreshReport();

            //Save the report as PDF file
            SavePDF(receiptViewer, @"..\..\Receipt\Receipt.pdf");

            //Close the dialog window
            this.Close();
        }

        //Code from https://www.c-sharpcorner.com/UploadFile/013102/save-report-rdlc-as-pdf-at-run-time-in-C-Sharp/
        public void SavePDF(ReportViewer viewer, string savePath)
        {
            //Convert file to PDF
            byte[] Bytes = viewer.LocalReport.Render(format: "PDF", deviceInfo: "");

            //Save file in send location
            using (FileStream stream = new FileStream(savePath, FileMode.Create))
            {
                stream.Write(Bytes, 0, Bytes.Length);
            }
        }
    }
}
