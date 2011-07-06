using System;
using System.Collections.Generic;
using System.IO;

/// <summary>
/// Common Stream-related utility methods.
/// </summary>
public static class StreamUtils
{
    public static StreamReader GetReader(this Stream stream)
    {
        if (!stream.CanRead) throw new InvalidOperationException("Stream doesn't support reading");

        return new StreamReader(stream);
    }

    public static StreamWriter GetWriter(this Stream stream)
    {
        if (!stream.CanWrite) throw new InvalidOperationException("Stream doesn't support writing");

        return new StreamWriter(stream);
    }

    public static string ReadToEnd(this Stream stream)
    {
        using (var reader = stream.GetReader())
        {
            return reader.ReadToEnd();
        }
    }

    public static void Write(this Stream stream, byte[] bytes)
    {
        stream.Write(bytes, 0, bytes.Length);
    }

    public static IEnumerable<string> EnumerateLines(this TextReader reader)
    {
        string line = null;
        while ((line = reader.ReadLine()) != null)
        {
            yield return line;
        }
    }
}