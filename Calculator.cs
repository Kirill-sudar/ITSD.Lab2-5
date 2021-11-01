using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculator:ICalc
    {
        public double Multiplication(double a, double b)
        {
            return a * b;
        }

        public double Division(double a, double b)
        {
            return a / b;
        }

        public double Sum(double a, double b)
        {
            return a + b;
        }

        public double Subtraction(double a, double b) //вычитание
        {
            return a - b;
        }
        public double Sin(double a)
        {
            return Math.Sin(a);
        }
        public double Cos(double a)
        {
            return Math.Cos(a);
        }
    }
}
