using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Extension methods for generic ICollection and classes derived from it.
/// </summary>
public static class GenericCollectionExtensions
{
    /// <summary>
    /// Adds the IEnumerable source elements to this collection.
    /// </summary>
    public static void AddRange<TSource>(this ICollection<TSource> collection, IEnumerable<TSource> source)
    {
        if (collection == null) throw new ArgumentNullException("collection");
        if (source == null) throw new ArgumentNullException("source");

        foreach (var elem in source)
        {
            collection.Add(elem);
        }
    }

    /// <summary>
    /// Adds specified elements to this collection.
    /// </summary>
    public static void AddRange<TSource>(this ICollection<TSource> collection, params TSource[] items)
    {
        if (collection == null) throw new ArgumentNullException("collection");
        if (items == null) throw new ArgumentNullException("items");

        foreach (var item in items)
        {
            collection.Add(item);
        }
    }

    /// <summary>
    /// Tests whether the specified index is valid for the list.
    /// </summary>
    public static bool IsValidIndex<TSource>(this IList<TSource> list, int index)
    {
        if (list == null) return false;
        return index >= 0 && index < list.Count;
    }

    /// <summary>
    /// Inverts the dictionary (swaps keys and values).
    /// If there are duplicate or null values in source, exception will be thrown.
    /// </summary>
    public static Dictionary<TValue, TKey> Invert<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> source)
    {
        if (source == null) throw new ArgumentNullException("source");

        return source.ToDictionary(i => i.Value, i => i.Key);
    }
}