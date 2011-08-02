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
    /// Clones this object the same way as Clone(), but returns result as type T instead of object.
    /// </summary>
    public static T CloneT<T>(this T t)
        where T : ICloneable
    {
        if (t == null) throw new ArgumentNullException("t");
        return (T)t.Clone();
    }

    /// <summary>
    /// If the <paramref name="function"/> doesn't throw anything - returns its result. <para/>
    /// If the <paramref name="function"/> throws only NullReferenceException - returns <paramref name="defaultValue"/>. <para/>
    /// If the <paramref name="function"/> throws any other exception - nothing is done with the exception.
    /// </summary>
    public static T TryNullReference<T>(Func<T> function, T defaultValue = default(T))
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
    /// If the <paramref name="function"/> throws only exceptions from the specified list - returns <paramref name="defaultValue"/>. To catch all exceptions specify null. <para/>
    /// If the <paramref name="function"/> throws any other exception - the exception is rethrown.
    /// </summary>
    public static T Try<T>(this Func<T> function, T defaultValue, params Type[] exceptions)
    {
        if (function == null) throw new ArgumentNullException("function");
        // check for null once
        if (exceptions == null) exceptions = new[] { typeof(Exception) };
        if (exceptions.Contains(null))
            throw new ArgumentException("Exceptions list cannot contain null. To catch all exceptions specify null as the whole list.", "exceptions");

        if (!exceptions.All(e => e.IsAssignableFrom(typeof(Exception))))
            throw new ArgumentException("Some of specified types aren't exception types.", "exceptions");

        try
        {
            return function();
        }
        catch (Exception caughtEx)
        {
            if (exceptions.Any(ex => ex.IsAssignableFrom(caughtEx.GetType())))
            {
                return defaultValue;
            }

            throw;
        }
    }
}