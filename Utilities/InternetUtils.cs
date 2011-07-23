using System;
using System.IO;
using System.Net;

/// <summary>
/// Common Internet-related utility methods.
/// </summary>
public static class InternetUtils
{
    /// <summary>
    /// Fetches content from the url as a string.
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
    /// Fetches content from the url as a string.
    /// </summary>
    public static string Fetch(string url)
    {
        if (url == null) throw new ArgumentNullException("url");
        return Fetch(new Uri(url));
    }
}