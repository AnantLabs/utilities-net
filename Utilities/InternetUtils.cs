using System;
using System.IO;
using System.Net;
using System.Text;

/// <summary>
/// Common Internet-related utility methods.
/// </summary>
public static class InternetUtils
{
    /// <summary>
    /// Fetch HTML page from <paramref name="url"/>, detecting encoding with meta tags.
    /// </summary>
    public static string FetchPage(string url)
    {
        var fetchRequest = (HttpWebRequest)WebRequest.Create(url);

        fetchRequest.Method = "GET";

        using (var resp = fetchRequest.GetResponse())
        using (var stream = resp.GetResponseStream())
        using (var seekStream = stream.ToSeekable())
        using (var reader = seekStream.GetReader())
        {
            Encoding encoding = null;
            string data = reader.ReadToEnd();
            if (data.Contains("charset="))
            {
                string charset = data.GetBetween("charset=", "\"");
                encoding = Encoding.GetEncoding(charset);
            }

            seekStream.Seek(0, SeekOrigin.Begin);
            using (var readerEnc = seekStream.GetReader(encoding))
            {
                return readerEnc.ReadToEnd();
            }
        }
    }

    /// <summary>
    /// Fetches content from the <paramref name="url"/> as a string.
    /// </summary>
    public static string Fetch(Uri url)
    {
        if (url == null) throw new ArgumentNullException("url");

        var request = (HttpWebRequest)WebRequest.Create(url);
        using (var response = request.GetResponse())
        using (var responseStream = response.GetResponseStream())
        using (var reader = new StreamReader(responseStream))
        {
            return reader.ReadToEnd();
        }
    }

    /// <summary>
    /// Fetches content from the <paramref name="url"/> as a string.
    /// </summary>
    public static string Fetch(string url)
    {
        if (url == null) throw new ArgumentNullException("url");
        return Fetch(new Uri(url));
    }
}