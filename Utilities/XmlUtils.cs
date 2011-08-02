using System;
using System.IO;
using System.Xml;

/// <summary>
/// Utility XML-related methods.
/// </summary>
public static class XmlUtils
{
    /// <summary>
    /// Check whether the <paramref name="xml"/> string is XML-valid.
    /// </summary>
    public static bool CheckValid(string xml)
    {
        if(xml == null) throw new ArgumentNullException("xml");

        var xmlDoc = new XmlDocument();
        try
        {
            xmlDoc.LoadXml(xml);
            return true;
        }
        catch (XmlException)
        {
            return false;
        }
    }

    /// <summary>
    /// Check whether the data from the <paramref name="stream"/> is XML-valid.
    /// </summary>
    public static bool CheckValid(Stream stream)
    {
        if(stream == null) throw new ArgumentNullException("stream");

        var xmlDoc = new XmlDocument();
        try
        {
            xmlDoc.Load(stream);
            return true;
        }
        catch (XmlException)
        {
            return false;
        }
    }

    /// <summary>
    /// Check whether the data from the <paramref name="reader"/> is XML-valid.
    /// </summary>
    public static bool CheckValid(TextReader reader)
    {
        if(reader == null) throw new ArgumentNullException("reader");

        var xmlDoc = new XmlDocument();
        try
        {
            xmlDoc.Load(reader);
            return true;
        }
        catch (XmlException)
        {
            return false;
        }
    }

    /// <summary>
    /// Check whether the file with specified <paramref name="filename"/> is XML-valid.
    /// </summary>
    public static bool CheckValidFile(string filename)
    {
        if(filename == null) throw new ArgumentNullException("filename");

        var xmlDoc = new XmlDocument();
        try
        {
            xmlDoc.Load(filename);
            return true;
        }
        catch (XmlException)
        {
            return false;
        }
    }
}