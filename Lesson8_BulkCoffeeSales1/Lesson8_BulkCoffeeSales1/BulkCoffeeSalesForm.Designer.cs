namespace Lesson8_BulkCoffeeSales1
{
    partial class BulkCoffeeSalesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BulkCoffeeSalesForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.findPriceButton = new System.Windows.Forms.Button();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.coffeeTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.fullPoundRadioButton = new System.Windows.Forms.RadioButton();
            this.halfPoundRadioButton = new System.Windows.Forms.RadioButton();
            this.quarterPoundRadioButton = new System.Windows.Forms.RadioButton();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bulk Coffee Sales";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(369, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Anju Chawla";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.exitButton);
            this.groupBox1.Controls.Add(this.printButton);
            this.groupBox1.Controls.Add(this.clearButton);
            this.groupBox1.Controls.Add(this.findPriceButton);
            this.groupBox1.Controls.Add(this.priceTextBox);
            this.groupBox1.Controls.Add(this.coffeeTypeComboBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(23, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 179);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Coffee Prices";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(324, 139);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
        
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(221, 139);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(75, 23);
            this.printButton.TabIndex = 7;
            this.printButton.Text = "&Print";
            this.printButton.UseVisualStyleBackColor = true;
          
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(118, 139);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "&Clear";
            this.clearButton.UseVisualStyleBackColor = true;
      
            // 
            // findPriceButton
            // 
            this.findPriceButton.Location = new System.Drawing.Point(15, 139);
            this.findPriceButton.Name = "findPriceButton";
            this.findPriceButton.Size = new System.Drawing.Size(75, 23);
            this.findPriceButton.TabIndex = 5;
            this.findPriceButton.Text = "&Find Price";
            this.findPriceButton.UseVisualStyleBackColor = true;
        
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(278, 93);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.ReadOnly = true;
            this.priceTextBox.Size = new System.Drawing.Size(121, 20);
            this.priceTextBox.TabIndex = 4;
            this.priceTextBox.TabStop = false;
            // 
            // coffeeTypeComboBox
            // 
            this.coffeeTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.coffeeTypeComboBox.FormattingEnabled = true;
            this.coffeeTypeComboBox.Items.AddRange(new object[] {
            "Regular",
            "Decaffeinated",
            "Special Blend"});
            this.coffeeTypeComboBox.Location = new System.Drawing.Point(278, 51);
            this.coffeeTypeComboBox.Name = "coffeeTypeComboBox";
            this.coffeeTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.coffeeTypeComboBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "&Type";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.fullPoundRadioButton);
            this.groupBox2.Controls.Add(this.halfPoundRadioButton);
            this.groupBox2.Controls.Add(this.quarterPoundRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(15, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 87);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quantity";
            // 
            // fullPoundRadioButton
            // 
            this.fullPoundRadioButton.AutoSize = true;
            this.fullPoundRadioButton.Location = new System.Drawing.Point(11, 63);
            this.fullPoundRadioButton.Name = "fullPoundRadioButton";
            this.fullPoundRadioButton.Size = new System.Drawing.Size(75, 17);
            this.fullPoundRadioButton.TabIndex = 2;
            this.fullPoundRadioButton.Text = "Fu&ll Pound";
            this.fullPoundRadioButton.UseVisualStyleBackColor = true;
           
            // 
            // halfPoundRadioButton
            // 
            this.halfPoundRadioButton.AutoSize = true;
            this.halfPoundRadioButton.Location = new System.Drawing.Point(11, 41);
            this.halfPoundRadioButton.Name = "halfPoundRadioButton";
            this.halfPoundRadioButton.Size = new System.Drawing.Size(78, 17);
            this.halfPoundRadioButton.TabIndex = 1;
            this.halfPoundRadioButton.Text = "&Half Pound";
            this.halfPoundRadioButton.UseVisualStyleBackColor = true;
       
            // 
            // quarterPoundRadioButton
            // 
            this.quarterPoundRadioButton.AutoSize = true;
            this.quarterPoundRadioButton.Checked = true;
            this.quarterPoundRadioButton.Location = new System.Drawing.Point(11, 19);
            this.quarterPoundRadioButton.Name = "quarterPoundRadioButton";
            this.quarterPoundRadioButton.Size = new System.Drawing.Size(94, 17);
            this.quarterPoundRadioButton.TabIndex = 0;
            this.quarterPoundRadioButton.TabStop = true;
            this.quarterPoundRadioButton.Text = "&Quarter Pound";
            this.quarterPoundRadioButton.UseVisualStyleBackColor = true;
         
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
         
            // 
            // BulkCoffeeSalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 265);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BulkCoffeeSalesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "R \'n R for Reading and Refreshment";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button findPriceButton;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.ComboBox coffeeTypeComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton fullPoundRadioButton;
        private System.Windows.Forms.RadioButton halfPoundRadioButton;
        private System.Windows.Forms.RadioButton quarterPoundRadioButton;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}

