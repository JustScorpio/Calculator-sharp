using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_sharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        char[] numbers = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
        char[] operands = new char[] { '+', '-', '*', '/' };
        char[] complexOperands = new char[] {'*', '/'};

        private void button1_Click(object sender, EventArgs e)
        {
            RemoveInfinitySymbol();

            textBoxExpression.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RemoveInfinitySymbol();

            textBoxExpression.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RemoveInfinitySymbol();

            textBoxExpression.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RemoveInfinitySymbol();

            textBoxExpression.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RemoveInfinitySymbol();

            textBoxExpression.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RemoveInfinitySymbol();

            textBoxExpression.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            RemoveInfinitySymbol();

            textBoxExpression.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            RemoveInfinitySymbol();

            textBoxExpression.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            RemoveInfinitySymbol();

            textBoxExpression.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            RemoveInfinitySymbol();

            textBoxExpression.Text += "0";
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            RemoveInfinitySymbol();

            if (textBoxExpression.TextLength == 0 || !numbers.Contains(textBoxExpression.Text.Last()))
                textBoxExpression.Text += "0";

            textBoxExpression.Text = textBoxExpression.Text.Substring(0, textBoxExpression.Text.LastIndexOfAny(numbers) + 1);

            textBoxExpression.Text += ",";

            buttonDot.Enabled = false;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            var lastNumIndex = textBoxExpression.Text.LastIndexOfAny(numbers);
            if (lastNumIndex == -1)
            {
                textBoxExpression.Text = string.Empty;
                return;
            }

            textBoxExpression.Text = textBoxExpression.Text.Substring(0, lastNumIndex + 1);

            Calculate();
            textBoxExpression.Text += "+";

            buttonDot.Enabled = true;
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            var lastNumIndex = textBoxExpression.Text.LastIndexOfAny(numbers);
            if (lastNumIndex == -1)
            {
                textBoxExpression.Text = string.Empty;
                return;
            }

            textBoxExpression.Text = textBoxExpression.Text.Substring(0, lastNumIndex + 1);

            Calculate();
            textBoxExpression.Text += "*";

            buttonDot.Enabled = true;
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            var lastNumIndex = textBoxExpression.Text.LastIndexOfAny(numbers);
            if (lastNumIndex == -1)
            {
                textBoxExpression.Text = "-";
                return;
            }
            else
            {
                if (complexOperands.Contains(textBoxExpression.Text.Last()))
                    textBoxExpression.Text += "(";
                else 
                    textBoxExpression.Text = textBoxExpression.Text.Substring(0, lastNumIndex + 1);
            }

            Calculate();
            textBoxExpression.Text += "-";

            buttonDot.Enabled = true;
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            var lastNumIndex = textBoxExpression.Text.LastIndexOfAny(numbers);
            if (lastNumIndex == -1)
            {
                textBoxExpression.Text = string.Empty;
                return;
            }

            textBoxExpression.Text = textBoxExpression.Text.Substring(0, lastNumIndex + 1);

            Calculate();
            textBoxExpression.Text += "/";

            buttonDot.Enabled = true;
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            if (textBoxExpression.TextLength == 0)
                return;

            Calculate();
        }

        private void buttonBackspace_Click(object sender, EventArgs e)
        {
            var textLength = textBoxExpression.TextLength;
            if (textLength == 0)
                return;

            var deletedChar = textBoxExpression.Text.Last();

            textBoxExpression.Text = textBoxExpression.Text.Substring(0, textLength - 1);

            if (deletedChar == ',')
                buttonDot.Enabled = true;
            else if (operands.Contains(deletedChar))
            {
                buttonDot.Enabled = !textBoxExpression.Text.Contains(',');
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text = string.Empty;
        }

        private void Calculate()
        {
            var str = textBoxExpression.Text;

            var indexOfOperand = str.IndexOfAny(operands, 1);
            if (indexOfOperand == -1)
                return;

            var secondNumFirstIndex = str.IndexOfAny(numbers, indexOfOperand);
            if (secondNumFirstIndex == -1)
                return;
            if (str[secondNumFirstIndex - 2] == '(') secondNumFirstIndex--;

            var operand = str[indexOfOperand];
            var firstNumString = str.Substring(0, indexOfOperand);
            var secondNumString = str.Substring(secondNumFirstIndex, str.Length - secondNumFirstIndex);

            try
            {
                var firstNum = Convert.ToDouble(firstNumString);
                var secondNum = Convert.ToDouble(secondNumString);

                double res = 0;
                switch (operand)
                {
                    case '+':
                        res = firstNum + secondNum;
                        break;
                    case '-':
                        res = firstNum - secondNum;
                        break;
                    case '*':
                        res = firstNum * secondNum;
                        break;
                    case '/':
                        res = firstNum / secondNum;
                        break;
                }

                textBoxExpression.Text = res.ToString();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message,
                    //"Что-то пошло не так",
                    //MessageBoxButtons.OK,
                    //MessageBoxIcon.Warning,
                    //MessageBoxDefaultButton.Button1,
                    //MessageBoxOptions.DefaultDesktopOnly);

                MessageBox(new IntPtr(0), ex.Message, "Что-то пошло не так", 0);
            }
        }

        private void RemoveInfinitySymbol()
        {
            if (textBoxExpression.Text.Contains('∞'))
                textBoxExpression.Text = string.Empty;
        }

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int MessageBox(IntPtr hWnd, String text, String caption, uint type);

    }
}
