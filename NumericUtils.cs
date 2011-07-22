using System;
using System.Linq;

/// <summary>
/// Common numeric utility methods.
/// </summary>
public static class MathEx
{
    #region Lerp (linear interpolation)
    /// <summary>
    /// Linear interpolation: left + (right - left) * frac.
    /// </summary>
    public static double Lerp(double left, double right, double frac)
    {
        return left + (right - left) * frac;
    }

    /// <summary>
    /// Linear interpolation: left + (right - left) * frac.
    /// </summary>
    public static float Lerp(float left, float right, float frac)
    {
        return left + (right - left) * frac;
    }
    #endregion

    #region Min
    public static int Min(params int[] values)
    {
        return values.Min();
    }

    public static long Min(params long[] values)
    {
        return values.Min();
    }

    public static float Min(params float[] values)
    {
        return values.Min();
    }

    public static double Min(params double[] values)
    {
        return values.Min();
    }
    #endregion

    #region Max
    public static int Max(params int[] values)
    {
        return values.Max();
    }

    public static long Max(params long[] values)
    {
        return values.Max();
    }

    public static float Max(params float[] values)
    {
        return values.Max();
    }

    public static double Max(params double[] values)
    {
        return values.Max();
    }
    #endregion

    #region Gcd
    /// <summary>
    /// Returns greatest common divisor of a and b.
    /// </summary>
    public static int Gcd(int a, int b)
    {
        if (a == 0 && b == 0) throw new InvalidOperationException("GCD isn't defined for two zeroes.");
        if (a == 0 || b == 0) return Math.Abs(a + b); // gcd of 0 and another number is the absolute value of this number
        if (a < 0 || b < 0) return Gcd(Math.Abs(a), Math.Abs(b)); // gcd(a, b) == gcd(|a|,|b|)

        while (b != 0) b = a % (a = b);
        return a;
    }

    /// <summary>
    /// Returns greatest common divisor of a and b.
    /// </summary>
    public static long Gcd(long a, long b)
    {
        if (a == 0 && b == 0) throw new InvalidOperationException("GCD isn't defined for two zeroes.");
        if (a == 0 || b == 0) return Math.Abs(a + b); // gcd of 0 and another number is the absolute value of this number
        if (a < 0 || b < 0) return Gcd(Math.Abs(a), Math.Abs(b)); // gcd(a, b) == gcd(|a|,|b|)

        while (b != 0) b = a % (a = b);
        return a;
    }

    /// <summary>
    /// Returns greatest common divisor of all values.
    /// </summary>
    public static int Gcd(params int[] values)
    {
        return values.Aggregate(Gcd);
    }

    /// <summary>
    /// Returns greatest common divisor of all values.
    /// </summary>
    public static long Gcd(params long[] values)
    {
        return values.Aggregate(Gcd);
    }
    #endregion

    #region Lcm
    /// <summary>
    /// Returns least common multiplier of a and b.
    /// </summary>
    public static int Lcm(int a, int b)
    {
        return Math.Abs(a / Gcd(a, b) * b);
    }

    /// <summary>
    /// Returns least common multiplier of a and b.
    /// </summary>
    public static long Lcm(long a, long b)
    {
        return Math.Abs(a / Gcd(a, b) * b);
    }

    /// <summary>
    /// Returns least common multiplier of all values.
    /// </summary>
    public static int Lcm(params int[] values)
    {
        return values.Aggregate(Lcm);
    }

    /// <summary>
    /// Returns least common multiplier of all values.
    /// </summary>
    public static long Lcm(params long[] values)
    {
        return values.Aggregate(Lcm);
    }
    #endregion

    #region IsPrime
    /// <summary>
    /// Tests whether a long number is prime.
    /// It can take some minutes for numbers near long.MaxValue.
    /// </summary>
    public static bool IsPrime(long number)
    {
        if (number <= 1) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;

        // uint is used because sqrt(long.MaxValue) doesn't fit into simple int
        uint max = (uint)Math.Sqrt(number) + 1;
        for (uint i = 3; i < max; i += 2)
        {
            if (number % i == 0) return false;
        }

        return true;
    }

    /// <summary>
    /// Tests whether an int number is prime.
    /// It takes about 1 ms on my laptop for numbers near int.MaxValue.
    /// </summary>
    public static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;

        long max = (int)Math.Sqrt(number) + 1;
        for (int i = 3; i < max; i += 2)
        {
            if (number % i == 0) return false;
        }

        return true;
    }
    #endregion
}