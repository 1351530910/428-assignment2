using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _428_assignment2;

namespace _428_assignment2_tests
{
    [TestClass]
    public class CalculatorTests
    {
        public package validpackage = new package("h2l2c9", "h2x1j5", 15, 10, 30,2, PostType.Regular);

        [TestInitialize]
        public void initialize()
        {
            DataSheet.init();
        }
        [TestMethod]
        public void testSmallPackage()
        {
            package package = new package(validpackage);
            Assert.AreEqual("9.49", calculator.getPrice(package));
        }
        [TestMethod]

        public void testLongDistance()
        {
            package package = new package("h2x2e2", "n4e6p6", 15, 10, 30, 2, PostType.Regular);
            Assert.AreEqual("14.49", calculator.getPrice(package));
        }
        [TestMethod]
        public void testnullreference()
        {
            Assert.AreEqual("invalid package", calculator.getPrice(null));
        }
        [TestMethod]
        public void testPostalCapital()
        {
            package package = new package("H2L2C9", "H2X1J5", 15, 10, 30, 2, PostType.Regular);
            Assert.AreEqual("9.49", calculator.getPrice(package));
        }

        [TestMethod]
        public void testNullFrom()
        {
            package apackage = new package(validpackage);
            apackage.from = null;
            Assert.AreEqual("invalid from", calculator.getPrice(apackage));
        }
        [TestMethod]
        public void testNullTo()
        {
            package bpackage = new package(validpackage);
            bpackage.to = null;
            Assert.AreEqual("invalid to", calculator.getPrice(bpackage));
        }
        [TestMethod]
        public void testLengthLowBound()
        {
            package package = new package(validpackage);
            package.length = 13.9f;
            Assert.AreEqual("invalid length", calculator.getPrice(package));

            
        }
        [TestMethod]
        public void testLengthHighBound()
        {
            package package = new package(validpackage);
            package.length = 38.1f;
            Assert.AreEqual("invalid length", calculator.getPrice(package));
        }

        [TestMethod]
        public void testWidthLowBound()
        {
            package package = new package(validpackage);
            package.width = 8.9f;
            Assert.AreEqual("invalid width", calculator.getPrice(package));
           
        }
        [TestMethod]
        public void testWidthHighBound()
        {
            package package = new package(validpackage);
            package.width = 27.1f;
            Assert.AreEqual("invalid width", calculator.getPrice(package));
        }
        [TestMethod]
        public void testWeightHighBound()
        {
            package package = new package(validpackage);
            package.weight = 50.1f;
            Assert.AreEqual("invalid weight", calculator.getPrice(package));
        }
        [TestMethod]
        public void testWeightLowBound()
        {
            package package = new package(validpackage);
            package.weight = 0.2f;
            Assert.AreEqual("invalid weight", calculator.getPrice(package));
        }
        [TestMethod]
        public void testHeightLowBound()
        {
            package package = new package(validpackage);
            package.height = 5.1f;
            Assert.AreEqual("invalid height", calculator.getPrice(package));
        }
        [TestMethod]
        public void testHeightHighBound()
        {
            package package = new package(validpackage);
            package.height = 50.1f;
            Assert.AreEqual("invalid height", calculator.getPrice(package));
        }

        [TestMethod]
        public void testPostalCodeFormatFrom()
        {
            package package = new package(validpackage);
            package.from = "hhhhhh";
            Assert.AreEqual("invalid from", calculator.getPrice(package));
            package.from = "h2x2e2e";
            Assert.AreEqual("invalid from", calculator.getPrice(package));
            package.from = "111111";
            Assert.AreEqual("invalid from", calculator.getPrice(package));
        }
        [TestMethod]
        public void testPostalCodeFormatFromTo()
        {
            package package = new package(validpackage);
            package.to = "hhhhhh";
            Assert.AreEqual("invalid to", calculator.getPrice(package));
            package.to = "h2x2e2e";
            Assert.AreEqual("invalid to", calculator.getPrice(package));
            package.to = "111111";
            Assert.AreEqual("invalid to", calculator.getPrice(package));
        }

    }
}
