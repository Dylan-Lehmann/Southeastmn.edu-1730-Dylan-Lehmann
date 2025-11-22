using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex_3C__Product_maintenence
{
    public partial class frmNewProduct : Form
    {
        private Product? product = null;

        public Product GetNewProduct()
        {
            this.ShowDialog();
            return product;
        }
        public frmNewProduct()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButtonBook.Checked)
                {
                    product = new Book(textBoxCode.Text, textBoxDescription.Text,
                        Convert.ToDecimal(textBoxPrice.Text), textBoxAuthor.Text);
                }
                else
                {
                    product = new Software(textBoxCode.Text, textBoxDescription.Text,
                        Convert.ToDecimal(textBoxPrice.Text), textBoxAuthor.Text);

                }
                this.Close();
            }
            catch (FormatException)
            { MessageBox.Show("Input String was not in the correct formant. Please try again."); }
        }
         private void radioButtonBook_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonBook.Checked)
            {
                labelBookOrSoftware.Text = "Author";
            }
            else
            { labelBookOrSoftware.Text = "Version"; }
        }
        
    }
}
