
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
            this.itemNumberSearchLabel = new System.Windows.Forms.Label();
            this.itemNumberSearchextBox = new System.Windows.Forms.TextBox();
            this.returnRadioButton = new System.Windows.Forms.RadioButton();
            this.radioButtonBuy = new System.Windows.Forms.RadioButton();
            this.checkutLabel = new System.Windows.Forms.Label();
            this.basketDataGridView = new System.Windows.Forms.DataGridView();
            this.buttonRemoveCheckout = new System.Windows.Forms.Button();
            this.buttonAddCheckout = new System.Windows.Forms.Button();
            this.buttonBuyCheckout = new System.Windows.Forms.Button();
            this.cartLabel = new System.Windows.Forms.Label();
            this.checkoutDataGrid = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.checkoutDataGrid)).BeginInit();
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
            // 
            // MenuSplitContainer
            // 
            this.MenuSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.MenuSplitContainer.Name = "MenuSplitContainer";
            // 
            // MenuSplitContainer.Panel1
            // 
            this.MenuSplitContainer.Panel1.Controls.Add(this.itemNumberSearchLabel);
            this.MenuSplitContainer.Panel1.Controls.Add(this.itemNumberSearchextBox);
            this.MenuSplitContainer.Panel1.Controls.Add(this.returnRadioButton);
            this.MenuSplitContainer.Panel1.Controls.Add(this.radioButtonBuy);
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
            this.MenuSplitContainer.TabIndex = 0;
            // 
            // itemNumberSearchLabel
            // 
            this.itemNumberSearchLabel.AutoSize = true;
            this.itemNumberSearchLabel.Location = new System.Drawing.Point(4, 79);
            this.itemNumberSearchLabel.Name = "itemNumberSearchLabel";
            this.itemNumberSearchLabel.Size = new System.Drawing.Size(66, 13);
            this.itemNumberSearchLabel.TabIndex = 4;
            this.itemNumberSearchLabel.Text = "Varunummer";
            // 
            // itemNumberSearchextBox
            // 
            this.itemNumberSearchextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemNumberSearchextBox.Location = new System.Drawing.Point(7, 95);
            this.itemNumberSearchextBox.Name = "itemNumberSearchextBox";
            this.itemNumberSearchextBox.Size = new System.Drawing.Size(87, 20);
            this.itemNumberSearchextBox.TabIndex = 3;
            this.itemNumberSearchextBox.TextChanged += new System.EventHandler(this.itemNumberSearchextBox_TextChanged);
            // 
            // returnRadioButton
            // 
            this.returnRadioButton.AutoSize = true;
            this.returnRadioButton.Location = new System.Drawing.Point(7, 56);
            this.returnRadioButton.Name = "returnRadioButton";
            this.returnRadioButton.Size = new System.Drawing.Size(62, 17);
            this.returnRadioButton.TabIndex = 2;
            this.returnRadioButton.Text = "Återköp";
            this.returnRadioButton.UseVisualStyleBackColor = true;
            this.returnRadioButton.CheckedChanged += new System.EventHandler(this.returnRadioButton_CheckedChanged);
            // 
            // radioButtonBuy
            // 
            this.radioButtonBuy.AutoSize = true;
            this.radioButtonBuy.Checked = true;
            this.radioButtonBuy.Location = new System.Drawing.Point(7, 30);
            this.radioButtonBuy.Name = "radioButtonBuy";
            this.radioButtonBuy.Size = new System.Drawing.Size(44, 17);
            this.radioButtonBuy.TabIndex = 1;
            this.radioButtonBuy.TabStop = true;
            this.radioButtonBuy.Text = "Köp";
            this.radioButtonBuy.UseVisualStyleBackColor = true;
            this.radioButtonBuy.CheckedChanged += new System.EventHandler(this.radioButtonBuy_CheckedChanged);
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
            this.basketDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            this.basketDataGridView.TabIndex = 18;
            // 
            // buttonRemoveCheckout
            // 
            this.buttonRemoveCheckout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemoveCheckout.Location = new System.Drawing.Point(424, 57);
            this.buttonRemoveCheckout.Name = "buttonRemoveCheckout";
            this.buttonRemoveCheckout.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveCheckout.TabIndex = 17;
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
            this.buttonAddCheckout.TabIndex = 16;
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
            this.buttonBuyCheckout.TabIndex = 14;
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
            this.checkoutDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            this.checkoutDataGrid.TabIndex = 2;
            this.checkoutDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.checkoutDataGrid_CellClick);
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
            ((System.ComponentModel.ISupportInitialize)(this.checkoutDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemNumberErrorProviderAdd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.SplitContainer MenuSplitContainer;
        private System.Windows.Forms.Label itemNumberSearchLabel;
        private System.Windows.Forms.TextBox itemNumberSearchextBox;
        private System.Windows.Forms.RadioButton returnRadioButton;
        private System.Windows.Forms.RadioButton radioButtonBuy;
        private System.Windows.Forms.Label checkutLabel;
        private System.Windows.Forms.Label cartLabel;
        private System.Windows.Forms.Button buttonBuyCheckout;
        private System.Windows.Forms.DataGridView checkoutDataGrid;
        private System.Windows.Forms.Button buttonRemoveCheckout;
        private System.Windows.Forms.Button buttonAddCheckout;
        private System.Windows.Forms.DataGridView basketDataGridView;
        private System.Windows.Forms.ErrorProvider itemNumberErrorProviderAdd;
    }
}
