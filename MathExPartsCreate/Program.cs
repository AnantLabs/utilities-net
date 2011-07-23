using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MathExPartsCreate
{
    using System.Diagnostics;
    using System.IO;

    public class Program
    {
        private const string TEMPLATE =
@"using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// Part of MathEx class: MathEx.{NAME}.
/// </summary>
public static partial class MathEx
{
{CONTENT}
}";

        private class Part
        {
            public string Name;
            public string[] Types;
            public string Content;
        }

        static void Main(string[] args)
        {
            string directory = Directory.GetCurrentDirectory();

            string[] configData = File.ReadAllLines(Path.Combine(directory, "config.dat"));

            var parts = new List<Part>();

            for (int i = 0; i < configData.Length; i++)
            {
                var part = new Part();
                part.Name = configData[i++];
                part.Types = configData[i++].Split(' ');
                Debug.Assert(configData[i++] == "/////");
                part.Content = configData.Skip(i).TakeWhile(s => s != "/////").Aggregate((acc, s) =>
                    {
                        i++;
                        return acc + "\r\n" + s;
                    });
                i++;
                Debug.Assert(configData[i++] == "/////");

                parts.Add(part);
            }

            foreach (var group in parts.GroupBy(p => p.Name))
            {
                var sb = new StringBuilder();

                foreach (var part in group)
                {
                    foreach (var type in part.Types)
                    {
                        string content = part.Content.Replace("{TYPE}", type);

                        sb.AppendFormat("#region {0}", type).AppendLine();
                        sb.Append(content).AppendLine();
                        sb.Append("#endregion").AppendLine().AppendLine();
                    }
                }

                string data = TEMPLATE.
                    Replace("{NAME}", group.Key).
                    Replace("{CONTENT}", sb.ToString().TrimEnd());
                File.WriteAllText(string.Format("MathEx.{0}.cs", group.Key), data);
            }
        }
    }
}
