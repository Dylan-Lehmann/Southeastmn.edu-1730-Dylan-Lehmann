namespace ex1c_food_truck
{
    partial class Food_Truck
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBoxHotdogs = new TextBox();
            textBoxHamburgers = new TextBox();
            textBoxHdTotal = new TextBox();
            textBoxHbTotal = new TextBox();
            textBoxPtTotal = new TextBox();
            textBoxTax = new TextBox();
            textBoxTotal = new TextBox();
            buttonCalculate = new Button();
            buttonClear = new Button();
            buttonExit = new Button();
            textBoxBlank = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(53, 44);
            label1.Name = "label1";
            label1.Size = new Size(86, 23);
            label1.TabIndex = 0;
            label1.Text = "Hot Dogs:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(226, 44);
            label2.Name = "label2";
            label2.Size = new Size(80, 23);
            label2.TabIndex = 1;
            label2.Text = "x $4.00 =";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(53, 100);
            label3.Name = "label3";
            label3.Size = new Size(108, 23);
            label3.TabIndex = 2;
            label3.Text = "Hamburgers:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(226, 100);
            label4.Name = "label4";
            label4.Size = new Size(80, 23);
            label4.TabIndex = 3;
            label4.Text = "x $5.00 =";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(226, 198);
            label5.Name = "label5";
            label5.Size = new Size(38, 23);
            label5.TabIndex = 4;
            label5.Text = "Tax:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(226, 245);
            label6.Name = "label6";
            label6.Size = new Size(50, 23);
            label6.TabIndex = 5;
            label6.Text = "Total:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(226, 149);
            label7.Name = "label7";
            label7.Size = new Size(103, 23);
            label7.TabIndex = 6;
            label7.Text = "Pretax Total:";
            // 
            // textBoxHotdogs
            // 
            textBoxHotdogs.Location = new Point(162, 47);
            textBoxHotdogs.Name = "textBoxHotdogs";
            textBoxHotdogs.Size = new Size(58, 27);
            textBoxHotdogs.TabIndex = 1;
            // 
            // textBoxHamburgers
            // 
            textBoxHamburgers.Location = new Point(162, 99);
            textBoxHamburgers.Name = "textBoxHamburgers";
            textBoxHamburgers.Size = new Size(58, 27);
            textBoxHamburgers.TabIndex = 2;
            // 
            // textBoxHdTotal
            // 
            textBoxHdTotal.Location = new Point(329, 44);
            textBoxHdTotal.Name = "textBoxHdTotal";
            textBoxHdTotal.ReadOnly = true;
            textBoxHdTotal.Size = new Size(74, 27);
            textBoxHdTotal.TabIndex = 9;
            textBoxHdTotal.TabStop = false;
            // 
            // textBoxHbTotal
            // 
            textBoxHbTotal.Location = new Point(329, 100);
            textBoxHbTotal.Name = "textBoxHbTotal";
            textBoxHbTotal.ReadOnly = true;
            textBoxHbTotal.Size = new Size(74, 27);
            textBoxHbTotal.TabIndex = 10;
            textBoxHbTotal.TabStop = false;
            // 
            // textBoxPtTotal
            // 
            textBoxPtTotal.Location = new Point(329, 149);
            textBoxPtTotal.Name = "textBoxPtTotal";
            textBoxPtTotal.ReadOnly = true;
            textBoxPtTotal.Size = new Size(74, 27);
            textBoxPtTotal.TabIndex = 11;
            textBoxPtTotal.TabStop = false;
            // 
            // textBoxTax
            // 
            textBoxTax.Location = new Point(329, 198);
            textBoxTax.Name = "textBoxTax";
            textBoxTax.ReadOnly = true;
            textBoxTax.Size = new Size(74, 27);
            textBoxTax.TabIndex = 12;
            textBoxTax.TabStop = false;
            // 
            // textBoxTotal
            // 
            textBoxTotal.Location = new Point(329, 245);
            textBoxTotal.Name = "textBoxTotal";
            textBoxTotal.ReadOnly = true;
            textBoxTotal.Size = new Size(74, 27);
            textBoxTotal.TabIndex = 13;
            textBoxTotal.TabStop = false;
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(67, 347);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(94, 29);
            buttonCalculate.TabIndex = 3;
            buttonCalculate.Text = "Calculate";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(182, 347);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(94, 29);
            buttonClear.TabIndex = 4;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(297, 347);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(94, 29);
            buttonExit.TabIndex = 5;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // textBoxBlank
            // 
            textBoxBlank.BackColor = SystemColors.InactiveBorder;
            textBoxBlank.ForeColor = SystemColors.InactiveBorder;
            textBoxBlank.Location = new Point(325, 303);
            textBoxBlank.Name = "textBoxBlank";
            textBoxBlank.ReadOnly = true;
            textBoxBlank.Size = new Size(32, 27);
            textBoxBlank.TabIndex = 14;
            textBoxBlank.TabStop = false;
            textBoxBlank.Visible = false;
            // 
            // Food_Truck
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 388);
            Controls.Add(textBoxBlank);
            Controls.Add(buttonExit);
            Controls.Add(buttonClear);
            Controls.Add(buttonCalculate);
            Controls.Add(textBoxTotal);
            Controls.Add(textBoxTax);
            Controls.Add(textBoxPtTotal);
            Controls.Add(textBoxHbTotal);
            Controls.Add(textBoxHdTotal);
            Controls.Add(textBoxHamburgers);
            Controls.Add(textBoxHotdogs);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Food_Truck";
            Text = "Food_Truck";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBoxHotdogs;
        private TextBox textBoxHamburgers;
        private TextBox textBoxHdTotal;
        private TextBox textBoxHbTotal;
        private TextBox textBoxPtTotal;
        private TextBox textBoxTax;
        private TextBox textBoxTotal;
        private Button buttonCalculate;
        private Button buttonClear;
        private Button buttonExit;
        private TextBox textBoxBlank;
    }
}