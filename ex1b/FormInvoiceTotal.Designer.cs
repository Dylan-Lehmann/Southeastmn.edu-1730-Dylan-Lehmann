namespace ex1b
{
    partial class FormInvoiceTotal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBoxSubtotal = new TextBox();
            textBoxTotal = new TextBox();
            label2 = new Label();
            textBoxDiscountamount = new TextBox();
            label3 = new Label();
            textBoxDiscountpercent = new TextBox();
            label4 = new Label();
            buttonCalculate = new Button();
            buttonExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(111, 36);
            label1.Name = "label1";
            label1.Size = new Size(91, 28);
            label1.TabIndex = 0;
            label1.Text = "&Subtotal:";
            // 
            // textBoxSubtotal
            // 
            textBoxSubtotal.Location = new Point(208, 36);
            textBoxSubtotal.Name = "textBoxSubtotal";
            textBoxSubtotal.Size = new Size(136, 27);
            textBoxSubtotal.TabIndex = 1;
            // 
            // textBoxTotal
            // 
            textBoxTotal.Location = new Point(208, 167);
            textBoxTotal.Name = "textBoxTotal";
            textBoxTotal.ReadOnly = true;
            textBoxTotal.Size = new Size(136, 27);
            textBoxTotal.TabIndex = 3;
            textBoxTotal.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(144, 163);
            label2.Name = "label2";
            label2.Size = new Size(58, 28);
            label2.TabIndex = 2;
            label2.Text = "Total:";
            // 
            // textBoxDiscountamount
            // 
            textBoxDiscountamount.Location = new Point(208, 127);
            textBoxDiscountamount.Name = "textBoxDiscountamount";
            textBoxDiscountamount.ReadOnly = true;
            textBoxDiscountamount.Size = new Size(136, 27);
            textBoxDiscountamount.TabIndex = 5;
            textBoxDiscountamount.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(33, 122);
            label3.Name = "label3";
            label3.Size = new Size(169, 28);
            label3.TabIndex = 4;
            label3.Text = "Discount Amount:";
            // 
            // textBoxDiscountpercent
            // 
            textBoxDiscountpercent.Location = new Point(208, 80);
            textBoxDiscountpercent.Name = "textBoxDiscountpercent";
            textBoxDiscountpercent.ReadOnly = true;
            textBoxDiscountpercent.Size = new Size(136, 27);
            textBoxDiscountpercent.TabIndex = 7;
            textBoxDiscountpercent.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(40, 80);
            label4.Name = "label4";
            label4.Size = new Size(162, 28);
            label4.TabIndex = 6;
            label4.Text = "Discount Percent:";
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(182, 254);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(91, 32);
            buttonCalculate.TabIndex = 2;
            buttonCalculate.Text = "&Calculate";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(282, 254);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(91, 32);
            buttonExit.TabIndex = 3;
            buttonExit.Text = "E&xit";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // FormInvoiceTotal
            // 
            AcceptButton = buttonCalculate;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonExit;
            ClientSize = new Size(429, 348);
            Controls.Add(buttonExit);
            Controls.Add(buttonCalculate);
            Controls.Add(textBoxDiscountpercent);
            Controls.Add(label4);
            Controls.Add(textBoxDiscountamount);
            Controls.Add(label3);
            Controls.Add(textBoxTotal);
            Controls.Add(label2);
            Controls.Add(textBoxSubtotal);
            Controls.Add(label1);
            Name = "FormInvoiceTotal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Invoice Total";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxSubtotal;
        private TextBox textBoxTotal;
        private Label label2;
        private TextBox textBoxDiscountamount;
        private Label label3;
        private TextBox textBoxDiscountpercent;
        private Label label4;
        private Button buttonCalculate;
        private Button buttonExit;
    }
}
