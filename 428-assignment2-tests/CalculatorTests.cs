using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _428_assignment2;

namespace _428_assignment2_tests
{
    [TestClass]
    public class CalculatorTests
    {
        string validfrom = "h2l2c9";
        string validto = "h2x1j5";
        float validlength = 20f;
        float validwidth = 20f;
        float validheight = 20f;
        float validweight = 20f;
        PostType validPostType = PostType.Regular;

        float expected = 0;

        [TestMethod]
        public void validInput()
        {
            Assert.AreEqual(expected, calculator.Compute(validfrom, validto, validlength, validwidth, validheight, validweight, validPostType));
        }
        [TestMethod]
        public void nullfrom()
        {
            try
            {
                calculator.Compute(null, validto, validlength, validwidth, validheight, validweight, validPostType);
                Assert.Fail("null from fail");
            }
            catch (FormatException e)
            {
                Assert.AreEqual("invalid from", e.Message);
            }
        }
        [TestMethod]
        public void nullto()
        {
            try
            {
                calculator.Compute(validfrom, null, validlength, validwidth, validheight, validweight, validPostType);
                Assert.Fail("null to fail");
            }
            catch (FormatException e)
            {
                Assert.AreEqual("invalid to", e.Message);
            }
        }
        [TestMethod]
        public void invalidfrom()
        {
            try
            {
                calculator.Compute("hhhhhh", validto, validlength, validwidth, validheight, validweight, validPostType);
                Assert.Fail("invalid from fail");
            }
            catch (FormatException e)
            {
                
                Assert.Equals("invalid from", e.Message);
            }
        }
        [TestMethod]
        public void invalidto()
        {
            try
            {
                calculator.Compute(validfrom, "hhhhh", validlength, validwidth, validheight, validweight, validPostType);
                Assert.Fail("invalid to fail");
            }
            catch (FormatException e)
            {
                Assert.Equals("invalid to", e.Message);
            }
        }
        [TestMethod]
        public void invalidLength()
        {
            try
            {
                calculator.Compute(validfrom, validto, 0, validwidth, validheight, validweight, validPostType);
                Assert.Fail("invalid length fail");
            }
            catch (FormatException e)
            {
                Assert.Equals("invalid length", e.Message);
            }
        }
        [TestMethod]
        public void invalidWidth()
        {
            try
            {
                calculator.Compute(validfrom, validto, validlength, 0, validheight, validweight, validPostType);
                Assert.Fail("invalid width fail");
            }
            catch (FormatException e)
            {
                Assert.Equals("invalid width", e.Message);
            }
        }
        [TestMethod]
        public void invalidheight()
        {
            try
            {
                calculator.Compute(validfrom, validto, validlength, validwidth, 0, validweight, validPostType);
                Assert.Fail("invalid height fail");
            }
            catch (FormatException e)
            {
                Assert.Equals("invalid height", e.Message);
            }
        }
        [TestMethod]
        public void invalidWeight()
        {
            try
            {
                calculator.Compute(validfrom, validto, validlength, validwidth, validheight, 0, validPostType);
                Assert.Fail("invalid weight fail");
            }
            catch (FormatException e)
            {
                Assert.Equals("invalid weight", e.Message);
            }
        }
        [TestMethod]
        public void invalidPostType()
        {
            try
            {
                calculator.Compute(validfrom, validto, validlength, validwidth, validheight, validweight, (PostType)8);
                Assert.Fail("invalid posttype fail");
            }
            catch (FormatException e)
            {
                Assert.Equals("invalid posttype", e.Message);
            }
        }
    }
}
