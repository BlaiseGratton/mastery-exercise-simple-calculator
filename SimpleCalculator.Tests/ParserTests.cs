using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    /// <summary>
    /// Summary description for ParserTests
    /// </summary>
    [TestClass]
    public class ParserTests
    {
        [TestMethod]
        public void TestInstantiatingParser()
        {
            Parser parser = new Parser();
            Assert.IsNotNull(parser);
        }

        [TestMethod]
        public void TestReturningAnExpressionObject()
        {
            Parser parser = new Parser();
            var result = parser.Parse("1 + 1");
            Assert.IsInstanceOfType(result, typeof(Expression));
        }

        [TestMethod]
        public void TestParsingInput1()
        {
            Parser parser = new Parser();
            var result = parser.Parse("1 + 1");
            Assert.AreEqual(1, result.Operand);
            Assert.AreEqual('+', result.Operation);
            Assert.AreEqual(1, result.Operator);
        }

        [TestMethod]
        public void TestParsingInput2()
        {
            Parser parser = new Parser();
            var result = parser.Parse("45 + 22");
            Assert.AreEqual(45, result.Operand);
            Assert.AreEqual('+', result.Operation);
            Assert.AreEqual(22, result.Operator);
        }

        [TestMethod]
        public void TestParsingInput3()
        {
            Parser parser = new Parser();
            var result = parser.Parse("4*6");
            Assert.AreEqual(4, result.Operand);
            Assert.AreEqual('*', result.Operation);
            Assert.AreEqual(6, result.Operator);
        }

        [TestMethod]
        public void TestParsingInput4()
        {
            Parser parser = new Parser();
            var result = parser.Parse("4 - 20");
            Assert.AreEqual(4, result.Operand);
            Assert.AreEqual('-', result.Operation);
            Assert.AreEqual(20, result.Operator);
        }

        [TestMethod]
        public void TestParsingInput5()
        {
            Parser parser = new Parser();
            var result = parser.Parse("400/3");
            Assert.AreEqual(400, result.Operand);
            Assert.AreEqual('/', result.Operation);
            Assert.AreEqual(3, result.Operator);
        }

        [TestMethod]
        public void TestParsingInput6()
        {
            Parser parser = new Parser();
            var result = parser.Parse("5 % 3");
            Assert.AreEqual(5, result.Operand);
            Assert.AreEqual('%', result.Operation);
            Assert.AreEqual(3, result.Operator);
        }

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void TestParsingBadInput()
        {
            Parser parser = new Parser();
            parser.Parse("abcdefg");
        }

    }
}
