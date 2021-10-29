using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_multiplic_Click(object sender, EventArgs e)
        {
            try
            {

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

            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show("Деление на ноль невозможно!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
    }
}
