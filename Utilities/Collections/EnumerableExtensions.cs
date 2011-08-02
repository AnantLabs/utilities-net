using System.Collections;

/// <summary>
/// Extension methods for non-generic IEnumerable.
/// </summary>
public static class EnumerableExtensions
{
    /// <summary>
    /// Tests whether the <paramref name="source"/> is empty or null.
    /// </summary>
    public static bool Empty(this IEnumerable source)
    {
        return source == null || !source.GetEnumerator().MoveNext();
    }
}