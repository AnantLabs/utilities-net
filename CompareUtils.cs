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
        return comparer.Compare(x, y) >= 0;
    }
    #endregion

    #region InRange
    /// <summary>
    /// Tests whether value &gt;= min and value &lt;= max. The default comparer is used.
    /// </summary>
    public static bool InRange<T>(this T value, T min, T max)
    {
        return InRange(value, min, max, Comparer<T>.Default);
    }

    /// <summary>
    /// Tests whether value &gt;= min and value &lt;= max. The specified comparer is used.
    /// </summary>
    public static bool InRange<T>(this T value, T min, T max, IComparer<T> comparer)
    {
        if (min.IsGreater(max, comparer)) throw new ArgumentException("Min is greater than max.");

        return value.IsGreaterOrEqual(min, comparer) && value.IsLessOrEqual(max, comparer);
    }
    #endregion

    #region Clamp
    /// <summary>
    /// If value &lt; min returns min.<para/>
    /// If value is between min and max returns value.<para/>
    /// If value &gt; max returns max.
    /// </summary>
    public static T Clamp<T>(T value, T min, T max)
    {
        return Clamp(value, min, max, Comparer<T>.Default);
    }

    /// <summary>
    /// If value &lt; min returns min.<para/>
    /// If value is between min and max returns value.<para/>
    /// If value &gt; max returns max.
    /// </summary>
    public static T Clamp<T>(T value, T min, T max, IComparer<T> comparer)
    {
        if (min.IsGreater(max, comparer)) throw new ArgumentException("Min must be less than or equal to max.");

        if (value.IsGreater(max, comparer)) return max;
        if (value.IsLess(min, comparer)) return min;
        return value;
    }
    #endregion
}