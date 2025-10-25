namespace Ex_2E
{
    public partial class Ex2e : Form
    {
        private readonly string FAIL = "Fail";
        private readonly string SUCCESS = "Success";
        private readonly string Error = "Error";

        public Ex2e()
        {
            InitializeComponent();
        }


        private void buttonSPV_Click(object sender, EventArgs e)
        {

        }

        private void buttonSFV_Click(object sender, EventArgs e)
        {

        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            


        }

        private void buttonSPV_Click_1(object sender, EventArgs e)
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

        private void buttonSFV_Click_1(object sender, EventArgs e)
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

        private void buttonCalculate_Click_1(object sender, EventArgs e)
        {
            //Set Result A to false
            textBoxRFrankA.Text = FAIL;
            textBoxREmptyA.Text = FAIL;
            textBoxR23A.Text = FAIL;
            textBoxRFalseA.Text = FAIL;
            textBoxREqualA.Text = FAIL;
            textBoxRNotJonesA.Text = FAIL;
            textBoxRLessEA.Text = FAIL;
            textBoxRLessA.Text = FAIL;
            textBoxRGreater0A.Text = FAIL;
            textBoxRGreater500A.Text = FAIL;

            //Set Result B to true
            textBoxRFrankB.Text = SUCCESS;
            textBoxREmptyB.Text = SUCCESS;
            textBoxR23B.Text = SUCCESS;
            textBoxRFalseB.Text = SUCCESS;
            textBoxREqualB.Text = SUCCESS;
            textBoxRNotJonesB.Text = SUCCESS;
            textBoxRLessEB.Text = SUCCESS;
            textBoxRLessB.Text = SUCCESS;
            textBoxRGreater0B.Text = SUCCESS;
            textBoxRGreater500B.Text = SUCCESS;

            textBoxRFrankA.Text = RelationalCalculations.IsFrank(textBoxFrankI.Text) ? SUCCESS : FAIL;
            textBoxRFrankB.Text = RelationalCalculations.IsFrank(textBoxFrankI.Text) ? SUCCESS : FAIL;

            textBoxREmptyA.Text = RelationalCalculations.IsEmpty(textBoxEmptyI.Text) ? SUCCESS : FAIL;
            textBoxREmptyB.Text = RelationalCalculations.IsEmpty(textBoxEmptyI.Text) ? SUCCESS : FAIL;

            textBoxRFalseA.Text = RelationalCalculations.IsFalse(textBoxFalseI.Text) ? SUCCESS : FAIL;
            textBoxRFalseB.Text = RelationalCalculations.IsFalse(textBoxFalseI.Text) ? SUCCESS : FAIL;

            textBoxREqualA.Text = RelationalCalculations.AreEqual(textBoxEqualAI.Text, textBoxEqualBI.Text) ? SUCCESS : FAIL;
            textBoxREqualB.Text = RelationalCalculations.AreEqual(textBoxEqualAI.Text, textBoxEqualBI.Text) ? SUCCESS : FAIL;

            textBoxRNotJonesA.Text = RelationalCalculations.IsNotJones(textBoxNotJonesI.Text) ? SUCCESS : FAIL;
            textBoxRNotJonesB.Text = RelationalCalculations.IsNotJones(textBoxNotJonesI.Text) ? SUCCESS : FAIL;

            textBoxR23A.Text = RelationalCalculations.IsTwoPointThree(textBox23I.Text) ? SUCCESS : FAIL;
            textBoxR23B.Text = RelationalCalculations.IsTwoPointThree(textBox23I.Text) ? SUCCESS : FAIL;

            textBoxRLessEA.Text = RelationalCalculations.IsLessOrEqualsThan(textBoxLessEAI.Text, textBoxLessEBI.Text) ? SUCCESS : FAIL;
            textBoxRLessEB.Text = RelationalCalculations.IsLessOrEqualsThan(textBoxLessEAI.Text, textBoxLessEBI.Text) ? SUCCESS : FAIL;

            textBoxRGreater500A.Text = RelationalCalculations.IsLargerOrEquals500(textBoxGreater500I.Text) ? SUCCESS : FAIL;
            textBoxRGreater500B.Text = RelationalCalculations.IsLargerOrEquals500(textBoxGreater500I.Text) ? SUCCESS : FAIL;

            textBoxRGreater0A.Text = RelationalCalculations.IsLargerThanZero(textBoxGreater0I.Text) ? SUCCESS : FAIL;
            textBoxRGreater0B.Text = RelationalCalculations.IsLargerThanZero(textBoxGreater0I.Text) ? SUCCESS : FAIL;

            textBoxRLessA.Text = RelationalCalculations.IsLessThan(textBoxLessAI.Text, textBoxLessBI.Text) ? SUCCESS : FAIL;
            textBoxRLessB.Text = RelationalCalculations.IsLessThan(textBoxLessAI.Text, textBoxLessBI.Text) ? SUCCESS : FAIL;

           
        }
    }
}
