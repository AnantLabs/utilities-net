using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// TODO: Update summary.
/// </summary>
public static class Base64
{
    public static string Encode(string str)
    {
        byte[] encbuff = System.Text.Encoding.UTF8.GetBytes(str);
        return Convert.ToBase64String(encbuff);
    }

    public static string Decode(string str)
    {
        byte[] decbuff = Convert.FromBase64String(str);
        return System.Text.Encoding.UTF8.GetString(decbuff);
    }
}