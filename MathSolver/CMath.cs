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
            int a = 0;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    a++;
                }
            }
            if (a == 2)
            {
                isPrime = true;
            }
            return isPrime;
        }
    }
}
