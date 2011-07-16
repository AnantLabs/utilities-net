using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// Common enumerable and collection utility methods.
/// </summary>
public static class CollectionUtils
{
    /// <summary>
    /// Tests whether the enumerable is empty. Equal to !enumerable.Any(), but returns true if null.
    /// </summary>
    public static bool Empty<TSource>(this IEnumerable<TSource> enumerable)
    {
        return enumerable.IsNull() || !enumerable.Any();
    }

    /// <summary>
    /// Runs the action for each element in the enumerable.
    /// </summary>
    public static void ForEach<TSource>(this IEnumerable<TSource> enumerable, Action<TSource> action)
    {
        foreach (var elem in enumerable)
        {
            action(elem);
        }
    }

    /// <summary>
    /// Adds the IEnumerable source elements to this collection.
    /// </summary>
    public static void AddRange<TSource>(this ICollection<TSource> collection, IEnumerable<TSource> source)
    {
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
        foreach (var item in items)
        {
            collection.Add(item);
        }
    }

    /// <summary>
    /// Bypasses elements in a sequence until a specified condition is true and then returns the remaining elements. 
    /// </summary>
    public static IEnumerable<TSource> SkipUntil<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
    {
        return source.SkipWhile(t => !predicate(t));
    }

    /// <summary>
    /// Bypasses elements in a sequence until a specified condition is true and then returns the remaining elements. 
    /// The element's index is used in the logic of the predicate function.
    /// </summary>
    public static IEnumerable<TSource> SkipUntil<TSource>(this IEnumerable<TSource> source, Func<TSource, int, bool> predicate)
    {
        return source.SkipWhile((t, i) => !predicate(t, i));
    }

    public static IEnumerable<TSource> SkipLast<TSource>(this IEnumerable<TSource> source, int count = 1)
    {
        int sourceCount = source.Count();

        using (var enumerator = source.GetEnumerator())
        {
            for (int i = 0; i < sourceCount - count; i++)
            {
                yield return enumerator.Current;
                enumerator.MoveNext();
            }
        }
    }

    /// <summary>
    /// Returns elements from a sequence until a specified condition is true.
    /// </summary>
    public static IEnumerable<TSource> TakeUntil<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
    {
        return source.TakeWhile(t => !predicate(t));
    }

    /// <summary>
    /// Returns elements from a sequence until a specified condition is true.
    /// The element's index is used in the logic of the predicate function.
    /// </summary>
    public static IEnumerable<TSource> TakeUntil<TSource>(this IEnumerable<TSource> source, Func<TSource, int, bool> predicate)
    {
        return source.TakeWhile((t, i) => !predicate(t, i));
    }

    /// <summary>
    /// Filters a sequence of values based on a predicate.
    /// </summary>
    public static IEnumerable<TSource> WhereNot<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
    {
        return source.Where(t => !predicate(t));
    }

    /// <summary>
    /// Filters a sequence of values based on a predicate.
    /// The element's index is used in the logic of the predicate function.
    /// </summary>
    public static IEnumerable<TSource> WhereNot<TSource>(this IEnumerable<TSource> source, Func<TSource, int, bool> predicate)
    {
        return source.Where((t, i) => !predicate(t, i));
    }

    /// <summary>
    /// Tests whether the specified index is valid for the list.
    /// </summary>
    public static bool ValidIndex<TSource>(this IList<TSource> list, int index)
    {
        return index >= 0 && index < list.Count;
    }

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

    /// <summary>
    /// Appends item to the end of the IEnumerable.
    /// </summary>
    public static IEnumerable<TSource> Concat<TSource>(this IEnumerable<TSource> source, TSource item)
    {
        foreach (var t in source)
        {
            yield return t;
        }

        yield return item;
    }

    /// <summary>
    /// Appends items to the end of the IEnumerable.
    /// </summary>
    public static IEnumerable<TSource> Concat<TSource>(this IEnumerable<TSource> source, params TSource[] items)
    {
        return source.Concat(items.AsEnumerable());
    }

