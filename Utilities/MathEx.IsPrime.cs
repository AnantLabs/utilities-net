using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// Part of MathEx class: MathEx.IsPrime.
/// </summary>
public static partial class MathEx
{
#region short
    /// <summary>
    /// Tests whether the <paramref name="number"/> is prime.
	/// It takes about 1 ms for numbers near int.MaxValue and some minutes for numbers near long.MaxValue on my laptop.
    /// </summary>
    public static bool IsPrime(short number)
    {
        if (number <= 1) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;

        short max = (short)(Math.Sqrt(number) + 1);
        for (short i = 3; i < max; i += 2)
        {
            if (number % i == 0) return false;
        }

        return true;
    }
#endregion

#region ushort
    /// <summary>
    /// Tests whether the <paramref name="number"/> is prime.
	/// It takes about 1 ms for numbers near int.MaxValue and some minutes for numbers near long.MaxValue on my laptop.
    /// </summary>
    public static bool IsPrime(ushort number)
    {
        if (number <= 1) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;

        ushort max = (ushort)(Math.Sqrt(number) + 1);
        for (ushort i = 3; i < max; i += 2)
        {
            if (number % i == 0) return false;
        }

        return true;
    }
#endregion

#region int
    /// <summary>
    /// Tests whether the <paramref name="number"/> is prime.
	/// It takes about 1 ms for numbers near int.MaxValue and some minutes for numbers near long.MaxValue on my laptop.
    /// </summary>
    public static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;

        int max = (int)(Math.Sqrt(number) + 1);
        for (int i = 3; i < max; i += 2)
        {
            if (number % i == 0) return false;
        }

        return true;
    }
#endregion

#region uint
    /// <summary>
    /// Tests whether the <paramref name="number"/> is prime.
	/// It takes about 1 ms for numbers near int.MaxValue and some minutes for numbers near long.MaxValue on my laptop.
    /// </summary>
    public static bool IsPrime(uint number)
    {
        if (number <= 1) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;

        uint max = (uint)(Math.Sqrt(number) + 1);
        for (uint i = 3; i < max; i += 2)
        {
            if (number % i == 0) return false;
        }

        return true;
    }
#endregion

#region long
    /// <summary>
    /// Tests whether the <paramref name="number"/> is prime.
	/// It takes about 1 ms for numbers near int.MaxValue and some minutes for numbers near long.MaxValue on my laptop.
    /// </summary>
    public static bool IsPrime(long number)
    {
        if (number <= 1) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;

        long max = (long)(Math.Sqrt(number) + 1);
        for (long i = 3; i < max; i += 2)
        {
            if (number % i == 0) return false;
        }

        return true;
    }
#endregion

#region ulong
    /// <summary>
    /// Tests whether the <paramref name="number"/> is prime.
	/// It takes about 1 ms for numbers near int.MaxValue and some minutes for numbers near long.MaxValue on my laptop.
    /// </summary>
    public static bool IsPrime(ulong number)
    {
        if (number <= 1) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;

        ulong max = (ulong)(Math.Sqrt(number) + 1);
        for (ulong i = 3; i < max; i += 2)
        {
            if (number % i == 0) return false;
        }

        return true;
    }
#endregion
}