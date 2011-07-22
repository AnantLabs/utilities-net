using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;

/// <summary>
/// TODO: Update summary.
/// </summary>
public static class XmlUtils
{
    public static bool CheckValid(Stream stream)
    {
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

    public static bool CheckValid(string filename)
    {
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

    public static bool CheckValid(TextReader reader)
    {
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
}