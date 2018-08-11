using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory {

    public partial class addItemForm : Form {
        public addItemForm() {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e) {
            InventoryAddItem();
        }

        private void buttonClose_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void InventoryAddItem() {

            string name;
            decimal price;
            int quantity;
            string itemType;
            string expiration;

            // Get new item data from form
            name = txtName.Text;
            quantity = Convert.ToInt32(txtQuantity.Text);
            itemType = txtType.Text;
            expiration = txtExpiration.Text;

            if (decimal.TryParse(txtPrice.Text, out price)) {
                InventoryItem item1 = new InventoryItem(name, price, quantity, itemType, expiration);
                mainForm.vendingMachine.addItem(item1);
                MessageBox.Show(string.Format("New Item Added: {0}, {1}, {2}, {3}, {4}", item1.Name, item1.Price, item1.Quantity, item1.ItemType, item1.Expiration));
            } else {
                MessageBox.Show("You must enter a valid decimal.");
                txtPrice.Text = "";
                this.ActiveControl = txtPrice;
            }
        }

        
    }
}
