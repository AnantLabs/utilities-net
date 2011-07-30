// <copyright file="GenericEnumerableExtensionsTest.cs" company="Microsoft">Copyright © Microsoft 2011</copyright>
using System;
using System.Collections.Generic;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

/// <summary>This class contains parameterized unit tests for GenericEnumerableExtensions</summary>
[PexClass(typeof(global::GenericEnumerableExtensions))]
[PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
[PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
[TestClass]
public partial class GenericEnumerableExtensionsTest
{
    /// <summary>Test stub for Aggregate(IEnumerable`1&lt;!!0&gt;, String, String)</summary>
    [PexGenericArguments(typeof(string))]
    [PexMethod]
    public string Aggregate<TSource>(
        IEnumerable<TSource> source,
        string separator,
        string format
    )
    {
        string result = global::GenericEnumerableExtensions.Aggregate<TSource>
                            (source, separator, format);
        return result;
        // TODO: add assertions to method GenericEnumerableExtensionsTest.Aggregate(IEnumerable`1<!!0>, String, String)
    }

    /// <summary>Test stub for Aggregate(IEnumerable`1&lt;!!0&gt;, Func`2&lt;!!0,!!1&gt;, String, String)</summary>
    [PexGenericArguments(typeof(int), typeof(string))]
    [PexMethod]
    public string Aggregate01<TSource, TDest>(
        IEnumerable<TSource> source,
        Func<TSource, TDest> func,
        string separator,
        string format
    )
    {
        string result = global::GenericEnumerableExtensions.Aggregate<TSource, TDest>
                            (source, func, separator, format);
        return result;
        // TODO: add assertions to method GenericEnumerableExtensionsTest.Aggregate01(IEnumerable`1<!!0>, Func`2<!!0,!!1>, String, String)
    }

    /// <summary>Test stub for Concat(IEnumerable`1&lt;!!0&gt;, !!0)</summary>
    [PexGenericArguments(typeof(int))]
    [PexMethod]
    public IEnumerable<TSource> Concat<TSource>(IEnumerable<TSource> source, TSource item)
    {
        IEnumerable<TSource> result
           = global::GenericEnumerableExtensions.Concat<TSource>(source, item);
        return result;
        // TODO: add assertions to method GenericEnumerableExtensionsTest.Concat(IEnumerable`1<!!0>, !!0)
    }

    /// <summary>Test stub for Concat(IEnumerable`1&lt;!!0&gt;, !!0[])</summary>
    [PexGenericArguments(typeof(int))]
    [PexMethod]
    public IEnumerable<TSource> Concat01<TSource>(IEnumerable<TSource> source, TSource[] items)
    {
        IEnumerable<TSource> result
           = global::GenericEnumerableExtensions.Concat<TSource>(source, items);
        return result;
        // TODO: add assertions to method GenericEnumerableExtensionsTest.Concat01(IEnumerable`1<!!0>, !!0[])
    }

    /// <summary>Test stub for Count(IEnumerable`1&lt;!!0&gt;, !!0)</summary>
    [PexGenericArguments(typeof(int))]
    [PexMethod]
    public int Count<TSource>(IEnumerable<TSource> source, TSource element)
    {
        int result = global::GenericEnumerableExtensions.Count<TSource>(source, element)
          ;
        return result;
        // TODO: add assertions to method GenericEnumerableExtensionsTest.Count(IEnumerable`1<!!0>, !!0)
    }

    /// <summary>Test stub for Empty(IEnumerable`1&lt;!!0&gt;)</summary>
    [PexGenericArguments(typeof(int))]
    [PexMethod]
    public bool Empty<TSource>(IEnumerable<TSource> source)
    {
        bool result = global::GenericEnumerableExtensions.Empty<TSource>(source);
        return result;
        // TODO: add assertions to method GenericEnumerableExtensionsTest.Empty(IEnumerable`1<!!0>)
    }

    /// <summary>Test stub for Flatten(IEnumerable`1&lt;IEnumerable`1&lt;!!0&gt;&gt;)</summary>
    [PexGenericArguments(typeof(int))]
    [PexMethod]
    public IEnumerable<TSource> Flatten<TSource>(IEnumerable<IEnumerable<TSource>> items2D)
    {
        IEnumerable<TSource> result
           = global::GenericEnumerableExtensions.Flatten<TSource>(items2D);
        return result;
        // TODO: add assertions to method GenericEnumerableExtensionsTest.Flatten(IEnumerable`1<IEnumerable`1<!!0>>)
    }

    /// <summary>Test stub for ForEach(IEnumerable`1&lt;!!0&gt;, Action`1&lt;!!0&gt;)</summary>
    [PexGenericArguments(typeof(int))]
    [PexMethod]
    public void ForEach<TSource>(IEnumerable<TSource> source, Action<TSource> action)
    {
        global::GenericEnumerableExtensions.ForEach<TSource>(source, action);
        // TODO: add assertions to method GenericEnumerableExtensionsTest.ForEach(IEnumerable`1<!!0>, Action`1<!!0>)
    }

    /// <summary>Test stub for MaxItem(IEnumerable`1&lt;!!0&gt;, Func`2&lt;!!0,!!1&gt;)</summary>
    [PexGenericArguments(typeof(int), typeof(int))]
    [PexMethod]
    public TSource MaxItem<TSource, TKey>(IEnumerable<TSource> source, Func<TSource, TKey> selector)
    {
        TSource result =
                        global::GenericEnumerableExtensions.MaxItem<TSource, TKey>(source, selector);
        return result;
        // TODO: add assertions to method GenericEnumerableExtensionsTest.MaxItem(IEnumerable`1<!!0>, Func`2<!!0,!!1>)
    }

    /// <summary>Test stub for MaxItem(IEnumerable`1&lt;!!0&gt;)</summary>
    [PexGenericArguments(typeof(int), typeof(int))]
    [PexMethod]
    public TSource MaxItem01<TSource, TKey>(IEnumerable<TSource> source)
    {
        TSource result
           = global::GenericEnumerableExtensions.MaxItem<TSource, TKey>(source);
        return result;
        // TODO: add assertions to method GenericEnumerableExtensionsTest.MaxItem01(IEnumerable`1<!!0>)
    }

    /// <summary>Test stub for MinItem(IEnumerable`1&lt;!!0&gt;, Func`2&lt;!!0,!!1&gt;)</summary>
    [PexGenericArguments(typeof(int), typeof(int))]
    [PexMethod]
    public TSource MinItem<TSource, TKey>(IEnumerable<TSource> source, Func<TSource, TKey> selector)
    {
        TSource result =
                        global::GenericEnumerableExtensions.MinItem<TSource, TKey>(source, selector);
        return result;
        // TODO: add assertions to method GenericEnumerableExtensionsTest.MinItem(IEnumerable`1<!!0>, Func`2<!!0,!!1>)
    }

    /// <summary>Test stub for MinItem(IEnumerable`1&lt;!!0&gt;)</summary>
    [PexGenericArguments(typeof(int), typeof(int))]
    [PexMethod]
    public TSource MinItem01<TSource, TKey>(IEnumerable<TSource> source)
    {
        TSource result
           = global::GenericEnumerableExtensions.MinItem<TSource, TKey>(source);
        return result;
        // TODO: add assertions to method GenericEnumerableExtensionsTest.MinItem01(IEnumerable`1<!!0>)
    }

    /// <summary>Test stub for Random(IEnumerable`1&lt;!!0&gt;)</summary>
    [PexGenericArguments(typeof(int))]
    [PexMethod]
    public TSource Random<TSource>(IEnumerable<TSource> source)
    {
        TSource result = global::GenericEnumerableExtensions.Random<TSource>(source);
        return result;
        // TODO: add assertions to method GenericEnumerableExtensionsTest.Random(IEnumerable`1<!!0>)
    }

    /// <summary>Test stub for SkipLast(IEnumerable`1&lt;!!0&gt;, Int32)</summary>
    [PexGenericArguments(typeof(int))]
    [PexMethod]
    public IEnumerable<TSource> SkipLast<TSource>(IEnumerable<TSource> source, int count)
    {
        IEnumerable<TSource> result
           = global::GenericEnumerableExtensions.SkipLast<TSource>(source, count);
        return result;
        // TODO: add assertions to method GenericEnumerableExtensionsTest.SkipLast(IEnumerable`1<!!0>, Int32)
    }

    /// <summary>Test stub for SkipUntil(IEnumerable`1&lt;!!0&gt;, Func`2&lt;!!0,Boolean&gt;)</summary>
    [PexGenericArguments(typeof(int))]
    [PexMethod]
    public IEnumerable<TSource> SkipUntil<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate)
    {
        IEnumerable<TSource> result
           = global::GenericEnumerableExtensions.SkipUntil<TSource>(source, predicate);
        return result;
        // TODO: add assertions to method GenericEnumerableExtensionsTest.SkipUntil(IEnumerable`1<!!0>, Func`2<!!0,Boolean>)
    }

    /// <summary>Test stub for SkipUntil(IEnumerable`1&lt;!!0&gt;, Func`3&lt;!!0,Int32,Boolean&gt;)</summary>
    [PexGenericArguments(typeof(int))]
    [PexMethod]
    public IEnumerable<TSource> SkipUntil01<TSource>(IEnumerable<TSource> source, Func<TSource, int, bool> predicate)
    {
        IEnumerable<TSource> result
           = global::GenericEnumerableExtensions.SkipUntil<TSource>(source, predicate);
        return result;
        // TODO: add assertions to method GenericEnumerableExtensionsTest.SkipUntil01(IEnumerable`1<!!0>, Func`3<!!0,Int32,Boolean>)
    }

    /// <summary>Test stub for TakeUntil(IEnumerable`1&lt;!!0&gt;, Func`2&lt;!!0,Boolean&gt;)</summary>
    [PexGenericArguments(typeof(int))]
    [PexMethod]
    public IEnumerable<TSource> TakeUntil<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate)
    {
        IEnumerable<TSource> result
           = global::GenericEnumerableExtensions.TakeUntil<TSource>(source, predicate);
        return result;
        // TODO: add assertions to method GenericEnumerableExtensionsTest.TakeUntil(IEnumerable`1<!!0>, Func`2<!!0,Boolean>)
    }

    /// <summary>Test stub for TakeUntil(IEnumerable`1&lt;!!0&gt;, Func`3&lt;!!0,Int32,Boolean&gt;)</summary>
    [PexGenericArguments(typeof(int))]
    [PexMethod]
    public IEnumerable<TSource> TakeUntil01<TSource>(IEnumerable<TSource> source, Func<TSource, int, bool> predicate)
    {
        IEnumerable<TSource> result
           = global::GenericEnumerableExtensions.TakeUntil<TSource>(source, predicate);
        return result;
        // TODO: add assertions to method GenericEnumerableExtensionsTest.TakeUntil01(IEnumerable`1<!!0>, Func`3<!!0,Int32,Boolean>)
    }

    /// <summary>Test stub for WhereNot(IEnumerable`1&lt;!!0&gt;, Func`2&lt;!!0,Boolean&gt;)</summary>
    [PexGenericArguments(typeof(int))]
    [PexMethod]
    public IEnumerable<TSource> WhereNot<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate)
    {
        IEnumerable<TSource> result
           = global::GenericEnumerableExtensions.WhereNot<TSource>(source, predicate);
        return result;
        // TODO: add assertions to method GenericEnumerableExtensionsTest.WhereNot(IEnumerable`1<!!0>, Func`2<!!0,Boolean>)
    }

    /// <summary>Test stub for WhereNot(IEnumerable`1&lt;!!0&gt;, Func`3&lt;!!0,Int32,Boolean&gt;)</summary>
    [PexGenericArguments(typeof(int))]
    [PexMethod]
    public IEnumerable<TSource> WhereNot01<TSource>(IEnumerable<TSource> source, Func<TSource, int, bool> predicate)
    {
        IEnumerable<TSource> result
           = global::GenericEnumerableExtensions.WhereNot<TSource>(source, predicate);
        return result;
        // TODO: add assertions to method GenericEnumerableExtensionsTest.WhereNot01(IEnumerable`1<!!0>, Func`3<!!0,Int32,Boolean>)
    }
}
