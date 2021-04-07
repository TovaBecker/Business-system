
namespace Laboration_4
{
    partial class ManageInventoryControl
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
            this.infoTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.typeLabel = new System.Windows.Forms.Label();
            this.itemNrLabel = new System.Windows.Forms.Label();
            this.namLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.itemNrTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.data1TextBox = new System.Windows.Forms.TextBox();
            this.data2TextBox = new System.Windows.Forms.TextBox();
            this.data3TextBox = new System.Windows.Forms.TextBox();
            this.data4TextBox = new System.Windows.Forms.TextBox();
            this.buttonAddInventory = new System.Windows.Forms.Button();
            this.buttonRemoveInventory = new System.Windows.Forms.Button();
            this.buttonUpdateInventory = new System.Windows.Forms.Button();
            this.data1Label = new System.Windows.Forms.Label();
            this.data2Label = new System.Windows.Forms.Label();
            this.data3Label = new System.Windows.Forms.Label();
            this.data4Label = new System.Windows.Forms.Label();
            this.buttonClearInventory = new System.Windows.Forms.Button();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.inventoryDataGrid = new System.Windows.Forms.DataGridView();
            this.inventoryGridView = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.itemNumberErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.priceErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.quantityErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.playtimeErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            this.infoTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemNumberErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playtimeErrorProvider)).BeginInit();
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
            this.mainSplitContainer.Panel1.Controls.Add(this.infoTableLayoutPanel);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.inventoryDataGrid);
            this.mainSplitContainer.Panel2.Controls.Add(this.inventoryGridView);
            this.mainSplitContainer.Size = new System.Drawing.Size(620, 386);
            this.mainSplitContainer.SplitterDistance = 136;
            this.mainSplitContainer.TabIndex = 0;
            // 
            // infoTableLayoutPanel
            // 
            this.infoTableLayoutPanel.ColumnCount = 5;
            this.infoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.infoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.infoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.infoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.infoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.infoTableLayoutPanel.Controls.Add(this.buttonSearch, 4, 4);
            this.infoTableLayoutPanel.Controls.Add(this.typeLabel, 0, 4);
            this.infoTableLayoutPanel.Controls.Add(this.itemNrLabel, 0, 0);
            this.infoTableLayoutPanel.Controls.Add(this.namLabel, 0, 1);
            this.infoTableLayoutPanel.Controls.Add(this.priceLabel, 0, 2);
            this.infoTableLayoutPanel.Controls.Add(this.quantityLabel, 0, 3);
            this.infoTableLayoutPanel.Controls.Add(this.itemNrTextBox, 1, 0);
            this.infoTableLayoutPanel.Controls.Add(this.nameTextBox, 1, 1);
            this.infoTableLayoutPanel.Controls.Add(this.priceTextBox, 1, 2);
            this.infoTableLayoutPanel.Controls.Add(this.quantityTextBox, 1, 3);
            this.infoTableLayoutPanel.Controls.Add(this.data1TextBox, 3, 0);
            this.infoTableLayoutPanel.Controls.Add(this.data2TextBox, 3, 1);
            this.infoTableLayoutPanel.Controls.Add(this.data3TextBox, 3, 2);
            this.infoTableLayoutPanel.Controls.Add(this.data4TextBox, 3, 3);
            this.infoTableLayoutPanel.Controls.Add(this.buttonAddInventory, 4, 0);
            this.infoTableLayoutPanel.Controls.Add(this.buttonRemoveInventory, 4, 1);
            this.infoTableLayoutPanel.Controls.Add(this.buttonUpdateInventory, 4, 2);
            this.infoTableLayoutPanel.Controls.Add(this.data1Label, 2, 0);
            this.infoTableLayoutPanel.Controls.Add(this.data2Label, 2, 1);
            this.infoTableLayoutPanel.Controls.Add(this.data3Label, 2, 2);
            this.infoTableLayoutPanel.Controls.Add(this.data4Label, 2, 3);
            this.infoTableLayoutPanel.Controls.Add(this.buttonClearInventory, 4, 3);
            this.infoTableLayoutPanel.Controls.Add(this.typeComboBox, 1, 4);
            this.infoTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.infoTableLayoutPanel.Name = "infoTableLayoutPanel";
            this.infoTableLayoutPanel.RowCount = 5;
            this.infoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.infoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.infoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.infoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.infoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.infoTableLayoutPanel.Size = new System.Drawing.Size(620, 136);
            this.infoTableLayoutPanel.TabIndex = 1;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonSearch.Location = new System.Drawing.Point(542, 111);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 22);
            this.buttonSearch.TabIndex = 6;
            this.buttonSearch.Text = "Sök";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLabel.Location = new System.Drawing.Point(3, 108);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(35, 28);
            this.typeLabel.TabIndex = 21;
            this.typeLabel.Text = "Typ";
            // 
            // itemNrLabel
            // 
            this.itemNrLabel.AutoSize = true;
            this.itemNrLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.itemNrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemNrLabel.Location = new System.Drawing.Point(3, 0);
            this.itemNrLabel.Name = "itemNrLabel";
            this.itemNrLabel.Size = new System.Drawing.Size(99, 27);
            this.itemNrLabel.TabIndex = 0;
            this.itemNrLabel.Text = "Varunummer";
            // 
            // namLabel
            // 
            this.namLabel.AutoSize = true;
            this.namLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.namLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namLabel.Location = new System.Drawing.Point(3, 27);
            this.namLabel.Name = "namLabel";
            this.namLabel.Size = new System.Drawing.Size(49, 27);
            this.namLabel.TabIndex = 1;
            this.namLabel.Text = "Namn";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(3, 54);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(36, 27);
            this.priceLabel.TabIndex = 2;
            this.priceLabel.Text = "Pris";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.quantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLabel.Location = new System.Drawing.Point(3, 81);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(45, 27);
            this.quantityLabel.TabIndex = 3;
            this.quantityLabel.Text = "Antal";
            // 
            // itemNrTextBox
            // 
            this.itemNrTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemNrTextBox.Location = new System.Drawing.Point(113, 3);
            this.itemNrTextBox.Name = "itemNrTextBox";
            this.itemNrTextBox.Size = new System.Drawing.Size(151, 20);
            this.itemNrTextBox.TabIndex = 1;
            this.itemNrTextBox.TextChanged += new System.EventHandler(this.itemNrTextBox_TextChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameTextBox.Location = new System.Drawing.Point(113, 30);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(151, 20);
            this.nameTextBox.TabIndex = 2;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // priceTextBox
            // 
            this.priceTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.priceTextBox.Location = new System.Drawing.Point(113, 57);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(151, 20);
            this.priceTextBox.TabIndex = 3;
            this.priceTextBox.TextChanged += new System.EventHandler(this.priceTextBox_TextChanged);
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quantityTextBox.Location = new System.Drawing.Point(113, 84);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(151, 20);
            this.quantityTextBox.TabIndex = 4;
            this.quantityTextBox.TextChanged += new System.EventHandler(this.quantityTextBox_TextChanged);
            // 
            // data1TextBox
            // 
            this.data1TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data1TextBox.Location = new System.Drawing.Point(380, 3);
            this.data1TextBox.Name = "data1TextBox";
            this.data1TextBox.Size = new System.Drawing.Size(151, 20);
            this.data1TextBox.TabIndex = 11;
            this.data1TextBox.Visible = false;
            this.data1TextBox.TextChanged += new System.EventHandler(this.data1TextBox_TextChanged);
            // 
            // data2TextBox
            // 
            this.data2TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data2TextBox.Location = new System.Drawing.Point(380, 30);
            this.data2TextBox.Name = "data2TextBox";
            this.data2TextBox.Size = new System.Drawing.Size(151, 20);
            this.data2TextBox.TabIndex = 12;
            this.data2TextBox.Visible = false;
            this.data2TextBox.TextChanged += new System.EventHandler(this.data2TextBox_TextChanged);
            // 
            // data3TextBox
            // 
            this.data3TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data3TextBox.Location = new System.Drawing.Point(380, 57);
            this.data3TextBox.Name = "data3TextBox";
            this.data3TextBox.Size = new System.Drawing.Size(151, 20);
            this.data3TextBox.TabIndex = 13;
            this.data3TextBox.Visible = false;
            this.data3TextBox.TextChanged += new System.EventHandler(this.data3TextBox_TextChanged);
            // 
            // data4TextBox
            // 
            this.data4TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data4TextBox.Location = new System.Drawing.Point(380, 84);
            this.data4TextBox.Name = "data4TextBox";
            this.data4TextBox.Size = new System.Drawing.Size(151, 20);
            this.data4TextBox.TabIndex = 14;
            this.data4TextBox.Visible = false;
            this.data4TextBox.TextChanged += new System.EventHandler(this.data4TextBox_TextChanged);
            // 
            // buttonAddInventory
            // 
            this.buttonAddInventory.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonAddInventory.Location = new System.Drawing.Point(542, 3);
            this.buttonAddInventory.Name = "buttonAddInventory";
            this.buttonAddInventory.Size = new System.Drawing.Size(75, 21);
            this.buttonAddInventory.TabIndex = 7;
            this.buttonAddInventory.Text = "Lägg till";
            this.buttonAddInventory.UseVisualStyleBackColor = true;
            this.buttonAddInventory.Click += new System.EventHandler(this.buttonAddInventory_Click);
            // 
            // buttonRemoveInventory
            // 
            this.buttonRemoveInventory.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonRemoveInventory.Location = new System.Drawing.Point(542, 30);
            this.buttonRemoveInventory.Name = "buttonRemoveInventory";
            this.buttonRemoveInventory.Size = new System.Drawing.Size(75, 21);
            this.buttonRemoveInventory.TabIndex = 8;
            this.buttonRemoveInventory.Text = "Ta bort";
            this.buttonRemoveInventory.UseVisualStyleBackColor = true;
            this.buttonRemoveInventory.Click += new System.EventHandler(this.buttonRemoveInventory_Click);
            // 
            // buttonUpdateInventory
            // 
            this.buttonUpdateInventory.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonUpdateInventory.Location = new System.Drawing.Point(542, 57);
            this.buttonUpdateInventory.Name = "buttonUpdateInventory";
            this.buttonUpdateInventory.Size = new System.Drawing.Size(75, 21);
            this.buttonUpdateInventory.TabIndex = 9;
            this.buttonUpdateInventory.Text = "Uppdatera";
            this.buttonUpdateInventory.UseVisualStyleBackColor = true;
            this.buttonUpdateInventory.Click += new System.EventHandler(this.buttonUpdateInventory_Click);
            // 
            // data1Label
            // 
            this.data1Label.AutoSize = true;
            this.data1Label.Dock = System.Windows.Forms.DockStyle.Left;
            this.data1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data1Label.Location = new System.Drawing.Point(270, 0);
            this.data1Label.Name = "data1Label";
            this.data1Label.Size = new System.Drawing.Size(51, 27);
            this.data1Label.TabIndex = 16;
            this.data1Label.Text = "Data1";
            this.data1Label.Visible = false;
            // 
            // data2Label
            // 
            this.data2Label.AutoSize = true;
            this.data2Label.Dock = System.Windows.Forms.DockStyle.Left;
            this.data2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data2Label.Location = new System.Drawing.Point(270, 27);
            this.data2Label.Name = "data2Label";
            this.data2Label.Size = new System.Drawing.Size(51, 27);
            this.data2Label.TabIndex = 17;
            this.data2Label.Text = "Data2";
            this.data2Label.Visible = false;
            // 
            // data3Label
            // 
            this.data3Label.AutoSize = true;
            this.data3Label.Dock = System.Windows.Forms.DockStyle.Left;
            this.data3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data3Label.Location = new System.Drawing.Point(270, 54);
            this.data3Label.Name = "data3Label";
            this.data3Label.Size = new System.Drawing.Size(51, 27);
            this.data3Label.TabIndex = 18;
            this.data3Label.Text = "Data3";
            this.data3Label.Visible = false;
            // 
            // data4Label
            // 
            this.data4Label.AutoSize = true;
            this.data4Label.Dock = System.Windows.Forms.DockStyle.Left;
            this.data4Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data4Label.Location = new System.Drawing.Point(270, 81);
            this.data4Label.Name = "data4Label";
            this.data4Label.Size = new System.Drawing.Size(51, 27);
            this.data4Label.TabIndex = 19;
            this.data4Label.Text = "Data4";
            this.data4Label.Visible = false;
            // 
            // buttonClearInventory
            // 
            this.buttonClearInventory.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonClearInventory.Location = new System.Drawing.Point(542, 84);
            this.buttonClearInventory.Name = "buttonClearInventory";
            this.buttonClearInventory.Size = new System.Drawing.Size(75, 21);
            this.buttonClearInventory.TabIndex = 10;
            this.buttonClearInventory.Text = "Rensa";
            this.buttonClearInventory.UseVisualStyleBackColor = true;
            this.buttonClearInventory.Click += new System.EventHandler(this.buttonClearInventory_Click);
            // 
            // typeComboBox
            // 
            this.typeComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "",
            "Bok",
            "Spel",
            "DVD"});
            this.typeComboBox.Location = new System.Drawing.Point(113, 111);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(151, 21);
            this.typeComboBox.TabIndex = 5;
            this.typeComboBox.SelectedIndexChanged += new System.EventHandler(this.typeComboBox_SelectedIndexChanged);
            // 
            // inventoryDataGrid
            // 
            this.inventoryDataGrid.AllowUserToAddRows = false;
            this.inventoryDataGrid.AllowUserToDeleteRows = false;
            this.inventoryDataGrid.AllowUserToOrderColumns = true;
            this.inventoryDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventoryDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inventoryDataGrid.Location = new System.Drawing.Point(0, 0);
            this.inventoryDataGrid.MultiSelect = false;
            this.inventoryDataGrid.Name = "inventoryDataGrid";
            this.inventoryDataGrid.ReadOnly = true;
            this.inventoryDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.inventoryDataGrid.ShowCellErrors = false;
            this.inventoryDataGrid.ShowCellToolTips = false;
            this.inventoryDataGrid.ShowEditingIcon = false;
            this.inventoryDataGrid.ShowRowErrors = false;
            this.inventoryDataGrid.Size = new System.Drawing.Size(620, 246);
            this.inventoryDataGrid.TabIndex = 1;
            this.inventoryDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inventoryDataGridView_CellClick);
            // 
            // inventoryGridView
            // 
            this.inventoryGridView.AllowUserToAddRows = false;
            this.inventoryGridView.AllowUserToDeleteRows = false;
            this.inventoryGridView.AllowUserToOrderColumns = true;
            this.inventoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventoryGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inventoryGridView.Location = new System.Drawing.Point(0, 0);
            this.inventoryGridView.Name = "inventoryGridView";
            this.inventoryGridView.ReadOnly = true;
            this.inventoryGridView.Size = new System.Drawing.Size(620, 246);
            this.inventoryGridView.TabIndex = 0;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(Laboration_4.Product);
            // 
            // itemNumberErrorProvider
            // 
            this.itemNumberErrorProvider.ContainerControl = this;
            // 
            // priceErrorProvider
            // 
            this.priceErrorProvider.ContainerControl = this;
            // 
            // quantityErrorProvider
            // 
            this.quantityErrorProvider.ContainerControl = this;
            // 
            // playtimeErrorProvider
            // 
            this.playtimeErrorProvider.ContainerControl = this;
            // 
            // ManageInventoryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainSplitContainer);
            this.Name = "ManageInventoryControl";
            this.Size = new System.Drawing.Size(620, 386);
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            this.infoTableLayoutPanel.ResumeLayout(false);
            this.infoTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemNumberErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playtimeErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.DataGridView inventoryGridView;
        private System.Windows.Forms.DataGridView inventoryDataGrid;
        private System.Windows.Forms.TableLayoutPanel infoTableLayoutPanel;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label itemNrLabel;
        private System.Windows.Forms.Label namLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.TextBox itemNrTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox data1TextBox;
        private System.Windows.Forms.TextBox data2TextBox;
        private System.Windows.Forms.TextBox data3TextBox;
        private System.Windows.Forms.TextBox data4TextBox;
        private System.Windows.Forms.Button buttonAddInventory;
        private System.Windows.Forms.Button buttonRemoveInventory;
        private System.Windows.Forms.Button buttonUpdateInventory;
        private System.Windows.Forms.Label data1Label;
        private System.Windows.Forms.Label data2Label;
        private System.Windows.Forms.Label data3Label;
        private System.Windows.Forms.Label data4Label;
        private System.Windows.Forms.Button buttonClearInventory;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.ErrorProvider itemNumberErrorProvider;
        private System.Windows.Forms.ErrorProvider priceErrorProvider;
        private System.Windows.Forms.ErrorProvider quantityErrorProvider;
        private System.Windows.Forms.ErrorProvider playtimeErrorProvider;
    }
}
