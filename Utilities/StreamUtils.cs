using System;
using System.Collections.Generic;
using System.IO;

/// <summary>
/// Common Stream-related utility methods.
/// </summary>
public static class StreamUtils
{
    /// <summary>
    /// Gets StreamReader for this <paramref name="stream"/>.
    /// </summary>
    /// <exception cref="InvalidOperationException">When stream doesn't support reading.</exception>
    public static StreamReader GetReader(this Stream stream)
    {
        if (stream == null) throw new ArgumentNullException("stream");
        if (!stream.CanRead) throw new InvalidOperationException("Stream doesn't support reading");

        return new StreamReader(stream);
    }

    /// <summary>
    /// Gets StreamWriter for this <paramref name="stream"/>.
    /// </summary>
    public static StreamWriter GetWriter(this Stream stream)
    {
        if (stream == null) throw new ArgumentNullException("stream");
        if (!stream.CanWrite) throw new InvalidOperationException("Stream doesn't support writing");

        return new StreamWriter(stream);
    }

    /// <summary>
    /// Reads from the current position to the end of the <paramref name="stream"/>. 
    /// StreamReader is automatically created and disposed.
    /// </summary>
    public static string ReadToEnd(this Stream stream)
    {
        if (stream == null) throw new ArgumentNullException("stream");

        using (var reader = stream.GetReader())
        {
            return reader.ReadToEnd();
        }
    }


    /// <summary>
    /// Writes <paramref name="buffer"/> to the <paramref name="stream"/>. The same as <paramref name="stream"/>.Write(<paramref name="buffer"/>, 0, <paramref name="buffer"/>.Length).
    /// </summary>
    public static void Write(this Stream stream, byte[] buffer)
    {
        if (stream == null) throw new ArgumentNullException("stream");
        if (buffer == null) throw new ArgumentNullException("buffer");

        stream.Write(buffer, 0, buffer.Length);
    }

    /// <summary>
    /// Enumerates all lines of the <paramref name="reader"/> using ReadLine().
    /// </summary>
    public static IEnumerable<string> EnumerateLines(this TextReader reader)
    {
        if (reader == null) throw new ArgumentNullException("reader");

        string line;
        while ((line = reader.ReadLine()) != null)
        {
            yield return line;
        }
    }
}