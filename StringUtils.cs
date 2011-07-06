using System;
using System.Linq;
using System.Text.RegularExpressions;

/// <summary>
/// Common string utility methods.
/// </summary>
public static class StringUtils
{
    /// <summary>
    /// Precompiled regex to use by FormatEx method.
    /// </summary>
    private static readonly Regex CurlyBracesRegex = new Regex(@"(\{+)([^\}]+)(\}+)", RegexOptions.Compiled);

    /// <summary>
    /// Precompiled Regex used by NormalizeSpaces method.
    /// </summary>
    private static readonly Regex ExtraSpacesRegex = new Regex(@"[ ]{2,}", RegexOptions.Compiled);

    /// <summary>
    /// Checkes whether this string is null or an empty string.
    /// </summary>
    public static bool IsNullOrEmpty(this string s)
    {
        return string.IsNullOrEmpty(s);
    }

    /// <summary>
    /// Formats args according to format. It's the same as string.Format().
    /// </summary>
    public static string Format(this string format, params object[] args)
    {
        return string.Format(format, args);
    }

    /// <summary>
    /// Formats arg according to format. It's like string.Format, but uses named parameters.
    /// </summary>
    public static string FormatEx(this string format, object arg)
    {
        if (format == null) throw new ArgumentNullException("format");
        if (arg == null) throw new ArgumentNullException("arg");

        Type type = arg.GetType();

        // replace each regex match with string formed specially...
        return CurlyBracesRegex.Replace(
            format,
            match =>
            {
                // count of open and close brackets
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

                // if all braces are escaped, so the output string between them will be the same as input
                if (openCount % 2 == 0)
                {
                    return openBraces + match.Groups[2].Value + closeBraces;
                }

                // format item, looks like fieldName[,alignment][:formatString]
                string formatItem = match.Groups[2].Value;

                // field/property name of the object
                string fieldName = formatItem.
                    TakeWhile(c => c != ':' && c != ',').
                    Aggregate(string.Empty, (s, c) => s + c);

                // format string which will be specified in string.Format()
                string formatString = formatItem.
                    SkipWhile(c => c != ':' && c != ',').
                    Aggregate(string.Empty, (s, c) => s + c);

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
            Aggregate();
    }

    /// <summary>
    /// String.Contains() analog, but case insensitive.
    /// </summary>
    public static bool ContainsCi(this string s, string t)
    {
        return s.ToLower().Contains(t.ToLower());
    }

    /// <summary>
    /// Gets substring before the first occurrence of x string.
    /// </summary>
    public static string GetBefore(this string s, string x)
    {
        var index = s.IndexOf(x);
        if (index == -1) throw new InvalidOperationException("This string doesn't contain specified x string.");

        return s.Substring(0, index);
    }

    /// <summary>
    /// Gets the string between the first occurrence of left and the first occurrence of right after left's one.
    /// </summary>
    public static string GetBetween(this string s, string left, string right)
    {
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
    /// Gets substring after the first occurrence of x string.
    /// </summary>
    public static string GetAfter(this string s, string x)
    {
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
        return ExtraSpacesRegex.Replace(s, @" ");
    }
}