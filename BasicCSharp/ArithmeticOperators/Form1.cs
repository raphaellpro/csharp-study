using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArithmeticOperators
{
    public partial class FrmCalculator : Form
    {
        public FrmCalculator()
        {
            InitializeComponent();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            int number1 = Convert.ToInt32(txbNumber1.Text);
            int number2 = Convert.ToInt32(txbNumber2.Text);
            //int result = number1 + number2;
            number1 += number2;
            txbResult.Text = number1.ToString();


        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            int number1 = Convert.ToInt32(txbNumber1.Text);
            int number2 = Convert.ToInt32(txbNumber2.Text);
            //int result = number1 - number2;
            number1 -= number2;

            txbResult.Text = number1.ToString();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            int number1 = Convert.ToInt32(txbNumber1.Text);
            int number2 = Convert.ToInt32(txbNumber2.Text);
            //int result = number1 * number2;
            number1 *= number2;

            txbResult.Text = number1.ToString();
        }

        private void btnToDivide_Click(object sender, EventArgs e)
        {
            int number1 = Convert.ToInt32(txbNumber1.Text);
            int number2 = Convert.ToInt32(txbNumber2.Text);
            //int result = number1 / number2;
            number1 /= number2;

            txbResult.Text = number1.ToString();
        }
    }
}
