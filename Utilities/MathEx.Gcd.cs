using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// Part of MathEx class: MathEx.Gcd.
/// </summary>
public static partial class MathEx
{
#region short
    /// <summary>
    /// Returns greatest common divisor of a and b.
    /// </summary>
    public static short Gcd(short a, short b)
    {
        if (a == 0 && b == 0) throw new InvalidOperationException("Gcd isn't defined for two zeroes.");
		
		// Gcd of 0 and another number is the absolute value of this number
        if (a == 0) return b;		
        if (b == 0) return a;		
		
        if (a < 0 || b < 0) return Gcd(Abs(a), Abs(b)); // Gcd(a, b) == Gcd(|a|,|b|)

        while (b != 0) b = (short)(a % (a = b));
        return a;
    }

    /// <summary>
    /// Returns greatest common divisor of all values.
    /// </summary>
    public static short Gcd(params short[] values)
    {
        if (values == null) throw new ArgumentNullException("values");
        if (values.Length == 0) throw new InvalidOperationException("Cannot calculate Gcd for 0 elements.");

        return values.Aggregate(Gcd);
    }

    /// <summary>
    /// Returns greatest common divisor of all values.
    /// </summary>
    public static short Gcd(IEnumerable<short> values)
    {
        if (values == null) throw new ArgumentNullException("values");

        return Gcd(values.ToArray());
    }
#endregion

#region ushort
    /// <summary>
    /// Returns greatest common divisor of a and b.
    /// </summary>
    public static ushort Gcd(ushort a, ushort b)
    {
        if (a == 0 && b == 0) throw new InvalidOperationException("Gcd isn't defined for two zeroes.");
		
		// Gcd of 0 and another number is the absolute value of this number
        if (a == 0) return b;		
        if (b == 0) return a;		
		
        if (a < 0 || b < 0) return Gcd(Abs(a), Abs(b)); // Gcd(a, b) == Gcd(|a|,|b|)

        while (b != 0) b = (ushort)(a % (a = b));
        return a;
    }

    /// <summary>
    /// Returns greatest common divisor of all values.
    /// </summary>
    public static ushort Gcd(params ushort[] values)
    {
        if (values == null) throw new ArgumentNullException("values");
        if (values.Length == 0) throw new InvalidOperationException("Cannot calculate Gcd for 0 elements.");

        return values.Aggregate(Gcd);
    }

    /// <summary>
    /// Returns greatest common divisor of all values.
    /// </summary>
    public static ushort Gcd(IEnumerable<ushort> values)
    {
        if (values == null) throw new ArgumentNullException("values");

        return Gcd(values.ToArray());
    }
#endregion

#region int
    /// <summary>
    /// Returns greatest common divisor of a and b.
    /// </summary>
    public static int Gcd(int a, int b)
    {
        if (a == 0 && b == 0) throw new InvalidOperationException("Gcd isn't defined for two zeroes.");
		
		// Gcd of 0 and another number is the absolute value of this number
        if (a == 0) return b;		
        if (b == 0) return a;		
		
        if (a < 0 || b < 0) return Gcd(Abs(a), Abs(b)); // Gcd(a, b) == Gcd(|a|,|b|)

        while (b != 0) b = (int)(a % (a = b));
        return a;
    }

    /// <summary>
    /// Returns greatest common divisor of all values.
    /// </summary>
    public static int Gcd(params int[] values)
    {
        if (values == null) throw new ArgumentNullException("values");
        if (values.Length == 0) throw new InvalidOperationException("Cannot calculate Gcd for 0 elements.");

        return values.Aggregate(Gcd);
    }

    /// <summary>
    /// Returns greatest common divisor of all values.
    /// </summary>
    public static int Gcd(IEnumerable<int> values)
    {
        if (values == null) throw new ArgumentNullException("values");

        return Gcd(values.ToArray());
    }
#endregion

#region uint
    /// <summary>
    /// Returns greatest common divisor of a and b.
    /// </summary>
    public static uint Gcd(uint a, uint b)
    {
        if (a == 0 && b == 0) throw new InvalidOperationException("Gcd isn't defined for two zeroes.");
		
		// Gcd of 0 and another number is the absolute value of this number
        if (a == 0) return b;		
        if (b == 0) return a;		
		
        if (a < 0 || b < 0) return Gcd(Abs(a), Abs(b)); // Gcd(a, b) == Gcd(|a|,|b|)

        while (b != 0) b = (uint)(a % (a = b));
        return a;
    }

    /// <summary>
    /// Returns greatest common divisor of all values.
    /// </summary>
    public static uint Gcd(params uint[] values)
    {
        if (values == null) throw new ArgumentNullException("values");
        if (values.Length == 0) throw new InvalidOperationException("Cannot calculate Gcd for 0 elements.");

        return values.Aggregate(Gcd);
    }

    /// <summary>
    /// Returns greatest common divisor of all values.
    /// </summary>
    public static uint Gcd(IEnumerable<uint> values)
    {
        if (values == null) throw new ArgumentNullException("values");

        return Gcd(values.ToArray());
    }
#endregion

#region long
    /// <summary>
    /// Returns greatest common divisor of a and b.
    /// </summary>
    public static long Gcd(long a, long b)
    {
        if (a == 0 && b == 0) throw new InvalidOperationException("Gcd isn't defined for two zeroes.");
		
		// Gcd of 0 and another number is the absolute value of this number
        if (a == 0) return b;		
        if (b == 0) return a;		
		
        if (a < 0 || b < 0) return Gcd(Abs(a), Abs(b)); // Gcd(a, b) == Gcd(|a|,|b|)

        while (b != 0) b = (long)(a % (a = b));
        return a;
    }

    /// <summary>
    /// Returns greatest common divisor of all values.
    /// </summary>
    public static long Gcd(params long[] values)
    {
        if (values == null) throw new ArgumentNullException("values");
        if (values.Length == 0) throw new InvalidOperationException("Cannot calculate Gcd for 0 elements.");

        return values.Aggregate(Gcd);
    }

    /// <summary>
    /// Returns greatest common divisor of all values.
    /// </summary>
    public static long Gcd(IEnumerable<long> values)
    {
        if (values == null) throw new ArgumentNullException("values");

        return Gcd(values.ToArray());
    }
#endregion

#region ulong
    /// <summary>
    /// Returns greatest common divisor of a and b.
    /// </summary>
    public static ulong Gcd(ulong a, ulong b)
    {
        if (a == 0 && b == 0) throw new InvalidOperationException("Gcd isn't defined for two zeroes.");
		
		// Gcd of 0 and another number is the absolute value of this number
        if (a == 0) return b;		
        if (b == 0) return a;		
		
        if (a < 0 || b < 0) return Gcd(Abs(a), Abs(b)); // Gcd(a, b) == Gcd(|a|,|b|)

        while (b != 0) b = (ulong)(a % (a = b));
        return a;
    }

    /// <summary>
    /// Returns greatest common divisor of all values.
    /// </summary>
    public static ulong Gcd(params ulong[] values)
    {
        if (values == null) throw new ArgumentNullException("values");
        if (values.Length == 0) throw new InvalidOperationException("Cannot calculate Gcd for 0 elements.");

        return values.Aggregate(Gcd);
    }

    /// <summary>
    /// Returns greatest common divisor of all values.
    /// </summary>
    public static ulong Gcd(IEnumerable<ulong> values)
    {
        if (values == null) throw new ArgumentNullException("values");

        return Gcd(values.ToArray());
    }
#endregion
}