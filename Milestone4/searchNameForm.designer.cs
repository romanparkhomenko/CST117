namespace inventory
{
    partial class searchNameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.displayBox = new System.Windows.Forms.ListBox();
            this.buttonSearchName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Silver;
            this.buttonClose.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(17, 162);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(162, 53);
            this.buttonClose.TabIndex = 6;
            this.buttonClose.Text = "Exit";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 75;
            this.label3.Text = "Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(64, 11);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(303, 20);
            this.txtName.TabIndex = 74;
            // 
            // displayBox
            // 
            this.displayBox.FormattingEnabled = true;
            this.displayBox.Location = new System.Drawing.Point(17, 36);
            this.displayBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.displayBox.Name = "displayBox";
            this.displayBox.Size = new System.Drawing.Size(350, 121);
            this.displayBox.TabIndex = 73;
            // 
            // buttonSearchName
            // 
            this.buttonSearchName.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonSearchName.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchName.Location = new System.Drawing.Point(185, 162);
            this.buttonSearchName.Name = "buttonSearchName";
            this.buttonSearchName.Size = new System.Drawing.Size(182, 53);
            this.buttonSearchName.TabIndex = 72;
            this.buttonSearchName.Text = "Search By Name";
            this.buttonSearchName.UseVisualStyleBackColor = false;
            this.buttonSearchName.Click += new System.EventHandler(this.buttonSearchName_Click);
            // 
            // searchNameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 235);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.displayBox);
            this.Controls.Add(this.buttonSearchName);
            this.Controls.Add(this.buttonClose);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "searchNameForm";
            this.Text = "Search By Name";
            this.Load += new System.EventHandler(this.frmSearchByName_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ListBox displayBox;
        private System.Windows.Forms.Button buttonSearchName;
    }
}