    /// <summary>
    /// Flattens the structure of 2-dimensional enumerable.
    /// </summary>
    public static IEnumerable<TSource> Flatten<TSource>(this IEnumerable<IEnumerable<TSource>> items2D)
    {
        return items2D.SelectMany(enumerable => enumerable);
    }

    /// <summary>
    /// Returns minimal item from this enumerable. Comparsion is based on specified selector.
    /// </summary>
    public static TSource MinItem<TSource, TKey>(this IEnumerable<TSource> enumerable, Func<TSource, TKey> selector)
    {
        if (enumerable == null) throw new ArgumentNullException("enumerable");
        if (enumerable.Empty()) throw new InvalidOperationException("Enumerable is empty");

        TSource min = enumerable.First();
        TKey minKey = selector(min);

        foreach (var item in enumerable)
        {
            TKey key = selector(item);

            if (key.IsLess(minKey))
            {
                minKey = key;
                min = item;
            }
        }

        return min;
    }

    /// <summary>
    /// Returns maximal item from this enumerable. Comparsion is based on specified selector.
    /// </summary>
    public static TSource MaxItem<TSource, TKey>(this IEnumerable<TSource> enumerable, Func<TSource, TKey> selector)
    {
        if (enumerable == null) throw new ArgumentNullException("enumerable");
        if (enumerable.Empty()) throw new InvalidOperationException("Enumerable is empty");

        TSource max = enumerable.First();
        TKey maxKey = selector(max);

        foreach (var item in enumerable)
        {
            TKey key = selector(item);

            if (key.IsGreater(maxKey))
            {
                maxKey = key;
                max = item;
            }
        }

        return max;
    }

    /// <summary>
    /// Gets one random element from this enumerable. Method doesn't copy elements to array or smth like this and requires only one pass through the enumerable.
    /// </summary>
    public static TSource Random<TSource>(this IEnumerable<TSource> enumerable)
    {
        if (enumerable == null) throw new ArgumentNullException("enumerable");

        Random rng = new Random(Guid.NewGuid().GetHashCode());
        int count = 0;
        TSource selected = default(TSource);

        foreach (var data in enumerable)
        {
            if (rng.Next(++count) == 0) selected = data;
        }

        return selected;
    }

    /// <summary>
    /// Concats all enumerable elements' string representations (possibly separating them with separator string and adding prefix and suffix to each one) and return the resulting string.
    /// </summary>
    public static string Aggregate<TSource>(this IEnumerable<TSource> enumerable, string separator = "", string prefix = "", string suffix = "")
    {
        if (enumerable == null) throw new ArgumentNullException("enumerable");
        if (separator == null) throw new ArgumentNullException("separator");

        if (enumerable.Empty()) return string.Empty;

        string result = enumerable.
            Aggregate(
                new StringBuilder(),
                (sb, el) => sb.Append(prefix).Append(el).Append(suffix).Append(separator),
                sb => sb.ToString());

        return result.Substring(0, result.Length - separator.Length);
    }

    /// <summary>
    /// Concats all enumerable elements' string representations (possibly separating them with separator string and adding prefix and suffix to each one) and return the resulting string.
    /// </summary>
    public static string Aggregate<TSource, TDest>(this IEnumerable<TSource> enumerable, Func<TSource, TDest> func, string separator = "", string prefix = "", string suffix = "")
    {
        if (enumerable == null) throw new ArgumentNullException("enumerable");
        if (separator == null) throw new ArgumentNullException("separator");

        if (enumerable.Empty()) return string.Empty;

        string result = enumerable.
            Aggregate(
                new StringBuilder(),
                (sb, el) => sb.Append(prefix).Append(func(el)).Append(suffix).Append(separator),
                sb => sb.ToString());

        return result.Substring(0, result.Length - separator.Length);
    }

    /// <summary>
    /// Inverts the dictionary (swaps keys and values). Identical values are not keeped!
    /// </summary>
    public static Dictionary<TValue, TKey> Invert<TKey, TValue>(this IDictionary<TKey, TValue> dictionary)
    {
        return dictionary.ToDictionary(i => i.Value, i => i.Key);
    }
}