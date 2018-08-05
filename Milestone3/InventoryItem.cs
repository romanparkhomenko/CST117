using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory {
    class InventoryItem {
        // private data
        private string _name;
        private decimal _price;
        private int _quantity;
        private string _expiration;

        // C# 3.0+ allows for this sweet getter/setter format
        public string ItemName {
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
        public string Expiration {
            get { return _expiration; }
            set { _expiration = value; }
        }

        // default constructor
        public InventoryItem() {
            _name = "Lays Chips";
            _price = 3.99m;
            _quantity = 10;
            _expiration = "05/30/2019";
        }

        // nondefault constructor
        public InventoryItem(string name, decimal price, int quantity, string expiration) {
            this.ItemName = name;
            this.Price = price;
            this.Quantity = quantity;
            this.Expiration = expiration;
        }

        // unique methods
        public void print() {
            Console.Write(_name + "\n" + _price + "\n" + _quantity + "\n" + _expiration + "\n");
        }
    }
}
