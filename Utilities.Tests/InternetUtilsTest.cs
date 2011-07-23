// <copyright file="InternetUtilsTest.cs" company="Microsoft">Copyright © Microsoft 2011</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

/// <summary>This class contains parameterized unit tests for InternetUtils</summary>
[PexClass(typeof(global::InternetUtils))]
[PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
[PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
[TestClass]
public partial class InternetUtilsTest
{
    /// <summary>Test stub for Fetch(Uri)</summary>
    [PexMethod]
    public string Fetch(Uri url)
    {
        string result = global::InternetUtils.Fetch(url);
        return result;
        // TODO: add assertions to method InternetUtilsTest.Fetch(Uri)
    }

    /// <summary>Test stub for Fetch(String)</summary>
    [PexMethod]
    public string Fetch01(string url)
    {
        string result = global::InternetUtils.Fetch(url);
        return result;
        // TODO: add assertions to method InternetUtilsTest.Fetch01(String)
    }
}
