using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Web;

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
    /// <param name="url">URL of the request</param>
    /// <param name="postData">Object containing data to be sent (as key => value). If not null, then POST method is used and the data is sent.</param>
    /// <param name="headers">Object containing additional headers (as key => value).</param>
    public static string Fetch(Uri url, object postData = null, object headers = null)
    {
        if (url == null) throw new ArgumentNullException("url");

        var request = (HttpWebRequest)WebRequest.Create(url);

        if (headers != null)
        {
            var values = headers.GetType().GetMembers().
                Where(m => m.MemberType == MemberTypes.Field || m.MemberType == MemberTypes.Property).
                ToDictionary(m => m.Name, m => ((PropertyInfo)m).GetValue(headers, null).ToString());

            values.ForEach(header => request.Headers.Add(header.Key, header.Value));
        }

        if (postData != null)
        {
            var values = postData.GetType().GetMembers().
                Where(m => m.MemberType == MemberTypes.Field || m.MemberType == MemberTypes.Property).
                ToDictionary(m => m.Name, m => ((PropertyInfo)m).GetValue(postData, null).ToString());
            string post = values.Aggregate(
                kvp => "{0}={1}".FormatWith(
                    kvp.Key,
                    kvp.Value),
                "&");
            byte[] bytes = new ASCIIEncoding().GetBytes(post);

            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = bytes.Length;

            using (var stream = request.GetRequestStream())
            {
                stream.Write(bytes, 0, bytes.Length);
            }
        }

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
    /// <param name="url">URL of the request</param>
    /// <param name="postData">Object containing data to be sent (as key => value). If not null, then POST method is used and the data is sent.</param>
    /// <param name="headers">Object containing additional headers (as key => value).</param>
    public static string Fetch(string url, object postData = null, object headers = null)
    {
        if (url == null) throw new ArgumentNullException("url");
        return Fetch(new Uri(url), postData, headers);
    }
}