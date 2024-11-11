using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using NCalc;

namespace Calculator
{
    public partial class MyCalculator : Form
    {
        private string some;
        public MyCalculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button27_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button28_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button32_Click(object sender, EventArgs e)
        {

            GlobalFunc.Instance.NowString = textBox1.Text;
            ///* 计算过程 */
            var expr1 = new NCalc.Expression(textBox1.Text);
            object obj1 = expr1.Evaluate();
            string number=obj1.ToString();
            GlobalFunc.Instance.HistoryString = GlobalFunc.Instance.NowString + "=" + number + "\n";
            textBox2.Text = number;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try 
            {
                textBox2.Text += Math.Sin((Convert.ToDouble(textBox1.Text) * Math.PI) / 180);
                GlobalFunc.Instance.HistoryString = "sin" + textBox1.Text + "=" + textBox2.Text + "\n";
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            textBox1.Text += '0';
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try 
            {
                textBox2.Text += Math.Tan((Convert.ToDouble(textBox1.Text) * Math.PI) / 180);
                GlobalFunc.Instance.HistoryString = "tan" + textBox1.Text + "=" + textBox2.Text + "\n";
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                textBox2.Text += Math.Cos((Convert.ToDouble(textBox1.Text) * Math.PI) / 180);
                GlobalFunc.Instance.HistoryString = "cos" + textBox1.Text + "=" + textBox2.Text + "\n";
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label2.Text += GlobalFunc.Instance.HistoryString;
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                textBox2.Text = Convert.ToString(Math.Log(Math.Abs(Convert.ToDouble(textBox1.Text)), Math.E));
                GlobalFunc.Instance.HistoryString = "ln(" + textBox1.Text + ")=" + textBox2.Text + "\n";
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                textBox2.Text = Convert.ToString(Math.Abs(Convert.ToDouble(textBox1.Text)));
                GlobalFunc.Instance.HistoryString = "abs(" + textBox1.Text + ")=" + textBox2.Text + "\n";
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            try
            {
                textBox2.Text = Convert.ToString(Math.Pow(Convert.ToDouble(textBox1.Text), 2));
                GlobalFunc.Instance.HistoryString = "pow(" + textBox1.Text + ",2)=" + textBox2.Text + "\n";
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            try
            {
                textBox2.Text = Convert.ToString(Math.Log10(Math.Abs(Convert.ToDouble(textBox1.Text))));
                GlobalFunc.Instance.HistoryString = "lg(" + textBox1.Text + ")=" + textBox2.Text + "\n";
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            try
            {
                textBox2.Text = Convert.ToString(Math.Pow(Math.Abs(Convert.ToDouble(textBox1.Text)), 1 / 2.0));
                GlobalFunc.Instance.HistoryString = "pow(" + textBox1.Text + ",0.5)=" + textBox2.Text + "\n";
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                int number = Convert.ToInt32(textBox1.Text);
                int res = 1;
                for (int i = 1; i < number + 1; i++)
                {
                    res *= i;
                }
                textBox2.Text = Convert.ToString(res);
                GlobalFunc.Instance.HistoryString = textBox1.Text + "!=" + textBox2.Text + "\n";
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Substring(1, textBox1.Text.Length - 1);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "(";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += ")";
        }

        private void button30_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }
    }
    // 算法题，来自力扣
    // https://leetcode.cn/problems/basic-calculator/description/
    // https://leetcode.cn/problems/basic-calculator-ii/
    // https://leetcode.cn/problems/basic-calculator-iii/
}
