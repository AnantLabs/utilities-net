// <auto-generated>
// This file contains automatically generated unit tests.
// Do NOT modify this file manually.
// 
// When Pex is invoked again,
// it might remove or update any previously generated unit tests.
// 
// If the contents of this file becomes outdated, e.g. if it does not
// compile anymore, you may delete this file and invoke Pex again.
// </auto-generated>
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Pex.Framework.Generated;

public partial class CommonUtilsTest
{
[TestMethod]
[PexGeneratedBy(typeof(global::CommonUtilsTest))]
public void IsOneOf474()
{
    bool b;
    int[] ints = new int[0];
    b = this.IsOneOf<int>(0, ints);
    Assert.AreEqual<bool>(false, b);
}
[TestMethod]
[PexGeneratedBy(typeof(global::CommonUtilsTest))]
public void IsOneOf20501()
{
    bool b;
    int[] ints = new int[1];
    b = this.IsOneOf<int>(0, ints);
    Assert.AreEqual<bool>(true, b);
}
[TestMethod]
[PexGeneratedBy(typeof(global::CommonUtilsTest))]
public void IsOneOf44901()
{
    bool b;
    b = this.IsOneOf<int>(0, (int[])null);
    Assert.AreEqual<bool>(false, b);
}
}
