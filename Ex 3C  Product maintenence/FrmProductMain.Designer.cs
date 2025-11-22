namespace Ex_3C__Product_maintenence
{
    partial class FrmProductMain
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
            buttonAddProduct = new Button();
            buttonExit = new Button();
            buttonDeleteProduct = new Button();
            listBoxProducts = new ListBox();
            SuspendLayout();
            // 
            // buttonAddProduct
            // 
            buttonAddProduct.Location = new Point(576, 31);
            buttonAddProduct.Name = "buttonAddProduct";
            buttonAddProduct.Size = new Size(140, 66);
            buttonAddProduct.TabIndex = 0;
            buttonAddProduct.Text = "Add Product";
            buttonAddProduct.UseVisualStyleBackColor = true;
            buttonAddProduct.Click += buttonAddProduct_Click;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(576, 184);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(140, 66);
            buttonExit.TabIndex = 3;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // buttonDeleteProduct
            // 
            buttonDeleteProduct.Location = new Point(576, 103);
            buttonDeleteProduct.Name = "buttonDeleteProduct";
            buttonDeleteProduct.Size = new Size(140, 66);
            buttonDeleteProduct.TabIndex = 4;
            buttonDeleteProduct.Text = "Delete Product";
            buttonDeleteProduct.UseVisualStyleBackColor = true;
            buttonDeleteProduct.Click += buttonDeleteProduct_Click;
            // 
            // listBoxProducts
            // 
            listBoxProducts.FormattingEnabled = true;
            listBoxProducts.Location = new Point(12, 19);
            listBoxProducts.Name = "listBoxProducts";
            listBoxProducts.Size = new Size(544, 324);
            listBoxProducts.TabIndex = 5;
            // 
            // FrmProductMain
            // 
            AcceptButton = buttonAddProduct;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonExit;
            ClientSize = new Size(729, 366);
            Controls.Add(listBoxProducts);
            Controls.Add(buttonDeleteProduct);
            Controls.Add(buttonExit);
            Controls.Add(buttonAddProduct);
            Name = "FrmProductMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product Maintenance";
            Load += FrmProductMain_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAddProduct;
        private Button buttonExit;
        private Button buttonDeleteProduct;
        private ListBox listBoxProducts;
    }
}
