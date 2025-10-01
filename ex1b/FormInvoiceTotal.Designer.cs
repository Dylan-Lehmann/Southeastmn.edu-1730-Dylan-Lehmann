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
            label5 = new Label();
            textBoxEnterSubtotal = new TextBox();
            ButtonClear = new Button();
            textBoxTotalInvoices = new TextBox();
            label6 = new Label();
            textBoxAvgInvoices = new TextBox();
            label7 = new Label();
            textBoxNmbInvoices = new TextBox();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 68);
            label1.Name = "label1";
            label1.Size = new Size(91, 28);
            label1.TabIndex = 0;
            label1.Text = "&Subtotal:";
            // 
            // textBoxSubtotal
            // 
            textBoxSubtotal.Location = new Point(192, 72);
            textBoxSubtotal.Name = "textBoxSubtotal";
            textBoxSubtotal.ReadOnly = true;
            textBoxSubtotal.Size = new Size(136, 27);
            textBoxSubtotal.TabIndex = 1;
            textBoxSubtotal.TabStop = false;
            // 
            // textBoxTotal
            // 
            textBoxTotal.Location = new Point(192, 200);
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
            label2.Location = new Point(12, 195);
            label2.Name = "label2";
            label2.Size = new Size(58, 28);
            label2.TabIndex = 2;
            label2.Text = "Total:";
            // 
            // textBoxDiscountamount
            // 
            textBoxDiscountamount.Location = new Point(192, 155);
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
            label3.Location = new Point(12, 154);
            label3.Name = "label3";
            label3.Size = new Size(169, 28);
            label3.TabIndex = 4;
            label3.Text = "Discount Amount:";
            // 
            // textBoxDiscountpercent
            // 
            textBoxDiscountpercent.Location = new Point(192, 113);
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
            label4.Location = new Point(12, 112);
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
            buttonExit.Location = new Point(379, 254);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(91, 32);
            buttonExit.TabIndex = 4;
            buttonExit.Text = "E&xit";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(12, 30);
            label5.Name = "label5";
            label5.Size = new Size(141, 28);
            label5.TabIndex = 8;
            label5.Text = "Enter &Subtotal:";
            // 
            // textBoxEnterSubtotal
            // 
            textBoxEnterSubtotal.Location = new Point(192, 34);
            textBoxEnterSubtotal.Name = "textBoxEnterSubtotal";
            textBoxEnterSubtotal.Size = new Size(136, 27);
            textBoxEnterSubtotal.TabIndex = 1;
            // 
            // ButtonClear
            // 
            ButtonClear.Location = new Point(279, 254);
            ButtonClear.Name = "ButtonClear";
            ButtonClear.Size = new Size(94, 32);
            ButtonClear.TabIndex = 3;
            ButtonClear.Text = "Clear";
            ButtonClear.UseVisualStyleBackColor = true;
            ButtonClear.Click += ButtonClear_Click;
            // 
            // textBoxTotalInvoices
            // 
            textBoxTotalInvoices.Location = new Point(514, 91);
            textBoxTotalInvoices.Name = "textBoxTotalInvoices";
            textBoxTotalInvoices.ReadOnly = true;
            textBoxTotalInvoices.Size = new Size(136, 27);
            textBoxTotalInvoices.TabIndex = 16;
            textBoxTotalInvoices.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(334, 90);
            label6.Name = "label6";
            label6.Size = new Size(156, 28);
            label6.TabIndex = 15;
            label6.Text = "Total of invoices:";
            // 
            // textBoxAvgInvoices
            // 
            textBoxAvgInvoices.Location = new Point(514, 133);
            textBoxAvgInvoices.Name = "textBoxAvgInvoices";
            textBoxAvgInvoices.ReadOnly = true;
            textBoxAvgInvoices.Size = new Size(136, 27);
            textBoxAvgInvoices.TabIndex = 14;
            textBoxAvgInvoices.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(334, 132);
            label7.Name = "label7";
            label7.Size = new Size(186, 28);
            label7.TabIndex = 13;
            label7.Text = "Average of invoices:";
            // 
            // textBoxNmbInvoices
            // 
            textBoxNmbInvoices.Location = new Point(514, 50);
            textBoxNmbInvoices.Name = "textBoxNmbInvoices";
            textBoxNmbInvoices.ReadOnly = true;
            textBoxNmbInvoices.Size = new Size(136, 27);
            textBoxNmbInvoices.TabIndex = 12;
            textBoxNmbInvoices.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(334, 46);
            label8.Name = "label8";
            label8.Size = new Size(186, 28);
            label8.TabIndex = 11;
            label8.Text = "Number of invoices:";
            // 
            // FormInvoiceTotal
            // 
            AcceptButton = buttonCalculate;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonExit;
            ClientSize = new Size(664, 308);
            Controls.Add(textBoxTotalInvoices);
            Controls.Add(label6);
            Controls.Add(textBoxAvgInvoices);
            Controls.Add(label7);
            Controls.Add(textBoxNmbInvoices);
            Controls.Add(label8);
            Controls.Add(ButtonClear);
            Controls.Add(textBoxEnterSubtotal);
            Controls.Add(label5);
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
        private Label label5;
        private TextBox textBoxEnterSubtotal;
        private Button ButtonClear;
        private TextBox textBoxTotalInvoices;
        private Label label6;
        private TextBox textBoxAvgInvoices;
        private Label label7;
        private TextBox textBoxNmbInvoices;
        private Label label8;
    }
}
