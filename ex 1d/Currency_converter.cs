using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex_1d
{
    public partial class Currency_converter : Form
    {
        public Currency_converter()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxMexAmt.Text = "0.00";
            textBoxMexUsd.Text = "0.00";
            textBoxMexRte.Text = "0.05432634";
            textBoxArgAmt.Text = "0.00";
            textBoxArgUsd.Text = "0.00";
            textBoxArgRte.Text = "0.00067810043";
            textBoxBrzAmt.Text = "0.00";
            textBoxBrzUsd.Text = "0.00";
            textBoxBrzRte.Text = "0.18793103";
            textBoxJapAmt.Text = "0.00";
            textBoxJapUsd.Text = "0.00";
            textBoxJapRte.Text = "0.0067579979";
            textBoxUsd.Text = "0.00";
        }

        private void TextMexicoChanged(object sender, EventArgs e)
        {
            textBoxMexUsd.Text = (Convert.ToDecimal(textBoxMexAmt.Text) * Convert.ToDecimal(textBoxMexRte.Text)).ToString("0.00");
            textBoxUsd.Text = (Convert.ToDecimal(textBoxMexUsd.Text) + Convert.ToDecimal(textBoxArgUsd.Text) + Convert.ToDecimal(textBoxBrzUsd.Text) + Convert.ToDecimal(textBoxJapUsd.Text)).ToString("0.00");
        }

        private void TextArgChanged(object sender, EventArgs e)
        {
            textBoxArgUsd.Text = (Convert.ToDecimal(textBoxArgAmt.Text) * Convert.ToDecimal(textBoxArgRte.Text)).ToString("0.00");
            textBoxUsd.Text = (Convert.ToDecimal(textBoxMexUsd.Text) + Convert.ToDecimal(textBoxArgUsd.Text) + Convert.ToDecimal(textBoxBrzUsd.Text) + Convert.ToDecimal(textBoxJapUsd.Text)).ToString("0.00");
        }

        private void TextBrazilChanged(object sender, EventArgs e)
        {
            textBoxBrzUsd.Text = (Convert.ToDecimal(textBoxBrzAmt.Text) * Convert.ToDecimal(textBoxBrzRte.Text)).ToString("0.00");
            textBoxUsd.Text = (Convert.ToDecimal(textBoxMexUsd.Text) + Convert.ToDecimal(textBoxArgUsd.Text) + Convert.ToDecimal(textBoxBrzUsd.Text) + Convert.ToDecimal(textBoxJapUsd.Text)).ToString("0.00");
        }

        private void TextJapanChanged(object sender, EventArgs e)
        {
            textBoxJapUsd.Text = (Convert.ToDecimal(textBoxJapAmt.Text) * Convert.ToDecimal(textBoxJapRte.Text)).ToString("0.00");
            textBoxUsd.Text = (Convert.ToDecimal(textBoxMexUsd.Text) + Convert.ToDecimal(textBoxArgUsd.Text) + Convert.ToDecimal(textBoxBrzUsd.Text) + Convert.ToDecimal(textBoxJapUsd.Text)).ToString("0.00");
        }
    }
}