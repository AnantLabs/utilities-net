using System;
using System.Linq;
using System.Text.RegularExpressions;

/// <summary>
/// Common string utility methods.
/// </summary>
public static class StringUtils
{
    private static readonly Regex CurlyBracesRegex = new Regex(@"(\{+)([^\}]+)(\}+)", RegexOptions.Compiled);
    private static readonly Regex ExtraSpacesRegex = new Regex(@"[ ]{2,}", RegexOptions.Compiled);

    /// <summary>
    /// Checkes whether this string is empty.
    /// </summary>
    public static bool IsEmpty(this string s)
    {
        return s == string.Empty;
    }

    /// <summary>
    /// Checkes whether this string is null or an empty string.
    /// </summary>
    public static bool IsNullOrEmpty(this string s)
    {
        return string.IsNullOrEmpty(s);
    }

    /// <summary>
    /// Checkes whether this string is null, empty or consists only of white-space characters.
    /// </summary>
    public static bool IsNullOrWhiteSpace(this string s)
    {
        return string.IsNullOrWhiteSpace(s);
    }

    /// <summary>
    /// Formats <paramref name="args"/> according to <paramref name="format"/>. It's the same as string.Format().
    /// </summary>
    public static string FormatWith(this string format, params object[] args)
    {
        if (format == null) throw new ArgumentNullException("format");
        if (args == null) throw new ArgumentNullException("args");

        return string.Format(format, args);
    }

    /// <summary>
    /// Formats <paramref name="arg"/> according to <paramref name="format"/>. It's like string.Format, but uses named parameters.
    /// </summary>
    public static string FormatNamed<T>(this string format, T arg)
    {
        if (format == null) throw new ArgumentNullException("format");
        if (arg == null) throw new ArgumentNullException("arg");

        Type type = arg.GetType();

        // replace each regex match with string formed specially...
        return CurlyBracesRegex.Replace(
            format,
            match =>
            {
                // numbers of open and close brackets
                int openCount = match.Groups[1].Value.Length;
                int closeCount = match.Groups[3].Value.Length;

                // each 2 brackets are replaced with one in the output, so only remainder matters
                if ((openCount % 2) != (closeCount % 2))
                {
                    throw new ArgumentException("Unbalanced braces in format string.", "format");
                }

                // create prefix and suffix of the match replacement
                string openBraces = new string('{', openCount / 2);
                string closeBraces = new string('}', closeCount / 2);

                // if all braces are escaped, the output string between them will be the same as input
                if (openCount % 2 == 0)
                {
                    return openBraces + match.Groups[2].Value + closeBraces;
                }

                // format item, looks like fieldName[,alignment][:formatString]
                string formatItem = match.Groups[2].Value;

                // field/property name of the object
                string fieldName = formatItem.
                    TakeWhile(c => c != ':' && c != ',').
                    Aggregate();

                // format string which will be specified in string.Format()
                string formatString = formatItem.
                    SkipWhile(c => c != ':' && c != ',').
                    Aggregate();

                // now get the value of object's field/property fieldName
                var prop = type.GetProperty(fieldName);
                if (prop == null)
                {
                    throw new ArgumentException("Object arg hasn't public field/property which is specified in the format string.", "arg");
                }

                object value = prop.GetValue(arg, null);

                return openBraces + string.Format("{0" + formatString + "}", value);
            });
    }

    /// <summary>
    /// Trims all lines of the string (using string.Trim() method). '\n' and '\r' are supposed to be end of each line.
    /// </summary>
    public static string TrimLines(this string s)
    {
        if (s == null) throw new ArgumentNullException("s");

        return s.
            Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).
            Select(l => l.Trim()).
            Aggregate("\n");
    }

    /// <summary>
    /// String.Contains() analog, but case insensitive.
    /// </summary>
    public static bool ContainsCi(this string s, string value)
    {
        if (s == null) throw new ArgumentNullException("s");
        if (value == null) throw new ArgumentNullException("value");

        return s.ToLower().Contains(value.ToLower());
    }

    /// <summary>
    /// Gets substring before the first occurrence of <paramref name="x"/>.
    /// </summary>
    public static string GetBefore(this string s, string x)
    {
        if (s == null) throw new ArgumentNullException("s");
        if (x == null) throw new ArgumentNullException("x");

        var index = s.IndexOf(x);
        if (index == -1) throw new InvalidOperationException("This string doesn't contain specified x string.");

        return s.Substring(0, index);
    }

    /// <summary>
    /// Gets the string between the first occurrence of <paramref name="left"/> and the first occurrence of <paramref name="right"/> after left's one.
    /// </summary>
    public static string GetBetween(this string s, string left, string right)
    {
        if (s == null) throw new ArgumentNullException("s");
        if (left == null) throw new ArgumentNullException("left");
        if (right == null) throw new ArgumentNullException("right");

        int leftIndex = s.IndexOf(left);
        int startIndex = leftIndex + left.Length;
        if (leftIndex == -1)
            throw new InvalidOperationException("This string doesn't contain specified left string.");

        int rightIndex = s.IndexOf(right, startIndex);
        int endIndex = rightIndex;
        if (rightIndex == -1)
            throw new InvalidOperationException("This string doesn't contain specified right string after the first occurrence of specified left string.");

        return s.Substring(startIndex, endIndex - startIndex);
    }

    /// <summary>
    /// Gets substring after the first occurrence of <paramref name="x"/>.
    /// </summary>
    public static string GetAfter(this string s, string x)
    {
        if (s == null) throw new ArgumentNullException("s");
        if (x == null) throw new ArgumentNullException("x");

        var index = s.IndexOf(x);
        if (index == -1) throw new InvalidOperationException("This string doesn't contain specified x string.");

        var startIndex = index + x.Length;
        return s.Substring(startIndex);
    }

    /// <summary>
    /// Removes extra spaces from this string by replacing any number of consecutive spaces to one.
    /// </summary>
    public static string NormalizeSpaces(this string s)
    {
        if (s == null) throw new ArgumentNullException("s");
        return ExtraSpacesRegex.Replace(s, @" ");
    }

    /// <summary>
    /// Returns number of <paramref name="value"/>'s occurences in this string.
    /// <para/>TODO: I think this is wrong
    /// </summary>
    public static int Count(this string s, string value)
    {
        if (s == null) throw new ArgumentNullException("s");
        if (value == null) throw new ArgumentNullException("value");
        if (value.IsEmpty()) throw new ArgumentException("Can't count empty string occurences", "value");

        int cnt = 0;
        int ind = 0;
        while ((ind = s.IndexOf(value, ind)) != -1)
        {
            cnt++;
        }
        return cnt;
    }

    /// <summary>
    /// Returns this string with character at position <paramref name="index"/> replaced with <paramref name="ch"/>.
    /// </summary>
    public static string Replace(this string s, int index, char ch)
    {
        if (s == null) throw new ArgumentNullException("s");
        if (!index.InRange(0, s.Length)) throw new ArgumentOutOfRangeException("index");

        return s.Substring(0, index) + ch + s.Substring(index + 1);
    }
}