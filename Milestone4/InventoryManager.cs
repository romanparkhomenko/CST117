/* Roman Parkhomenko CST117 08/11/2018
 * Inventory Item Class for the inventory Management 
 * Project. The purpose of this class is to manage inventory 
 * objects with such methods as adding, removing, searching,
 * restocking, and displaying inventory.
 * All work is my own.
 *  */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory {
    public class InventoryManager {

        // initialize list for inventoryManager
        private List<InventoryItem> inventoryManagerList = new List<InventoryItem>();

        // addItem method
        public void addItem(InventoryItem item) {
            this.inventoryManagerList.Add(item);
        } 

        // removeItem method
        public void removeItem(int index) {
            if (index >= 0)
            this.inventoryManagerList.RemoveAt(index);
        } 

        // restockItem method
        public void restockItem(InventoryItem item, int quantity) {
            item.Quantity += quantity; 
        } 

        public List<InventoryItem> Inventories {
            get { return this.inventoryManagerList; }
        }

        /*To display inventory we make sure the box is empty and then loop through list to populate items*/
        public void displayInventory(ListBox displayBox) {
            displayBox.Items.Clear();
            foreach(InventoryItem product in this.inventoryManagerList) {
                displayBox.Items.Add(product.Name + ", " + product.Price + ", " + product.Quantity + ", " + product.ItemType + ", " + product.Expiration);
            } 
        } 

        // Search by item name
        public void searchName(string objectName, ListBox displayBox) {
            displayBox.Items.Clear();

            foreach(InventoryItem product in this.inventoryManagerList) {   
                if (String.Equals(product.Name, objectName, StringComparison.OrdinalIgnoreCase)) {
                    displayBox.Items.Add(product.Name + ", " + product.Price + ", " + product.Quantity + ", " + product.ItemType + ", " + product.Expiration);
                } 
            } 
        } 

        // Search by item price
        public void searchPrice(decimal objectPrice, ListBox displayBox) {
            displayBox.Items.Clear();

            foreach (InventoryItem product in this.inventoryManagerList) {
                if (product.Price == objectPrice) {
                    displayBox.Items.Add(product.Name + ", " + product.Price + ", " + product.Quantity + ", " + product.ItemType + ", " + product.Expiration);
                } 
            } 
        } 

    } 
} 
