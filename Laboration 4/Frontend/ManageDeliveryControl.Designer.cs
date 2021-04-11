
namespace Laboration_4
{
    partial class ManageDeliveryControl
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
            this.deliveryLabel = new System.Windows.Forms.Label();
            this.deliveryTextBox = new System.Windows.Forms.RichTextBox();
            this.addDeliverButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.infoTextLabel = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // deliveryLabel
            // 
            this.deliveryLabel.AutoSize = true;
            this.deliveryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliveryLabel.Location = new System.Drawing.Point(14, 13);
            this.deliveryLabel.Name = "deliveryLabel";
            this.deliveryLabel.Size = new System.Drawing.Size(82, 20);
            this.deliveryLabel.TabIndex = 0;
            this.deliveryLabel.Text = "Leverans";
            // 
            // deliveryTextBox
            // 
            this.deliveryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deliveryTextBox.Location = new System.Drawing.Point(18, 78);
            this.deliveryTextBox.Name = "deliveryTextBox";
            this.deliveryTextBox.Size = new System.Drawing.Size(491, 292);
            this.deliveryTextBox.TabIndex = 1;
            this.deliveryTextBox.Text = "";
            // 
            // addDeliverButton
            // 
            this.addDeliverButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addDeliverButton.Location = new System.Drawing.Point(528, 78);
            this.addDeliverButton.Name = "addDeliverButton";
            this.addDeliverButton.Size = new System.Drawing.Size(75, 23);
            this.addDeliverButton.TabIndex = 2;
            this.addDeliverButton.Text = "Lägg till leverans";
            this.addDeliverButton.UseVisualStyleBackColor = true;
            this.addDeliverButton.Click += new System.EventHandler(this.addDeliverButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clearButton.Location = new System.Drawing.Point(528, 107);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Rensa";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // infoTextLabel
            // 
            this.infoTextLabel.AutoSize = true;
            this.infoTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoTextLabel.Location = new System.Drawing.Point(15, 58);
            this.infoTextLabel.Name = "infoTextLabel";
            this.infoTextLabel.Size = new System.Drawing.Size(137, 17);
            this.infoTextLabel.TabIndex = 4;
            this.infoTextLabel.Text = "Artikelnummer, antal";
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(15, 33);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(419, 13);
            this.infoLabel.TabIndex = 5;
            this.infoLabel.Text = "För att regristrera en leverans behöver du skriva ett artikelnummer, antal (323,5" +
    ") per rad.";
            // 
            // ManageDeliveryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.infoTextLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.addDeliverButton);
            this.Controls.Add(this.deliveryTextBox);
            this.Controls.Add(this.deliveryLabel);
            this.Name = "ManageDeliveryControl";
            this.Size = new System.Drawing.Size(620, 386);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label deliveryLabel;
        private System.Windows.Forms.RichTextBox deliveryTextBox;
        private System.Windows.Forms.Button addDeliverButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label infoTextLabel;
        private System.Windows.Forms.Label infoLabel;
    }
}
