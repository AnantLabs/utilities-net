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

public partial class MathExTest
{
[TestMethod]
[PexGeneratedBy(typeof(global::MathExTest))]
public void Abs04284()
{
    float f;
    f = this.Abs04((float)0);
    Assert.AreEqual<float>((float)0, f);
}
[TestMethod]
[PexGeneratedBy(typeof(global::MathExTest))]
public void Abs04726()
{
    float f;
    f = this.Abs04((float)(-1));
    Assert.AreEqual<float>((float)1, f);
}
}
