
namespace Laboration_4
{
    partial class ManageStatisticsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.staticSearchButton = new System.Windows.Forms.Button();
            this.dateToLabel = new System.Windows.Forms.Label();
            this.dateFromLabel = new System.Windows.Forms.Label();
            this.TotalSale = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalSale)).BeginInit();
            this.SuspendLayout();
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.mainSplitContainer.Name = "mainSplitContainer";
            this.mainSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.dataGridView1);
            this.mainSplitContainer.Panel1.Controls.Add(this.toDateTimePicker);
            this.mainSplitContainer.Panel1.Controls.Add(this.fromDateTimePicker);
            this.mainSplitContainer.Panel1.Controls.Add(this.staticSearchButton);
            this.mainSplitContainer.Panel1.Controls.Add(this.dateToLabel);
            this.mainSplitContainer.Panel1.Controls.Add(this.dateFromLabel);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.TotalSale);
            this.mainSplitContainer.Size = new System.Drawing.Size(666, 449);
            this.mainSplitContainer.SplitterDistance = 224;
            this.mainSplitContainer.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(558, 218);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // toDateTimePicker
            // 
            this.toDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.toDateTimePicker.Location = new System.Drawing.Point(571, 75);
            this.toDateTimePicker.MaxDate = new System.DateTime(2021, 4, 10, 0, 0, 0, 0);
            this.toDateTimePicker.Name = "toDateTimePicker";
            this.toDateTimePicker.Size = new System.Drawing.Size(92, 20);
            this.toDateTimePicker.TabIndex = 9;
            this.toDateTimePicker.Value = new System.DateTime(2021, 4, 10, 0, 0, 0, 0);
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromDateTimePicker.Location = new System.Drawing.Point(571, 26);
            this.fromDateTimePicker.MaxDate = new System.DateTime(2021, 4, 10, 0, 0, 0, 0);
            this.fromDateTimePicker.MaximumSize = new System.Drawing.Size(92, 20);
            this.fromDateTimePicker.MinimumSize = new System.Drawing.Size(92, 20);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(92, 20);
            this.fromDateTimePicker.TabIndex = 8;
            this.fromDateTimePicker.Value = new System.DateTime(2021, 4, 10, 0, 0, 0, 0);
            this.fromDateTimePicker.ValueChanged += new System.EventHandler(this.fromDateTimePicker1_ValueChanged);
            // 
            // staticSearchButton
            // 
            this.staticSearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.staticSearchButton.Location = new System.Drawing.Point(588, 107);
            this.staticSearchButton.Name = "staticSearchButton";
            this.staticSearchButton.Size = new System.Drawing.Size(75, 20);
            this.staticSearchButton.TabIndex = 7;
            this.staticSearchButton.Text = "Sök";
            this.staticSearchButton.UseVisualStyleBackColor = true;
            this.staticSearchButton.Click += new System.EventHandler(this.staticSearchButton_Click);
            // 
            // dateToLabel
            // 
            this.dateToLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateToLabel.AutoSize = true;
            this.dateToLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateToLabel.Location = new System.Drawing.Point(568, 55);
            this.dateToLabel.Name = "dateToLabel";
            this.dateToLabel.Size = new System.Drawing.Size(30, 17);
            this.dateToLabel.TabIndex = 5;
            this.dateToLabel.Text = "Till";
            this.dateToLabel.Click += new System.EventHandler(this.dateToLabel_Click);
            // 
            // dateFromLabel
            // 
            this.dateFromLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateFromLabel.AutoSize = true;
            this.dateFromLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFromLabel.Location = new System.Drawing.Point(568, 6);
            this.dateFromLabel.Name = "dateFromLabel";
            this.dateFromLabel.Size = new System.Drawing.Size(41, 17);
            this.dateFromLabel.TabIndex = 4;
            this.dateFromLabel.Text = "Från";
            // 
            // TotalSale
            // 
            chartArea3.Name = "ChartArea1";
            this.TotalSale.ChartAreas.Add(chartArea3);
            this.TotalSale.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.TotalSale.Legends.Add(legend3);
            this.TotalSale.Location = new System.Drawing.Point(0, 0);
            this.TotalSale.Name = "TotalSale";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Antal";
            this.TotalSale.Series.Add(series3);
            this.TotalSale.Size = new System.Drawing.Size(666, 221);
            this.TotalSale.TabIndex = 2;
            this.TotalSale.Text = "Total försäljning";
            title3.Name = "TotalSale";
            title3.Text = "Total Försäljning";
            this.TotalSale.Titles.Add(title3);
            // 
            // ManageStatisticsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainSplitContainer);
            this.Name = "ManageStatisticsControl";
            this.Size = new System.Drawing.Size(666, 449);
            this.Load += new System.EventHandler(this.ManageStatisticsControl_Load);
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel1.PerformLayout();
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalSale)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.Label dateFromLabel;
        private System.Windows.Forms.Button staticSearchButton;
        private System.Windows.Forms.Label dateToLabel;
        private System.Windows.Forms.DateTimePicker toDateTimePicker;
        private System.Windows.Forms.DateTimePicker fromDateTimePicker;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart TotalSale;
    }
}
