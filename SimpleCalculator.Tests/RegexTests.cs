using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class RegexTests
    {
        [TestMethod]
        public void TestInstantiating()
        {
            RegexParser parser = new RegexParser();
            Assert.IsNotNull(parser);
        }

        [TestMethod]
        public void TestParsing1()
        {
            //Arrange - instantiate/declare only what you need to model this situation
            RegexParser parser = new RegexParser();

            //Act - interact with the object
            parser.ParseInput("1 + 2");

            //Assert - verify the expected result against the actual results
            Assert.AreEqual(1, parser.Term1);
            Assert.AreEqual(2, parser.Term2);
            Assert.AreEqual('+', parser.Operator);
        }

        [TestMethod]
        public void TestParsing2()
        {
            RegexParser parser = new RegexParser();
            parser.ParseInput("20 - 5");
            Assert.AreEqual(20, parser.Term1);
            Assert.AreEqual(5, parser.Term2);
            Assert.AreEqual('-', parser.Operator);
        }

        [TestMethod]
        public void TestParsing3()
        {
            RegexParser parser = new RegexParser();
            parser.ParseInput("500      % 26");
            Assert.AreEqual(500, parser.Term1);
            Assert.AreEqual(26, parser.Term2);
            Assert.AreEqual('%', parser.Operator);
        }

        [TestMethod]
        public void TestParsing4()
        {
            RegexParser parser = new RegexParser();
            parser.ParseInput("17 + 42");
            Assert.AreEqual(17, parser.Term1);
            Assert.AreEqual(42, parser.Term2);
            Assert.AreEqual('+', parser.Operator);
        }

        [TestMethod]
        public void TestParsing5()
        {
            RegexParser parser = new RegexParser();
            parser.ParseInput("1 / 2");
            Assert.AreEqual(1, parser.Term1);
            Assert.AreEqual(2, parser.Term2);
            Assert.AreEqual('/', parser.Operator);
        }

        [TestMethod]
        public void TestParsing6()
        {
            RegexParser parser = new RegexParser();
            parser.ParseInput("18*92");
            Assert.AreEqual(18, parser.Term1);
            Assert.AreEqual(92, parser.Term2);
            Assert.AreEqual('*', parser.Operator);
        }

        [TestMethod]
        public void TestParsing7()
        {
            RegexParser parser = new RegexParser();
            parser.ParseInput("-1 - -2");
            Assert.AreEqual(-1, parser.Term1);
            Assert.AreEqual(-2, parser.Term2);
            Assert.AreEqual('-', parser.Operator);
        }

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void TestBadInput1()
        {
            RegexParser parser = new RegexParser();
            parser.ParseInput("arsotenaroistenaroistenarositne");
        }

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void TestBadInput2()
        {
            RegexParser parser = new RegexParser();
            parser.ParseInput("10a * b");
        }

    }
}
