using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UtilitiesTest
{


    /// <summary>
    ///This is a test class for StringUtilsTest and is intended
    ///to contain all StringUtilsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class StringUtilsTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for ContainsCi
        ///</summary>
        [TestMethod()]
        public void ContainsCiTest()
        {
            Assert.IsTrue("tEst StrING".ContainsCi("est sTR"));
            Assert.IsFalse("tEst StrING".ContainsCi("eststr"));

            Assert.IsTrue("руССкАя СТРока".ContainsCi("уссКАя ст"));
            Assert.IsFalse("руССкАя СТРока".ContainsCi("уссКАяст"));

            Assert.IsTrue("gerigYH%TRgewg".ContainsCi(string.Empty));
            Assert.IsTrue(string.Empty.ContainsCi(string.Empty));
            Assert.IsFalse(string.Empty.ContainsCi("ghow"));

            try
            {
                ((string)null).ContainsCi("a");
                Assert.Fail();
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is NullReferenceException);
            }

            try
            {
                "a".ContainsCi(null);
                Assert.Fail();
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is ArgumentNullException);
            }
        }

        /// <summary>
        ///A test for FormatWith
        ///</summary>
        [TestMethod()]
        public void FormatWithTest()
        {
            // this function delegates to string.Format(), so don't test full correctness
            Assert.AreEqual("simpleTest", "simple{0}".FormatWith("Test"));

            try
            {
                ((string)null).FormatWith("a");
                Assert.Fail();
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is ArgumentNullException);
            }

            try
            {
                "a".FormatWith(null);
                Assert.Fail();
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is ArgumentNullException);
            }
        }

        /// <summary>
        ///A test for FormatNamed
        ///</summary>
        [TestMethod()]
        public void FormatNamedTest()
        {
            string format = string.Empty; // TODO: Initialize to an appropriate value
            object arg = null; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = StringUtils.FormatNamed(format, arg);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetAfter
        ///</summary>
        [TestMethod()]
        public void GetAfterTest()
        {
            string s = string.Empty; // TODO: Initialize to an appropriate value
            string x = string.Empty; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = StringUtils.GetAfter(s, x);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetBefore
        ///</summary>
        [TestMethod()]
        public void GetBeforeTest()
        {
            string s = string.Empty; // TODO: Initialize to an appropriate value
            string x = string.Empty; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = StringUtils.GetBefore(s, x);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetBetween
        ///</summary>
        [TestMethod()]
        public void GetBetweenTest()
        {
            string s = string.Empty; // TODO: Initialize to an appropriate value
            string left = string.Empty; // TODO: Initialize to an appropriate value
            string right = string.Empty; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = StringUtils.GetBetween(s, left, right);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsNullOrEmpty
        ///</summary>
        [TestMethod()]
        public void IsNullOrEmptyTest()
        {
            string s = string.Empty; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = StringUtils.IsNullOrEmpty(s);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for NormalizeSpaces
        ///</summary>
        [TestMethod()]
        public void NormalizeSpacesTest()
        {
            string s = string.Empty; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = StringUtils.NormalizeSpaces(s);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for TrimLines
        ///</summary>
        [TestMethod()]
        public void TrimLinesTest()
        {
            string s = string.Empty; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = StringUtils.TrimLines(s);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
