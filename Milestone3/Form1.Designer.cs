namespace inventory {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.itemNameTextbox = new System.Windows.Forms.TextBox();
            this.itemPriceTextbox = new System.Windows.Forms.TextBox();
            this.itemQuantityTextbox = new System.Windows.Forms.TextBox();
            this.itemExpirationTextbox = new System.Windows.Forms.TextBox();
            this.addItemButton = new System.Windows.Forms.Button();
            this.driverButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Expiration Date:";
            // 
            // itemNameTextbox
            // 
            this.itemNameTextbox.Location = new System.Drawing.Point(145, 38);
            this.itemNameTextbox.Name = "itemNameTextbox";
            this.itemNameTextbox.Size = new System.Drawing.Size(222, 20);
            this.itemNameTextbox.TabIndex = 4;
            // 
            // itemPriceTextbox
            // 
            this.itemPriceTextbox.Location = new System.Drawing.Point(145, 68);
            this.itemPriceTextbox.Name = "itemPriceTextbox";
            this.itemPriceTextbox.Size = new System.Drawing.Size(222, 20);
            this.itemPriceTextbox.TabIndex = 5;
            // 
            // itemQuantityTextbox
            // 
            this.itemQuantityTextbox.Location = new System.Drawing.Point(145, 97);
            this.itemQuantityTextbox.Name = "itemQuantityTextbox";
            this.itemQuantityTextbox.Size = new System.Drawing.Size(222, 20);
            this.itemQuantityTextbox.TabIndex = 6;
            // 
            // itemExpirationTextbox
            // 
            this.itemExpirationTextbox.Location = new System.Drawing.Point(145, 126);
            this.itemExpirationTextbox.Name = "itemExpirationTextbox";
            this.itemExpirationTextbox.Size = new System.Drawing.Size(222, 20);
            this.itemExpirationTextbox.TabIndex = 7;
            // 
            // addItemButton
            // 
            this.addItemButton.Location = new System.Drawing.Point(262, 163);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(105, 38);
            this.addItemButton.TabIndex = 8;
            this.addItemButton.Text = "Add Item";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // driverButton
            // 
            this.driverButton.BackColor = System.Drawing.Color.SkyBlue;
            this.driverButton.Location = new System.Drawing.Point(145, 163);
            this.driverButton.Name = "driverButton";
            this.driverButton.Size = new System.Drawing.Size(98, 38);
            this.driverButton.TabIndex = 9;
            this.driverButton.Text = "Driver Button";
            this.driverButton.UseVisualStyleBackColor = false;
            this.driverButton.Click += new System.EventHandler(this.driverButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 218);
            this.Controls.Add(this.driverButton);
            this.Controls.Add(this.addItemButton);
            this.Controls.Add(this.itemExpirationTextbox);
            this.Controls.Add(this.itemQuantityTextbox);
            this.Controls.Add(this.itemPriceTextbox);
            this.Controls.Add(this.itemNameTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Inventory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox itemNameTextbox;
        private System.Windows.Forms.TextBox itemPriceTextbox;
        private System.Windows.Forms.TextBox itemQuantityTextbox;
        private System.Windows.Forms.TextBox itemExpirationTextbox;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.Button driverButton;
    }
}