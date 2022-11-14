using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathSolver
{
    public class CMath
    {
        public bool IsPrimeNumber(int number)
        {
            bool isPrime = false;

            int n, i, m = 0;
            int flag = 0;

            m = number / 2;
            for (i = 2; i <= m; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    flag = 1;
                }
            }
            if (flag == 0)
            {
                isPrime = true;
            }

            return isPrime;
        }

        public void SolveQuadraticEquation(double a, double b, double c, out double xout1, out double xout2)
        {
            double sqrtpart = (b * b) - (4 * a * c);

            double answer1 = ((-1) * b + Math.Sqrt(sqrtpart)) / (2 * a);
            double answer2 = ((-1) * b - Math.Sqrt(sqrtpart)) / (2 * a);

            xout1 = answer1;
            xout2 = answer2;
        }
    }
}
