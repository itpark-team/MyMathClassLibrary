using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMathClassLibrary
{
    public class PlainArithmetic
    {
        public double Sum(double a, double b)
        {
            return a + b;
        }

        public double Sub(double a, double b)
        {
            return a - b;
        }

        public double Mul(double a, double b)
        {
            return a * b;
        }

        public double Dev(double a, double b)
        {
            if (b == 0)
            {
                throw new Exception("devision by zero");
            }
            return a / b;
        }

    }
}
