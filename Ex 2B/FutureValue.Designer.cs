namespace Ex_2B
{
    partial class Future_Value
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            buttonCalculate = new Button();
            buttonExit = new Button();
            textBoxMonthInvest = new TextBox();
            textBoxYIR = new TextBox();
            textBoxNmbYears = new TextBox();
            textBoxFutureValue = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(19, 39);
            label1.Name = "label1";
            label1.Size = new Size(167, 23);
            label1.TabIndex = 0;
            label1.Text = "Monthly Investment:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(19, 75);
            label2.Name = "label2";
            label2.Size = new Size(160, 23);
            label2.TabIndex = 1;
            label2.Text = "Yearly Interest Rate:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(19, 112);
            label3.Name = "label3";
            label3.Size = new Size(141, 23);
            label3.TabIndex = 2;
            label3.Text = "Number of Years:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(19, 149);
            label4.Name = "label4";
            label4.Size = new Size(110, 23);
            label4.TabIndex = 3;
            label4.Text = "Future Value:";
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(92, 201);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(94, 29);
            buttonCalculate.TabIndex = 4;
            buttonCalculate.Text = "Calculate";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(205, 201);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(94, 29);
            buttonExit.TabIndex = 5;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // textBoxMonthInvest
            // 
            textBoxMonthInvest.Location = new Point(205, 39);
            textBoxMonthInvest.Name = "textBoxMonthInvest";
            textBoxMonthInvest.Size = new Size(125, 27);
            textBoxMonthInvest.TabIndex = 1;
            // 
            // textBoxYIR
            // 
            textBoxYIR.Location = new Point(205, 75);
            textBoxYIR.Name = "textBoxYIR";
            textBoxYIR.Size = new Size(125, 27);
            textBoxYIR.TabIndex = 2;
            // 
            // textBoxNmbYears
            // 
            textBoxNmbYears.Location = new Point(205, 112);
            textBoxNmbYears.Name = "textBoxNmbYears";
            textBoxNmbYears.Size = new Size(125, 27);
            textBoxNmbYears.TabIndex = 3;
            // 
            // textBoxFutureValue
            // 
            textBoxFutureValue.Location = new Point(205, 149);
            textBoxFutureValue.Name = "textBoxFutureValue";
            textBoxFutureValue.ReadOnly = true;
            textBoxFutureValue.Size = new Size(125, 27);
            textBoxFutureValue.TabIndex = 9;
            textBoxFutureValue.TabStop = false;
            // 
            // Future_Value
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 242);
            Controls.Add(textBoxFutureValue);
            Controls.Add(textBoxNmbYears);
            Controls.Add(textBoxYIR);
            Controls.Add(textBoxMonthInvest);
            Controls.Add(buttonExit);
            Controls.Add(buttonCalculate);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Future_Value";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Future Value";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button buttonCalculate;
        private Button buttonExit;
        private TextBox textBoxMonthInvest;
        private TextBox textBoxYIR;
        private TextBox textBoxNmbYears;
        private TextBox textBoxFutureValue;
    }
}
