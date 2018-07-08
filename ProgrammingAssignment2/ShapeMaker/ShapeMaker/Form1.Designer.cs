namespace ShapeMaker {
    partial class ShapeMaker {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.shapeList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fillBox = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.drawButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.fillRadioButton = new System.Windows.Forms.RadioButton();
            this.outlineRadioButton = new System.Windows.Forms.RadioButton();
            this.nameCheckbox = new System.Windows.Forms.CheckBox();
            this.dateCheckbox = new System.Windows.Forms.CheckBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.fillBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // shapeList
            // 
            this.shapeList.FormattingEnabled = true;
            this.shapeList.Items.AddRange(new object[] {
            "Circle",
            "Rectangle"});
            this.shapeList.Location = new System.Drawing.Point(35, 47);
            this.shapeList.Name = "shapeList";
            this.shapeList.Size = new System.Drawing.Size(120, 30);
            this.shapeList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select a shape:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Location = new System.Drawing.Point(262, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 223);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // fillBox
            // 
            this.fillBox.Controls.Add(this.outlineRadioButton);
            this.fillBox.Controls.Add(this.fillRadioButton);
            this.fillBox.Location = new System.Drawing.Point(35, 102);
            this.fillBox.Name = "fillBox";
            this.fillBox.Size = new System.Drawing.Size(156, 100);
            this.fillBox.TabIndex = 3;
            this.fillBox.TabStop = false;
            this.fillBox.Text = "Select fill mode";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateCheckbox);
            this.groupBox1.Controls.Add(this.nameCheckbox);
            this.groupBox1.Location = new System.Drawing.Point(35, 227);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select details";
            // 
            // drawButton
            // 
            this.drawButton.Location = new System.Drawing.Point(262, 290);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(124, 37);
            this.drawButton.TabIndex = 5;
            this.drawButton.Text = "Draw";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.drawButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(408, 290);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(124, 37);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // fillRadioButton
            // 
            this.fillRadioButton.AutoSize = true;
            this.fillRadioButton.Location = new System.Drawing.Point(20, 31);
            this.fillRadioButton.Name = "fillRadioButton";
            this.fillRadioButton.Size = new System.Drawing.Size(37, 17);
            this.fillRadioButton.TabIndex = 0;
            this.fillRadioButton.TabStop = true;
            this.fillRadioButton.Text = "Fill";
            this.fillRadioButton.UseVisualStyleBackColor = true;
            // 
            // outlineRadioButton
            // 
            this.outlineRadioButton.AutoSize = true;
            this.outlineRadioButton.Location = new System.Drawing.Point(20, 64);
            this.outlineRadioButton.Name = "outlineRadioButton";
            this.outlineRadioButton.Size = new System.Drawing.Size(58, 17);
            this.outlineRadioButton.TabIndex = 1;
            this.outlineRadioButton.TabStop = true;
            this.outlineRadioButton.Text = "Outline";
            this.outlineRadioButton.UseVisualStyleBackColor = true;
            // 
            // nameCheckbox
            // 
            this.nameCheckbox.AutoSize = true;
            this.nameCheckbox.Location = new System.Drawing.Point(20, 25);
            this.nameCheckbox.Name = "nameCheckbox";
            this.nameCheckbox.Size = new System.Drawing.Size(54, 17);
            this.nameCheckbox.TabIndex = 0;
            this.nameCheckbox.Text = "Name";
            this.nameCheckbox.UseVisualStyleBackColor = true;
            // 
            // dateCheckbox
            // 
            this.dateCheckbox.AutoSize = true;
            this.dateCheckbox.Location = new System.Drawing.Point(20, 63);
            this.dateCheckbox.Name = "dateCheckbox";
            this.dateCheckbox.Size = new System.Drawing.Size(49, 17);
            this.dateCheckbox.TabIndex = 1;
            this.dateCheckbox.Text = "Date";
            this.dateCheckbox.UseVisualStyleBackColor = true;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(262, 261);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(0, 13);
            this.nameLabel.TabIndex = 7;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(408, 261);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(0, 13);
            this.dateLabel.TabIndex = 8;
            // 
            // ShapeMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 362);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.drawButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.fillBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeList);
            this.Name = "ShapeMaker";
            this.Text = "Shape Maker";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.fillBox.ResumeLayout(false);
            this.fillBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox shapeList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox fillBox;
        private System.Windows.Forms.RadioButton outlineRadioButton;
        private System.Windows.Forms.RadioButton fillRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox dateCheckbox;
        private System.Windows.Forms.CheckBox nameCheckbox;
        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label dateLabel;
    }
}

