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

public partial class DateTimeUtilsTest
{
    [TestMethod]
    [PexGeneratedBy(typeof(global::DateTimeUtilsTest))]
    public void FromUnixTime876()
    {
        DateTime dt;
        dt = this.FromUnixTime(0L, false);
        Assert.AreEqual<int>(1, dt.Day);
        Assert.AreEqual<DayOfWeek>(DayOfWeek.Thursday, dt.DayOfWeek);
        Assert.AreEqual<int>(1, dt.DayOfYear);
        Assert.AreEqual<int>(0, dt.Hour);
        Assert.AreEqual<DateTimeKind>(DateTimeKind.Unspecified, dt.Kind);
        Assert.AreEqual<int>(0, dt.Millisecond);
        Assert.AreEqual<int>(0, dt.Minute);
        Assert.AreEqual<int>(1, dt.Month);
        Assert.AreEqual<int>(0, dt.Second);
        Assert.AreEqual<int>(1970, dt.Year);
    }
    [TestMethod]
    [PexGeneratedBy(typeof(global::DateTimeUtilsTest))]
    [ExpectedException(typeof(OverflowException))]
    public void FromUnixTimeThrowsOverflowException555()
    {
        DateTime dt;
        dt = this.FromUnixTime(274877906944L, false);
    }
    [TestMethod]
    [PexGeneratedBy(typeof(global::DateTimeUtilsTest))]
    [ExpectedException(typeof(OverflowException))]
    public void FromUnixTimeThrowsOverflowException512()
    {
        DateTime dt;
        dt = this.FromUnixTime(-7830914895977906043L, false);
    }
    [TestMethod]
    [PexGeneratedBy(typeof(global::DateTimeUtilsTest))]
    [ExpectedException(typeof(OverflowException))]
    public void FromUnixTimeThrowsOverflowException319()
    {
        DateTime dt;
        dt = this.FromUnixTime(549755813888L, false);
    }
[TestMethod]
[PexGeneratedBy(typeof(global::DateTimeUtilsTest))]
[ExpectedException(typeof(OverflowException))]
public void FromUnixTimeThrowsOverflowException851()
{
    DateTime dt;
    dt = this.FromUnixTime
             (-7830914895977906043L, PexSafeHelpers.ByteToBoolean((byte)2));
}
[TestMethod]
[PexGeneratedBy(typeof(global::DateTimeUtilsTest))]
public void FromUnixTime994()
{
    DateTime dt;
    dt = this.FromUnixTime(-1L, false);
    Assert.AreEqual<int>(31, dt.Day);
    Assert.AreEqual<DayOfWeek>(DayOfWeek.Wednesday, dt.DayOfWeek);
    Assert.AreEqual<int>(365, dt.DayOfYear);
    Assert.AreEqual<int>(23, dt.Hour);
    Assert.AreEqual<DateTimeKind>(DateTimeKind.Unspecified, dt.Kind);
    Assert.AreEqual<int>(0, dt.Millisecond);
    Assert.AreEqual<int>(59, dt.Minute);
    Assert.AreEqual<int>(12, dt.Month);
    Assert.AreEqual<int>(59, dt.Second);
    Assert.AreEqual<int>(1969, dt.Year);
}
[TestMethod]
[PexGeneratedBy(typeof(global::DateTimeUtilsTest))]
public void FromUnixTime34()
{
    DateTime dt;
    dt = this.FromUnixTime(1000001L, false);
    Assert.AreEqual<int>(12, dt.Day);
    Assert.AreEqual<DayOfWeek>(DayOfWeek.Monday, dt.DayOfWeek);
    Assert.AreEqual<int>(12, dt.DayOfYear);
    Assert.AreEqual<int>(13, dt.Hour);
    Assert.AreEqual<DateTimeKind>(DateTimeKind.Unspecified, dt.Kind);
    Assert.AreEqual<int>(0, dt.Millisecond);
    Assert.AreEqual<int>(46, dt.Minute);
    Assert.AreEqual<int>(1, dt.Month);
    Assert.AreEqual<int>(41, dt.Second);
    Assert.AreEqual<int>(1970, dt.Year);
}
[TestMethod]
[PexGeneratedBy(typeof(global::DateTimeUtilsTest))]
public void FromUnixTime809()
{
    DateTime dt;
    dt = this.FromUnixTime(100000001L, false);
    Assert.AreEqual<int>(3, dt.Day);
    Assert.AreEqual<DayOfWeek>(DayOfWeek.Saturday, dt.DayOfWeek);
    Assert.AreEqual<int>(62, dt.DayOfYear);
    Assert.AreEqual<int>(9, dt.Hour);
    Assert.AreEqual<DateTimeKind>(DateTimeKind.Unspecified, dt.Kind);
    Assert.AreEqual<int>(0, dt.Millisecond);
    Assert.AreEqual<int>(46, dt.Minute);
    Assert.AreEqual<int>(3, dt.Month);
    Assert.AreEqual<int>(41, dt.Second);
    Assert.AreEqual<int>(1973, dt.Year);
}
[TestMethod]
[PexGeneratedBy(typeof(global::DateTimeUtilsTest))]
public void FromUnixTime12()
{
    DateTime dt;
    dt = this.FromUnixTime(1000000001L, false);
    Assert.AreEqual<int>(9, dt.Day);
    Assert.AreEqual<DayOfWeek>(DayOfWeek.Sunday, dt.DayOfWeek);
    Assert.AreEqual<int>(252, dt.DayOfYear);
    Assert.AreEqual<int>(1, dt.Hour);
    Assert.AreEqual<DateTimeKind>(DateTimeKind.Unspecified, dt.Kind);
    Assert.AreEqual<int>(0, dt.Millisecond);
    Assert.AreEqual<int>(46, dt.Minute);
    Assert.AreEqual<int>(9, dt.Month);
    Assert.AreEqual<int>(41, dt.Second);
    Assert.AreEqual<int>(2001, dt.Year);
}
[TestMethod]
[PexGeneratedBy(typeof(global::DateTimeUtilsTest))]
public void FromUnixTime738()
{
    DateTime dt;
    dt = this.FromUnixTime(1000000001L, PexSafeHelpers.ByteToBoolean((byte)2));
    Assert.AreEqual<int>(12, dt.Day);
    Assert.AreEqual<DayOfWeek>(DayOfWeek.Monday, dt.DayOfWeek);
    Assert.AreEqual<int>(12, dt.DayOfYear);
    Assert.AreEqual<int>(13, dt.Hour);
    Assert.AreEqual<DateTimeKind>(DateTimeKind.Unspecified, dt.Kind);
    Assert.AreEqual<int>(1, dt.Millisecond);
    Assert.AreEqual<int>(46, dt.Minute);
    Assert.AreEqual<int>(1, dt.Month);
    Assert.AreEqual<int>(40, dt.Second);
    Assert.AreEqual<int>(1970, dt.Year);
}
}
