namespace Ex_3D_New_food_truck
{
    partial class NewFoodTruck
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
            textBoxBlank = new TextBox();
            buttonExit = new Button();
            buttonClear = new Button();
            buttonCalculate = new Button();
            textBoxTotal = new TextBox();
            textBoxTax = new TextBox();
            textBoxPtTotal = new TextBox();
            textBoxHbTotal = new TextBox();
            textBoxHdTotal = new TextBox();
            textBoxHamburgers = new TextBox();
            textBoxHotdogs = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ErrorLabel = new Label();
            SuspendLayout();
            // 
            // textBoxBlank
            // 
            textBoxBlank.BackColor = SystemColors.InactiveBorder;
            textBoxBlank.ForeColor = SystemColors.InactiveBorder;
            textBoxBlank.Location = new Point(344, 279);
            textBoxBlank.Name = "textBoxBlank";
            textBoxBlank.ReadOnly = true;
            textBoxBlank.Size = new Size(32, 27);
            textBoxBlank.TabIndex = 32;
            textBoxBlank.TabStop = false;
            textBoxBlank.Visible = false;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(316, 323);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(94, 29);
            buttonExit.TabIndex = 24;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(201, 323);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(94, 29);
            buttonClear.TabIndex = 22;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(86, 323);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(94, 29);
            buttonCalculate.TabIndex = 20;
            buttonCalculate.Text = "Calculate";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // textBoxTotal
            // 
            textBoxTotal.Location = new Point(348, 221);
            textBoxTotal.Name = "textBoxTotal";
            textBoxTotal.ReadOnly = true;
            textBoxTotal.Size = new Size(74, 27);
            textBoxTotal.TabIndex = 31;
            textBoxTotal.TabStop = false;
            // 
            // textBoxTax
            // 
            textBoxTax.Location = new Point(348, 174);
            textBoxTax.Name = "textBoxTax";
            textBoxTax.ReadOnly = true;
            textBoxTax.Size = new Size(74, 27);
            textBoxTax.TabIndex = 30;
            textBoxTax.TabStop = false;
            // 
            // textBoxPtTotal
            // 
            textBoxPtTotal.Location = new Point(348, 125);
            textBoxPtTotal.Name = "textBoxPtTotal";
            textBoxPtTotal.ReadOnly = true;
            textBoxPtTotal.Size = new Size(74, 27);
            textBoxPtTotal.TabIndex = 29;
            textBoxPtTotal.TabStop = false;
            // 
            // textBoxHbTotal
            // 
            textBoxHbTotal.Location = new Point(348, 76);
            textBoxHbTotal.Name = "textBoxHbTotal";
            textBoxHbTotal.ReadOnly = true;
            textBoxHbTotal.Size = new Size(74, 27);
            textBoxHbTotal.TabIndex = 28;
            textBoxHbTotal.TabStop = false;
            // 
            // textBoxHdTotal
            // 
            textBoxHdTotal.Location = new Point(348, 20);
            textBoxHdTotal.Name = "textBoxHdTotal";
            textBoxHdTotal.ReadOnly = true;
            textBoxHdTotal.Size = new Size(74, 27);
            textBoxHdTotal.TabIndex = 27;
            textBoxHdTotal.TabStop = false;
            // 
            // textBoxHamburgers
            // 
            textBoxHamburgers.Location = new Point(181, 75);
            textBoxHamburgers.Name = "textBoxHamburgers";
            textBoxHamburgers.Size = new Size(58, 27);
            textBoxHamburgers.TabIndex = 19;
            // 
            // textBoxHotdogs
            // 
            textBoxHotdogs.Location = new Point(181, 23);
            textBoxHotdogs.Name = "textBoxHotdogs";
            textBoxHotdogs.Size = new Size(58, 27);
            textBoxHotdogs.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(245, 125);
            label7.Name = "label7";
            label7.Size = new Size(103, 23);
            label7.TabIndex = 26;
            label7.Text = "Pretax Total:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(245, 221);
            label6.Name = "label6";
            label6.Size = new Size(50, 23);
            label6.TabIndex = 25;
            label6.Text = "Total:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(245, 174);
            label5.Name = "label5";
            label5.Size = new Size(38, 23);
            label5.TabIndex = 23;
            label5.Text = "Tax:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(245, 76);
            label4.Name = "label4";
            label4.Size = new Size(80, 23);
            label4.TabIndex = 21;
            label4.Text = "x $5.00 =";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(72, 76);
            label3.Name = "label3";
            label3.Size = new Size(108, 23);
            label3.TabIndex = 18;
            label3.Text = "Hamburgers:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(245, 20);
            label2.Name = "label2";
            label2.Size = new Size(80, 23);
            label2.TabIndex = 16;
            label2.Text = "x $4.00 =";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(72, 20);
            label1.Name = "label1";
            label1.Size = new Size(86, 23);
            label1.TabIndex = 15;
            label1.Text = "Hot Dogs:";
            // 
            // ErrorLabel
            // 
            ErrorLabel.AutoSize = true;
            ErrorLabel.Location = new Point(86, 279);
            ErrorLabel.Name = "ErrorLabel";
            ErrorLabel.Size = new Size(0, 20);
            ErrorLabel.TabIndex = 33;
            // 
            // NewFoodTruck
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 373);
            Controls.Add(ErrorLabel);
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
            Name = "NewFoodTruck";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New Food Truck";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxBlank;
        private Button buttonExit;
        private Button buttonClear;
        private Button buttonCalculate;
        private TextBox textBoxTotal;
        private TextBox textBoxTax;
        private TextBox textBoxPtTotal;
        private TextBox textBoxHbTotal;
        private TextBox textBoxHdTotal;
        private TextBox textBoxHamburgers;
        private TextBox textBoxHotdogs;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label ErrorLabel;
    }
}
