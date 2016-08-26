using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_UnitTestDemo
{
    public static class Arithmetic
    {
        public static int Addition(int b, int a)
        {
            return a + b;
        }

        public static int Subtraction(int a, int b)
        {
            return a - b;
        }

        public static int Multiplication(int a, int b)
        {
            return a * b;
        }

        public static int Division2(int a, int b)
        {
            if (b == 0) return 0;
            return a / b;
        }
    }
}
