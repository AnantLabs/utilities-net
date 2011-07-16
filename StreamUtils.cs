using System;
using System.Collections.Generic;
using System.IO;

/// <summary>
/// Common Stream-related utility methods.
/// </summary>
public static class StreamUtils
{
    /// <summary>
    /// Gets StreamReader for this stream.
    /// </summary>
    /// <exception cref="InvalidOperationException">When stream doesn't support reading.</exception>
    public static StreamReader GetReader(this Stream stream)
    {
        if (!stream.CanRead) throw new InvalidOperationException("Stream doesn't support reading");

        return new StreamReader(stream);
    }

    /// <summary>
    /// Gets StreamWriter for this stream.
    /// </summary>
    public static StreamWriter GetWriter(this Stream stream)
    {
        if (!stream.CanWrite) throw new InvalidOperationException("Stream doesn't support writing");

        return new StreamWriter(stream);
    }

    /// <summary>
    /// Reads from the current position to the end of the stream. 
    /// StreamReader is automatically created and disposed.
    /// </summary>
    public static string ReadToEnd(this Stream stream)
    {
        using (var reader = stream.GetReader())
        {
            return reader.ReadToEnd();
        }
    }


    /// <summary>
    /// Writes bytes to the stream. The same as Write(bytes, 0, bytes.Length).
    /// </summary>
    public static void Write(this Stream stream, byte[] bytes)
    {
        stream.Write(bytes, 0, bytes.Length);
    }

    /// <summary>
    /// Enumerates all lines of the reader using ReadLine().
    /// </summary>
    public static IEnumerable<string> EnumerateLines(this TextReader reader)
    {
        string line;
        while ((line = reader.ReadLine()) != null)
        {
            yield return line;
        }
    }
}