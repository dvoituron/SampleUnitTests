using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DevApps.MyProject;

namespace DevApps.MyProjectTests
{
    [TestClass]
    public class MathTests
    {
        [TestMethod]
        public void DivideTwoIntegers_ToInteger()
        {
            double result = SimpleMath.Divide(20, 2);
            Assert.AreEqual(10, result);
        }

        [TestMethod]        
        public void DivideTwoIntegers_ToRounded()
        {
            double result = SimpleMath.Divide(20, 3);  // 6 or 6.666 ?
            Assert.AreEqual(7, result);
        }

        [TestMethod]
        //[ExpectedException(typeof(DivideByZeroException))]
        public void DivideTwoIntegers_ByZero()
        {
            double result = SimpleMath.Divide(100, 0);
            Assert.IsTrue(double.IsInfinity(result));
        }

        [TestMethod]
        public void Surface_Normal()
        {
            int surface = SimpleMath.Surface(2, 3);
            Assert.AreEqual(6, surface);
        }

        [TestMethod]
        public void Surface_NegativeWidth()
        {
            int surface = SimpleMath.Surface(3, -2);
            Assert.AreEqual(0, surface);
        }

        [TestMethod]
        public void Surface_NegativeHeight()
        {
            int surface = SimpleMath.Surface(-2, 3);
            Assert.AreEqual(0, surface);
        }
    }
}
