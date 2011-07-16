using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing;
using System.Windows.Media.Imaging;

namespace UtilitiesTest
{
    
    
    /// <summary>
    ///This is a test class for ImageUtilsTest and is intended
    ///to contain all ImageUtilsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ImageUtilsTest
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
        ///A test for Download
        ///</summary>
        [TestMethod()]
        public void DownloadTest()
        {
            Uri url = null; // TODO: Initialize to an appropriate value
            Bitmap expected = null; // TODO: Initialize to an appropriate value
            Bitmap actual;
            actual = ImageUtils.Download(url);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Download
        ///</summary>
        [TestMethod()]
        public void DownloadTest1()
        {
            string url = string.Empty; // TODO: Initialize to an appropriate value
            Bitmap expected = null; // TODO: Initialize to an appropriate value
            Bitmap actual;
            actual = ImageUtils.Download(url);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetJpegBytes
        ///</summary>
        [TestMethod()]
        public void GetJpegBytesTest()
        {
            Image image = null; // TODO: Initialize to an appropriate value
            int quality = 0; // TODO: Initialize to an appropriate value
            byte[] expected = null; // TODO: Initialize to an appropriate value
            byte[] actual;
            actual = ImageUtils.GetJpegBytes(image, quality);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Grayscale
        ///</summary>
        [TestMethod()]
        public void GrayscaleTest()
        {
            Image original = null; // TODO: Initialize to an appropriate value
            Bitmap expected = null; // TODO: Initialize to an appropriate value
            Bitmap actual;
            actual = ImageUtils.Grayscale(original);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Scale
        ///</summary>
        [TestMethod()]
        public void ScaleTest()
        {
            Image image = null; // TODO: Initialize to an appropriate value
            int width = 0; // TODO: Initialize to an appropriate value
            int height = 0; // TODO: Initialize to an appropriate value
            Bitmap expected = null; // TODO: Initialize to an appropriate value
            Bitmap actual;
            actual = ImageUtils.Scale(image, width, height);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Scale
        ///</summary>
        [TestMethod()]
        public void ScaleTest1()
        {
            Image image = null; // TODO: Initialize to an appropriate value
            Size size = new Size(); // TODO: Initialize to an appropriate value
            Bitmap expected = null; // TODO: Initialize to an appropriate value
            Bitmap actual;
            actual = ImageUtils.Scale(image, size);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Shrink
        ///</summary>
        [TestMethod()]
        public void ShrinkTest()
        {
            Image image = null; // TODO: Initialize to an appropriate value
            int maxWidth = 0; // TODO: Initialize to an appropriate value
            int maxHeight = 0; // TODO: Initialize to an appropriate value
            Bitmap expected = null; // TODO: Initialize to an appropriate value
            Bitmap actual;
            actual = ImageUtils.Shrink(image, maxWidth, maxHeight);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ToBitmap
        ///</summary>
        [TestMethod()]
        public void ToBitmapTest()
        {
            BitmapSource bitmapSource = null; // TODO: Initialize to an appropriate value
            Bitmap expected = null; // TODO: Initialize to an appropriate value
            Bitmap actual;
            actual = ImageUtils.ToBitmap(bitmapSource);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ToBitmapSource
        ///</summary>
        [TestMethod()]
        public void ToBitmapSourceTest()
        {
            Bitmap bitmap = null; // TODO: Initialize to an appropriate value
            BitmapSource expected = null; // TODO: Initialize to an appropriate value
            BitmapSource actual;
            actual = ImageUtils.ToBitmapSource(bitmap);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
