using System.Collections.Generic;

/// <summary>
/// IEnumerable-related methods.
/// </summary>
public class EnumerableEx
{
    /// <summary>
    /// Makes IEnumerable of single element.
    /// </summary>
    public static IEnumerable<TSource> MakeEnumerable<TSource>(TSource item)
    {
        yield return item;
    }

    /// <summary>
    /// Makes IEnumerable of specified elements.
    /// </summary>
    public static IEnumerable<TSource> MakeEnumerable<TSource>(params TSource[] items)
    {
        return items;
    }
}
