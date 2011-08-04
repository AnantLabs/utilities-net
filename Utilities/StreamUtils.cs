using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

/// <summary>
/// Common Stream-related utility methods.
/// </summary>
public static class StreamUtils
{
    /// <summary>
    /// Gets StreamReader for this <paramref name="stream"/>.
    /// </summary>
    /// <exception cref="InvalidOperationException">When stream doesn't support reading.</exception>
    public static StreamReader GetReader(this Stream stream, Encoding encoding = null)
    {
        if (stream == null) throw new ArgumentNullException("stream");
        if (!stream.CanRead) throw new InvalidOperationException("Stream doesn't support reading");

        return encoding == null ?
            new StreamReader(stream) :
            new StreamReader(stream, encoding);
    }

    /// <summary>
    /// Gets StreamWriter for this <paramref name="stream"/>.
    /// </summary>
    public static StreamWriter GetWriter(this Stream stream, Encoding encoding = null)
    {
        if (stream == null) throw new ArgumentNullException("stream");
        if (!stream.CanWrite) throw new InvalidOperationException("Stream doesn't support writing");

        return encoding == null ?
            new StreamWriter(stream) :
            new StreamWriter(stream, encoding);
    }

    /// <summary>
    /// Writes <paramref name="buffer"/> to the <paramref name="stream"/>. 
    /// The same as <paramref name="stream"/>.Write(<paramref name="buffer"/>, 0, <paramref name="buffer"/>.Length).
    /// </summary>
    public static void Write(this Stream stream, byte[] buffer)
    {
        if (stream == null) throw new ArgumentNullException("stream");
        if (buffer == null) throw new ArgumentNullException("buffer");

        stream.Write(buffer, 0, buffer.Length);
    }

    /// <summary>
    /// Reads to <paramref name="buffer"/> from the <paramref name="stream"/>. 
    /// The same as <paramref name="stream"/>.Read(<paramref name="buffer"/>, 0, <paramref name="buffer"/>.Length).
    /// </summary>
    public static int Read(this Stream stream, byte[] buffer)
    {
        if (stream == null) throw new ArgumentNullException("stream");
        if (buffer == null) throw new ArgumentNullException("buffer");

        return stream.Read(buffer, 0, buffer.Length);
    }

    /// <summary>
    /// Returns seekable MemoryStream which contains the same data as this <paramref name="stream"/> (from current position).
    /// This <paramref name="stream"/> position after this call will be at the end.
    /// </summary>
    public static MemoryStream ToSeekable(this Stream stream)
    {
        var memoryStream = new MemoryStream();
        stream.CopyTo(memoryStream);
        memoryStream.Seek(0, SeekOrigin.Begin);

        return memoryStream;
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