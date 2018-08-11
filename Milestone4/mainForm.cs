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
    public partial class mainForm : Form {
        public static InventoryManager vendingMachine { get; set; }

        public mainForm() {
            InitializeComponent();
            vendingMachine = new InventoryManager();
        }

        private void buttonClose_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e) {
            addItemForm launchInventoryForm = new addItemForm();
            launchInventoryForm.ShowDialog();
        }

        private void btnDriver_Click(object sender, EventArgs e) {
            InventoryItem item1 = new InventoryItem("Lays Chips", 3.99m, 15, "Food", "09/30/2019");
            mainForm.vendingMachine.addItem(item1);
            InventoryItem item2 = new InventoryItem("AA Batteries", 5.99m, 25, "Utility", "01/01/2099");
            mainForm.vendingMachine.addItem(item2);
            InventoryItem item3 = new InventoryItem("Gummi Bears", 6.00m, 23, "Food", "02/21/2017");
            mainForm.vendingMachine.addItem(item3);
            InventoryItem item4 = new InventoryItem("Rubber Bands", 7.99m, 30, "Utiity", "06/07/2020");
            mainForm.vendingMachine.addItem(item4);
            InventoryItem item5 = new InventoryItem("Pens", 8.00m, 8, "Utility", "05/20/2029");
            mainForm.vendingMachine.addItem(item5);
            InventoryItem item6 = new InventoryItem("Coca-Cola", 1.50m, 11, "Beverage", "03/25/2025");
            mainForm.vendingMachine.addItem(item6);
            InventoryItem item7 = new InventoryItem("Pepsi", 1.75m, 35, "Beverage", "04/11/2026");
            mainForm.vendingMachine.addItem(item7);
            MessageBox.Show("Starter items added to inventory.");
        }

        private void buttonRemove_Click(object sender, EventArgs e) {
            removeItemForm launchInventoryForm = new removeItemForm();
            launchInventoryForm.ShowDialog();
        }

        private void buttonRestock_Click(object sender, EventArgs e) {
            restockForm launchInventoryForm = new restockForm();
            launchInventoryForm.ShowDialog();
        }

        private void buttonSearchPrice_Click(object sender, EventArgs e) {
            searchPriceForm launchInventoryForm = new searchPriceForm();
            launchInventoryForm.ShowDialog();
        }

        private void buttonSearchByName_Click(object sender, EventArgs e) {
            searchNameForm launchInventoryForm = new searchNameForm();
            launchInventoryForm.ShowDialog();
        }

        private void buttonDisplay_Click(object sender, EventArgs e) {
            displayForm launchInventoryForm = new displayForm();
            launchInventoryForm.ShowDialog();
        }
    }
}
