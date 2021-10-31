using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    interface ICalc
    {
        double Multiplication(double a, double b);
        double Division(double a, double b);
        double Sum(double a, double b);
        double Subtraction(double a, double b);
    }
}
