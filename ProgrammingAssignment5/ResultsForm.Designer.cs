namespace ProgrammingProject5 {
    partial class ResultsForm {
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
            this.luckyLabel = new System.Windows.Forms.Label();
            this.luckyNumberLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // luckyLabel
            // 
            this.luckyLabel.BackColor = System.Drawing.Color.Lime;
            this.luckyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luckyLabel.Location = new System.Drawing.Point(51, 127);
            this.luckyLabel.Name = "luckyLabel";
            this.luckyLabel.Size = new System.Drawing.Size(197, 61);
            this.luckyLabel.TabIndex = 0;
            this.luckyLabel.Text = "Lucky#";
            this.luckyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // luckyNumberLabel
            // 
            this.luckyNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luckyNumberLabel.ForeColor = System.Drawing.Color.Lime;
            this.luckyNumberLabel.Location = new System.Drawing.Point(27, 22);
            this.luckyNumberLabel.Name = "luckyNumberLabel";
            this.luckyNumberLabel.Size = new System.Drawing.Size(243, 92);
            this.luckyNumberLabel.TabIndex = 1;
            this.luckyNumberLabel.Text = "Your lucky number is";
            this.luckyNumberLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(295, 224);
            this.Controls.Add(this.luckyNumberLabel);
            this.Controls.Add(this.luckyLabel);
            this.Name = "ResultsForm";
            this.Text = "ResultsForm";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label luckyLabel;
        public System.Windows.Forms.Label luckyNumberLabel;
    }
}