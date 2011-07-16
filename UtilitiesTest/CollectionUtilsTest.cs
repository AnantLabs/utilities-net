using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UtilitiesTest
{
    
    
    /// <summary>
    ///This is a test class for CollectionUtilsTest and is intended
    ///to contain all CollectionUtilsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class CollectionUtilsTest
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
        ///A test for AddRange
        ///</summary>
        public void AddRangeTestHelper<TSource>()
        {
            ICollection<TSource> collection = null; // TODO: Initialize to an appropriate value
            TSource[] items = null; // TODO: Initialize to an appropriate value
            CollectionUtils.AddRange<TSource>(collection, items);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        [TestMethod()]
        public void AddRangeTest()
        {
            AddRangeTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for AddRange
        ///</summary>
        public void AddRangeTest1Helper<TSource>()
        {
            ICollection<TSource> collection = null; // TODO: Initialize to an appropriate value
            IEnumerable<TSource> source = null; // TODO: Initialize to an appropriate value
            CollectionUtils.AddRange<TSource>(collection, source);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        [TestMethod()]
        public void AddRangeTest1()
        {
            AddRangeTest1Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Aggregate
        ///</summary>
        public void AggregateTestHelper<TSource>()
        {
            IEnumerable<TSource> enumerable = null; // TODO: Initialize to an appropriate value
            string separator = string.Empty; // TODO: Initialize to an appropriate value
            string prefix = string.Empty; // TODO: Initialize to an appropriate value
            string suffix = string.Empty; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = CollectionUtils.Aggregate<TSource>(enumerable, separator, prefix, suffix);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void AggregateTest()
        {
            AggregateTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Aggregate
        ///</summary>
        public void AggregateTest1Helper<TSource, TDest>()
        {
            IEnumerable<TSource> enumerable = null; // TODO: Initialize to an appropriate value
            Func<TSource, TDest> func = null; // TODO: Initialize to an appropriate value
            string separator = string.Empty; // TODO: Initialize to an appropriate value
            string prefix = string.Empty; // TODO: Initialize to an appropriate value
            string suffix = string.Empty; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = CollectionUtils.Aggregate<TSource, TDest>(enumerable, func, separator, prefix, suffix);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void AggregateTest1()
        {
            AggregateTest1Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Concat
        ///</summary>
        public void ConcatTestHelper<TSource>()
        {
            IEnumerable<TSource> source = null; // TODO: Initialize to an appropriate value
            TSource item = default(TSource); // TODO: Initialize to an appropriate value
            IEnumerable<TSource> expected = null; // TODO: Initialize to an appropriate value
            IEnumerable<TSource> actual;
            actual = CollectionUtils.Concat<TSource>(source, item);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ConcatTest()
        {
            ConcatTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Concat
        ///</summary>
        public void ConcatTest1Helper<TSource>()
        {
            IEnumerable<TSource> source = null; // TODO: Initialize to an appropriate value
            TSource[] items = null; // TODO: Initialize to an appropriate value
            IEnumerable<TSource> expected = null; // TODO: Initialize to an appropriate value
            IEnumerable<TSource> actual;
            actual = CollectionUtils.Concat<TSource>(source, items);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ConcatTest1()
        {
            ConcatTest1Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Empty
        ///</summary>
        public void EmptyTestHelper<TSource>()
        {
            IEnumerable<TSource> enumerable = null; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = CollectionUtils.Empty<TSource>(enumerable);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void EmptyTest()
        {
            EmptyTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Flatten
        ///</summary>
        public void FlattenTestHelper<TSource>()
        {
            IEnumerable<IEnumerable<TSource>> items2D = null; // TODO: Initialize to an appropriate value
            IEnumerable<TSource> expected = null; // TODO: Initialize to an appropriate value
            IEnumerable<TSource> actual;
            actual = CollectionUtils.Flatten<TSource>(items2D);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FlattenTest()
        {
            FlattenTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ForEach
        ///</summary>
        public void ForEachTestHelper<TSource>()
        {
            IEnumerable<TSource> enumerable = null; // TODO: Initialize to an appropriate value
            Action<TSource> action = null; // TODO: Initialize to an appropriate value
            CollectionUtils.ForEach<TSource>(enumerable, action);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        [TestMethod()]
        public void ForEachTest()
        {
            ForEachTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Invert
        ///</summary>
        public void InvertTestHelper<TKey, TValue>()
        {
            IDictionary<TKey, TValue> dictionary = null; // TODO: Initialize to an appropriate value
            Dictionary<TValue, TKey> expected = null; // TODO: Initialize to an appropriate value
            Dictionary<TValue, TKey> actual;
            actual = CollectionUtils.Invert<TKey, TValue>(dictionary);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void InvertTest()
        {
            InvertTestHelper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for MakeEnumerable
        ///</summary>
        public void MakeEnumerableTestHelper<TSource>()
        {
            TSource[] items = null; // TODO: Initialize to an appropriate value
            IEnumerable<TSource> expected = null; // TODO: Initialize to an appropriate value
            IEnumerable<TSource> actual;
            actual = CollectionUtils.MakeEnumerable<TSource>(items);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void MakeEnumerableTest()
        {
            MakeEnumerableTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for MakeEnumerable
        ///</summary>
        public void MakeEnumerableTest1Helper<TSource>()
        {
            TSource item = default(TSource); // TODO: Initialize to an appropriate value
            IEnumerable<TSource> expected = null; // TODO: Initialize to an appropriate value
            IEnumerable<TSource> actual;
            actual = CollectionUtils.MakeEnumerable<TSource>(item);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void MakeEnumerableTest1()
        {
            MakeEnumerableTest1Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for MaxItem
        ///</summary>
        public void MaxItemTestHelper<TSource, TKey>()
        {
            IEnumerable<TSource> enumerable = null; // TODO: Initialize to an appropriate value
            Func<TSource, TKey> selector = null; // TODO: Initialize to an appropriate value
            TSource expected = default(TSource); // TODO: Initialize to an appropriate value
            TSource actual;
            actual = CollectionUtils.MaxItem<TSource, TKey>(enumerable, selector);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void MaxItemTest()
        {
            MaxItemTestHelper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for MinItem
        ///</summary>
        public void MinItemTestHelper<TSource, TKey>()
        {
            IEnumerable<TSource> enumerable = null; // TODO: Initialize to an appropriate value
            Func<TSource, TKey> selector = null; // TODO: Initialize to an appropriate value
            TSource expected = default(TSource); // TODO: Initialize to an appropriate value
            TSource actual;
            actual = CollectionUtils.MinItem<TSource, TKey>(enumerable, selector);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void MinItemTest()
        {
            MinItemTestHelper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Random
        ///</summary>
        public void RandomTestHelper<TSource>()
        {
            IEnumerable<TSource> enumerable = null; // TODO: Initialize to an appropriate value
            TSource expected = default(TSource); // TODO: Initialize to an appropriate value
            TSource actual;
            actual = CollectionUtils.Random<TSource>(enumerable);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void RandomTest()
        {
            RandomTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for SkipLast
        ///</summary>
        public void SkipLastTestHelper<TSource>()
        {
            IEnumerable<TSource> source = null; // TODO: Initialize to an appropriate value
            int count = 0; // TODO: Initialize to an appropriate value
            IEnumerable<TSource> expected = null; // TODO: Initialize to an appropriate value
            IEnumerable<TSource> actual;
            actual = CollectionUtils.SkipLast<TSource>(source, count);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void SkipLastTest()
        {
            SkipLastTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for SkipUntil
        ///</summary>
        public void SkipUntilTestHelper<TSource>()
        {
            IEnumerable<TSource> source = null; // TODO: Initialize to an appropriate value
            Func<TSource, bool> predicate = null; // TODO: Initialize to an appropriate value
            IEnumerable<TSource> expected = null; // TODO: Initialize to an appropriate value
            IEnumerable<TSource> actual;
            actual = CollectionUtils.SkipUntil<TSource>(source, predicate);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void SkipUntilTest()
        {
            SkipUntilTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for SkipUntil
        ///</summary>
        public void SkipUntilTest1Helper<TSource>()
        {
            IEnumerable<TSource> source = null; // TODO: Initialize to an appropriate value
            Func<TSource, int, bool> predicate = null; // TODO: Initialize to an appropriate value
            IEnumerable<TSource> expected = null; // TODO: Initialize to an appropriate value
            IEnumerable<TSource> actual;
            actual = CollectionUtils.SkipUntil<TSource>(source, predicate);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void SkipUntilTest1()
        {
            SkipUntilTest1Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for TakeUntil
        ///</summary>
        public void TakeUntilTestHelper<TSource>()
        {
            IEnumerable<TSource> source = null; // TODO: Initialize to an appropriate value
            Func<TSource, int, bool> predicate = null; // TODO: Initialize to an appropriate value
            IEnumerable<TSource> expected = null; // TODO: Initialize to an appropriate value
            IEnumerable<TSource> actual;
            actual = CollectionUtils.TakeUntil<TSource>(source, predicate);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void TakeUntilTest()
        {
            TakeUntilTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for TakeUntil
        ///</summary>
        public void TakeUntilTest1Helper<TSource>()
        {
            IEnumerable<TSource> source = null; // TODO: Initialize to an appropriate value
            Func<TSource, bool> predicate = null; // TODO: Initialize to an appropriate value
            IEnumerable<TSource> expected = null; // TODO: Initialize to an appropriate value
            IEnumerable<TSource> actual;
            actual = CollectionUtils.TakeUntil<TSource>(source, predicate);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void TakeUntilTest1()
        {
            TakeUntilTest1Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ValidIndex
        ///</summary>
        public void ValidIndexTestHelper<TSource>()
        {
            IList<TSource> list = null; // TODO: Initialize to an appropriate value
            int index = 0; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = CollectionUtils.ValidIndex<TSource>(list, index);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ValidIndexTest()
        {
            ValidIndexTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for WhereNot
        ///</summary>
        public void WhereNotTestHelper<TSource>()
        {
            IEnumerable<TSource> source = null; // TODO: Initialize to an appropriate value
            Func<TSource, int, bool> predicate = null; // TODO: Initialize to an appropriate value
            IEnumerable<TSource> expected = null; // TODO: Initialize to an appropriate value
            IEnumerable<TSource> actual;
            actual = CollectionUtils.WhereNot<TSource>(source, predicate);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void WhereNotTest()
        {
            WhereNotTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for WhereNot
        ///</summary>
        public void WhereNotTest1Helper<TSource>()
        {
            IEnumerable<TSource> source = null; // TODO: Initialize to an appropriate value
            Func<TSource, bool> predicate = null; // TODO: Initialize to an appropriate value
            IEnumerable<TSource> expected = null; // TODO: Initialize to an appropriate value
            IEnumerable<TSource> actual;
            actual = CollectionUtils.WhereNot<TSource>(source, predicate);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void WhereNotTest1()
        {
            WhereNotTest1Helper<GenericParameterHelper>();
        }
    }
}
