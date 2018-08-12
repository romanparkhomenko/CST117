namespace ProgrammingProject5 {
    partial class MainForm {
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
            this.label1 = new System.Windows.Forms.Label();
            this.birthYearTextBox = new System.Windows.Forms.TextBox();
            this.animalValuesBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.birthDayBox = new System.Windows.Forms.ComboBox();
            this.luckyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your birth year:";
            // 
            // birthYearTextBox
            // 
            this.birthYearTextBox.Location = new System.Drawing.Point(176, 27);
            this.birthYearTextBox.Name = "birthYearTextBox";
            this.birthYearTextBox.Size = new System.Drawing.Size(100, 20);
            this.birthYearTextBox.TabIndex = 1;
            this.birthYearTextBox.TextChanged += new System.EventHandler(this.birthYearTextBox_TextChanged);
            // 
            // animalValuesBox
            // 
            this.animalValuesBox.FormattingEnabled = true;
            this.animalValuesBox.Location = new System.Drawing.Point(176, 58);
            this.animalValuesBox.Name = "animalValuesBox";
            this.animalValuesBox.Size = new System.Drawing.Size(100, 21);
            this.animalValuesBox.TabIndex = 2;
            this.animalValuesBox.SelectedIndexChanged += new System.EventHandler(this.animalValuesBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Choose an animal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Select your birth day:";
            // 
            // birthDayBox
            // 
            this.birthDayBox.FormattingEnabled = true;
            this.birthDayBox.Location = new System.Drawing.Point(176, 89);
            this.birthDayBox.Name = "birthDayBox";
            this.birthDayBox.Size = new System.Drawing.Size(100, 21);
            this.birthDayBox.TabIndex = 5;
            this.birthDayBox.SelectedIndexChanged += new System.EventHandler(this.birthDayBox_SelectedIndexChanged);
            // 
            // luckyButton
            // 
            this.luckyButton.Location = new System.Drawing.Point(38, 127);
            this.luckyButton.Name = "luckyButton";
            this.luckyButton.Size = new System.Drawing.Size(238, 39);
            this.luckyButton.TabIndex = 6;
            this.luckyButton.Text = "Get Your Lucky Number";
            this.luckyButton.UseVisualStyleBackColor = true;
            this.luckyButton.Click += new System.EventHandler(this.luckyButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 194);
            this.Controls.Add(this.luckyButton);
            this.Controls.Add(this.birthDayBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.animalValuesBox);
            this.Controls.Add(this.birthYearTextBox);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Lucky Number";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox birthYearTextBox;
        private System.Windows.Forms.ComboBox animalValuesBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox birthDayBox;
        private System.Windows.Forms.Button luckyButton;
    }
}

