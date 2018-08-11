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
    public partial class restockForm : Form {
        public restockForm() {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void frmRestock_Load(object sender, EventArgs e) {
            mainForm.vendingMachine.displayInventory(displayBox);
        }

        private void buttonRestockItem_Click(object sender, EventArgs e) {
            int qty;
            if (int.TryParse(txtQty.Text, out qty)) {
                InventoryItem item = mainForm.vendingMachine.Inventories[displayBox.SelectedIndex];
                mainForm.vendingMachine.restockItem(item, qty);
                mainForm.vendingMachine.displayInventory(displayBox);
            } else {
                MessageBox.Show("You must enter a valid integer.");
                txtQty.Text = "";
                this.ActiveControl = txtQty;
            }
        }
    }
}
