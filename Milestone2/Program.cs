using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory {
    class Program {
        static void Main(string[] args) {
            //create new inventrory item called chips and print
            InventoryItem chips = new InventoryItem();

            chips.print();

            // for system pause
            Console.ReadLine();
        }
    }
}
