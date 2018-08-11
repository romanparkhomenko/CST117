namespace inventory
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.btnDriver = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonRestock = new System.Windows.Forms.Button();
            this.buttonDisplay = new System.Windows.Forms.Button();
            this.buttonSearchPrice = new System.Windows.Forms.Button();
            this.buttonSearchByName = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonAdd.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(12, 109);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(129, 53);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Add Item";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonClose.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(12, 283);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(257, 47);
            this.buttonClose.TabIndex = 5;
            this.buttonClose.Text = "Exit Inventory Manager";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // btnDriver
            // 
            this.btnDriver.BackColor = System.Drawing.SystemColors.Menu;
            this.btnDriver.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDriver.Location = new System.Drawing.Point(12, 61);
            this.btnDriver.Name = "btnDriver";
            this.btnDriver.Size = new System.Drawing.Size(257, 42);
            this.btnDriver.TabIndex = 40;
            this.btnDriver.Text = "Generate Starter Inventory";
            this.btnDriver.UseVisualStyleBackColor = false;
            this.btnDriver.Click += new System.EventHandler(this.btnDriver_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonRemove.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemove.Location = new System.Drawing.Point(147, 109);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(122, 53);
            this.buttonRemove.TabIndex = 41;
            this.buttonRemove.Text = "Remove Item";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonRestock
            // 
            this.buttonRestock.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonRestock.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRestock.Location = new System.Drawing.Point(147, 227);
            this.buttonRestock.Name = "buttonRestock";
            this.buttonRestock.Size = new System.Drawing.Size(122, 50);
            this.buttonRestock.TabIndex = 42;
            this.buttonRestock.Text = "Restock";
            this.buttonRestock.UseVisualStyleBackColor = false;
            this.buttonRestock.Click += new System.EventHandler(this.buttonRestock_Click);
            // 
            // buttonDisplay
            // 
            this.buttonDisplay.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonDisplay.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisplay.Location = new System.Drawing.Point(12, 227);
            this.buttonDisplay.Name = "buttonDisplay";
            this.buttonDisplay.Size = new System.Drawing.Size(129, 50);
            this.buttonDisplay.TabIndex = 43;
            this.buttonDisplay.Text = "Display Inventory";
            this.buttonDisplay.UseVisualStyleBackColor = false;
            this.buttonDisplay.Click += new System.EventHandler(this.buttonDisplay_Click);
            // 
            // buttonSearchPrice
            // 
            this.buttonSearchPrice.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonSearchPrice.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchPrice.Location = new System.Drawing.Point(12, 168);
            this.buttonSearchPrice.Name = "buttonSearchPrice";
            this.buttonSearchPrice.Size = new System.Drawing.Size(129, 53);
            this.buttonSearchPrice.TabIndex = 44;
            this.buttonSearchPrice.Text = "Search By Price";
            this.buttonSearchPrice.UseVisualStyleBackColor = false;
            this.buttonSearchPrice.Click += new System.EventHandler(this.buttonSearchPrice_Click);
            // 
            // buttonSearchByName
            // 
            this.buttonSearchByName.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonSearchByName.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchByName.Location = new System.Drawing.Point(147, 168);
            this.buttonSearchByName.Name = "buttonSearchByName";
            this.buttonSearchByName.Size = new System.Drawing.Size(122, 53);
            this.buttonSearchByName.TabIndex = 45;
            this.buttonSearchByName.Text = "Search By Name";
            this.buttonSearchByName.UseVisualStyleBackColor = false;
            this.buttonSearchByName.Click += new System.EventHandler(this.buttonSearchByName_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 22);
            this.label1.TabIndex = 46;
            this.label1.Text = "Vending Machine Manager";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(281, 351);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSearchByName);
            this.Controls.Add(this.buttonSearchPrice);
            this.Controls.Add(this.buttonDisplay);
            this.Controls.Add(this.buttonRestock);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.btnDriver);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonClose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "mainForm";
            this.Text = "Inventory Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button btnDriver;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonRestock;
        private System.Windows.Forms.Button buttonDisplay;
        private System.Windows.Forms.Button buttonSearchPrice;
        private System.Windows.Forms.Button buttonSearchByName;
        private System.Windows.Forms.Label label1;
    }
}

