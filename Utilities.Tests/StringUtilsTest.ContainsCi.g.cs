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

public partial class StringUtilsTest
{
[TestMethod]
[PexGeneratedBy(typeof(global::StringUtilsTest))]
public void ContainsCi84101()
{
    bool b;
    b = this.ContainsCi("", "\0");
    Assert.AreEqual<bool>(false, b);
}
[TestMethod]
[PexGeneratedBy(typeof(global::StringUtilsTest))]
public void ContainsCi98901()
{
    bool b;
    b = this.ContainsCi("", "");
    Assert.AreEqual<bool>(true, b);
}
[TestMethod]
[PexGeneratedBy(typeof(global::StringUtilsTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void ContainsCiThrowsArgumentNullException798()
{
    bool b;
    b = this.ContainsCi("", (string)null);
}
[TestMethod]
[PexGeneratedBy(typeof(global::StringUtilsTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void ContainsCiThrowsArgumentNullException717()
{
    bool b;
    b = this.ContainsCi((string)null, (string)null);
}
}
