using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Collections.Generic;

namespace UtilitiesTest
{
    
    
    /// <summary>
    ///This is a test class for StreamUtilsTest and is intended
    ///to contain all StreamUtilsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class StreamUtilsTest
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
        ///A test for EnumerateLines
        ///</summary>
        [TestMethod()]
        public void EnumerateLinesTest()
        {
            TextReader reader = null; // TODO: Initialize to an appropriate value
            IEnumerable<string> expected = null; // TODO: Initialize to an appropriate value
            IEnumerable<string> actual;
            actual = StreamUtils.EnumerateLines(reader);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetReader
        ///</summary>
        [TestMethod()]
        public void GetReaderTest()
        {
            Stream stream = null; // TODO: Initialize to an appropriate value
            StreamReader expected = null; // TODO: Initialize to an appropriate value
            StreamReader actual;
            actual = StreamUtils.GetReader(stream);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetWriter
        ///</summary>
        [TestMethod()]
        public void GetWriterTest()
        {
            Stream stream = null; // TODO: Initialize to an appropriate value
            StreamWriter expected = null; // TODO: Initialize to an appropriate value
            StreamWriter actual;
            actual = StreamUtils.GetWriter(stream);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ReadToEnd
        ///</summary>
        [TestMethod()]
        public void ReadToEndTest()
        {
            Stream stream = null; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = StreamUtils.ReadToEnd(stream);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Write
        ///</summary>
        [TestMethod()]
        public void WriteTest()
        {
            Stream stream = null; // TODO: Initialize to an appropriate value
            byte[] bytes = null; // TODO: Initialize to an appropriate value
            StreamUtils.Write(stream, bytes);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
