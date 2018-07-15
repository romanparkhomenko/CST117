/* Roman Parkhomenko CST117 07/14/2018
 * The purpose of this application is to exemplify usage of loops
 * in addition to file processing. This application will take words in
 * an input file and display those words in the form in addition to creating
 * an output file and writing to it. Loops and string manipulation is utilized 
 * to change the words to lowercase and find out certain things about them.
 * All work is my own.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingProject3 {
    public partial class FileProcessor : Form {
        public FileProcessor() {
            InitializeComponent();
        }

        private void readDataButton_Click(object sender, EventArgs e) {

            StreamReader inputFile;
            StreamWriter outputFile;

            //open file dialog
            openFile.ShowDialog();
            if (openFile.ShowDialog() == DialogResult.OK) {
                try {
                    // input should be words.txt file and output file
                    // is output.txt
                    inputFile = File.OpenText(openFile.FileName);
                    outputFile = File.CreateText("output.txt");

                    string randomWord;
                    string firstWord = "z";
                    string lastWord = "a";
                    string longestWord = "";
                    string vowelWord = "";
                    int mostVowels = 0;

                    while (!inputFile.EndOfStream) {
                        // read line from input file
                        randomWord = inputFile.ReadLine();

                        string lowercaseWord = randomWord.ToLower();
                        // 1.a) Print lowercase words to display
                        displayBox.Items.Add(lowercaseWord);
                        // 1.b) Print lowercase words fo file
                        outputFile.WriteLine(lowercaseWord);

                        // Check to see if first two letters of word are less than
                        // existing word, if so, set first word.
                        if (lowercaseWord[0] <= firstWord[0]) {
                            firstWord = lowercaseWord;
                            //if (lowercaseWord[1] <= firstWord[1]) {
                            //    firstWord = lowercaseWord;
                            //}
                        }

                        // Check to see if first two letters of word are greater than
                        // existing word, if so, set last word.
                        if (lowercaseWord[0] >= lastWord[0]) {
                            lastWord = lowercaseWord;
                            //if (lowercaseWord[1] >= lastWord[1]) {
                            //    lastWord = lowercaseWord;
                            //}
                        }

                        // Check to see if word is longer than existing longest word,
                        // if so, set new longest word.
                        if (lowercaseWord.Length > longestWord.Length) {
                            longestWord = lowercaseWord;
                        }

                        /* Check to see if word contains vowels and increment counter.
                         * if the total vowel count is greater than the most vowel count
                         * set that word to be the vowelWord. 
                         */
                        int totalVowels = 0;
                        for (int i = 0; i < lowercaseWord.Length; i++) {
                            if (lowercaseWord[i] == 'a' || lowercaseWord[i] == 'e' || lowercaseWord[i] == 'i' || lowercaseWord[i] == 'o' || lowercaseWord[i] == 'u') {
                                totalVowels++;
                            }
                        }

                        if (totalVowels > mostVowels) {
                            mostVowels = totalVowels;
                            vowelWord = randomWord;
                        }

                    }

                    // 2.a) Print first and last words to display
                    displayBox.Items.Add(firstWord);
                    displayBox.Items.Add(lastWord);
                    // 2.b) Print first and last words fo file
                    outputFile.WriteLine("The first word is " + firstWord + " and the last word is " + lastWord);

                    // 3.a) Print longest word to display
                    displayBox.Items.Add(longestWord);
                    // 3.b) Print longest word to file
                    outputFile.WriteLine("The longest word is " + longestWord);

                    // 4.a) Print longest word to display
                    displayBox.Items.Add(vowelWord);
                    // 4.b) Print longest word to file
                    outputFile.WriteLine("The word with the most vowels is " + vowelWord);

                    inputFile.Close();
                    outputFile.Close();

                    printLabel.Text = "You can find an output file at Debug/bin";

                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
                
            } else {
                MessageBox.Show("Operation canceled.");
            }
        }
    }
}
