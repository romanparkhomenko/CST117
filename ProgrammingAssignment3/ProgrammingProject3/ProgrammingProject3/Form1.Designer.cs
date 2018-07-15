namespace ProgrammingProject3 {
    partial class FileProcessor {
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
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.displayBox = new System.Windows.Forms.ListBox();
            this.readDataButton = new System.Windows.Forms.Button();
            this.printLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // displayBox
            // 
            this.displayBox.FormattingEnabled = true;
            this.displayBox.Location = new System.Drawing.Point(56, 35);
            this.displayBox.Name = "displayBox";
            this.displayBox.Size = new System.Drawing.Size(170, 134);
            this.displayBox.TabIndex = 1;
            // 
            // readDataButton
            // 
            this.readDataButton.Location = new System.Drawing.Point(56, 192);
            this.readDataButton.Name = "readDataButton";
            this.readDataButton.Size = new System.Drawing.Size(170, 41);
            this.readDataButton.TabIndex = 2;
            this.readDataButton.Text = "Read Data From File";
            this.readDataButton.UseVisualStyleBackColor = true;
            this.readDataButton.Click += new System.EventHandler(this.readDataButton_Click);
            // 
            // printLabel
            // 
            this.printLabel.AutoSize = true;
            this.printLabel.Location = new System.Drawing.Point(40, 239);
            this.printLabel.Name = "printLabel";
            this.printLabel.Size = new System.Drawing.Size(0, 13);
            this.printLabel.TabIndex = 3;
            // 
            // FileProcessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.printLabel);
            this.Controls.Add(this.readDataButton);
            this.Controls.Add(this.displayBox);
            this.Name = "FileProcessor";
            this.Text = "File Processor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.ListBox displayBox;
        private System.Windows.Forms.Button readDataButton;
        private System.Windows.Forms.Label printLabel;
    }
}

