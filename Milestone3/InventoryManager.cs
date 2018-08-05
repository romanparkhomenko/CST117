using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using inventory;

namespace inventory {
    class InventoryManager {
        // Initilize inventoryManagerList
        private List<InventoryItem> inventoryManagerList = new List<InventoryItem>();

        // Method to add item
        public void addItem(InventoryItem item) {
            this.inventoryManagerList.Add(item);
        } 

        // Method to remove item
        public void removeItem(InventoryItem item) {
            this.inventoryManagerList.Remove(item);
        } 

        // Method to restock item
        public void restockItem(InventoryItem item, int quantity) {
            if (item.Quantity == 0) {
                this.inventoryManagerList.Add(item);
                item.Quantity = quantity;
            } else {
                item.Quantity += quantity;
            }
        } 

        //Method to display current inventory
        public void displayInventory() {
            foreach (InventoryItem product in this.inventoryManagerList) {
                Console.WriteLine("Name = " + product.ItemName + ", Price = " + product.Price + ", Quantity = " + product.Quantity + ", Expiration Date = " + product.Expiration);

            } 
        } 

        //Method to search items
        public List<int> searchName(string objectName) {
            List<int> itemPosition = new List<int>();

            foreach (InventoryItem item in this.inventoryManagerList) {
                if (String.Equals(item.ItemName, objectName, StringComparison.OrdinalIgnoreCase)) {
                    itemPosition.Add(this.inventoryManagerList.IndexOf(item));
                } 
            } 
            return itemPosition;
        }

        //Method to search items by price
        public List<int> searchPrice(decimal objectPrice) {
            List<int> itemPosition = new List<int>();
            
            foreach (InventoryItem item in this.inventoryManagerList) {
                if (item.Price == objectPrice) {
                    itemPosition.Add(this.inventoryManagerList.IndexOf(item));
                } 
            } 
            return itemPosition;
        } 

    } 
} 
