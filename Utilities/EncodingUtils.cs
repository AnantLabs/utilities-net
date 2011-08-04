using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Ude;

/// <summary>
/// TODO: Update summary.
/// </summary>
public static class EncodingUtils
{
    /// <summary>
    /// Detects encoding of text data in this <paramref name="stream"/>.
    /// </summary>
    public static Encoding DetectEncoding(this Stream stream)
    {
        if (stream == null) throw new ArgumentNullException("stream");
        if (!stream.CanRead || !stream.CanSeek) throw new NotSupportedException("Stream should be readable and seekable.");

        var detector = new CharsetDetector();
        detector.Feed(stream);
        detector.DataEnd();

        stream.Seek(0, SeekOrigin.Begin);

        return Encoding.GetEncoding(detector.Charset);
    }

    /// <summary>
    /// Gets StreamReader for this <paramref name="stream"/> using automatically detected encoding.
    /// </summary>
    public static StreamReader GetReaderAuto(this Stream stream)
    {
        if (stream == null) throw new ArgumentNullException("stream");
        if (!stream.CanRead || !stream.CanSeek) throw new NotSupportedException("Stream should be readable and seekable.");

        return stream.GetReader(stream.DetectEncoding());
    }
}