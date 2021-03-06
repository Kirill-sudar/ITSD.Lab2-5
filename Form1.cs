using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculator;



namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Calculator c = new Calculator();
        double tmp;
        private void btn_multiplic_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == " " || textBox2.Text == " ") MessageBox.Show("Как минимум одно из полей пустое!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    if (!double.TryParse(textBox1.Text, out tmp) || !double.TryParse(textBox2.Text, out tmp)) throw new ArithmeticException();
                    this.Height = 228;
                    textBox3.Text = Convert.ToDouble(c.Multiplication(Double.Parse(textBox1.Text), Double.Parse(textBox2.Text))).ToString();
                }
            }
            catch (ArithmeticException ex)
            {
                MessageBox.Show("Введены некорректные значения!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_sum_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == " " || textBox2.Text == " ") MessageBox.Show("Как минимум одно из полей пустое!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    if (!double.TryParse(textBox1.Text, out tmp) || !double.TryParse(textBox2.Text, out tmp)) throw new ArithmeticException();
                    this.Height = 228;
                    textBox3.Text = Convert.ToDouble(c.Sum(Double.Parse(textBox1.Text), Double.Parse(textBox2.Text))).ToString();
                }
            }
            catch (ArithmeticException ex)
            {
                MessageBox.Show("Введены некорректные значения!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_substract_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == " " || textBox2.Text == " ") MessageBox.Show("Как минимум одно из полей пустое!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    if (!double.TryParse(textBox1.Text, out tmp) || !double.TryParse(textBox2.Text, out tmp)) throw new ArithmeticException();
                    this.Height = 228;
                    textBox3.Text = Convert.ToDouble(c.Subtraction(Double.Parse(textBox1.Text), Double.Parse(textBox2.Text))).ToString();
                }
            }
            catch (ArithmeticException ex)
            {
                MessageBox.Show("Введены некорректные значения!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_divide_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == " " || textBox2.Text == " ") MessageBox.Show("Как минимум одно из полей пустое!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    if (!double.TryParse(textBox1.Text, out tmp) || !double.TryParse(textBox2.Text, out tmp)) throw new ArithmeticException();
                    if (double.Parse(textBox2.Text) == 0) throw new DivideByZeroException();
                    this.Height = 228;
                    textBox3.Text = Convert.ToDouble(c.Division(Double.Parse(textBox1.Text), Double.Parse(textBox2.Text))).ToString();
                }
            }
            catch(DivideByZeroException ex)
            {
                MessageBox.Show("Деление на ноль невозможно!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch(ArithmeticException ex)
            {
                MessageBox.Show("Введены некорректные значения!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Height = 194;
        }
        //realize interface of an arithmetic actions for any button
    }
}
