// <copyright file="CommonUtilsTest.cs" company="Microsoft">Copyright © Microsoft 2011</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

/// <summary>This class contains parameterized unit tests for CommonUtils</summary>
[PexClass(typeof(global::CommonUtils))]
[PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
[PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
[TestClass]
public partial class CommonUtilsTest
{
    /// <summary>Test stub for CloneT(!!0)</summary>
    [PexGenericArguments(typeof(ICloneable))]
    [PexMethod]
    public T CloneT<T>(T t)
        where T : ICloneable
    {
        T result = global::CommonUtils.CloneT<T>(t);
        return result;
        // TODO: add assertions to method CommonUtilsTest.CloneT(!!0)
    }

    /// <summary>Test stub for IsNotNull(!!0)</summary>
    [PexGenericArguments(typeof(object))]
    [PexMethod]
    public bool IsNotNull<T>(T arg)
        where T : class
    {
        bool result = global::CommonUtils.IsNotNull<T>(arg);
        return result;
        // TODO: add assertions to method CommonUtilsTest.IsNotNull(!!0)
    }

    /// <summary>Test stub for IsNull(!!0)</summary>
    [PexGenericArguments(typeof(object))]
    [PexMethod]
    public bool IsNull<T>(T arg)
        where T : class
    {
        bool result = global::CommonUtils.IsNull<T>(arg);
        return result;
        // TODO: add assertions to method CommonUtilsTest.IsNull(!!0)
    }

    /// <summary>Test stub for IsOneOf(!!0, !!0[])</summary>
    [PexGenericArguments(typeof(int))]
    [PexMethod]
    public bool IsOneOf<T>(T obj, T[] values)
    {
        bool result = global::CommonUtils.IsOneOf<T>(obj, values);
        return result;
        // TODO: add assertions to method CommonUtilsTest.IsOneOf(!!0, !!0[])
    }

    /// <summary>Test stub for Try(Func`1&lt;!!0&gt;, !!0, Type[])</summary>
    [PexGenericArguments(typeof(int))]
    [PexMethod, PexAllowedException(typeof(NullReferenceException)), PexAllowedException(typeof(OperationCanceledException))]
    public T Try<T>(
        Func<T> function,
        T defaultValue,
        Type[] exceptions
    )
    {
        T result = global::CommonUtils.Try<T>(function, defaultValue, exceptions);
        return result;
        // TODO: add assertions to method CommonUtilsTest.Try(Func`1<!!0>, !!0, Type[])
    }

    /// <summary>Test stub for TryNullReference(Func`1&lt;!!0&gt;)</summary>
    [PexGenericArguments(typeof(int))]
    [PexMethod, PexAllowedException(typeof(OperationCanceledException))]
    public T TryNullReference<T>(Func<T> function)
    {
        T result = global::CommonUtils.TryNullReference<T>(function);
        return result;
        // TODO: add assertions to method CommonUtilsTest.TryNullReference(Func`1<!!0>)
    }

    /// <summary>Test stub for TryNullReference(Func`1&lt;!!0&gt;, !!0)</summary>
    [PexGenericArguments(typeof(int))]
    [PexMethod, PexAllowedException(typeof(OperationCanceledException))]
    public T TryNullReference01<T>(Func<T> function, T defaultValue)
    {
        T result = global::CommonUtils.TryNullReference<T>(function, defaultValue);
        return result;
        // TODO: add assertions to method CommonUtilsTest.TryNullReference01(Func`1<!!0>, !!0)
    }
}
