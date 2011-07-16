using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class EnumerableUtils
{
    /// <summary>
    /// Tests whether the source is empty or null.
    /// </summary>
    public static bool Empty<TSource>(this IEnumerable<TSource> source)
    {
        return source.IsNull() || !source.Any();
    }

    /// <summary>
    /// Performs the specified action on each element of the source.
    /// </summary>
    public static void ForEach<TSource>(this IEnumerable<TSource> source, Action<TSource> action)
    {
        if (source == null) throw new ArgumentNullException("source");
        if (action == null) throw new ArgumentNullException("action");

        foreach (var elem in source)
        {
            action(elem);
        }
    }

    /// <summary>
    /// Bypasses elements in a sequence until a specified condition is true and then returns the remaining elements. 
    /// </summary>
    public static IEnumerable<TSource> SkipUntil<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
    {
        if (source == null) throw new ArgumentNullException("source");
        if (predicate == null) throw new ArgumentNullException("predicate");

        return source.SkipWhile(t => !predicate(t));
    }

    /// <summary>
    /// Bypasses elements in a sequence until a specified condition is true and then returns the remaining elements. 
    /// The element's index is used in the logic of the predicate function.
    /// </summary>
    public static IEnumerable<TSource> SkipUntil<TSource>(this IEnumerable<TSource> source, Func<TSource, int, bool> predicate)
    {
        if (source == null) throw new ArgumentNullException("source");
        if (predicate == null) throw new ArgumentNullException("predicate");

        return source.SkipWhile((t, i) => !predicate(t, i));
    }

    public static IEnumerable<TSource> SkipLast<TSource>(this IEnumerable<TSource> source, int count = 1)
    {
        if (source == null) throw new ArgumentNullException("source");

        int sourceCount = source.Count();
        count = CompareUtils.Clamp(count, 0, sourceCount); // 0 <= count <= sourceCount

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
        if (source == null) throw new ArgumentNullException("source");
        if (predicate == null) throw new ArgumentNullException("predicate");

        return source.TakeWhile(t => !predicate(t));
    }

    /// <summary>
    /// Returns elements from a sequence until a specified condition is true.
    /// The element's index is used in the logic of the predicate function.
    /// </summary>
    public static IEnumerable<TSource> TakeUntil<TSource>(this IEnumerable<TSource> source, Func<TSource, int, bool> predicate)
    {
        if (source == null) throw new ArgumentNullException("source");
        if (predicate == null) throw new ArgumentNullException("predicate");

        return source.TakeWhile((t, i) => !predicate(t, i));
    }

    /// <summary>
    /// Filters a sequence of values based on a predicate.
    /// </summary>
    public static IEnumerable<TSource> WhereNot<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
    {
        if (source == null) throw new ArgumentNullException("source");
        if (predicate == null) throw new ArgumentNullException("predicate");

        return source.Where(t => !predicate(t));
    }

    /// <summary>
    /// Filters a sequence of values based on a predicate.
    /// The element's index is used in the logic of the predicate function.
    /// </summary>
    public static IEnumerable<TSource> WhereNot<TSource>(this IEnumerable<TSource> source, Func<TSource, int, bool> predicate)
    {
        if (source == null) throw new ArgumentNullException("source");
        if (predicate == null) throw new ArgumentNullException("predicate");

        return source.Where((t, i) => !predicate(t, i));
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
        if (source == null) throw new ArgumentNullException("source");

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
        if (source == null) throw new ArgumentNullException("source");

        return source.Concat(items.AsEnumerable());
    }

    /// <summary>
    /// Flattens the structure of 2-dimensional enumerable.
    /// </summary>
    public static IEnumerable<TSource> Flatten<TSource>(this IEnumerable<IEnumerable<TSource>> items2D)
    {
        if (items2D == null) throw new ArgumentNullException("items2D");

        return items2D.SelectMany(enumerable => enumerable);
    }

    /// <summary>
    /// Returns minimal item from source. Comparsion is based on specified selector.
    /// </summary>
    public static TSource MinItem<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> selector)
    {
        if (source == null) throw new ArgumentNullException("source");
        if (selector == null) throw new ArgumentNullException("selector");
        if (source.Empty()) throw new InvalidOperationException("Source is empty");

        TSource min = source.First();
        TKey minKey = selector(min);

        foreach (var item in source)
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
    /// Returns maximal item from source. Comparsion is based on specified selector.
    /// </summary>
    public static TSource MaxItem<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> selector)
    {
        if (source == null) throw new ArgumentNullException("source");
        if (selector == null) throw new ArgumentNullException("selector");
        if (source.Empty()) throw new InvalidOperationException("Source is empty");

        TSource max = source.First();
        TKey maxKey = selector(max);

        foreach (var item in source)
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
    /// Gets one random element from source. Method doesn't copy elements to array or smth like this and requires only one pass through the enumerable.
    /// </summary>
    public static TSource Random<TSource>(this IEnumerable<TSource> source)
    {
        if (source == null) throw new ArgumentNullException("source");
        if (source.Empty()) throw new InvalidOperationException("Source is empty");

        Random rng = new Random();
        int count = 0;
        TSource selected = default(TSource);

        foreach (var data in source)
        {
            if (rng.Next(++count) == 0) selected = data;
        }

        return selected;
    }

    /// <summary>
    /// Concats all source elements' string representations (possibly separating them with separator string and adding prefix and suffix to each one) and return the resulting string.
    /// </summary>
    public static string Aggregate<TSource>(this IEnumerable<TSource> source, string separator = "", string formatString = "{0}")
    {
        if (source == null) throw new ArgumentNullException("source");
        if (separator == null) throw new ArgumentNullException("separator");
        if (formatString == null) throw new ArgumentNullException("formatString");

        if (source.Empty()) return String.Empty;

        string result = source.
            Aggregate(
                new StringBuilder(),
                (sb, el) => sb.AppendFormat(formatString, el).Append(separator),
                sb => sb.ToString());

        return result.Substring(0, result.Length - separator.Length);
    }

    /// <summary>
    /// Concats all source elements' string representations (possibly separating them with separator string and adding prefix and suffix to each one) and return the resulting string.
    /// </summary>
    public static string Aggregate<TSource, TDest>(this IEnumerable<TSource> source, Func<TSource, TDest> func, string separator = "", string formatString = "{0}")
    {
        if (source == null) throw new ArgumentNullException("source");
        if (separator == null) throw new ArgumentNullException("separator");
        if (formatString == null) throw new ArgumentNullException("formatString");
        if (func == null) throw new ArgumentNullException("func");

        return Aggregate(source.Select(func), separator, formatString);
    }
}