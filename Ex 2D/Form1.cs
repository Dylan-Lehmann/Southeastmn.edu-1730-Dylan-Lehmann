namespace Ex_2D
{
    public partial class FormIfStatements : Form
    {
        public FormIfStatements()
        {
            InitializeComponent();
        }

        private void buttonSPV_Click(object sender, EventArgs e)
        {
            textBoxFrankI.Text = "Frank";
            textBoxEmptyI.Text = "";
            textBox23I.Text = "2.3";
            textBoxFalseI.Text = "false";
            textBoxEqualAI.Text = "2";
            textBoxEqualBI.Text = "2";
            textBoxNotJonesI.Text = "xyz";
            textBoxLessEAI.Text = "2";
            textBoxLessEBI.Text = "2";
            textBoxGreater500I.Text = "500";
            textBoxLessAI.Text = "6";
            textBoxLessBI.Text = "7";
            textBoxGreater0I.Text = "1";
        }

        private void buttonSFV_Click(object sender, EventArgs e)
        {
            textBoxFrankI.Text = "xyz";
            textBoxEmptyI.Text = "xyz";
            textBox23I.Text = "2.4";
            textBoxFalseI.Text = "true";
            textBoxEqualAI.Text = "1";
            textBoxEqualBI.Text = "2";
            textBoxNotJonesI.Text = "Jones";
            textBoxLessEAI.Text = "3";
            textBoxLessEBI.Text = "2";
            textBoxGreater500I.Text = "499";
            textBoxLessAI.Text = "7";
            textBoxLessBI.Text = "7";
            textBoxGreater0I.Text = "0";
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            //Set Result A to false
            textBoxRFrankA.Text = "Fail";
            textBoxREmptyA.Text = "Fail";
            textBoxR23A.Text = "Fail";
            textBoxRFalseA.Text = "Fail";
            textBoxREqualA.Text = "Fail";
            textBoxRNotJonesA.Text = "Fail";
            textBoxRLessEA.Text = "Fail";
            textBoxRLessA.Text = "Fail";
            textBoxRGreater0A.Text = "Fail";
            textBoxRGreater500A.Text = "Fail";

            //Check if input is true and change result A to success
            if (textBoxFrankI.Text == "Frank")
            { textBoxRFrankA.Text = "Success"; }
            if (textBoxEmptyI.Text == "")
            { textBoxREmptyA.Text = "Success"; }
            if (textBox23I.Text == "2.3")
            { textBoxR23A.Text = "Success"; }
            if (textBoxFalseI.Text == "false")
            { textBoxRFalseA.Text = "Success"; }
            if (textBoxEqualAI.Text == textBoxEqualBI.Text)
            { textBoxREqualA.Text = "Success"; }
            if (textBoxNotJonesI.Text != "Jones")
            { textBoxRNotJonesA.Text = "Success"; }
            if (Convert.ToDecimal(textBoxLessEAI.Text) <= Convert.ToDecimal(textBoxLessEBI.Text))
            { textBoxRLessEA.Text = "Success"; }
            if (Convert.ToDecimal(textBoxGreater500I.Text) >= 500)
            { textBoxRGreater500A.Text = "Success"; }
           if (Convert.ToDecimal(textBoxLessAI.Text) < Convert.ToDecimal(textBoxLessBI.Text))
            { textBoxRLessA.Text = "Success"; }
           if (Convert.ToDecimal(textBoxGreater0I.Text) > 0)
            { textBoxRGreater0A.Text = "Success"; }

            //Set Result B to true
            textBoxRFrankB.Text = "Success";
            textBoxREmptyB.Text = "Success";
            textBoxR23B.Text = "Success";
            textBoxRFalseB.Text = "Success";
            textBoxREqualB.Text = "Success";
            textBoxRNotJonesB.Text = "Success";
            textBoxRLessEB.Text = "Success";
            textBoxRLessB.Text = "Success";
            textBoxRGreater0B.Text = "Success";
            textBoxRGreater500B.Text = "Success";

            //Check if input is true and change result B to fail
            if (textBoxFrankI.Text != "Frank")
            { textBoxRFrankB.Text = "Fail"; }
            if (textBoxEmptyI.Text != "")
            { textBoxREmptyB.Text = "Fail"; }
            if (textBox23I.Text != "2.3")
            { textBoxR23B.Text = "Fail"; }
            if (textBoxFalseI.Text == "true")
            { textBoxRFalseB.Text = "Fail"; }
            if (textBoxEqualAI.Text != textBoxEqualBI.Text)
            { textBoxREqualB.Text = "Fail"; }
            if (textBoxNotJonesI.Text == "Jones")
            { textBoxRNotJonesB.Text = "Fail"; }
            if (Convert.ToDecimal(textBoxLessEAI.Text) > Convert.ToDecimal(textBoxLessEBI.Text))
            { textBoxRLessEB.Text = "Fail"; }
            if (Convert.ToDecimal(textBoxGreater500I.Text) < 500)
            { textBoxRGreater500B.Text = "Fail"; }
            if (Convert.ToDecimal(textBoxLessAI.Text) >= Convert.ToDecimal(textBoxLessBI.Text))
            { textBoxRLessB.Text = "Fail"; }
            if (Convert.ToDecimal(textBoxGreater0I.Text) <= 0)
            { textBoxRGreater0B.Text = "Fail"; }



        }
    }
}
