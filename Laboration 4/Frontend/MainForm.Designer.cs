namespace Laboration_4
{
    partial class MainForm
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
            this.MainTab = new System.Windows.Forms.TabControl();
            this.CheckoutTab = new System.Windows.Forms.TabPage();
            this.manageCheckoutControl1 = new Laboration_4.ManageCheckoutControl();
            this.InventoryTab = new System.Windows.Forms.TabPage();
            this.manageInventoryControl = new Laboration_4.ManageInventoryControl();
            this.StatisticsTab = new System.Windows.Forms.TabPage();
            this.MainTab.SuspendLayout();
            this.CheckoutTab.SuspendLayout();
            this.InventoryTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTab
            // 
            this.MainTab.Controls.Add(this.CheckoutTab);
            this.MainTab.Controls.Add(this.InventoryTab);
            this.MainTab.Controls.Add(this.StatisticsTab);
            this.MainTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTab.Location = new System.Drawing.Point(0, 0);
            this.MainTab.Name = "MainTab";
            this.MainTab.SelectedIndex = 0;
            this.MainTab.Size = new System.Drawing.Size(800, 421);
            this.MainTab.TabIndex = 0;
            // 
            // CheckoutTab
            // 
            this.CheckoutTab.Controls.Add(this.manageCheckoutControl1);
            this.CheckoutTab.Location = new System.Drawing.Point(4, 22);
            this.CheckoutTab.Name = "CheckoutTab";
            this.CheckoutTab.Padding = new System.Windows.Forms.Padding(3);
            this.CheckoutTab.Size = new System.Drawing.Size(792, 396);
            this.CheckoutTab.TabIndex = 0;
            this.CheckoutTab.Text = "Kassa";
            this.CheckoutTab.UseVisualStyleBackColor = true;
            // 
            // manageCheckoutControl1
            // 
            this.manageCheckoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.manageCheckoutControl1.Location = new System.Drawing.Point(3, 3);
            this.manageCheckoutControl1.Name = "manageCheckoutControl1";
            this.manageCheckoutControl1.Size = new System.Drawing.Size(786, 390);
            this.manageCheckoutControl1.TabIndex = 0;
            // 
            // InventoryTab
            // 
            this.InventoryTab.Controls.Add(this.manageInventoryControl);
            this.InventoryTab.Location = new System.Drawing.Point(4, 22);
            this.InventoryTab.Name = "InventoryTab";
            this.InventoryTab.Padding = new System.Windows.Forms.Padding(3);
            this.InventoryTab.Size = new System.Drawing.Size(792, 395);
            this.InventoryTab.TabIndex = 1;
            this.InventoryTab.Text = "Lager";
            this.InventoryTab.UseVisualStyleBackColor = true;
            // 
            // manageInventoryControl
            // 
            this.manageInventoryControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.manageInventoryControl.Location = new System.Drawing.Point(3, 3);
            this.manageInventoryControl.Name = "manageInventoryControl";
            this.manageInventoryControl.Size = new System.Drawing.Size(786, 389);
            this.manageInventoryControl.TabIndex = 0;
            // 
            // StatisticsTab
            // 
            this.StatisticsTab.Location = new System.Drawing.Point(4, 22);
            this.StatisticsTab.Name = "StatisticsTab";
            this.StatisticsTab.Size = new System.Drawing.Size(792, 396);
            this.StatisticsTab.TabIndex = 2;
            this.StatisticsTab.Text = "Statistik";
            this.StatisticsTab.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 421);
            this.Controls.Add(this.MainTab);
            this.MinimumSize = new System.Drawing.Size(620, 460);
            this.Name = "MainForm";
            this.Text = "Affärssystemet Mia";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainTab.ResumeLayout(false);
            this.CheckoutTab.ResumeLayout(false);
            this.InventoryTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTab;
        private System.Windows.Forms.TabPage CheckoutTab;
        private System.Windows.Forms.TabPage InventoryTab;
        private System.Windows.Forms.TabPage StatisticsTab;
        private ManageInventoryControl manageInventoryControl;
        private ManageCheckoutControl manageCheckoutControl1;
    }
}

