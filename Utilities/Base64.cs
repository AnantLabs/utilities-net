using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// TODO: Update summary.
/// </summary>
public static class Base64
{
    /// <summary>
    /// Encode the <paramref name="s"/> string to Base64.
    /// </summary>
    public static string Encode(string s)
    {
        if (s == null) throw new ArgumentNullException("s");

        byte[] encbuff = Encoding.UTF8.GetBytes(s);
        return Convert.ToBase64String(encbuff);
    }

    /// <summary>
    /// Decode the Base64-encoded string <paramref name="s"/>.
    /// </summary>
    public static string Decode(string s)
    {
        if (s == null) throw new ArgumentNullException("s");

        byte[] decbuff = Convert.FromBase64String(s);
        return Encoding.UTF8.GetString(decbuff);
    }
}