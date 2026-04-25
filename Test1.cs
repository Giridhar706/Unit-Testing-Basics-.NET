using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorLibrary;
using System;

namespace CalculatorTests
{
    [TestClass]
    public class CalculatorTest
    {
        Calculator calc = new Calculator();

        [TestMethod]
        public void TestAddition()
        {
            Assert.AreEqual(10, calc.Add(5, 5));
        }

        [TestMethod]
        public void TestSubtraction()
        {
            Assert.AreEqual(2, calc.Subtract(5, 3));
        }

        [TestMethod]
        public void TestMultiplication()
        {
            Assert.AreEqual(15, calc.Multiply(5, 3));
        }

        [TestMethod]
        public void TestDivision()
        {
            Assert.AreEqual(2, calc.Divide(10, 5));
        }

        [TestMethod]
        public void TestDivideByZero()
        {
            try
            {
                calc.Divide(5, 0);
                Assert.Fail("Expected exception not thrown");
            }
            catch (DivideByZeroException)
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void TestWithZero()
        {
            Assert.AreEqual(5, calc.Add(5, 0));
        }
    }
}