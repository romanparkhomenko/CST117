/* Roman Parkhomenko CST117 08/04/2018
 * The purpose of this project is to exemplify usage
 * of multidimensional arrays and methods. When clicking
 * New game the program generates a new tic-tac-toe match and
 * displays the winner being "X", "O" or "Tied".
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

namespace TicTacToe {
    public partial class TicTacToe : Form {
        public TicTacToe() {
            InitializeComponent();
        }

        private void newGameButton_Click(object sender, EventArgs e) {
            // Initilize random number object
            Random rand = new Random();

            //Set size of gameboard
            const int ROWS = 3;
            const int COLS = 3;

            // Create a two-dimensional int array.
            int[,] gameBoard = new int[ROWS, COLS];

            // Fill array with random integers between 0 and 1
            for (int row = 0; row < ROWS; row++) {
                for (int col = 0; col < COLS; col++) {
                    gameBoard[row, col] = rand.Next(2);
                }
            }

            // Fill labels with values from array
            label1.Text = getValue(gameBoard[0, 0]);
            label2.Text = getValue(gameBoard[0, 1]);
            label3.Text = getValue(gameBoard[0, 2]);

            label4.Text = getValue(gameBoard[1, 0]);
            label5.Text = getValue(gameBoard[1, 1]);
            label6.Text = getValue(gameBoard[1, 2]);

            label7.Text = getValue(gameBoard[2, 0]);
            label8.Text = getValue(gameBoard[2, 1]);
            label9.Text = getValue(gameBoard[2, 2]);

            resultsDisplayTextbox.Text = getWinner(gameBoard);
        }

        // Method to determine the winner
        public string getWinner(int[,] intArray) {
            // set default value to -1 which is equal to a tie
            int winner = -1;

            // Check for horizontal win
            if ((intArray[0, 0] == intArray[0, 1]) && (intArray[0, 0] == intArray[0, 2])) {
                winner = intArray[0, 0];
            }
            if ((intArray[1, 0] == intArray[1, 1]) && (intArray[1, 0] == intArray[1, 2])) {
                winner = intArray[1, 0];
            }
            if ((intArray[2, 0] == intArray[2, 1]) && (intArray[2, 0] == intArray[2, 2])) {
                winner = intArray[2, 0];
            }


            // Check for vertical win
            if ((intArray[0, 0] == intArray[1, 0]) && (intArray[0, 0] == intArray[2, 0])) {
                winner = intArray[0, 0];
            }
            if ((intArray[0, 1] == intArray[1, 1]) && (intArray[0, 1] == intArray[2, 1])) {
                winner = intArray[0, 1];
            }
            if ((intArray[0, 2] == intArray[1, 2]) && (intArray[0, 2] == intArray[2, 2])) {
                winner = intArray[0, 2];
            }


            // check for diagonal win 
            if ((intArray[0, 0] == intArray[1, 1]) && (intArray[0, 0] == intArray[2, 2])) {
                winner = intArray[0, 0];
            }
            if ((intArray[0, 2] == intArray[1, 1]) && (intArray[0, 2] == intArray[2, 0])) {
                winner = intArray[0, 2];
            }

            // Check winner
            if (winner == 0) {
                return "O is the winner";
            } else if (winner == 1) {
                return "X is the winner";
            } else {
                return "The game was a tie";
            }
        } // End of get winner

        // Assign 0 or X for randomized array values
        public string getValue(int integerValue) {
            if (integerValue == 0) {
                return "0";
            } else {
                return "X";
            }
        }

        private void exitButton_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
