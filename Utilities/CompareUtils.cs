using System;
using System.Collections.Generic;

/// <summary>
/// Common comparable utility methods.
/// </summary>
public static class CompareUtils
{
    #region IsLess
    public static bool IsLess<T>(this T x, T y)
    {
        return IsLess(x, y, Comparer<T>.Default);
    }

    public static bool IsLess<T>(this T x, T y, IComparer<T> comparer)
    {
        if (comparer == null) comparer = Comparer<T>.Default;
        return comparer.Compare(x, y) < 0;
    }
    #endregion

    #region IsGreater
    public static bool IsGreater<T>(this T x, T y)
    {
        return IsGreater(x, y, Comparer<T>.Default);
    }

    public static bool IsGreater<T>(this T x, T y, IComparer<T> comparer)
    {
        if (comparer == null) comparer = Comparer<T>.Default;
        return comparer.Compare(x, y) > 0;
    }
    #endregion

    #region IsLessOrEqual
    public static bool IsLessOrEqual<T>(this T x, T y)
    {
        return IsLessOrEqual(x, y, Comparer<T>.Default);
    }

    public static bool IsLessOrEqual<T>(this T x, T y, IComparer<T> comparer)
    {
        if (comparer == null) comparer = Comparer<T>.Default;
        return comparer.Compare(x, y) <= 0;
    }
    #endregion

    #region IsGreaterOrEqual
    public static bool IsGreaterOrEqual<T>(this T x, T y)
    {
        return IsGreaterOrEqual(x, y, Comparer<T>.Default);
    }

    public static bool IsGreaterOrEqual<T>(this T x, T y, IComparer<T> comparer)
    {
        if (comparer == null) comparer = Comparer<T>.Default;
        return comparer.Compare(x, y) >= 0;
    }
    #endregion

    #region InRange
    /// <summary>
    /// Tests whether <paramref name="value"/> &gt;= <paramref name="min"/> and <paramref name="value"/> &lt; <paramref name="max"/> (using default comparer).
    /// </summary>
    public static bool InRange<T>(this T value, T min, T max)
    {
        return InRange(value, min, max, Comparer<T>.Default);
    }

    /// <summary>
    /// Tests whether <paramref name="value"/> &gt;= <paramref name="min"/> and <paramref name="value"/> &lt; <paramref name="max"/> (using <paramref name="comparer"/>).
    /// </summary>
    public static bool InRange<T>(this T value, T min, T max, IComparer<T> comparer)
    {
        if (comparer == null) comparer = Comparer<T>.Default;
        if (min.IsGreater(max, comparer)) throw new ArgumentException("Min is greater than max.");

        return value.IsGreaterOrEqual(min, comparer) && value.IsLess(max, comparer);
    }
    #endregion

    #region Clamp

    /// <summary>
    /// If <paramref name="value"/> &lt;= <paramref name="min"/> returns <paramref name="min"/>.<para/>
    /// If <paramref name="value"/> &gt;= <paramref name="min"/> and <paramref name="value"/> &lt;= <paramref name="max"/> returns <paramref name="value"/>.<para/>
    /// If <paramref name="value"/> &gt; <paramref name="max"/> returns <paramref name="max"/>.<para/>
    /// The default comparer is used.
    /// </summary>
    public static T Clamp<T>(T value, T min, T max)
    {
        return Clamp(value, min, max, Comparer<T>.Default);
    }

    /// <summary>
    /// If <paramref name="value"/> &lt;= <paramref name="min"/> returns <paramref name="min"/>.<para/>
    /// If <paramref name="value"/> &gt;= <paramref name="min"/> and <paramref name="value"/> &lt;= <paramref name="max"/> returns <paramref name="value"/>.<para/>
    /// If <paramref name="value"/> &gt; <paramref name="max"/> returns <paramref name="max"/>.<para/>
    /// The specified <paramref name="comparer"/> is used.
    /// </summary>
    public static T Clamp<T>(T value, T min, T max, IComparer<T> comparer)
    {
        if (comparer == null) comparer = Comparer<T>.Default;
        if (min.IsGreater(max, comparer)) throw new ArgumentException("Min must be less than or equal to max.");

        if (value.IsGreater(max, comparer)) return max;
        if (value.IsLess(min, comparer)) return min;
        return value;
    }
    #endregion
}