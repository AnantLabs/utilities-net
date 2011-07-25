using System;
using System.Collections;

/// <summary>
/// Extension methods for non-generic ICollection and classes derived from it.
/// </summary>
public static class CollectionExtensions
{
    /// <summary>
    /// Adds the IEnumerable <paramref name="source"/> elements to this <paramref name="list"/>.
    /// </summary>
    public static void AddRange(this IList list, IEnumerable source)
    {
        if (list == null) throw new ArgumentNullException("list");
        if (source == null) throw new ArgumentNullException("source");

        foreach (var elem in source)
        {
            list.Add(elem);
        }
    }

    /// <summary>
    /// Adds specified <paramref name="items"/> to this <paramref name="list"/>.
    /// </summary>
    public static void AddRange(this IList list, params object[] items)
    {
        if (list == null) throw new ArgumentNullException("list");
        if (items == null) throw new ArgumentNullException("items");

        foreach (var item in items)
        {
            list.Add(item);
        }
    }

    /// <summary>
    /// Tests whether the specified <paramref name="index"/> is valid for the <paramref name="list"/>.
    /// </summary>
    public static bool IsValidIndex(this IList list, int index)
    {
        if (list == null) return false;
        return index >= 0 && index < list.Count;
    }
}