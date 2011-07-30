using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// Part of MathEx class: MathEx.Lcm.
/// </summary>
public static partial class MathEx
{
#region short
    /// <summary>
    /// Returns least common multiplier of <paramref name="a"/> and <paramref name="b"/>.
    /// </summary>
    public static short Lcm(short a, short b)
    {
		if(a == 0 || b == 0) throw new InvalidOperationException("Lcm isn't defined for a == 0 or b == 0.");
        checked
        {
            return (short)Abs(a / Gcd(a, b) * b);
        }
    }

    /// <summary>
    /// Returns least common multiplier of <paramref name="values"/>.
    /// </summary>
    public static short Lcm(params short[] values)
    {
        if (values == null) throw new ArgumentNullException("values");
        if (values.Length == 0) throw new InvalidOperationException("Cannot calculate Lcm for 0 elements.");
		
		if(values.Length == 1) {
			if(values.Single() == 0) throw new InvalidOperationException("Lcm isn't defined for single zero.");
			else return Abs(values.Single());
		}

        return values.Aggregate(Lcm);
    }

    /// <summary>
    /// Returns greatest common divisor of <paramref name="values"/>.
    /// </summary>
    public static short Lcm(IEnumerable<short> values)
    {
        if (values == null) throw new ArgumentNullException("values");

        return Gcd(values.ToArray());
    }
#endregion

#region int
    /// <summary>
    /// Returns least common multiplier of <paramref name="a"/> and <paramref name="b"/>.
    /// </summary>
    public static int Lcm(int a, int b)
    {
		if(a == 0 || b == 0) throw new InvalidOperationException("Lcm isn't defined for a == 0 or b == 0.");
        checked
        {
            return (int)Abs(a / Gcd(a, b) * b);
        }
    }

    /// <summary>
    /// Returns least common multiplier of <paramref name="values"/>.
    /// </summary>
    public static int Lcm(params int[] values)
    {
        if (values == null) throw new ArgumentNullException("values");
        if (values.Length == 0) throw new InvalidOperationException("Cannot calculate Lcm for 0 elements.");
		
		if(values.Length == 1) {
			if(values.Single() == 0) throw new InvalidOperationException("Lcm isn't defined for single zero.");
			else return Abs(values.Single());
		}

        return values.Aggregate(Lcm);
    }

    /// <summary>
    /// Returns greatest common divisor of <paramref name="values"/>.
    /// </summary>
    public static int Lcm(IEnumerable<int> values)
    {
        if (values == null) throw new ArgumentNullException("values");

        return Gcd(values.ToArray());
    }
#endregion

#region long
    /// <summary>
    /// Returns least common multiplier of <paramref name="a"/> and <paramref name="b"/>.
    /// </summary>
    public static long Lcm(long a, long b)
    {
		if(a == 0 || b == 0) throw new InvalidOperationException("Lcm isn't defined for a == 0 or b == 0.");
        checked
        {
            return (long)Abs(a / Gcd(a, b) * b);
        }
    }

    /// <summary>
    /// Returns least common multiplier of <paramref name="values"/>.
    /// </summary>
    public static long Lcm(params long[] values)
    {
        if (values == null) throw new ArgumentNullException("values");
        if (values.Length == 0) throw new InvalidOperationException("Cannot calculate Lcm for 0 elements.");
		
		if(values.Length == 1) {
			if(values.Single() == 0) throw new InvalidOperationException("Lcm isn't defined for single zero.");
			else return Abs(values.Single());
		}

        return values.Aggregate(Lcm);
    }

    /// <summary>
    /// Returns greatest common divisor of <paramref name="values"/>.
    /// </summary>
    public static long Lcm(IEnumerable<long> values)
    {
        if (values == null) throw new ArgumentNullException("values");

        return Gcd(values.ToArray());
    }
#endregion

#region ushort
    /// <summary>
    /// Returns least common multiplier of <paramref name="a"/> and <paramref name="b"/>.
    /// </summary>
    public static ushort Lcm(ushort a, ushort b)
    {
		if(a == 0 || b == 0) throw new InvalidOperationException("Lcm isn't defined for a == 0 or b == 0.");
        checked
        {
            return (ushort)(a / Gcd(a, b) * b);
        }
    }

    /// <summary>
    /// Returns least common multiplier of <paramref name="values"/>.
    /// </summary>
    public static ushort Lcm(params ushort[] values)
    {
        if (values == null) throw new ArgumentNullException("values");
        if (values.Length == 0) throw new InvalidOperationException("Cannot calculate Lcm for 0 elements.");
		
		if(values.Length == 1) {
			if(values.Single() == 0) throw new InvalidOperationException("Lcm isn't defined for single zero.");
			else return values.Single();
		}

        return values.Aggregate(Lcm);
    }

    /// <summary>
    /// Returns greatest common divisor of <paramref name="values"/>.
    /// </summary>
    public static ushort Lcm(IEnumerable<ushort> values)
    {
        if (values == null) throw new ArgumentNullException("values");

        return Gcd(values.ToArray());
    }
#endregion

#region uint
    /// <summary>
    /// Returns least common multiplier of <paramref name="a"/> and <paramref name="b"/>.
    /// </summary>
    public static uint Lcm(uint a, uint b)
    {
		if(a == 0 || b == 0) throw new InvalidOperationException("Lcm isn't defined for a == 0 or b == 0.");
        checked
        {
            return (uint)(a / Gcd(a, b) * b);
        }
    }

    /// <summary>
    /// Returns least common multiplier of <paramref name="values"/>.
    /// </summary>
    public static uint Lcm(params uint[] values)
    {
        if (values == null) throw new ArgumentNullException("values");
        if (values.Length == 0) throw new InvalidOperationException("Cannot calculate Lcm for 0 elements.");
		
		if(values.Length == 1) {
			if(values.Single() == 0) throw new InvalidOperationException("Lcm isn't defined for single zero.");
			else return values.Single();
		}

        return values.Aggregate(Lcm);
    }

    /// <summary>
    /// Returns greatest common divisor of <paramref name="values"/>.
    /// </summary>
    public static uint Lcm(IEnumerable<uint> values)
    {
        if (values == null) throw new ArgumentNullException("values");

        return Gcd(values.ToArray());
    }
#endregion

#region ulong
    /// <summary>
    /// Returns least common multiplier of <paramref name="a"/> and <paramref name="b"/>.
    /// </summary>
    public static ulong Lcm(ulong a, ulong b)
    {
		if(a == 0 || b == 0) throw new InvalidOperationException("Lcm isn't defined for a == 0 or b == 0.");
        checked
        {
            return (ulong)(a / Gcd(a, b) * b);
        }
    }

    /// <summary>
    /// Returns least common multiplier of <paramref name="values"/>.
    /// </summary>
    public static ulong Lcm(params ulong[] values)
    {
        if (values == null) throw new ArgumentNullException("values");
        if (values.Length == 0) throw new InvalidOperationException("Cannot calculate Lcm for 0 elements.");
		
		if(values.Length == 1) {
			if(values.Single() == 0) throw new InvalidOperationException("Lcm isn't defined for single zero.");
			else return values.Single();
		}

        return values.Aggregate(Lcm);
    }

    /// <summary>
    /// Returns greatest common divisor of <paramref name="values"/>.
    /// </summary>
    public static ulong Lcm(IEnumerable<ulong> values)
    {
        if (values == null) throw new ArgumentNullException("values");

        return Gcd(values.ToArray());
    }
#endregion
}