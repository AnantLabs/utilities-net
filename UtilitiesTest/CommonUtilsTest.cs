using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UtilitiesTest
{
    
    
    /// <summary>
    ///This is a test class for CommonUtilsTest and is intended
    ///to contain all CommonUtilsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class CommonUtilsTest
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
        ///A test for CloneT
        ///</summary>
        public void CloneTTestHelper<T>()
            where T : ICloneable
        {
            T t = default(T); // TODO: Initialize to an appropriate value
            T expected = default(T); // TODO: Initialize to an appropriate value
            T actual;
            actual = CommonUtils.CloneT<T>(t);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void CloneTTest()
        {
            CloneTTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for GetAllExceptions
        ///</summary>
        [TestMethod()]
        public void GetAllExceptionsTest()
        {
            Exception exception = null; // TODO: Initialize to an appropriate value
            IEnumerable<Exception> expected = null; // TODO: Initialize to an appropriate value
            IEnumerable<Exception> actual;
            actual = CommonUtils.GetAllExceptions(exception);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetMostInnerException
        ///</summary>
        [TestMethod()]
        public void GetMostInnerExceptionTest()
        {
            Exception exception = null; // TODO: Initialize to an appropriate value
            Exception expected = null; // TODO: Initialize to an appropriate value
            Exception actual;
            actual = CommonUtils.GetMostInnerException(exception);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsNotNull
        ///</summary>
        [TestMethod()]
        public void IsNotNullTest()
        {
            object obj = null; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = CommonUtils.IsNotNull(obj);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsNull
        ///</summary>
        [TestMethod()]
        public void IsNullTest()
        {
            object obj = null; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = CommonUtils.IsNull(obj);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsOneOf
        ///</summary>
        public void IsOneOfTestHelper<T>()
        {
            T obj = default(T); // TODO: Initialize to an appropriate value
            T[] values = null; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = CommonUtils.IsOneOf<T>(obj, values);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void IsOneOfTest()
        {
            IsOneOfTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Try
        ///</summary>
        public void TryTestHelper<T>()
        {
            Func<T> function = null; // TODO: Initialize to an appropriate value
            T defaultValue = default(T); // TODO: Initialize to an appropriate value
            Type[] exceptions = null; // TODO: Initialize to an appropriate value
            T expected = default(T); // TODO: Initialize to an appropriate value
            T actual;
            actual = CommonUtils.Try<T>(function, defaultValue, exceptions);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void TryTest()
        {
            TryTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for TryNullReference
        ///</summary>
        public void TryNullReferenceTestHelper<T>()
        {
            Func<T> function = null; // TODO: Initialize to an appropriate value
            T defaultValue = default(T); // TODO: Initialize to an appropriate value
            T expected = default(T); // TODO: Initialize to an appropriate value
            T actual;
            actual = CommonUtils.TryNullReference<T>(function, defaultValue);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void TryNullReferenceTest()
        {
            TryNullReferenceTestHelper<GenericParameterHelper>();
        }
    }
}
