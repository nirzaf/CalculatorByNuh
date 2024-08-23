using System.Globalization;

namespace CalculatorByNuh
{
    public partial class Form1 : Form
    {
        private string Total;
        private double num1;
        private double num2;
        private string option;
        private double result;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnNumber1_Click(object sender, EventArgs e)
        {
            TextBoxCalculator.Text += BtnNumber1.Text;
        }

        private void BtnNumber2_Click(object sender, EventArgs e)
        {
            TextBoxCalculator.Text += BtnNumber2.Text;
        }

        private void BtnNumber3_Click(object sender, EventArgs e)
        {
            TextBoxCalculator.Text += BtnNumber3.Text;
        }

        private void BtnNumber4_Click(object sender, EventArgs e)
        {
            TextBoxCalculator.Text += BtnNumber4.Text;
        }

        private void BtnNumber5_Click(object sender, EventArgs e)
        {
            TextBoxCalculator.Text += BtnNumber5.Text;
        }

        private void BtnNumber6_Click(object sender, EventArgs e)
        {
            TextBoxCalculator.Text += BtnNumber6.Text;
        }

        private void BtnNumber7_Click(object sender, EventArgs e)
        {
            TextBoxCalculator.Text += BtnNumber7.Text;
        }

        private void BtnNumber8_Click(object sender, EventArgs e)
        {
            TextBoxCalculator.Text += BtnNumber8.Text;
        }

        private void BtnNumber9_Click(object sender, EventArgs e)
        {
            TextBoxCalculator.Text += BtnNumber9.Text;
        }

        private void BtnNumber0_Click(object sender, EventArgs e)
        {
            TextBoxCalculator.Text += BtnNumber0.Text;
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            try
            {
                option = BtnPlus.Text;
                num1 = double.Parse(TextBoxCalculator.Text);
                TextBoxCalculator.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            option = BtnMinus.Text;
            num1 = double.Parse(TextBoxCalculator.Text);
            TextBoxCalculator.Text = string.Empty;
        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            option = BtnMultiply.Text;
            num1 = double.Parse(TextBoxCalculator.Text);
            TextBoxCalculator.Text = string.Empty;
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            option = BtnDivide.Text;
            num1 = double.Parse(TextBoxCalculator.Text);
            TextBoxCalculator.Text = string.Empty;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TextBoxCalculator.Text = string.Empty;
            num1 = 0;
            num2 = 0;
        }

        private void BtnEqual_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBoxCalculator.Text == string.Empty)
                {
                    return;
                }

                num2 = int.Parse(TextBoxCalculator.Text);
                result = option switch
                {
                    "+" => num1 + num2,
                    "-" => num1 - num2,
                    "X" => num1 * num2,
                    "/" => num1 / num2,
                    _ => result
                };

                TextBoxCalculator.Text = result.ToString(CultureInfo.InvariantCulture);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}