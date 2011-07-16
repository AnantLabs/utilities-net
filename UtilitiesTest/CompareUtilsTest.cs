using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UtilitiesTest
{
    
    
    /// <summary>
    ///This is a test class for CompareUtilsTest and is intended
    ///to contain all CompareUtilsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class CompareUtilsTest
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
        ///A test for Clamp
        ///</summary>
        public void ClampTestHelper<T>()
        {
            T value = default(T); // TODO: Initialize to an appropriate value
            T min = default(T); // TODO: Initialize to an appropriate value
            T max = default(T); // TODO: Initialize to an appropriate value
            T expected = default(T); // TODO: Initialize to an appropriate value
            T actual;
            actual = CompareUtils.Clamp<T>(value, min, max);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ClampTest()
        {
            ClampTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Clamp
        ///</summary>
        public void ClampTest1Helper<T>()
        {
            T value = default(T); // TODO: Initialize to an appropriate value
            T min = default(T); // TODO: Initialize to an appropriate value
            T max = default(T); // TODO: Initialize to an appropriate value
            IComparer<T> comparer = null; // TODO: Initialize to an appropriate value
            T expected = default(T); // TODO: Initialize to an appropriate value
            T actual;
            actual = CompareUtils.Clamp<T>(value, min, max, comparer);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ClampTest1()
        {
            ClampTest1Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for InRange
        ///</summary>
        public void InRangeTestHelper<T>()
        {
            T value = default(T); // TODO: Initialize to an appropriate value
            T min = default(T); // TODO: Initialize to an appropriate value
            T max = default(T); // TODO: Initialize to an appropriate value
            IComparer<T> comparer = null; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = CompareUtils.InRange<T>(value, min, max, comparer);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void InRangeTest()
        {
            InRangeTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for InRange
        ///</summary>
        public void InRangeTest1Helper<T>()
        {
            T value = default(T); // TODO: Initialize to an appropriate value
            T min = default(T); // TODO: Initialize to an appropriate value
            T max = default(T); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = CompareUtils.InRange<T>(value, min, max);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void InRangeTest1()
        {
            InRangeTest1Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for IsGreater
        ///</summary>
        public void IsGreaterTestHelper<T>()
        {
            T x = default(T); // TODO: Initialize to an appropriate value
            T y = default(T); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = CompareUtils.IsGreater<T>(x, y);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void IsGreaterTest()
        {
            IsGreaterTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for IsGreater
        ///</summary>
        public void IsGreaterTest1Helper<T>()
        {
            T x = default(T); // TODO: Initialize to an appropriate value
            T y = default(T); // TODO: Initialize to an appropriate value
            IComparer<T> comparer = null; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = CompareUtils.IsGreater<T>(x, y, comparer);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void IsGreaterTest1()
        {
            IsGreaterTest1Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for IsGreaterOrEqual
        ///</summary>
        public void IsGreaterOrEqualTestHelper<T>()
        {
            T x = default(T); // TODO: Initialize to an appropriate value
            T y = default(T); // TODO: Initialize to an appropriate value
            IComparer<T> comparer = null; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = CompareUtils.IsGreaterOrEqual<T>(x, y, comparer);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void IsGreaterOrEqualTest()
        {
            IsGreaterOrEqualTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for IsGreaterOrEqual
        ///</summary>
        public void IsGreaterOrEqualTest1Helper<T>()
        {
            T x = default(T); // TODO: Initialize to an appropriate value
            T y = default(T); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = CompareUtils.IsGreaterOrEqual<T>(x, y);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void IsGreaterOrEqualTest1()
        {
            IsGreaterOrEqualTest1Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for IsLess
        ///</summary>
        public void IsLessTestHelper<T>()
        {
            T x = default(T); // TODO: Initialize to an appropriate value
            T y = default(T); // TODO: Initialize to an appropriate value
            IComparer<T> comparer = null; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = CompareUtils.IsLess<T>(x, y, comparer);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void IsLessTest()
        {
            IsLessTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for IsLess
        ///</summary>
        public void IsLessTest1Helper<T>()
        {
            T x = default(T); // TODO: Initialize to an appropriate value
            T y = default(T); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = CompareUtils.IsLess<T>(x, y);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void IsLessTest1()
        {
            IsLessTest1Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for IsLessOrEqual
        ///</summary>
        public void IsLessOrEqualTestHelper<T>()
        {
            T x = default(T); // TODO: Initialize to an appropriate value
            T y = default(T); // TODO: Initialize to an appropriate value
            IComparer<T> comparer = null; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = CompareUtils.IsLessOrEqual<T>(x, y, comparer);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void IsLessOrEqualTest()
        {
            IsLessOrEqualTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for IsLessOrEqual
        ///</summary>
        public void IsLessOrEqualTest1Helper<T>()
        {
            T x = default(T); // TODO: Initialize to an appropriate value
            T y = default(T); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = CompareUtils.IsLessOrEqual<T>(x, y);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void IsLessOrEqualTest1()
        {
            IsLessOrEqualTest1Helper<GenericParameterHelper>();
        }
    }
}
