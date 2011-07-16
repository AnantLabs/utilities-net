﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UtilitiesTest
{
    
    
    /// <summary>
    ///This is a test class for DateTimeUtilsTest and is intended
    ///to contain all DateTimeUtilsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DateTimeUtilsTest
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
        ///A test for CalculateAge
        ///</summary>
        [TestMethod()]
        public void CalculateAgeTest()
        {
            DateTime birthDate = new DateTime(); // TODO: Initialize to an appropriate value
            DateTime referenceDate = new DateTime(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = DateTimeUtils.CalculateAge(birthDate, referenceDate);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for CalculateAge
        ///</summary>
        [TestMethod()]
        public void CalculateAgeTest1()
        {
            DateTime birthDate = new DateTime(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = DateTimeUtils.CalculateAge(birthDate);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for DaysInMonth
        ///</summary>
        [TestMethod()]
        public void DaysInMonthTest()
        {
            DateTime date = new DateTime(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = DateTimeUtils.DaysInMonth(date);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FromUnixTime
        ///</summary>
        [TestMethod()]
        public void FromUnixTimeTest()
        {
            long unixTime = 0; // TODO: Initialize to an appropriate value
            bool withMilliseconds = false; // TODO: Initialize to an appropriate value
            DateTime expected = new DateTime(); // TODO: Initialize to an appropriate value
            DateTime actual;
            actual = DateTimeUtils.FromUnixTime(unixTime, withMilliseconds);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ToUnixTime
        ///</summary>
        [TestMethod()]
        public void ToUnixTimeTest()
        {
            DateTime dateTime = new DateTime(); // TODO: Initialize to an appropriate value
            bool withMilliseconds = false; // TODO: Initialize to an appropriate value
            long expected = 0; // TODO: Initialize to an appropriate value
            long actual;
            actual = DateTimeUtils.ToUnixTime(dateTime, withMilliseconds);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for UtcOffset
        ///</summary>
        [TestMethod()]
        public void UtcOffsetTest()
        {
            double actual;
            actual = DateTimeUtils.UtcOffset;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
