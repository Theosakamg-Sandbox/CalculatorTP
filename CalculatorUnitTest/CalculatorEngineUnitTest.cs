using System;
using Console;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorUnitTest
{
    [TestClass]
    public class CalculatorEngineUnitTest
    {
        [TestMethod]
        public void TestMethodAdd()
        {
            // 
            int a = 1;
            int b = 2;
            int expected = 3;

            //
            CalculatorEngine engine = new CalculatorEngine();
            int actual = engine.Addition(a, b);

            //
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodSub()
        {
            // 
            int a = 3;
            int b = 2;
            int expected = 1;

            //
            CalculatorEngine engine = new CalculatorEngine();
            int actual = engine.Subtraction(a, b);

            //
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodMul()
        {
            // 
            int a = 3;
            int b = 2;
            int expected = 6;

            //
            CalculatorEngine engine = new CalculatorEngine();
            int actual = engine.Multiplication(a, b);

            //
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodDiv()
        {
            // 
            int a = 6;
            int b = 2;
            int expected = 3;

            //
            CalculatorEngine engine = new CalculatorEngine();
            int actual = engine.Division(a, b);

            //
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodDivByZero()
        {
            // 
            int a = 6;
            int b = 0;
            int expected = Int32.MinValue;

            //
            CalculatorEngine engine = new CalculatorEngine();
            int actual = engine.Division(a, b);

            //
            Assert.AreEqual(expected, actual);
        }
    }
}
