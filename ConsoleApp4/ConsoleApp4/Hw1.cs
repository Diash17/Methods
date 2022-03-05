using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    static class homework1
    {
        public static double GetTheResultOfEquation(double a, double b)
        {
            double result = (5 * a) + (b * b) / (b - a);
            return result;
        }

        public static string GetEquationOfTheLineIn4Points(double x1, double y1, double x2, double y2)
        {
            double tmp1 = (y2 - y1);
            double tmp2 = (x2 - x1);
            double tmp3 = ((x1 * y2) - (x2 * y1));
            double A = (tmp1 / tmp2);
            double B = (tmp3 / tmp2);

            string result = ($"y={A}x+{B}");
            return result;
        }

        public static double GetTheResultOfLinearEquation(int a, int b, int c)
        {
            if (a == 0 || b == 0)

            {
                throw new Exception("can't be zero");
            }
            return (c - b) / a;
        }
    }
}
