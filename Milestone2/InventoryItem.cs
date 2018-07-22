using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory {
    class InventoryItem {
        
        private string _name;
        private decimal _price;
        private int _quantity;
        private DateTime _expiration;

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
        public DateTime Expiration {
            get { return _expiration; }
            set { _expiration = value; }
        }

        // default constructor
        public InventoryItem() {
            _name = "Lays Chips";
            _price = 3.99m;
            _quantity = 10;
            _expiration = System.DateTime.Now;
        }

        //constructor
        public InventoryItem(string name, decimal price, int quantity, DateTime expiration) {
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
