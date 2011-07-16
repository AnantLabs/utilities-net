using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Common utility methods.
/// </summary>
public static class CommonUtils
{
    /// <summary>
    /// Tests whether this object is null.
    /// </summary>
    public static bool IsNull(this object obj)
    {
        return obj == null;
    }

    /// <summary>
    /// Tests whether this object is not null.
    /// </summary>
    public static bool IsNotNull(this object obj)
    {
        return obj != null;
    }

    /// <summary>
    /// Checks whether this object is one of the specified values.
    /// </summary>
    public static bool IsOneOf<T>(this T obj, params T[] values)
    {
        return values.Contains(obj);
    }

    /// <summary>
    /// Clones this object the same way as Clone(), but returns result as type T instead of object.
    /// </summary>
    public static T CloneT<T>(this T t)
        where T : ICloneable
    {
        return (T)t.Clone();
    }

    /// <summary>
    /// Returns the most inner exception.
    /// </summary>
    public static Exception GetMostInnerException(this Exception exception)
    {
        while (exception.InnerException.IsNotNull())
        {
            exception = exception.InnerException;
        }

        return exception;
    }

    /// <summary>
    /// Returns all inner exceptions as IEnumerable starting from the most inner one.
    /// </summary>
    public static IEnumerable<Exception> GetAllExceptions(this Exception exception)
    {
        if (exception == null) yield break;

        foreach (var ex in exception.InnerException.GetAllExceptions())
        {
            yield return ex;
        }

        yield return exception;
    }

    /// <summary>
    /// If the specified function doesn't throw anything - returns its result. <para/>
    /// If the specified function throws only NullReferenceException - returns defaultValue. <para/>
    /// If the specified function throws any other exception - nothing is done with the exception.
    /// </summary>
    public static T TryNullReference<T>(this Func<T> function, T defaultValue)
    {
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
    /// If the specified function doesn't throw anything - returns its result. <para/>
    /// If the specified function throws only exceptions from the specified list - returns defaultValue. To catch all exceptions - specify null. <para/>
    /// If the specified function throws any other exception - the exception is rethrown.
    /// </summary>
    public static T Try<T>(this Func<T> function, T defaultValue, params Type[] exceptions)
    {
        if (exceptions != null &&
            !exceptions.All(e => e.IsAssignableFrom(typeof(Exception))))
            throw new ArgumentException("Some of specified types aren't exception types.", "exceptions");

        try
        {
            return function();
        }
        catch (Exception caughtEx)
        {
            if (exceptions == null ||
                exceptions.Any(ex => caughtEx.GetType().IsAssignableFrom(ex)))
            {
                return defaultValue;
            }

            throw;
        }
    }
}