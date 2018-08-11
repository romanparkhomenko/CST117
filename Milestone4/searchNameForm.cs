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
    public partial class searchNameForm : Form {
        public searchNameForm() {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void frmSearchByName_Load(object sender, EventArgs e) {
            mainForm.vendingMachine.displayInventory(displayBox);
        }

        private void buttonSearchName_Click(object sender, EventArgs e) {
            mainForm.vendingMachine.searchName(txtName.Text, displayBox);
        }
    }
}
