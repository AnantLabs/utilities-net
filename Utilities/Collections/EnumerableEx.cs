using System.Collections.Generic;

/// <summary>
/// IEnumerable-related methods.
/// </summary>
public static class EnumerableEx
{
    /// <summary>
    /// Makes IEnumerable of the single <paramref name="item"/>.
    /// </summary>
    public static IEnumerable<TSource> MakeEnumerable<TSource>(TSource item)
    {
        yield return item;
    }

    /// <summary>
    /// Makes IEnumerable of specified <paramref name="items"/>.
    /// </summary>
    public static IEnumerable<TSource> MakeEnumerable<TSource>(params TSource[] items)
    {
        return items;
    }
}
