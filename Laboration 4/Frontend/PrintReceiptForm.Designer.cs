
namespace Laboration_4
{
    partial class PrintReceiptForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.receiptViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.receiptViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.receiptViewer.LocalReport.ReportEmbeddedResource = "Laboration_4.ReceiptReport.rdlc";
            this.receiptViewer.Location = new System.Drawing.Point(0, 0);
            this.receiptViewer.Name = "reportViewer1";
            this.receiptViewer.ServerReport.BearerToken = null;
            this.receiptViewer.Size = new System.Drawing.Size(800, 450);
            this.receiptViewer.TabIndex = 0;
            // 
            // PrintReceiptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.receiptViewer);
            this.Name = "PrintReceiptForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kvitto";
            this.Load += new System.EventHandler(this.PrintReceiptForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer receiptViewer;
    }
}