namespace Ex_2c
{
    public partial class Form1 : Form
    {
        private short short1, short2, short3;
        private int int1, int2, int3;
        private double double1, double2, double3;
        private decimal decimal1, decimal2, decimal3;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonMinimum_Click(object sender, EventArgs e)
        {

            short1 = Int16.MinValue; textBoxS1.Text = short1.ToString();

            int1 = int.MinValue; textBoxI1.Text = int1.ToString();

            double1 = double.MinValue; textBoxDo1.Text = double1.ToString();

            decimal1 = decimal.MinValue; textBoxDe1.Text = decimal1.ToString();
        }

        private void buttonMaximum_Click(object sender, EventArgs e)
        {

            short2 = Int16.MaxValue; textBoxS2.Text = short2.ToString();

            int2 = int.MaxValue; textBoxI2.Text = int2.ToString();

            double2 = double.MaxValue; textBoxDo2.Text = double2.ToString();

            decimal2 = decimal.MaxValue; textBoxDe2.Text = decimal2.ToString();

        }

        private void textBoxInput1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                short1 = Convert.ToInt16(textBoxInput1.Text);
                textBoxS1.Text = short1.ToString();
            }
            catch (Exception) { textBoxS1.Text = "error"; }
            try
            {
                int1 = Convert.ToInt32(textBoxInput1.Text);
                textBoxI1.Text = int1.ToString();
            }
            catch (Exception) { textBoxI1.Text = "error"; }
            try
            {
                double1 = Convert.ToInt64(textBoxInput1.Text);
                textBoxDo1.Text = double1.ToString();
            }
            catch (Exception) { textBoxDo1.Text = "error"; }
            try
            {
                decimal1 = Convert.ToDecimal(textBoxInput1.Text);
                textBoxDe1.Text = decimal1.ToString();
            }
            catch (Exception) { textBoxDe1.Text = "error"; }

        }

        private void textBoxInput2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                short2 = Convert.ToInt16(textBoxInput2.Text);
                textBoxS2.Text = short2.ToString();
            }
            catch (Exception) { textBoxS2.Text = "error"; }
            try
            {
                int2 = Convert.ToInt32(textBoxInput2.Text);
                textBoxI2.Text = int2.ToString();
            }
            catch (Exception) { textBoxI2.Text = "error"; }
            try
            {
                double2 = Convert.ToInt64(textBoxInput2.Text);
                textBoxDo2.Text = double2.ToString();
            }
            catch (Exception) { textBoxDo2.Text = "error"; }
            try
            {
                decimal2 = Convert.ToDecimal(textBoxInput2.Text);
                textBoxDe2.Text = decimal2.ToString();
            }
            catch (Exception) { textBoxDe2.Text = "error"; }

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                short short3 = 0;
                short3 = Convert.ToInt16(this.short1 + this.short2);
                textBoxS3.Text = short3.ToString();
            }
            catch (Exception) { textBoxS3.Text = "error"; }
            try
            {
                int int3 = 0;
                int3 = checked(this.int1 + this.int2);
                textBoxI3.Text = int3.ToString();
            }
            catch (Exception) { textBoxI3.Text = "error"; }
            try
            {
                double double3 = 0;
                double3 = Convert.ToInt64(this.double1 + this.double2);
                textBoxDo3.Text = double3.ToString();
            }
            catch (Exception) { textBoxDo3.Text = "error"; }
            try
            {
                decimal decimal3 = 0;
                decimal3 = Convert.ToDecimal(this.decimal1 + this.decimal2);
                textBoxDe3.Text = decimal3.ToString();
            }
            catch (Exception) { textBoxDe3.Text = "error"; }
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {

            try
            {
                short short3 = 0;
                short3 = Convert.ToInt16(this.short1 - this.short2);
                textBoxS3.Text = short3.ToString();
            }
            catch (Exception) { textBoxS3.Text = "error"; }
            try
            {
                int int3 = 0;
                int3 = checked(this.int1 - this.int2);
                textBoxI3.Text = int3.ToString();
            }
            catch (Exception) { textBoxI3.Text = "error"; }
            try
            {
                double double3 = 0;
                double3 = Convert.ToInt64(this.double1 - this.double2);
                textBoxDo3.Text = double3.ToString();
            }
            catch (Exception) { textBoxDo3.Text = "error"; }
            try
            {
                decimal decimal3 = 0;
                decimal3 = Convert.ToDecimal(this.decimal1 - this.decimal2);
                textBoxDe3.Text = decimal3.ToString();
            }
            catch (Exception) { textBoxDe3.Text = "error"; }
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            try
            {
                short short3 = 0;
                short3 = Convert.ToInt16(this.short1 * this.short2);
                textBoxS3.Text = short3.ToString();
            }
            catch (Exception) { textBoxS3.Text = "error"; }
            try
            {
                int int3 = 0;
                int3 = checked(this.int1 * this.int2);
                textBoxI3.Text = int3.ToString();
            }
            catch (Exception) { textBoxI3.Text = "error"; }
            try
            {
                double double3 = 0;
                double3 = Convert.ToInt64(this.double1 * this.double2);
                textBoxDo3.Text = double3.ToString();
            }
            catch (Exception) { textBoxDo3.Text = "error"; }
            try
            {
                decimal decimal3 = 0;
                decimal3 = Convert.ToDecimal(this.decimal1 * this.decimal2);
                textBoxDe3.Text = decimal3.ToString();
            }
            catch (Exception) { textBoxDe3.Text = "error"; }
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            try
            {
                short short3 = 0;
                short3 = Convert.ToInt16(this.short1 / this.short2);
                textBoxS3.Text = short3.ToString();
            }
            catch (Exception) { textBoxS3.Text = "error"; }
            try
            {
                int int3 = 0;
                int3 = checked(this.int1 / this.int2);
                textBoxI3.Text = int3.ToString();
            }
            catch (Exception) { textBoxI3.Text = "error"; }
            try
            {
                double double3 = 0;
                double3 = Convert.ToInt64(this.double1 / this.double2);
                textBoxDo3.Text = double3.ToString();
            }
            catch (Exception) { textBoxDo3.Text = "error"; }
            try
            {
                decimal decimal3 = 0;
                decimal3 = Convert.ToDecimal(this.decimal1 / this.decimal2);
                textBoxDe3.Text = decimal3.ToString();
            }
            catch (Exception) { textBoxDe3.Text = "error"; }
        }
    }
    
}
