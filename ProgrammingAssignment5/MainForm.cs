/* Roman Parkhomenko CST117 08/11/2018
 * The purpose of this project is to exemplify usage
 * of more than one form in addition to creating dynamically
 * generated controls. I have the user enter their birth year
 * (any year would work) and have it generate a list of animals if
 * dependent on if the year is odd or even. Based on the animal selected,
 * I generate a list of numbers. Based on the index of the selected option
 * another number is chosen from the list. The numbers are then added and
 * displayed on the new form.
 * All work is my own.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingProject5 {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }
       
        // Declare variables
        public int birthYear;
        public string animal;
        public int birthDay;

        private void birthYearTextBox_TextChanged(object sender, EventArgs e) {
            string dog = "dog";
            string cat = "cat";
            string tiger = "tiger";
            string elephant = "elephant";
            string monkey = "monkey";
            string walrus = "walrus";

            if (int.TryParse(birthYearTextBox.Text, out birthYear)) {      
                if (birthYear % 2 == 0) {
                    animalValuesBox.Items.Add(dog);
                    animalValuesBox.Items.Add(cat);
                    animalValuesBox.Items.Add(tiger);
                } else {
                    animalValuesBox.Items.Add(elephant);
                    animalValuesBox.Items.Add(monkey);
                    animalValuesBox.Items.Add(walrus);
                }
            } 
        }

        private void animalValuesBox_SelectedIndexChanged(object sender, EventArgs e) {
            birthDayBox.Items.Clear();
            animal = animalValuesBox.SelectedItem.ToString();

            if (animal == "dog") {
                birthDayBox.Items.Add(1);
                birthDayBox.Items.Add(2);
                birthDayBox.Items.Add(3);
                birthDayBox.Items.Add(4);
                birthDayBox.Items.Add(5);
            } else if (animal == "cat") {
                birthDayBox.Items.Add(6);
                birthDayBox.Items.Add(7);
                birthDayBox.Items.Add(8);
                birthDayBox.Items.Add(9);
                birthDayBox.Items.Add(10);
            } else if (animal == "tiger") {
                birthDayBox.Items.Add(11);
                birthDayBox.Items.Add(12);
                birthDayBox.Items.Add(13);
                birthDayBox.Items.Add(14);
                birthDayBox.Items.Add(15);
            } else if (animal == "elephant") {
                birthDayBox.Items.Add(16);
                birthDayBox.Items.Add(17);
                birthDayBox.Items.Add(18);
                birthDayBox.Items.Add(19);
                birthDayBox.Items.Add(20);
            } else if (animal == "monkey") {
                birthDayBox.Items.Add(21);
                birthDayBox.Items.Add(22);
                birthDayBox.Items.Add(23);
                birthDayBox.Items.Add(24);
                birthDayBox.Items.Add(25);
            } else if (animal == "walrus") {
                birthDayBox.Items.Add(26);
                birthDayBox.Items.Add(27);
                birthDayBox.Items.Add(28);
                birthDayBox.Items.Add(29);
                birthDayBox.Items.Add(30);
            }
        }

        private void birthDayBox_SelectedIndexChanged(object sender, EventArgs e) {
            List<int> randomValue = new List<int> { 30, 79, 25, 29, 34 };
            birthDay = randomValue[birthDayBox.SelectedIndex];
        }

        private void luckyButton_Click(object sender, EventArgs e) {
            ResultsForm LuckyResultForm = new ResultsForm();
            int luckyResult = birthDay + birthYear; 

            LuckyResultForm.luckyLabel.Text = luckyResult.ToString(); 
            LuckyResultForm.ShowDialog();
        }
    }
}
