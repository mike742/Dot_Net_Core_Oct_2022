using Microsoft.VisualStudio.TestTools.UnitTesting;
using QE;
using System;

namespace QuadraticEquationUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        private int _a;
        private int _b;
        private int _c;

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Calculate_a_is_outOfRange()
        {
            _a = 100;
            _b = 2;
            _c = 3;
            QuadraticEquation.Calculate(_a, _b, _c);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Calculate_b_is_outOfRange()
        {
            _a = 2;
            _b = -100;
            _c = 3;
            QuadraticEquation.Calculate(_a, _b, _c);
        }

        [TestMethod]
        public void Calculate_Imaginary_Roots()
        {
            _a = 2;
            _b = 1;
            _c = 2;

            string actualResult = QuadraticEquation.Calculate(_a,_b,_c);    
            string expectedResult = "Solution: x's roots are imaginary";

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Calculate_One_Root()
        {
            _a = 1;
            _b = -2;
            _c = 1;

            string actualResult = QuadraticEquation.Calculate(_a, _b, _c);
            string expectedResult = "Solution: x = 1.000";

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Calculate_Two_Roots()
        {
            _a = -5;
            _b = 5;
            _c = 5;

            string actualResult = QuadraticEquation.Calculate(_a, _b, _c);
            string expectedResult = "Solution: x = -0.618, x = 1.618";

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}