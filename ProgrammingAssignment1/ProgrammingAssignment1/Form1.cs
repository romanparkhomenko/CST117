/* Roman Parkhomenko CST117 07/01/2018 
 * The purpose of this assignment is to exemplify ability
 * to utilize primitive data types and calculations in C#
 * with a .NET developed form. This project also shows calculation
 * and string format handling.
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

namespace ProgrammingAssignment1 {
    public partial class planetaryWeights : Form {
        public planetaryWeights() {
            InitializeComponent();
        }

        private void calculateWeight_Click(object sender, EventArgs e) {
            try {
                // Obtain earth weight from input and declare variables for other planet weights.
                double earthWeight = double.Parse(earthPounds.Text);
                double mercuryWeight = (earthWeight / 9.81) * 3.7;
                double venusWeight = (earthWeight / 9.81) * 8.87;
                double marsWeight = (earthWeight / 9.81) * 3.711;
                double jupiterWeight = (earthWeight / 9.81) * 24.79;
                double saturnWeight = (earthWeight / 9.81) * 10.44;
                double uranusWeight = (earthWeight / 9.81) * 8.69;
                double neptuneWeight = (earthWeight / 9.81) * 11.15;
                double plutoWeight = (earthWeight / 9.81) * 0.60;

                // Fill in and format other planetary weights
                mercuryPounds.Text = mercuryWeight.ToString("n3");
                venusPounds.Text = venusWeight.ToString("n3");
                marsPounds.Text = marsWeight.ToString("n3");
                jupiterPounds.Text = jupiterWeight.ToString("n3");
                saturnPounds.Text = saturnWeight.ToString("n3");
                uranusPounds.Text = uranusWeight.ToString("n3");
                neptunePounds.Text = neptuneWeight.ToString("n3");
                plutoPounds.Text = plutoWeight.ToString("n3");
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
