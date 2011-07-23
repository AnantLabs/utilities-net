using System;
using System.IO;
using System.Xml;

/// <summary>
/// TODO: Update summary.
/// </summary>
public static class XmlUtils
{
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