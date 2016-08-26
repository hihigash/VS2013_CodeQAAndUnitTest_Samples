using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _4_UnitTestDemo
{
    [TestClass]
    public class ArithmeticTests
    {
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Divisionのゼロ割テスト()
        {
            int a = 2;
            int b = 0;
            int actual = Arithmetic.Division2(a, b);
        }

    }
}
