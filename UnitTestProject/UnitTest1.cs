using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Ecse428_AssignmentB;


namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        public package validpackage = new package("h2l2c9", "h2x1j5", 15, 10, 20, 4, PostType.Regular);

        [TestInitialize]
        public void initialize()
        {
            DataSheet.init();
        }
        [TestMethod]
        public void testValid1()
        {
            Assert.AreEqual("14.49", Calc.getPrice(new package("h2x2e2", "n4e6p6", 15, 10, 20, 1, PostType.Regular)));
        }
        [TestMethod]

        public void testValid2()
        {
            Assert.AreEqual("14.8", Calc.getPrice(new package("h2x2e2", "n4e6p6", 15, 10, 20, 4, PostType.Regular)));
        }
        [TestMethod]
        public void testValid3()
        {
            Assert.AreEqual("14.49", Calc.getPrice(new package("h2x2e2", "n4e6p6", 15, 10, 38, 0.8f, PostType.Regular)));
        }
        [TestMethod]
        public void testValid4()
        {
            Assert.AreEqual("14.49", Calc.getPrice(new package("h2x2e2", "n4e6p6", 15, 10, 38, 2, PostType.Regular)));
        }
        [TestMethod]

        public void testValid5()
        {
            Assert.AreEqual("14.98", Calc.getPrice(new package("h2x2e2", "n4e6p6", 28, 10, 20, 0.8f, PostType.Regular)));
        }
        [TestMethod]

        public void testValid6()
        {
            Assert.AreEqual("16.4", Calc.getPrice(new package("h2x2e2", "n4e6p6", 28, 10, 20, 2, PostType.Regular)));
        }
        [TestMethod]

        public void testValid7()
        {
            Assert.AreEqual("14.98", Calc.getPrice(new package("h2x2e2", "n4e6p6", 15, 19, 20, 0.8f, PostType.Regular)));
        }
        [TestMethod]

        public void testValid8()
        {
            Assert.AreEqual("16.4", Calc.getPrice(new package("h2x2e2", "n4e6p6", 15, 19, 20, 2, PostType.Regular)));
        }
        [TestMethod]

        public void testValid9()
        {
            Assert.AreEqual("24.6", Calc.getPrice(new package("h2x2e2", "n4e6p6", 15, 19, 20, 2, PostType.Xpress)));
        }
        [TestMethod]

        public void testValid10()
        {
            Assert.AreEqual("32.8", Calc.getPrice(new package("h2x2e2", "n4e6p6", 15, 19, 20, 2, PostType.Priority)));
        }
        [TestMethod]

        public void testValid11()
        {
            Assert.AreEqual("22.8", Calc.getPrice(new package("H2L2C9", "H2X1J5", 15, 19, 20, 2, PostType.Priority)));
        }
        [TestMethod]
        public void testnullreference()
        {
            Assert.AreEqual("invalid package", Calc.getPrice(null));
        }
        [TestMethod]
        public void testPostalCapital()
        {
            package package = new package("H2L2C9", "H2X1J5", 15, 10, 30, 2, PostType.Regular);
            Assert.AreEqual("9.49", Calc.getPrice(package));
        }

        [TestMethod]
        public void testNullFrom()
        {
            package apackage = new package(validpackage);
            apackage.from = null;
            Assert.AreEqual("invalid from", Calc.getPrice(apackage));
        }
        [TestMethod]
        public void testNullTo()
        {
            package bpackage = new package(validpackage);
            bpackage.to = null;
            Assert.AreEqual("invalid to", Calc.getPrice(bpackage));
        }
        [TestMethod]
        public void testLengthLowBound()
        {
            package package = new package(validpackage);
            package.length = 13.9f;
            Assert.AreEqual("invalid length", Calc.getPrice(package));


        }
        [TestMethod]
        public void testLengthHighBound()
        {
            package package = new package(validpackage);
            package.length = 38.1f;
            Assert.AreEqual("invalid length", Calc.getPrice(package));
        }

        [TestMethod]
        public void testWidthLowBound()
        {
            package package = new package(validpackage);
            package.width = 8.9f;
            Assert.AreEqual("invalid width", Calc.getPrice(package));

        }
        [TestMethod]
        public void testWidthHighBound()
        {
            package package = new package(validpackage);
            package.width = 27.1f;
            Assert.AreEqual("invalid width", Calc.getPrice(package));
        }
        [TestMethod]
        public void testWeightHighBound()
        {
            package package = new package(validpackage);
            package.weight = 50.1f;
            Assert.AreEqual("invalid weight", Calc.getPrice(package));
        }
        [TestMethod]
        public void testWeightLowBound()
        {
            package package = new package(validpackage);
            package.weight = 0.2f;
            Assert.AreEqual("invalid weight", Calc.getPrice(package));
        }
        [TestMethod]
        public void testHeightLowBound()
        {
            package package = new package(validpackage);
            package.height = 5.1f;
            Assert.AreEqual("invalid height", Calc.getPrice(package));
        }
        [TestMethod]
        public void testHeightHighBound()
        {
            package package = new package(validpackage);
            package.height = 50.1f;
            Assert.AreEqual("invalid height", Calc.getPrice(package));
        }

        [TestMethod]
        public void testPostalCodeFormatFrom()
        {
            package package = new package(validpackage);
            package.from = "hhhhhh";
            Assert.AreEqual("invalid from", Calc.getPrice(package));
            package.from = "h2x2e2e";
            Assert.AreEqual("invalid from", Calc.getPrice(package));
            package.from = "111111";
            Assert.AreEqual("invalid from", Calc.getPrice(package));
        }
        [TestMethod]
        public void testPostalCodeFormatTo()
        {
            package package = new package(validpackage);
            package.to = "hhhhhh";
            Assert.AreEqual("invalid to", Calc.getPrice(package));
            package.to = "h2x2e2e";
            Assert.AreEqual("invalid to", Calc.getPrice(package));
            package.to = "111111";
            Assert.AreEqual("invalid to", Calc.getPrice(package));
        }
    }
}
