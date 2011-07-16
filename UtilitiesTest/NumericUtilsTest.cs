using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UtilitiesTest
{
    
    
    /// <summary>
    ///This is a test class for NumericUtilsTest and is intended
    ///to contain all NumericUtilsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class NumericUtilsTest
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
        ///A test for GCD
        ///</summary>
        [TestMethod()]
        public void GCDTest()
        {
            int[] values = null; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = NumericUtils.GCD(values);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GCD
        ///</summary>
        [TestMethod()]
        public void GCDTest1()
        {
            long[] values = null; // TODO: Initialize to an appropriate value
            long expected = 0; // TODO: Initialize to an appropriate value
            long actual;
            actual = NumericUtils.GCD(values);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GCD
        ///</summary>
        [TestMethod()]
        public void GCDTest2()
        {
            int a = 0; // TODO: Initialize to an appropriate value
            int b = 0; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = NumericUtils.GCD(a, b);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GCD
        ///</summary>
        [TestMethod()]
        public void GCDTest3()
        {
            long a = 0; // TODO: Initialize to an appropriate value
            long b = 0; // TODO: Initialize to an appropriate value
            long expected = 0; // TODO: Initialize to an appropriate value
            long actual;
            actual = NumericUtils.GCD(a, b);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsPrime
        ///</summary>
        [TestMethod()]
        public void IsPrimeTest()
        {
            int number = 0; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = NumericUtils.IsPrime(number);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsPrime
        ///</summary>
        [TestMethod()]
        public void IsPrimeTest1()
        {
            long number = 0; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = NumericUtils.IsPrime(number);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for LCM
        ///</summary>
        [TestMethod()]
        public void LCMTest()
        {
            long a = 0; // TODO: Initialize to an appropriate value
            long b = 0; // TODO: Initialize to an appropriate value
            long expected = 0; // TODO: Initialize to an appropriate value
            long actual;
            actual = NumericUtils.LCM(a, b);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for LCM
        ///</summary>
        [TestMethod()]
        public void LCMTest1()
        {
            long[] values = null; // TODO: Initialize to an appropriate value
            long expected = 0; // TODO: Initialize to an appropriate value
            long actual;
            actual = NumericUtils.LCM(values);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for LCM
        ///</summary>
        [TestMethod()]
        public void LCMTest2()
        {
            int a = 0; // TODO: Initialize to an appropriate value
            int b = 0; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = NumericUtils.LCM(a, b);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for LCM
        ///</summary>
        [TestMethod()]
        public void LCMTest3()
        {
            int[] values = null; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = NumericUtils.LCM(values);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Lerp
        ///</summary>
        [TestMethod()]
        public void LerpTest()
        {
            float left = 0F; // TODO: Initialize to an appropriate value
            float right = 0F; // TODO: Initialize to an appropriate value
            float frac = 0F; // TODO: Initialize to an appropriate value
            float expected = 0F; // TODO: Initialize to an appropriate value
            float actual;
            actual = NumericUtils.Lerp(left, right, frac);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Lerp
        ///</summary>
        [TestMethod()]
        public void LerpTest1()
        {
            double left = 0F; // TODO: Initialize to an appropriate value
            double right = 0F; // TODO: Initialize to an appropriate value
            double frac = 0F; // TODO: Initialize to an appropriate value
            double expected = 0F; // TODO: Initialize to an appropriate value
            double actual;
            actual = NumericUtils.Lerp(left, right, frac);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Max
        ///</summary>
        [TestMethod()]
        public void MaxTest()
        {
            double[] values = null; // TODO: Initialize to an appropriate value
            double expected = 0F; // TODO: Initialize to an appropriate value
            double actual;
            actual = NumericUtils.Max(values);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Max
        ///</summary>
        [TestMethod()]
        public void MaxTest1()
        {
            int[] values = null; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = NumericUtils.Max(values);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Max
        ///</summary>
        [TestMethod()]
        public void MaxTest2()
        {
            float[] values = null; // TODO: Initialize to an appropriate value
            float expected = 0F; // TODO: Initialize to an appropriate value
            float actual;
            actual = NumericUtils.Max(values);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Max
        ///</summary>
        [TestMethod()]
        public void MaxTest3()
        {
            long[] values = null; // TODO: Initialize to an appropriate value
            long expected = 0; // TODO: Initialize to an appropriate value
            long actual;
            actual = NumericUtils.Max(values);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Min
        ///</summary>
        [TestMethod()]
        public void MinTest()
        {
            double[] values = null; // TODO: Initialize to an appropriate value
            double expected = 0F; // TODO: Initialize to an appropriate value
            double actual;
            actual = NumericUtils.Min(values);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Min
        ///</summary>
        [TestMethod()]
        public void MinTest1()
        {
            int[] values = null; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = NumericUtils.Min(values);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Min
        ///</summary>
        [TestMethod()]
        public void MinTest2()
        {
            float[] values = null; // TODO: Initialize to an appropriate value
            float expected = 0F; // TODO: Initialize to an appropriate value
            float actual;
            actual = NumericUtils.Min(values);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Min
        ///</summary>
        [TestMethod()]
        public void MinTest3()
        {
            long[] values = null; // TODO: Initialize to an appropriate value
            long expected = 0; // TODO: Initialize to an appropriate value
            long actual;
            actual = NumericUtils.Min(values);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
