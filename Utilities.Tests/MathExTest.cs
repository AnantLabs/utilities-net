// <copyright file="MathExTest.cs" company="Microsoft">Copyright © Microsoft 2011</copyright>
using System;
using System.Collections.Generic;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

/// <summary>This class contains parameterized unit tests for MathEx</summary>
[PexClass(typeof(global::MathEx))]
[PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
[PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
[TestClass]
public partial class MathExTest
{
    /// <summary>Test stub for Abs(SByte)</summary>
    [PexMethod]
    public sbyte Abs(sbyte value)
    {
        sbyte result = global::MathEx.Abs(value);
        return result;
        // TODO: add assertions to method MathExTest.Abs(SByte)
    }

    /// <summary>Test stub for Abs(Int16)</summary>
    [PexMethod]
    public short Abs01(short value)
    {
        short result = global::MathEx.Abs(value);
        return result;
        // TODO: add assertions to method MathExTest.Abs01(Int16)
    }

    /// <summary>Test stub for Abs(Int32)</summary>
    [PexMethod]
    public int Abs02(int value)
    {
        int result = global::MathEx.Abs(value);
        return result;
        // TODO: add assertions to method MathExTest.Abs02(Int32)
    }

    /// <summary>Test stub for Abs(Int64)</summary>
    [PexMethod]
    public long Abs03(long value)
    {
        long result = global::MathEx.Abs(value);
        return result;
        // TODO: add assertions to method MathExTest.Abs03(Int64)
    }

    /// <summary>Test stub for Abs(Single)</summary>
    [PexMethod]
    public float Abs04(float value)
    {
        float result = global::MathEx.Abs(value);
        return result;
        // TODO: add assertions to method MathExTest.Abs04(Single)
    }

    /// <summary>Test stub for Abs(Double)</summary>
    [PexMethod]
    public double Abs05(double value)
    {
        double result = global::MathEx.Abs(value);
        return result;
        // TODO: add assertions to method MathExTest.Abs05(Double)
    }

    /// <summary>Test stub for Abs(Decimal)</summary>
    [PexMethod]
    public decimal Abs06(decimal value)
    {
        decimal result = global::MathEx.Abs(value);
        return result;
        // TODO: add assertions to method MathExTest.Abs06(Decimal)
    }

    /// <summary>Test stub for Abs(Byte)</summary>
    [PexMethod]
    public byte Abs07(byte value)
    {
        byte result = global::MathEx.Abs(value);
        return result;
        // TODO: add assertions to method MathExTest.Abs07(Byte)
    }

    /// <summary>Test stub for Abs(UInt16)</summary>
    [PexMethod]
    public ushort Abs08(ushort value)
    {
        ushort result = global::MathEx.Abs(value);
        return result;
        // TODO: add assertions to method MathExTest.Abs08(UInt16)
    }

    /// <summary>Test stub for Abs(UInt32)</summary>
    [PexMethod]
    public uint Abs09(uint value)
    {
        uint result = global::MathEx.Abs(value);
        return result;
        // TODO: add assertions to method MathExTest.Abs09(UInt32)
    }

    /// <summary>Test stub for Abs(UInt64)</summary>
    [PexMethod]
    public ulong Abs10(ulong value)
    {
        ulong result = global::MathEx.Abs(value);
        return result;
        // TODO: add assertions to method MathExTest.Abs10(UInt64)
    }

    /// <summary>Test stub for Gcd(Int16, Int16)</summary>
    [PexMethod]
    public short Gcd(short a, short b)
    {
        short result = global::MathEx.Gcd(a, b);
        return result;
        // TODO: add assertions to method MathExTest.Gcd(Int16, Int16)
    }

    /// <summary>Test stub for Gcd(Int16[])</summary>
    [PexMethod]
    public short Gcd01(short[] values)
    {
        short result = global::MathEx.Gcd(values);
        return result;
        // TODO: add assertions to method MathExTest.Gcd01(Int16[])
    }

    /// <summary>Test stub for Gcd(IEnumerable`1&lt;Int16&gt;)</summary>
    [PexMethod]
    public short Gcd02(IEnumerable<short> values)
    {
        short result = global::MathEx.Gcd(values);
        return result;
        // TODO: add assertions to method MathExTest.Gcd02(IEnumerable`1<Int16>)
    }

    /// <summary>Test stub for Gcd(UInt16, UInt16)</summary>
    [PexMethod]
    public ushort Gcd03(ushort a, ushort b)
    {
        ushort result = global::MathEx.Gcd(a, b);
        return result;
        // TODO: add assertions to method MathExTest.Gcd03(UInt16, UInt16)
    }

    /// <summary>Test stub for Gcd(UInt16[])</summary>
    [PexMethod]
    public ushort Gcd04(ushort[] values)
    {
        ushort result = global::MathEx.Gcd(values);
        return result;
        // TODO: add assertions to method MathExTest.Gcd04(UInt16[])
    }

    /// <summary>Test stub for Gcd(IEnumerable`1&lt;UInt16&gt;)</summary>
    [PexMethod]
    public ushort Gcd05(IEnumerable<ushort> values)
    {
        ushort result = global::MathEx.Gcd(values);
        return result;
        // TODO: add assertions to method MathExTest.Gcd05(IEnumerable`1<UInt16>)
    }

    /// <summary>Test stub for Gcd(Int32, Int32)</summary>
    [PexMethod]
    public int Gcd06(int a, int b)
    {
        int result = global::MathEx.Gcd(a, b);
        return result;
        // TODO: add assertions to method MathExTest.Gcd06(Int32, Int32)
    }

    /// <summary>Test stub for Gcd(Int32[])</summary>
    [PexMethod]
    public int Gcd07(int[] values)
    {
        int result = global::MathEx.Gcd(values);
        return result;
        // TODO: add assertions to method MathExTest.Gcd07(Int32[])
    }

    /// <summary>Test stub for Gcd(IEnumerable`1&lt;Int32&gt;)</summary>
    [PexMethod]
    public int Gcd08(IEnumerable<int> values)
    {
        int result = global::MathEx.Gcd(values);
        return result;
        // TODO: add assertions to method MathExTest.Gcd08(IEnumerable`1<Int32>)
    }

    /// <summary>Test stub for Gcd(UInt32, UInt32)</summary>
    [PexMethod]
    public uint Gcd09(uint a, uint b)
    {
        uint result = global::MathEx.Gcd(a, b);
        return result;
        // TODO: add assertions to method MathExTest.Gcd09(UInt32, UInt32)
    }

    /// <summary>Test stub for Gcd(UInt32[])</summary>
    [PexMethod]
    public uint Gcd10(uint[] values)
    {
        uint result = global::MathEx.Gcd(values);
        return result;
        // TODO: add assertions to method MathExTest.Gcd10(UInt32[])
    }

    /// <summary>Test stub for Gcd(IEnumerable`1&lt;UInt32&gt;)</summary>
    [PexMethod]
    public uint Gcd11(IEnumerable<uint> values)
    {
        uint result = global::MathEx.Gcd(values);
        return result;
        // TODO: add assertions to method MathExTest.Gcd11(IEnumerable`1<UInt32>)
    }

    /// <summary>Test stub for Gcd(Int64, Int64)</summary>
    [PexMethod]
    public long Gcd12(long a, long b)
    {
        long result = global::MathEx.Gcd(a, b);
        return result;
        // TODO: add assertions to method MathExTest.Gcd12(Int64, Int64)
    }

    /// <summary>Test stub for Gcd(Int64[])</summary>
    [PexMethod]
    public long Gcd13(long[] values)
    {
        long result = global::MathEx.Gcd(values);
        return result;
        // TODO: add assertions to method MathExTest.Gcd13(Int64[])
    }

    /// <summary>Test stub for Gcd(IEnumerable`1&lt;Int64&gt;)</summary>
    [PexMethod]
    public long Gcd14(IEnumerable<long> values)
    {
        long result = global::MathEx.Gcd(values);
        return result;
        // TODO: add assertions to method MathExTest.Gcd14(IEnumerable`1<Int64>)
    }

    /// <summary>Test stub for Gcd(UInt64, UInt64)</summary>
    [PexMethod]
    public ulong Gcd15(ulong a, ulong b)
    {
        ulong result = global::MathEx.Gcd(a, b);
        return result;
        // TODO: add assertions to method MathExTest.Gcd15(UInt64, UInt64)
    }

    /// <summary>Test stub for Gcd(UInt64[])</summary>
    [PexMethod]
    public ulong Gcd16(ulong[] values)
    {
        ulong result = global::MathEx.Gcd(values);
        return result;
        // TODO: add assertions to method MathExTest.Gcd16(UInt64[])
    }

    /// <summary>Test stub for Gcd(IEnumerable`1&lt;UInt64&gt;)</summary>
    [PexMethod]
    public ulong Gcd17(IEnumerable<ulong> values)
    {
        ulong result = global::MathEx.Gcd(values);
        return result;
        // TODO: add assertions to method MathExTest.Gcd17(IEnumerable`1<UInt64>)
    }

    /// <summary>Test stub for IsPrime(Int16)</summary>
    [PexMethod]
    public bool IsPrime(short number)
    {
        bool result = global::MathEx.IsPrime(number);
        return result;
        // TODO: add assertions to method MathExTest.IsPrime(Int16)
    }

    /// <summary>Test stub for IsPrime(UInt16)</summary>
    [PexMethod]
    public bool IsPrime01(ushort number)
    {
        bool result = global::MathEx.IsPrime(number);
        return result;
        // TODO: add assertions to method MathExTest.IsPrime01(UInt16)
    }

    /// <summary>Test stub for IsPrime(Int32)</summary>
    [PexMethod]
    public bool IsPrime02(int number)
    {
        bool result = global::MathEx.IsPrime(number);
        return result;
        // TODO: add assertions to method MathExTest.IsPrime02(Int32)
    }

    /// <summary>Test stub for IsPrime(UInt32)</summary>
    [PexMethod]
    public bool IsPrime03(uint number)
    {
        bool result = global::MathEx.IsPrime(number);
        return result;
        // TODO: add assertions to method MathExTest.IsPrime03(UInt32)
    }

    /// <summary>Test stub for IsPrime(Int64)</summary>
    [PexMethod]
    public bool IsPrime04(long number)
    {
        bool result = global::MathEx.IsPrime(number);
        return result;
        // TODO: add assertions to method MathExTest.IsPrime04(Int64)
    }

    /// <summary>Test stub for IsPrime(UInt64)</summary>
    [PexMethod]
    public bool IsPrime05(ulong number)
    {
        bool result = global::MathEx.IsPrime(number);
        return result;
        // TODO: add assertions to method MathExTest.IsPrime05(UInt64)
    }

    /// <summary>Test stub for Lcm(Int16, Int16)</summary>
    [PexMethod]
    public short Lcm(short a, short b)
    {
        short result = global::MathEx.Lcm(a, b);
        return result;
        // TODO: add assertions to method MathExTest.Lcm(Int16, Int16)
    }

    /// <summary>Test stub for Lcm(Int16[])</summary>
    [PexMethod]
    public short Lcm01(short[] values)
    {
        short result = global::MathEx.Lcm(values);
        return result;
        // TODO: add assertions to method MathExTest.Lcm01(Int16[])
    }

    /// <summary>Test stub for Lcm(IEnumerable`1&lt;Int16&gt;)</summary>
    [PexMethod]
    public short Lcm02(IEnumerable<short> values)
    {
        short result = global::MathEx.Lcm(values);
        return result;
        // TODO: add assertions to method MathExTest.Lcm02(IEnumerable`1<Int16>)
    }

    /// <summary>Test stub for Lcm(UInt16, UInt16)</summary>
    [PexMethod]
    public ushort Lcm03(ushort a, ushort b)
    {
        ushort result = global::MathEx.Lcm(a, b);
        return result;
        // TODO: add assertions to method MathExTest.Lcm03(UInt16, UInt16)
    }

    /// <summary>Test stub for Lcm(UInt16[])</summary>
    [PexMethod]
    public ushort Lcm04(ushort[] values)
    {
        ushort result = global::MathEx.Lcm(values);
        return result;
        // TODO: add assertions to method MathExTest.Lcm04(UInt16[])
    }

    /// <summary>Test stub for Lcm(IEnumerable`1&lt;UInt16&gt;)</summary>
    [PexMethod]
    public ushort Lcm05(IEnumerable<ushort> values)
    {
        ushort result = global::MathEx.Lcm(values);
        return result;
        // TODO: add assertions to method MathExTest.Lcm05(IEnumerable`1<UInt16>)
    }

    /// <summary>Test stub for Lcm(Int32, Int32)</summary>
    [PexMethod]
    public int Lcm06(int a, int b)
    {
        int result = global::MathEx.Lcm(a, b);
        return result;
        // TODO: add assertions to method MathExTest.Lcm06(Int32, Int32)
    }

    /// <summary>Test stub for Lcm(Int32[])</summary>
    [PexMethod]
    public int Lcm07(int[] values)
    {
        int result = global::MathEx.Lcm(values);
        return result;
        // TODO: add assertions to method MathExTest.Lcm07(Int32[])
    }

    /// <summary>Test stub for Lcm(IEnumerable`1&lt;Int32&gt;)</summary>
    [PexMethod]
    public int Lcm08(IEnumerable<int> values)
    {
        int result = global::MathEx.Lcm(values);
        return result;
        // TODO: add assertions to method MathExTest.Lcm08(IEnumerable`1<Int32>)
    }

    /// <summary>Test stub for Lcm(UInt32, UInt32)</summary>
    [PexMethod]
    public uint Lcm09(uint a, uint b)
    {
        uint result = global::MathEx.Lcm(a, b);
        return result;
        // TODO: add assertions to method MathExTest.Lcm09(UInt32, UInt32)
    }

    /// <summary>Test stub for Lcm(UInt32[])</summary>
    [PexMethod]
    public uint Lcm10(uint[] values)
    {
        uint result = global::MathEx.Lcm(values);
        return result;
        // TODO: add assertions to method MathExTest.Lcm10(UInt32[])
    }

    /// <summary>Test stub for Lcm(IEnumerable`1&lt;UInt32&gt;)</summary>
    [PexMethod]
    public uint Lcm11(IEnumerable<uint> values)
    {
        uint result = global::MathEx.Lcm(values);
        return result;
        // TODO: add assertions to method MathExTest.Lcm11(IEnumerable`1<UInt32>)
    }

    /// <summary>Test stub for Lcm(Int64, Int64)</summary>
    [PexMethod]
    public long Lcm12(long a, long b)
    {
        long result = global::MathEx.Lcm(a, b);
        return result;
        // TODO: add assertions to method MathExTest.Lcm12(Int64, Int64)
    }

    /// <summary>Test stub for Lcm(Int64[])</summary>
    [PexMethod]
    public long Lcm13(long[] values)
    {
        long result = global::MathEx.Lcm(values);
        return result;
        // TODO: add assertions to method MathExTest.Lcm13(Int64[])
    }

    /// <summary>Test stub for Lcm(IEnumerable`1&lt;Int64&gt;)</summary>
    [PexMethod]
    public long Lcm14(IEnumerable<long> values)
    {
        long result = global::MathEx.Lcm(values);
        return result;
        // TODO: add assertions to method MathExTest.Lcm14(IEnumerable`1<Int64>)
    }

    /// <summary>Test stub for Lcm(UInt64, UInt64)</summary>
    [PexMethod]
    public ulong Lcm15(ulong a, ulong b)
    {
        ulong result = global::MathEx.Lcm(a, b);
        return result;
        // TODO: add assertions to method MathExTest.Lcm15(UInt64, UInt64)
    }

    /// <summary>Test stub for Lcm(UInt64[])</summary>
    [PexMethod]
    public ulong Lcm16(ulong[] values)
    {
        ulong result = global::MathEx.Lcm(values);
        return result;
        // TODO: add assertions to method MathExTest.Lcm16(UInt64[])
    }

    /// <summary>Test stub for Lcm(IEnumerable`1&lt;UInt64&gt;)</summary>
    [PexMethod]
    public ulong Lcm17(IEnumerable<ulong> values)
    {
        ulong result = global::MathEx.Lcm(values);
        return result;
        // TODO: add assertions to method MathExTest.Lcm17(IEnumerable`1<UInt64>)
    }

    /// <summary>Test stub for Lerp(Single, Single, Single)</summary>
    [PexMethod]
    public float Lerp(
        float left,
        float right,
        float frac
    )
    {
        float result = global::MathEx.Lerp(left, right, frac);
        return result;
        // TODO: add assertions to method MathExTest.Lerp(Single, Single, Single)
    }

    /// <summary>Test stub for Lerp(Double, Double, Double)</summary>
    [PexMethod]
    public double Lerp01(
        double left,
        double right,
        double frac
    )
    {
        double result = global::MathEx.Lerp(left, right, frac);
        return result;
        // TODO: add assertions to method MathExTest.Lerp01(Double, Double, Double)
    }

    /// <summary>Test stub for Max(Byte[])</summary>
    [PexMethod]
    public byte Max(byte[] values)
    {
        byte result = global::MathEx.Max(values);
        return result;
        // TODO: add assertions to method MathExTest.Max(Byte[])
    }

    /// <summary>Test stub for Max(SByte[])</summary>
    [PexMethod]
    public sbyte Max01(sbyte[] values)
    {
        sbyte result = global::MathEx.Max(values);
        return result;
        // TODO: add assertions to method MathExTest.Max01(SByte[])
    }

    /// <summary>Test stub for Max(Int16[])</summary>
    [PexMethod]
    public short Max02(short[] values)
    {
        short result = global::MathEx.Max(values);
        return result;
        // TODO: add assertions to method MathExTest.Max02(Int16[])
    }

    /// <summary>Test stub for Max(UInt16[])</summary>
    [PexMethod]
    public ushort Max03(ushort[] values)
    {
        ushort result = global::MathEx.Max(values);
        return result;
        // TODO: add assertions to method MathExTest.Max03(UInt16[])
    }

    /// <summary>Test stub for Max(Int32[])</summary>
    [PexMethod]
    public int Max04(int[] values)
    {
        int result = global::MathEx.Max(values);
        return result;
        // TODO: add assertions to method MathExTest.Max04(Int32[])
    }

    /// <summary>Test stub for Max(UInt32[])</summary>
    [PexMethod]
    public uint Max05(uint[] values)
    {
        uint result = global::MathEx.Max(values);
        return result;
        // TODO: add assertions to method MathExTest.Max05(UInt32[])
    }

    /// <summary>Test stub for Max(Int64[])</summary>
    [PexMethod]
    public long Max06(long[] values)
    {
        long result = global::MathEx.Max(values);
        return result;
        // TODO: add assertions to method MathExTest.Max06(Int64[])
    }

    /// <summary>Test stub for Max(UInt64[])</summary>
    [PexMethod]
    public ulong Max07(ulong[] values)
    {
        ulong result = global::MathEx.Max(values);
        return result;
        // TODO: add assertions to method MathExTest.Max07(UInt64[])
    }

    /// <summary>Test stub for Max(Single[])</summary>
    [PexMethod]
    public float Max08(float[] values)
    {
        float result = global::MathEx.Max(values);
        return result;
        // TODO: add assertions to method MathExTest.Max08(Single[])
    }

    /// <summary>Test stub for Max(Double[])</summary>
    [PexMethod]
    public double Max09(double[] values)
    {
        double result = global::MathEx.Max(values);
        return result;
        // TODO: add assertions to method MathExTest.Max09(Double[])
    }

    /// <summary>Test stub for Max(Decimal[])</summary>
    [PexMethod]
    public decimal Max10(decimal[] values)
    {
        decimal result = global::MathEx.Max(values);
        return result;
        // TODO: add assertions to method MathExTest.Max10(Decimal[])
    }

    /// <summary>Test stub for Min(Byte[])</summary>
    [PexMethod]
    public byte Min(byte[] values)
    {
        byte result = global::MathEx.Min(values);
        return result;
        // TODO: add assertions to method MathExTest.Min(Byte[])
    }

    /// <summary>Test stub for Min(SByte[])</summary>
    [PexMethod]
    public sbyte Min01(sbyte[] values)
    {
        sbyte result = global::MathEx.Min(values);
        return result;
        // TODO: add assertions to method MathExTest.Min01(SByte[])
    }

    /// <summary>Test stub for Min(Int16[])</summary>
    [PexMethod]
    public short Min02(short[] values)
    {
        short result = global::MathEx.Min(values);
        return result;
        // TODO: add assertions to method MathExTest.Min02(Int16[])
    }

    /// <summary>Test stub for Min(UInt16[])</summary>
    [PexMethod]
    public ushort Min03(ushort[] values)
    {
        ushort result = global::MathEx.Min(values);
        return result;
        // TODO: add assertions to method MathExTest.Min03(UInt16[])
    }

    /// <summary>Test stub for Min(Int32[])</summary>
    [PexMethod]
    public int Min04(int[] values)
    {
        int result = global::MathEx.Min(values);
        return result;
        // TODO: add assertions to method MathExTest.Min04(Int32[])
    }

    /// <summary>Test stub for Min(UInt32[])</summary>
    [PexMethod]
    public uint Min05(uint[] values)
    {
        uint result = global::MathEx.Min(values);
        return result;
        // TODO: add assertions to method MathExTest.Min05(UInt32[])
    }

    /// <summary>Test stub for Min(Int64[])</summary>
    [PexMethod]
    public long Min06(long[] values)
    {
        long result = global::MathEx.Min(values);
        return result;
        // TODO: add assertions to method MathExTest.Min06(Int64[])
    }

    /// <summary>Test stub for Min(UInt64[])</summary>
    [PexMethod]
    public ulong Min07(ulong[] values)
    {
        ulong result = global::MathEx.Min(values);
        return result;
        // TODO: add assertions to method MathExTest.Min07(UInt64[])
    }

    /// <summary>Test stub for Min(Single[])</summary>
    [PexMethod]
    public float Min08(float[] values)
    {
        float result = global::MathEx.Min(values);
        return result;
        // TODO: add assertions to method MathExTest.Min08(Single[])
    }

    /// <summary>Test stub for Min(Double[])</summary>
    [PexMethod]
    public double Min09(double[] values)
    {
        double result = global::MathEx.Min(values);
        return result;
        // TODO: add assertions to method MathExTest.Min09(Double[])
    }

    /// <summary>Test stub for Min(Decimal[])</summary>
    [PexMethod]
    public decimal Min10(decimal[] values)
    {
        decimal result = global::MathEx.Min(values);
        return result;
        // TODO: add assertions to method MathExTest.Min10(Decimal[])
    }
}
