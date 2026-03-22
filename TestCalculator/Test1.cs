using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZelenikinPractica2;

namespace ZelenikinPractica2.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Test_Add()
        {
            dynamic result = Class1.Exicute(1, '+', 9);
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void Test_Subtract()
        {
            dynamic result = Class1.Exicute(15, '-', 8);
            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void Test_Multiply()
        {
            dynamic result = Class1.Exicute(8, '*', 7);
            Assert.AreEqual(56, result);
        }

        [TestMethod]
        public void Test_Divide()
        {
            dynamic result = Class1.Exicute(25, '/', 5);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Test_Power()
        {
            dynamic result = Class1.Exicute(2, '^', 3);
            Assert.AreEqual(8, result);
        }
    }
}
