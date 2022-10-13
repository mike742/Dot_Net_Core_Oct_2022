using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QE
{
    public class QuadraticEquation
    {
        public static string Calculate(int a, int b, int c)
        {
            if (a < -99 || a > 99 || b < -99 || b > 99)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (b * b < 4 * a * c)
            {
                return "Solution: x's roots are imaginary";
            }

            if (b * b == 4 * a * c)
            {
                double res = -b / (a * 2);

                return $"Solution: x = {res.ToString("0.000")}";
            }

            double x1 = (-b + Math.Sqrt(b * b - 4 * a * c)) / (a * 2);
            double x2 = (-b - Math.Sqrt(b * b - 4 * a * c)) / (a * 2);

            return $"Solution: x = {x1.ToString("0.000")}, x = {x2.ToString("0.000")}";
        }
    }
}
