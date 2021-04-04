
namespace Laboration_4
{
    partial class InventoryMain
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
            this.InventoryView = new System.Windows.Forms.DataGridView();
            this.InventorySplit = new System.Windows.Forms.SplitContainer();
            this.InventoryMenuSplitContainer = new System.Windows.Forms.SplitContainer();
            this.typeGroupBox = new System.Windows.Forms.GroupBox();
            this.Alla = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.InfoLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.data3TextBox = new System.Windows.Forms.TextBox();
            this.data2TextBox = new System.Windows.Forms.TextBox();
            this.data1TextBox = new System.Windows.Forms.TextBox();
            this.data4TextBox = new System.Windows.Forms.TextBox();
            this.data4Label = new System.Windows.Forms.Label();
            this.data3Label = new System.Windows.Forms.Label();
            this.data2Label = new System.Windows.Forms.Label();
            this.data1Label = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.itemNumberTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.itemNumberLabel = new System.Windows.Forms.Label();
            this.buttonInventoryAdd = new System.Windows.Forms.Button();
            this.buttonInventoryRemove = new System.Windows.Forms.Button();
            this.buttonInventoryUpdate = new System.Windows.Forms.Button();
            this.buttonInventorySearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventorySplit)).BeginInit();
            this.InventorySplit.Panel1.SuspendLayout();
            this.InventorySplit.Panel2.SuspendLayout();
            this.InventorySplit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryMenuSplitContainer)).BeginInit();
            this.InventoryMenuSplitContainer.Panel1.SuspendLayout();
            this.InventoryMenuSplitContainer.Panel2.SuspendLayout();
            this.InventoryMenuSplitContainer.SuspendLayout();
            this.typeGroupBox.SuspendLayout();
            this.InfoLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // InventoryView
            // 
            this.InventoryView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InventoryView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InventoryView.Location = new System.Drawing.Point(0, 0);
            this.InventoryView.Name = "InventoryView";
            this.InventoryView.Size = new System.Drawing.Size(814, 370);
            this.InventoryView.TabIndex = 0;
            this.InventoryView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InventoryView_CellContentClick);
            // 
            // InventorySplit
            // 
            this.InventorySplit.Dock = System.Windows.Forms.DockStyle.Top;
            this.InventorySplit.Location = new System.Drawing.Point(0, 0);
            this.InventorySplit.Name = "InventorySplit";
            this.InventorySplit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // InventorySplit.Panel1
            // 
            this.InventorySplit.Panel1.Controls.Add(this.InventoryMenuSplitContainer);
            // 
            // InventorySplit.Panel2
            // 
            this.InventorySplit.Panel2.Controls.Add(this.InventoryView);
            this.InventorySplit.Size = new System.Drawing.Size(814, 514);
            this.InventorySplit.SplitterDistance = 140;
            this.InventorySplit.TabIndex = 1;
            // 
            // InventoryMenuSplitContainer
            // 
            this.InventoryMenuSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InventoryMenuSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.InventoryMenuSplitContainer.Name = "InventoryMenuSplitContainer";
            // 
            // InventoryMenuSplitContainer.Panel1
            // 
            this.InventoryMenuSplitContainer.Panel1.Controls.Add(this.typeGroupBox);
            // 
            // InventoryMenuSplitContainer.Panel2
            // 
            this.InventoryMenuSplitContainer.Panel2.Controls.Add(this.InfoLayoutPanel);
            this.InventoryMenuSplitContainer.Size = new System.Drawing.Size(814, 140);
            this.InventoryMenuSplitContainer.SplitterDistance = 55;
            this.InventoryMenuSplitContainer.TabIndex = 2;
            // 
            // typeGroupBox
            // 
            this.typeGroupBox.Controls.Add(this.Alla);
            this.typeGroupBox.Controls.Add(this.radioButton3);
            this.typeGroupBox.Controls.Add(this.radioButton2);
            this.typeGroupBox.Controls.Add(this.radioButton1);
            this.typeGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.typeGroupBox.Location = new System.Drawing.Point(0, 0);
            this.typeGroupBox.Name = "typeGroupBox";
            this.typeGroupBox.Size = new System.Drawing.Size(55, 140);
            this.typeGroupBox.TabIndex = 2;
            this.typeGroupBox.TabStop = false;
            this.typeGroupBox.Text = "Typ";
            // 
            // Alla
            // 
            this.Alla.AutoSize = true;
            this.Alla.Location = new System.Drawing.Point(4, 27);
            this.Alla.Name = "Alla";
            this.Alla.Size = new System.Drawing.Size(42, 17);
            this.Alla.TabIndex = 3;
            this.Alla.TabStop = true;
            this.Alla.Text = "Alla";
            this.Alla.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(4, 96);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(48, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "DVD";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(4, 73);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(46, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Spel";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(4, 50);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(44, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Bok";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // InfoLayoutPanel
            // 
            this.InfoLayoutPanel.ColumnCount = 5;
            this.InfoLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.InfoLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.InfoLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.InfoLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.InfoLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.InfoLayoutPanel.Controls.Add(this.data3TextBox, 3, 2);
            this.InfoLayoutPanel.Controls.Add(this.data2TextBox, 3, 1);
            this.InfoLayoutPanel.Controls.Add(this.data1TextBox, 3, 0);
            this.InfoLayoutPanel.Controls.Add(this.data4TextBox, 3, 3);
            this.InfoLayoutPanel.Controls.Add(this.data4Label, 2, 3);
            this.InfoLayoutPanel.Controls.Add(this.data3Label, 2, 2);
            this.InfoLayoutPanel.Controls.Add(this.data2Label, 2, 1);
            this.InfoLayoutPanel.Controls.Add(this.data1Label, 2, 0);
            this.InfoLayoutPanel.Controls.Add(this.quantityLabel, 0, 3);
            this.InfoLayoutPanel.Controls.Add(this.priceTextBox, 1, 2);
            this.InfoLayoutPanel.Controls.Add(this.nameTextBox, 1, 1);
            this.InfoLayoutPanel.Controls.Add(this.nameLabel, 0, 1);
            this.InfoLayoutPanel.Controls.Add(this.itemNumberTextBox, 1, 0);
            this.InfoLayoutPanel.Controls.Add(this.quantityTextBox, 1, 3);
            this.InfoLayoutPanel.Controls.Add(this.priceLabel, 0, 2);
            this.InfoLayoutPanel.Controls.Add(this.itemNumberLabel, 0, 0);
            this.InfoLayoutPanel.Controls.Add(this.buttonInventoryAdd, 4, 0);
            this.InfoLayoutPanel.Controls.Add(this.buttonInventoryRemove, 4, 1);
            this.InfoLayoutPanel.Controls.Add(this.buttonInventoryUpdate, 4, 2);
            this.InfoLayoutPanel.Controls.Add(this.buttonInventorySearch, 4, 3);
            this.InfoLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.InfoLayoutPanel.Name = "InfoLayoutPanel";
            this.InfoLayoutPanel.RowCount = 4;
            this.InfoLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.InfoLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.InfoLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.InfoLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.InfoLayoutPanel.Size = new System.Drawing.Size(755, 140);
            this.InfoLayoutPanel.TabIndex = 1;
            // 
            // data3TextBox
            // 
            this.data3TextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.data3TextBox.Enabled = false;
            this.data3TextBox.Location = new System.Drawing.Point(455, 82);
            this.data3TextBox.Name = "data3TextBox";
            this.data3TextBox.Size = new System.Drawing.Size(220, 20);
            this.data3TextBox.TabIndex = 37;
            // 
            // data2TextBox
            // 
            this.data2TextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.data2TextBox.Enabled = false;
            this.data2TextBox.Location = new System.Drawing.Point(455, 47);
            this.data2TextBox.Name = "data2TextBox";
            this.data2TextBox.Size = new System.Drawing.Size(220, 20);
            this.data2TextBox.TabIndex = 36;
            // 
            // data1TextBox
            // 
            this.data1TextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.data1TextBox.Enabled = false;
            this.data1TextBox.Location = new System.Drawing.Point(455, 12);
            this.data1TextBox.Name = "data1TextBox";
            this.data1TextBox.Size = new System.Drawing.Size(220, 20);
            this.data1TextBox.TabIndex = 35;
            // 
            // data4TextBox
            // 
            this.data4TextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.data4TextBox.Enabled = false;
            this.data4TextBox.Location = new System.Drawing.Point(455, 117);
            this.data4TextBox.Name = "data4TextBox";
            this.data4TextBox.Size = new System.Drawing.Size(220, 20);
            this.data4TextBox.TabIndex = 33;
            // 
            // data4Label
            // 
            this.data4Label.AutoSize = true;
            this.data4Label.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.data4Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data4Label.Location = new System.Drawing.Point(342, 123);
            this.data4Label.Name = "data4Label";
            this.data4Label.Size = new System.Drawing.Size(107, 17);
            this.data4Label.TabIndex = 32;
            // 
            // data3Label
            // 
            this.data3Label.AutoSize = true;
            this.data3Label.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.data3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data3Label.Location = new System.Drawing.Point(342, 88);
            this.data3Label.Name = "data3Label";
            this.data3Label.Size = new System.Drawing.Size(107, 17);
            this.data3Label.TabIndex = 31;
            // 
            // data2Label
            // 
            this.data2Label.AutoSize = true;
            this.data2Label.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.data2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data2Label.Location = new System.Drawing.Point(342, 53);
            this.data2Label.Name = "data2Label";
            this.data2Label.Size = new System.Drawing.Size(107, 17);
            this.data2Label.TabIndex = 30;
            // 
            // data1Label
            // 
            this.data1Label.AutoSize = true;
            this.data1Label.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.data1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data1Label.Location = new System.Drawing.Point(342, 18);
            this.data1Label.Name = "data1Label";
            this.data1Label.Size = new System.Drawing.Size(107, 17);
            this.data1Label.TabIndex = 25;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.quantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLabel.Location = new System.Drawing.Point(3, 123);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(107, 17);
            this.quantityLabel.TabIndex = 24;
            this.quantityLabel.Text = "Antal";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.priceTextBox.Location = new System.Drawing.Point(116, 82);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(220, 20);
            this.priceTextBox.TabIndex = 23;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.nameTextBox.Location = new System.Drawing.Point(116, 47);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(220, 20);
            this.nameTextBox.TabIndex = 22;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(3, 53);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(107, 17);
            this.nameLabel.TabIndex = 21;
            this.nameLabel.Text = "Name";
            // 
            // itemNumberTextBox
            // 
            this.itemNumberTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.itemNumberTextBox.Location = new System.Drawing.Point(116, 12);
            this.itemNumberTextBox.Name = "itemNumberTextBox";
            this.itemNumberTextBox.Size = new System.Drawing.Size(220, 20);
            this.itemNumberTextBox.TabIndex = 20;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.quantityTextBox.Location = new System.Drawing.Point(116, 117);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(220, 20);
            this.quantityTextBox.TabIndex = 13;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(3, 88);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(107, 17);
            this.priceLabel.TabIndex = 8;
            this.priceLabel.Text = "Pris";
            // 
            // itemNumberLabel
            // 
            this.itemNumberLabel.AutoSize = true;
            this.itemNumberLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.itemNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemNumberLabel.Location = new System.Drawing.Point(3, 18);
            this.itemNumberLabel.Name = "itemNumberLabel";
            this.itemNumberLabel.Size = new System.Drawing.Size(107, 17);
            this.itemNumberLabel.TabIndex = 0;
            this.itemNumberLabel.Text = "Varunummer";
            // 
            // buttonInventoryAdd
            // 
            this.buttonInventoryAdd.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonInventoryAdd.Location = new System.Drawing.Point(686, 3);
            this.buttonInventoryAdd.Name = "buttonInventoryAdd";
            this.buttonInventoryAdd.Size = new System.Drawing.Size(66, 29);
            this.buttonInventoryAdd.TabIndex = 46;
            this.buttonInventoryAdd.Text = "Lägg till";
            this.buttonInventoryAdd.UseVisualStyleBackColor = true;
            // 
            // buttonInventoryRemove
            // 
            this.buttonInventoryRemove.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonInventoryRemove.Location = new System.Drawing.Point(686, 38);
            this.buttonInventoryRemove.Name = "buttonInventoryRemove";
            this.buttonInventoryRemove.Size = new System.Drawing.Size(66, 29);
            this.buttonInventoryRemove.TabIndex = 47;
            this.buttonInventoryRemove.Text = "Ta bort";
            this.buttonInventoryRemove.UseVisualStyleBackColor = true;
            // 
            // buttonInventoryUpdate
            // 
            this.buttonInventoryUpdate.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonInventoryUpdate.Location = new System.Drawing.Point(686, 73);
            this.buttonInventoryUpdate.Name = "buttonInventoryUpdate";
            this.buttonInventoryUpdate.Size = new System.Drawing.Size(66, 29);
            this.buttonInventoryUpdate.TabIndex = 48;
            this.buttonInventoryUpdate.Text = "Uppdatera";
            this.buttonInventoryUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonInventorySearch
            // 
            this.buttonInventorySearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonInventorySearch.Location = new System.Drawing.Point(686, 108);
            this.buttonInventorySearch.Name = "buttonInventorySearch";
            this.buttonInventorySearch.Size = new System.Drawing.Size(66, 29);
            this.buttonInventorySearch.TabIndex = 49;
            this.buttonInventorySearch.Text = "Sök";
            this.buttonInventorySearch.UseVisualStyleBackColor = true;
            // 
            // InventoryMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.InventorySplit);
            this.Name = "InventoryMain";
            this.Size = new System.Drawing.Size(814, 514);
            ((System.ComponentModel.ISupportInitialize)(this.InventoryView)).EndInit();
            this.InventorySplit.Panel1.ResumeLayout(false);
            this.InventorySplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InventorySplit)).EndInit();
            this.InventorySplit.ResumeLayout(false);
            this.InventoryMenuSplitContainer.Panel1.ResumeLayout(false);
            this.InventoryMenuSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InventoryMenuSplitContainer)).EndInit();
            this.InventoryMenuSplitContainer.ResumeLayout(false);
            this.typeGroupBox.ResumeLayout(false);
            this.typeGroupBox.PerformLayout();
            this.InfoLayoutPanel.ResumeLayout(false);
            this.InfoLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView InventoryView;
        private System.Windows.Forms.SplitContainer InventorySplit;
        private System.Windows.Forms.SplitContainer InventoryMenuSplitContainer;
        private System.Windows.Forms.GroupBox typeGroupBox;
        private System.Windows.Forms.RadioButton Alla;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TableLayoutPanel InfoLayoutPanel;
        private System.Windows.Forms.TextBox data3TextBox;
        private System.Windows.Forms.TextBox data2TextBox;
        private System.Windows.Forms.TextBox data1TextBox;
        private System.Windows.Forms.TextBox data4TextBox;
        private System.Windows.Forms.Label data4Label;
        private System.Windows.Forms.Label data3Label;
        private System.Windows.Forms.Label data2Label;
        private System.Windows.Forms.Label data1Label;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox itemNumberTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label itemNumberLabel;
        private System.Windows.Forms.Button buttonInventoryAdd;
        private System.Windows.Forms.Button buttonInventoryRemove;
        private System.Windows.Forms.Button buttonInventoryUpdate;
        private System.Windows.Forms.Button buttonInventorySearch;
    }
}
