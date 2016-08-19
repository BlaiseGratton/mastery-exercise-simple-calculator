using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class ExpressionTests
    {
        [TestMethod]
        public void TestInstantiating()
        {
            Expression exp = new Expression();
            Assert.IsNotNull(exp);
        }

        [TestMethod]
        public void TestInstantiatingWithRightInputs()
        {
            Expression exp = new Expression(1, '+', 2);
            Assert.AreEqual(1, exp.Operand);
            Assert.AreEqual('+', exp.Operation);
            Assert.AreEqual(2, exp.Operator);
        }

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void TestInstantiatingWithBadInput()
        {
            Expression exp = new Expression(1, 'a', 4);
        }

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void TestInstantiatingWithBadInput2()
        {
            Expression exp = new Expression(-1, '+', -1);
        }
    }
}