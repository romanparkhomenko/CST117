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
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void addItemButton_Click(object sender, EventArgs e) {
            //Initialize variables
            string name;
            decimal price;
            int quantity;
            string expiration;

            // Get variable from form
            name = itemNameTextbox.Text;
            price = Convert.ToDecimal(itemPriceTextbox.Text);
            quantity = Convert.ToInt16(itemQuantityTextbox.Text);
            expiration = Convert.ToString(itemExpirationTextbox.Text);
            InventoryItem item1 = new InventoryItem(name, price, quantity, expiration);
            MessageBox.Show(string.Format("The new item added is {0}, {1}, {2}, {3} and there are a total of {4} items", item1.ItemName, item1.Price, item1.Quantity, item1.Expiration));
        }

        private void driverButton_Click(object sender, EventArgs e) {
            // Create inventory objects
            InventoryItem item1 = new InventoryItem("Lay's Chips", 3.99m, 10, "05/30/2019");
            InventoryItem item2 = new InventoryItem("AA Batteries", 5.99m, 20, "07/20/2025");
            InventoryItem item3 = new InventoryItem("Gummi Bears", 2.99m, 5, "08/12/2012");
            InventoryItem item4 = new InventoryItem("Rubber Bands", 7.00m, 7, "08/30/2018");
            InventoryItem item5 = new InventoryItem("Pens", 8.00m, 13, "09/04/2099");
            InventoryItem item6 = new InventoryItem("Coca-Cola", 1.50m, 16, "09/30/2015");
            InventoryItem item7 = new InventoryItem("Pepsi", 1.75m, 17, "08/30/2011");

            //Initilize inventory manager object
            InventoryManager vendingMachine = new InventoryManager();

            //Add items objects to inventory manager class
            vendingMachine.addItem(item1);
            vendingMachine.addItem(item2);
            vendingMachine.addItem(item3);
            vendingMachine.addItem(item4);
            vendingMachine.addItem(item5);
            vendingMachine.addItem(item6);
            vendingMachine.addItem(item7);

            //Display items after they were added
            Console.WriteLine("*****Display current inventory*****");
            vendingMachine.displayInventory();

            //Remove items from the inventory manager
            vendingMachine.removeItem(item5);
            vendingMachine.removeItem(item6);
            vendingMachine.removeItem(item7);

            Console.WriteLine("\n*****Display inventory after removing objects*****");
            vendingMachine.displayInventory();

            //Restock items method
            vendingMachine.restockItem(item2, 15);
            vendingMachine.restockItem(item4, 5);
            vendingMachine.restockItem(item6, 4);

            Console.WriteLine("\n*****Display inventory after restocking*****");
            vendingMachine.displayInventory();
        }
    }
}
