using System;
using System.Linq;

/// <summary>
/// Extension methods that cannot be easily divided into different categories.
/// </summary>
public static class CommonUtils
{
    /// <summary>
    /// Checks whether this object is one of the specified <paramref name="values"/>.
    /// </summary>
    public static bool IsOneOf<T>(this T obj, params T[] values)
    {
        if (values == null) throw new ArgumentNullException("values");
        return values.Contains(obj);
    }

    /// <summary>
    /// If the <paramref name="function"/> doesn't throw anything - returns its result. <para/>
    /// If the <paramref name="function"/> throws only NullReferenceException - returns <paramref name="defaultValue"/>. <para/>
    /// If the <paramref name="function"/> throws any other exception - nothing is done with the exception.
    /// </summary>
    public static T NullSafe<T>(Func<T> function, T defaultValue = default(T))
    {
        if (function == null) throw new ArgumentNullException("function");

        try
        {
            return function();
        }
        catch (NullReferenceException)
        {
            return defaultValue;
        }
    }

    /// <summary>
    /// If the <paramref name="function"/> doesn't throw anything - returns its result. <para/>
    /// If the <paramref name="function"/> throws any exception - returns <paramref name="defaultValue"/>. <para/>
    /// </summary>
    public static T Safe<T>(Func<T> function, T defaultValue = default(T))
    {
        if (function == null) throw new ArgumentNullException("function");

        try
        {
            return function();
        }
        catch
        {
            return defaultValue;
        }
    }
}