namespace Ex_3C__Product_maintenence
{
    partial class frmNewProduct
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
            labelBookOrSoftware = new Label();
            textBoxCode = new TextBox();
            textBoxDescription = new TextBox();
            textBoxPrice = new TextBox();
            textBoxAuthor = new TextBox();
            buttonCancel = new Button();
            buttonSave = new Button();
            radioButtonBook = new RadioButton();
            radioButtonSofware = new RadioButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(-238, 100);
            label1.Name = "label1";
            label1.Size = new Size(50, 23);
            label1.TabIndex = 0;
            label1.Text = "Code";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(30, 97);
            label2.Name = "label2";
            label2.Size = new Size(50, 23);
            label2.TabIndex = 1;
            label2.Text = "Code";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(30, 136);
            label3.Name = "label3";
            label3.Size = new Size(101, 23);
            label3.TabIndex = 2;
            label3.Text = "Description ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(30, 173);
            label4.Name = "label4";
            label4.Size = new Size(47, 23);
            label4.TabIndex = 3;
            label4.Text = "Price";
            // 
            // labelBookOrSoftware
            // 
            labelBookOrSoftware.AutoSize = true;
            labelBookOrSoftware.Font = new Font("Segoe UI", 10F);
            labelBookOrSoftware.Location = new Point(33, 216);
            labelBookOrSoftware.Name = "labelBookOrSoftware";
            labelBookOrSoftware.Size = new Size(63, 23);
            labelBookOrSoftware.TabIndex = 4;
            labelBookOrSoftware.Text = "Author";
            // 
            // textBoxCode
            // 
            textBoxCode.Location = new Point(135, 97);
            textBoxCode.Name = "textBoxCode";
            textBoxCode.Size = new Size(225, 27);
            textBoxCode.TabIndex = 5;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(137, 132);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(302, 27);
            textBoxDescription.TabIndex = 6;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(137, 173);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(225, 27);
            textBoxPrice.TabIndex = 7;
            // 
            // textBoxAuthor
            // 
            textBoxAuthor.Location = new Point(135, 216);
            textBoxAuthor.Name = "textBoxAuthor";
            textBoxAuthor.Size = new Size(225, 27);
            textBoxAuthor.TabIndex = 8;
            // 
            // buttonCancel
            // 
            buttonCancel.Font = new Font("Segoe UI", 10F);
            buttonCancel.Location = new Point(345, 264);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 9;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonSave
            // 
            buttonSave.Font = new Font("Segoe UI", 10F);
            buttonSave.Location = new Point(245, 264);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 29);
            buttonSave.TabIndex = 10;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // radioButtonBook
            // 
            radioButtonBook.AutoSize = true;
            radioButtonBook.Checked = true;
            radioButtonBook.Font = new Font("Segoe UI", 10F);
            radioButtonBook.Location = new Point(81, 48);
            radioButtonBook.Name = "radioButtonBook";
            radioButtonBook.Size = new Size(69, 27);
            radioButtonBook.TabIndex = 11;
            radioButtonBook.TabStop = true;
            radioButtonBook.Text = "Book";
            radioButtonBook.UseVisualStyleBackColor = true;
            radioButtonBook.CheckedChanged += this.radioButtonBook_CheckedChanged;
            // 
            // radioButtonSofware
            // 
            radioButtonSofware.AutoSize = true;
            radioButtonSofware.Font = new Font("Segoe UI", 10F);
            radioButtonSofware.Location = new Point(190, 48);
            radioButtonSofware.Name = "radioButtonSofware";
            radioButtonSofware.Size = new Size(97, 27);
            radioButtonSofware.TabIndex = 12;
            radioButtonSofware.Text = "Software";
            radioButtonSofware.UseVisualStyleBackColor = true;
            // 
            // frmNewProduct
            // 
            AcceptButton = buttonSave;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancel;
            ClientSize = new Size(498, 301);
            Controls.Add(radioButtonSofware);
            Controls.Add(radioButtonBook);
            Controls.Add(buttonSave);
            Controls.Add(buttonCancel);
            Controls.Add(textBoxAuthor);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxDescription);
            Controls.Add(textBoxCode);
            Controls.Add(labelBookOrSoftware);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmNewProduct";
            StartPosition = FormStartPosition.CenterParent;
            Text = "NewProduct";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label labelBookOrSoftware;
        private TextBox textBoxCode;
        private TextBox textBoxDescription;
        private TextBox textBoxPrice;
        private TextBox textBoxAuthor;
        private Button buttonCancel;
        private Button buttonSave;
        private RadioButton radioButtonBook;
        private RadioButton radioButtonSofware;
    }
}