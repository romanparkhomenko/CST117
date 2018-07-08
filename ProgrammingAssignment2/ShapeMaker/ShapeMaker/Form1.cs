/* Roman Parkhomenko CST117 07/07/2018
 * The purpose of this assignment is to utilize list boxes,
 * radio buttons, and checkboxes to create a form. I created
 * the form that was in the example for our assignment with a
 * shape maker module. This application utilizes conditional and
 * switch logic to combine selected elements into a shape. 
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

namespace ShapeMaker {
    public partial class ShapeMaker : Form {
        public ShapeMaker() {
            InitializeComponent();
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        }

        private void drawButton_Click(object sender, EventArgs e) {
            using (var g = Graphics.FromImage(pictureBox1.Image)) {

                //create solid brush for filled shapes.
                SolidBrush myBrush = new SolidBrush(Color.Blue);
                //create pen for outline shapes
                Pen myPen = new Pen(Color.Blue);

                string shape;
                if (shapeList.SelectedIndex != -1) {
                    shape = shapeList.SelectedItem.ToString();

                    switch (shape) {
                        case "Rectangle":
                            if (fillRadioButton.Checked) {
                                g.FillRectangle(myBrush, 35, 50, 200, 100);
                                pictureBox1.Refresh();
                            } else {
                                g.DrawRectangle(myPen, 35, 50, 200, 100);
                                pictureBox1.Refresh();
                            }
                            if (nameCheckbox.Checked) {
                                nameLabel.Text = "Rectangle";
                            }
                            if (dateCheckbox.Checked) {
                                dateLabel.Text = "07/07/2018";
                            }
                            break;

                        case "Circle":
                            if (fillRadioButton.Checked) {
                                g.FillEllipse(myBrush, 40, 10, 200, 200);
                                pictureBox1.Refresh();
                            } else {
                                g.DrawEllipse(myPen, 40, 10, 200, 200);
                                pictureBox1.Refresh();
                            }
                            if (nameCheckbox.Checked) {
                                nameLabel.Text = "Circle";
                            }
                            if (dateCheckbox.Checked) {
                                dateLabel.Text = "07/07/2018";
                            }
                            break;
                    }
                } else {
                    //No shape selected
                    MessageBox.Show("Please select a shape");
                }

            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e) {

        }

        private void clearButton_Click(object sender, EventArgs e) {
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Refresh();
            nameLabel.Text = "";
            dateLabel.Text = "";
        }
    }
}
