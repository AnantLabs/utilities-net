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
using Microsoft.Pex.Framework.Exceptions;

public partial class MathExTest
{
[TestMethod]
[PexGeneratedBy(typeof(global::MathExTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void Gcd02ThrowsArgumentNullException763()
{
    short w;
    w = this.Gcd02((short[])null);
}
[TestMethod]
[PexGeneratedBy(typeof(global::MathExTest))]
[ExpectedException(typeof(InvalidOperationException))]
public void Gcd02ThrowsInvalidOperationException41()
{
    short w;
    short[] ws = new short[0];
    w = this.Gcd02(ws);
}
[TestMethod]
[PexGeneratedBy(typeof(global::MathExTest))]
[ExpectedException(typeof(InvalidOperationException))]
public void Gcd02ThrowsInvalidOperationException410()
{
    short w;
    short[] ws = new short[1];
    w = this.Gcd02(ws);
}
[TestMethod]
[PexGeneratedBy(typeof(global::MathExTest))]
public void Gcd02381()
{
    short w;
    short[] ws = new short[1];
    ws[0] = (short)33;
    w = this.Gcd02(ws);
    Assert.AreEqual<short>((short)33, w);
}
[TestMethod]
[PexGeneratedBy(typeof(global::MathExTest))]
[ExpectedException(typeof(InvalidOperationException))]
public void Gcd02ThrowsInvalidOperationException959()
{
    short w;
    short[] ws = new short[2];
    w = this.Gcd02(ws);
}
[TestMethod]
[PexGeneratedBy(typeof(global::MathExTest))]
[ExpectedException(typeof(OverflowException))]
public void Gcd02ThrowsOverflowException400()
{
    short w;
    short[] ws = new short[2];
    ws[1] = (short)short.MinValue;
    w = this.Gcd02(ws);
}
[TestMethod]
[PexGeneratedBy(typeof(global::MathExTest))]
[ExpectedException(typeof(OverflowException))]
public void Gcd02ThrowsOverflowException643()
{
    short w;
    short[] ws = new short[2];
    ws[0] = (short)short.MinValue;
    w = this.Gcd02(ws);
}
[TestMethod]
[PexGeneratedBy(typeof(global::MathExTest))]
public void Gcd02723()
{
    short w;
    short[] ws = new short[2];
    ws[1] = (short)1;
    w = this.Gcd02(ws);
    Assert.AreEqual<short>((short)1, w);
}
[TestMethod]
[PexGeneratedBy(typeof(global::MathExTest))]
public void Gcd02623()
{
    short w;
    short[] ws = new short[1];
    ws[0] = (short)(-9);
    w = this.Gcd02(ws);
    Assert.AreEqual<short>((short)9, w);
}
[TestMethod]
[PexGeneratedBy(typeof(global::MathExTest))]
public void Gcd02989()
{
    short w;
    short[] ws = new short[2];
    ws[0] = (short)1;
    w = this.Gcd02(ws);
    Assert.AreEqual<short>((short)1, w);
}
[TestMethod]
[PexGeneratedBy(typeof(global::MathExTest))]
[ExpectedException(typeof(OverflowException))]
public void Gcd02ThrowsOverflowException603()
{
    short w;
    short[] ws = new short[2];
    ws[0] = (short)(-9);
    ws[1] = (short)short.MinValue;
    w = this.Gcd02(ws);
}
[TestMethod]
[PexGeneratedBy(typeof(global::MathExTest))]
public void Gcd02161()
{
    short w;
    short[] ws = new short[3];
    ws[1] = (short)1;
    w = this.Gcd02(ws);
    Assert.AreEqual<short>((short)1, w);
}
[TestMethod]
[PexGeneratedBy(typeof(global::MathExTest))]
public void Gcd02955()
{
    short w;
    short[] ws = new short[2];
    ws[0] = (short)32;
    ws[1] = (short)32;
    w = this.Gcd02(ws);
    Assert.AreEqual<short>((short)32, w);
}
[TestMethod]
[PexGeneratedBy(typeof(global::MathExTest))]
public void Gcd02315()
{
    short w;
    short[] ws = new short[3];
    ws[0] = (short)1;
    w = this.Gcd02(ws);
    Assert.AreEqual<short>((short)1, w);
}
[TestMethod]
[PexGeneratedBy(typeof(global::MathExTest))]
public void Gcd02247()
{
    short w;
    short[] ws = new short[2];
    ws[0] = (short)125;
    ws[1] = (short)121;
    w = this.Gcd02(ws);
    Assert.AreEqual<short>((short)1, w);
}
[TestMethod]
[PexGeneratedBy(typeof(global::MathExTest))]
public void Gcd02664()
{
    short w;
    short[] ws = new short[2];
    ws[1] = (short)(-1);
    w = this.Gcd02(ws);
    Assert.AreEqual<short>((short)1, w);
}
[TestMethod]
[PexGeneratedBy(typeof(global::MathExTest))]
public void Gcd0219()
{
    short w;
    short[] ws = new short[2];
    ws[0] = (short)(-16464);
    ws[1] = (short)(-16464);
    w = this.Gcd02(ws);
    Assert.AreEqual<short>((short)16464, w);
}
[TestMethod]
[PexGeneratedBy(typeof(global::MathExTest))]
public void Gcd0210()
{
    short w;
    short[] ws = new short[3];
    ws[0] = (short)32;
    ws[1] = (short)32;
    ws[2] = (short)32;
    w = this.Gcd02(ws);
    Assert.AreEqual<short>((short)32, w);
}
[TestMethod]
[PexGeneratedBy(typeof(global::MathExTest))]
[ExpectedException(typeof(OverflowException))]
public void Gcd02ThrowsOverflowException32()
{
    short w;
    short[] ws = new short[4];
    ws[0] = (short)1;
    ws[2] = (short)(-1);
    ws[3] = (short)short.MinValue;
    w = this.Gcd02(ws);
}
[TestMethod]
[PexGeneratedBy(typeof(global::MathExTest))]
public void Gcd02129()
{
    short w;
    short[] ws = new short[4];
    ws[0] = (short)1;
    ws[2] = (short)(-1);
    ws[3] = (short)(-1);
    w = this.Gcd02(ws);
    Assert.AreEqual<short>((short)1, w);
}
}
