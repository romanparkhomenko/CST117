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
    public partial class removeItemForm : Form {
        public removeItemForm() {
            InitializeComponent();
            mainForm.vendingMachine.displayInventory(displayBox);
        }

        private void buttonClose_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void buttonRemove_Click(object sender, EventArgs e) {
            mainForm.vendingMachine.removeItem(displayBox.SelectedIndex);
            mainForm.vendingMachine.displayInventory(displayBox);
        }
    }
}
