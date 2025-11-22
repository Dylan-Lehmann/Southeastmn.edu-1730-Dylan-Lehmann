namespace Ex_3C__Product_maintenence
{
    public partial class FrmProductMain : Form
    {
        private ProductList products = new();
        public FrmProductMain()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            frmNewProduct frmNewProduct = new();
            Product newProduct = frmNewProduct.GetNewProduct();

            if (newProduct != null)
            {
                products.Add(newProduct);

                listBoxProducts.Items.Clear();

                foreach (Product p in products)
                { listBoxProducts.Items.Add(p); }
            }
        }

        private void FrmProductMain_Load(object sender, EventArgs e)
        {
            products.LoadFromDataBase();
            listBoxProducts.Items.Clear();

            foreach (Product p in products)
            { listBoxProducts.Items.Add(p); }
        }

        private void buttonDeleteProduct_Click(object sender, EventArgs e)
        {
            Product selectedProduct = (Product) listBoxProducts.SelectedItem;
           
            if (selectedProduct != null)
            {
                products.Remove(selectedProduct);
                listBoxProducts.Items.Clear();

                foreach (Product p in products)
                { listBoxProducts.Items.Add(p); }
            }
        }
    }
}
