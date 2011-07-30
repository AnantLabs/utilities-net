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
public void Lcm04833()
{
    ushort w;
    w = this.Lcm04((ushort)32, (ushort)32);
    Assert.AreEqual<ushort>((ushort)32, w);
}
[TestMethod]
[PexGeneratedBy(typeof(global::MathExTest))]
[ExpectedException(typeof(InvalidOperationException))]
public void Lcm04ThrowsInvalidOperationException48()
{
    ushort w;
    w = this.Lcm04((ushort)0, (ushort)32);
}
[TestMethod]
[PexGeneratedBy(typeof(global::MathExTest))]
public void Lcm04474()
{
    ushort w;
    w = this.Lcm04((ushort)115, (ushort)34);
    Assert.AreEqual<ushort>((ushort)3910, w);
}
[TestMethod]
[PexGeneratedBy(typeof(global::MathExTest))]
[ExpectedException(typeof(OverflowException))]
public void Lcm04ThrowsOverflowException48()
{
    ushort w;
    w = this.Lcm04((ushort)32769, (ushort)32768);
}
}
