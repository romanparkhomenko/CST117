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
    public partial class searchPriceForm : Form {
        public searchPriceForm() {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void frmSearchPrice_Load(object sender, EventArgs e) {
            mainForm.vendingMachine.displayInventory(displayBox);
        }

        private void buttonSearch_Click(object sender, EventArgs e) {
            decimal price;
            if (decimal.TryParse(txtPrice.Text, out price)) {
                mainForm.vendingMachine.searchPrice(price, displayBox);
            } else {
                MessageBox.Show("You must enter a valid decimal.");
                txtPrice.Text = "";
                this.ActiveControl = txtPrice;
            }
        }
    }
}
