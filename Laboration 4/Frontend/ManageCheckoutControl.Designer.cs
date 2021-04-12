
namespace Laboration_4
{
    partial class ManageCheckoutControl
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
            this.components = new System.ComponentModel.Container();
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.MenuSplitContainer = new System.Windows.Forms.SplitContainer();
            this.SearcIDhLabel = new System.Windows.Forms.Label();
            this.itemNumberSearchextBox = new System.Windows.Forms.TextBox();
            this.returnRadioButton = new System.Windows.Forms.RadioButton();
            this.buyRadioButton = new System.Windows.Forms.RadioButton();
            this.checkutLabel = new System.Windows.Forms.Label();
            this.basketDataGridView = new System.Windows.Forms.DataGridView();
            this.itemNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonRemoveCheckout = new System.Windows.Forms.Button();
            this.buttonAddCheckout = new System.Windows.Forms.Button();
            this.buttonBuyCheckout = new System.Windows.Forms.Button();
            this.cartLabel = new System.Windows.Forms.Label();
            this.checkoutDataGrid = new System.Windows.Forms.DataGridView();
            this.typeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.languageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.platformDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemNumberErrorProviderAdd = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuSplitContainer)).BeginInit();
            this.MenuSplitContainer.Panel1.SuspendLayout();
            this.MenuSplitContainer.Panel2.SuspendLayout();
            this.MenuSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.basketDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkoutDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemNumberErrorProviderAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.IsSplitterFixed = true;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.mainSplitContainer.Name = "mainSplitContainer";
            this.mainSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.MenuSplitContainer);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.checkoutDataGrid);
            this.mainSplitContainer.Size = new System.Drawing.Size(620, 386);
            this.mainSplitContainer.SplitterDistance = 118;
            this.mainSplitContainer.TabIndex = 0;
            this.mainSplitContainer.TabStop = false;
            // 
            // MenuSplitContainer
            // 
            this.MenuSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.MenuSplitContainer.Name = "MenuSplitContainer";
            // 
            // MenuSplitContainer.Panel1
            // 
            this.MenuSplitContainer.Panel1.Controls.Add(this.SearcIDhLabel);
            this.MenuSplitContainer.Panel1.Controls.Add(this.itemNumberSearchextBox);
            this.MenuSplitContainer.Panel1.Controls.Add(this.returnRadioButton);
            this.MenuSplitContainer.Panel1.Controls.Add(this.buyRadioButton);
            this.MenuSplitContainer.Panel1.Controls.Add(this.checkutLabel);
            // 
            // MenuSplitContainer.Panel2
            // 
            this.MenuSplitContainer.Panel2.Controls.Add(this.basketDataGridView);
            this.MenuSplitContainer.Panel2.Controls.Add(this.buttonRemoveCheckout);
            this.MenuSplitContainer.Panel2.Controls.Add(this.buttonAddCheckout);
            this.MenuSplitContainer.Panel2.Controls.Add(this.buttonBuyCheckout);
            this.MenuSplitContainer.Panel2.Controls.Add(this.cartLabel);
            this.MenuSplitContainer.Size = new System.Drawing.Size(620, 118);
            this.MenuSplitContainer.SplitterDistance = 112;
            this.MenuSplitContainer.TabIndex = 1;
            this.MenuSplitContainer.TabStop = false;
            // 
            // SearcIDhLabel
            // 
            this.SearcIDhLabel.AutoSize = true;
            this.SearcIDhLabel.Location = new System.Drawing.Point(4, 79);
            this.SearcIDhLabel.Name = "SearcIDhLabel";
            this.SearcIDhLabel.Size = new System.Drawing.Size(73, 13);
            this.SearcIDhLabel.TabIndex = 4;
            this.SearcIDhLabel.Text = "Artikelnummer";
            // 
            // itemNumberSearchextBox
            // 
            this.itemNumberSearchextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemNumberSearchextBox.Location = new System.Drawing.Point(7, 95);
            this.itemNumberSearchextBox.Name = "itemNumberSearchextBox";
            this.itemNumberSearchextBox.Size = new System.Drawing.Size(87, 20);
            this.itemNumberSearchextBox.TabIndex = 1;
            this.itemNumberSearchextBox.TextChanged += new System.EventHandler(this.itemNumberSearchextBox_TextChanged);
            // 
            // returnRadioButton
            // 
            this.returnRadioButton.AutoSize = true;
            this.returnRadioButton.Location = new System.Drawing.Point(7, 56);
            this.returnRadioButton.Name = "returnRadioButton";
            this.returnRadioButton.Size = new System.Drawing.Size(62, 17);
            this.returnRadioButton.TabIndex = 5;
            this.returnRadioButton.Text = "Återköp";
            this.returnRadioButton.UseVisualStyleBackColor = true;
            this.returnRadioButton.CheckedChanged += new System.EventHandler(this.returnRadioButton_CheckedChanged);
            // 
            // buyRadioButton
            // 
            this.buyRadioButton.AutoSize = true;
            this.buyRadioButton.Checked = true;
            this.buyRadioButton.Location = new System.Drawing.Point(7, 31);
            this.buyRadioButton.Name = "buyRadioButton";
            this.buyRadioButton.Size = new System.Drawing.Size(44, 17);
            this.buyRadioButton.TabIndex = 5;
            this.buyRadioButton.TabStop = true;
            this.buyRadioButton.Text = "Köp";
            this.buyRadioButton.UseVisualStyleBackColor = true;
            this.buyRadioButton.CheckedChanged += new System.EventHandler(this.buyRadioButton_CheckedChanged);
            // 
            // checkutLabel
            // 
            this.checkutLabel.AutoSize = true;
            this.checkutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkutLabel.Location = new System.Drawing.Point(3, 0);
            this.checkutLabel.Name = "checkutLabel";
            this.checkutLabel.Size = new System.Drawing.Size(58, 20);
            this.checkutLabel.TabIndex = 0;
            this.checkutLabel.Text = "Kassa";
            // 
            // basketDataGridView
            // 
            this.basketDataGridView.AllowUserToAddRows = false;
            this.basketDataGridView.AllowUserToDeleteRows = false;
            this.basketDataGridView.AllowUserToOrderColumns = true;
            this.basketDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.basketDataGridView.AutoGenerateColumns = false;
            this.basketDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.basketDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.basketDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.basketDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.basketDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemNumberDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.Sum});
            this.basketDataGridView.DataSource = this.saleInfoBindingSource;
            this.basketDataGridView.Location = new System.Drawing.Point(6, 25);
            this.basketDataGridView.MultiSelect = false;
            this.basketDataGridView.Name = "basketDataGridView";
            this.basketDataGridView.ReadOnly = true;
            this.basketDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.basketDataGridView.ShowCellErrors = false;
            this.basketDataGridView.ShowCellToolTips = false;
            this.basketDataGridView.ShowEditingIcon = false;
            this.basketDataGridView.ShowRowErrors = false;
            this.basketDataGridView.Size = new System.Drawing.Size(412, 88);
            this.basketDataGridView.TabIndex = 0;
            this.basketDataGridView.TabStop = false;
            // 
            // itemNumberDataGridViewTextBoxColumn
            // 
            this.itemNumberDataGridViewTextBoxColumn.DataPropertyName = "ItemNumber";
            this.itemNumberDataGridViewTextBoxColumn.HeaderText = "Artikel Nr";
            this.itemNumberDataGridViewTextBoxColumn.Name = "itemNumberDataGridViewTextBoxColumn";
            this.itemNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemNumberDataGridViewTextBoxColumn.Width = 75;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Typ";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeDataGridViewTextBoxColumn.Width = 50;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Namn";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 60;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Pris";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 49;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Antal";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantityDataGridViewTextBoxColumn.Width = 56;
            // 
            // Sum
            // 
            this.Sum.DataPropertyName = "Sum";
            this.Sum.HeaderText = "Summa";
            this.Sum.Name = "Sum";
            this.Sum.ReadOnly = true;
            this.Sum.Width = 67;
            // 
            // saleInfoBindingSource
            // 
            this.saleInfoBindingSource.DataSource = typeof(Laboration_4.SaleInfo);
            // 
            // buttonRemoveCheckout
            // 
            this.buttonRemoveCheckout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemoveCheckout.Location = new System.Drawing.Point(424, 57);
            this.buttonRemoveCheckout.Name = "buttonRemoveCheckout";
            this.buttonRemoveCheckout.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveCheckout.TabIndex = 3;
            this.buttonRemoveCheckout.Text = "Ta bort";
            this.buttonRemoveCheckout.UseVisualStyleBackColor = true;
            this.buttonRemoveCheckout.Click += new System.EventHandler(this.buttonRemoveCheckout_Click);
            // 
            // buttonAddCheckout
            // 
            this.buttonAddCheckout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddCheckout.Location = new System.Drawing.Point(424, 25);
            this.buttonAddCheckout.Name = "buttonAddCheckout";
            this.buttonAddCheckout.Size = new System.Drawing.Size(75, 23);
            this.buttonAddCheckout.TabIndex = 2;
            this.buttonAddCheckout.Text = "Lägg till";
            this.buttonAddCheckout.UseVisualStyleBackColor = true;
            this.buttonAddCheckout.Click += new System.EventHandler(this.buttonAddCheckout_Click);
            // 
            // buttonBuyCheckout
            // 
            this.buttonBuyCheckout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBuyCheckout.Location = new System.Drawing.Point(424, 90);
            this.buttonBuyCheckout.Name = "buttonBuyCheckout";
            this.buttonBuyCheckout.Size = new System.Drawing.Size(75, 23);
            this.buttonBuyCheckout.TabIndex = 4;
            this.buttonBuyCheckout.Text = "Köp";
            this.buttonBuyCheckout.UseVisualStyleBackColor = true;
            this.buttonBuyCheckout.Click += new System.EventHandler(this.buttonBuyCheckout_Click);
            // 
            // cartLabel
            // 
            this.cartLabel.AutoSize = true;
            this.cartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartLabel.Location = new System.Drawing.Point(3, 0);
            this.cartLabel.Name = "cartLabel";
            this.cartLabel.Size = new System.Drawing.Size(74, 17);
            this.cartLabel.TabIndex = 1;
            this.cartLabel.Text = "Varukorg";
            // 
            // checkoutDataGrid
            // 
            this.checkoutDataGrid.AllowUserToAddRows = false;
            this.checkoutDataGrid.AllowUserToDeleteRows = false;
            this.checkoutDataGrid.AllowUserToOrderColumns = true;
            this.checkoutDataGrid.AutoGenerateColumns = false;
            this.checkoutDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.checkoutDataGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.checkoutDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.checkoutDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeDataGridViewTextBoxColumn1,
            this.itemNumberDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.priceDataGridViewTextBoxColumn1,
            this.quantityDataGridViewTextBoxColumn1,
            this.authorDataGridViewTextBoxColumn,
            this.genreDataGridViewTextBoxColumn,
            this.formatDataGridViewTextBoxColumn,
            this.languageDataGridViewTextBoxColumn,
            this.platformDataGridViewTextBoxColumn,
            this.playtimeDataGridViewTextBoxColumn});
            this.checkoutDataGrid.DataSource = this.productBindingSource;
            this.checkoutDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkoutDataGrid.Location = new System.Drawing.Point(0, 0);
            this.checkoutDataGrid.MultiSelect = false;
            this.checkoutDataGrid.Name = "checkoutDataGrid";
            this.checkoutDataGrid.ReadOnly = true;
            this.checkoutDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.checkoutDataGrid.ShowCellErrors = false;
            this.checkoutDataGrid.ShowCellToolTips = false;
            this.checkoutDataGrid.ShowEditingIcon = false;
            this.checkoutDataGrid.ShowRowErrors = false;
            this.checkoutDataGrid.Size = new System.Drawing.Size(620, 264);
            this.checkoutDataGrid.TabIndex = 0;
            this.checkoutDataGrid.TabStop = false;
            this.checkoutDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.checkoutDataGrid_CellClick);
            // 
            // typeDataGridViewTextBoxColumn1
            // 
            this.typeDataGridViewTextBoxColumn1.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn1.HeaderText = "Typ";
            this.typeDataGridViewTextBoxColumn1.Name = "typeDataGridViewTextBoxColumn1";
            this.typeDataGridViewTextBoxColumn1.ReadOnly = true;
            this.typeDataGridViewTextBoxColumn1.Width = 50;
            // 
            // itemNumberDataGridViewTextBoxColumn1
            // 
            this.itemNumberDataGridViewTextBoxColumn1.DataPropertyName = "ItemNumber";
            this.itemNumberDataGridViewTextBoxColumn1.HeaderText = "Artikel Nr";
            this.itemNumberDataGridViewTextBoxColumn1.Name = "itemNumberDataGridViewTextBoxColumn1";
            this.itemNumberDataGridViewTextBoxColumn1.ReadOnly = true;
            this.itemNumberDataGridViewTextBoxColumn1.Width = 75;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Namn";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn1.Width = 60;
            // 
            // priceDataGridViewTextBoxColumn1
            // 
            this.priceDataGridViewTextBoxColumn1.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn1.HeaderText = "Pris";
            this.priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            this.priceDataGridViewTextBoxColumn1.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn1.Width = 49;
            // 
            // quantityDataGridViewTextBoxColumn1
            // 
            this.quantityDataGridViewTextBoxColumn1.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn1.HeaderText = "Antal";
            this.quantityDataGridViewTextBoxColumn1.Name = "quantityDataGridViewTextBoxColumn1";
            this.quantityDataGridViewTextBoxColumn1.ReadOnly = true;
            this.quantityDataGridViewTextBoxColumn1.Width = 56;
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "Författare";
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            this.authorDataGridViewTextBoxColumn.ReadOnly = true;
            this.authorDataGridViewTextBoxColumn.Width = 77;
            // 
            // genreDataGridViewTextBoxColumn
            // 
            this.genreDataGridViewTextBoxColumn.DataPropertyName = "Genre";
            this.genreDataGridViewTextBoxColumn.HeaderText = "Genre";
            this.genreDataGridViewTextBoxColumn.Name = "genreDataGridViewTextBoxColumn";
            this.genreDataGridViewTextBoxColumn.ReadOnly = true;
            this.genreDataGridViewTextBoxColumn.Width = 61;
            // 
            // formatDataGridViewTextBoxColumn
            // 
            this.formatDataGridViewTextBoxColumn.DataPropertyName = "Format";
            this.formatDataGridViewTextBoxColumn.HeaderText = "Format";
            this.formatDataGridViewTextBoxColumn.Name = "formatDataGridViewTextBoxColumn";
            this.formatDataGridViewTextBoxColumn.ReadOnly = true;
            this.formatDataGridViewTextBoxColumn.Width = 64;
            // 
            // languageDataGridViewTextBoxColumn
            // 
            this.languageDataGridViewTextBoxColumn.DataPropertyName = "Language";
            this.languageDataGridViewTextBoxColumn.HeaderText = "Språk";
            this.languageDataGridViewTextBoxColumn.Name = "languageDataGridViewTextBoxColumn";
            this.languageDataGridViewTextBoxColumn.ReadOnly = true;
            this.languageDataGridViewTextBoxColumn.Width = 60;
            // 
            // platformDataGridViewTextBoxColumn
            // 
            this.platformDataGridViewTextBoxColumn.DataPropertyName = "Platform";
            this.platformDataGridViewTextBoxColumn.HeaderText = "Plattform";
            this.platformDataGridViewTextBoxColumn.Name = "platformDataGridViewTextBoxColumn";
            this.platformDataGridViewTextBoxColumn.ReadOnly = true;
            this.platformDataGridViewTextBoxColumn.Width = 73;
            // 
            // playtimeDataGridViewTextBoxColumn
            // 
            this.playtimeDataGridViewTextBoxColumn.DataPropertyName = "Playtime";
            this.playtimeDataGridViewTextBoxColumn.HeaderText = "Speltid";
            this.playtimeDataGridViewTextBoxColumn.Name = "playtimeDataGridViewTextBoxColumn";
            this.playtimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.playtimeDataGridViewTextBoxColumn.Width = 64;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(Laboration_4.Product);
            // 
            // itemNumberErrorProviderAdd
            // 
            this.itemNumberErrorProviderAdd.ContainerControl = this;
            // 
            // ManageCheckoutControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainSplitContainer);
            this.Name = "ManageCheckoutControl";
            this.Size = new System.Drawing.Size(620, 386);
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            this.MenuSplitContainer.Panel1.ResumeLayout(false);
            this.MenuSplitContainer.Panel1.PerformLayout();
            this.MenuSplitContainer.Panel2.ResumeLayout(false);
            this.MenuSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuSplitContainer)).EndInit();
            this.MenuSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.basketDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkoutDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemNumberErrorProviderAdd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.SplitContainer MenuSplitContainer;
        private System.Windows.Forms.Label SearcIDhLabel;
        private System.Windows.Forms.TextBox itemNumberSearchextBox;
        private System.Windows.Forms.RadioButton returnRadioButton;
        private System.Windows.Forms.RadioButton buyRadioButton;
        private System.Windows.Forms.Label checkutLabel;
        private System.Windows.Forms.Label cartLabel;
        private System.Windows.Forms.Button buttonBuyCheckout;
        private System.Windows.Forms.DataGridView checkoutDataGrid;
        private System.Windows.Forms.Button buttonRemoveCheckout;
        private System.Windows.Forms.Button buttonAddCheckout;
        private System.Windows.Forms.DataGridView basketDataGridView;
        private System.Windows.Forms.ErrorProvider itemNumberErrorProviderAdd;
        private System.Windows.Forms.BindingSource saleInfoBindingSource;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNumberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn languageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn platformDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn playtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sum;
    }
}
