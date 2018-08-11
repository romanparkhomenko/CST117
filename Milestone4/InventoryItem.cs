/* Roman Parkhomenko CST117 08/11/2018
 * Inventory Item Class for the inventory Management 
 * Project. The purpose of this class is to create an 
 * inventory object that's to be used by the inventory manager.
 * Our inventroy object contains name, price, quantity, item type, and 
 * expiration properties.
 * All work is my own.
 *  */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory {
    public class InventoryItem {
        //Declare private inventory fields
        private string _name;
        private decimal _price;
        private int _quantity;
        private string _itemType;
        private string _expiration;

        public string Name {
            get { return _name; }
            set { _name = value; }
        }
        public decimal Price {
            get { return _price; }
            set { _price = value; }
        }
        public int Quantity {
            get { return _quantity; }
            set { _quantity = value; }
        }
        public string ItemType {
            get { return _itemType; }
            set { _itemType = value; }
        }
        public string Expiration {
            get { return _expiration; }
            set { _expiration = value; }
        }


        // Default constructor
        public InventoryItem() {
            _name = "None";
            _price = 0.00m;
            _quantity = 0;
            _itemType = "None";
            _expiration = "12/31/2099";
        }

        // Constructor with arguments
        public InventoryItem(string name, decimal price, int quantity, string itemType, string expiration) {
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
            this.ItemType = itemType;
            this.Expiration = expiration;
        }

    }
}
