using System;
using System.Collections.Generic;
using System.Text;
using Managed.Adb;

namespace Common
{
    public class CommandResultReceiver : MultiLineReceiver
    {
        private List<string> lines=new List<string>();

        private StringBuilder result = new StringBuilder();

        protected override void ProcessNewLines(string[] lines)
        {
            this.lines.AddRange(lines);
           
            foreach (String line in lines)
            {
                if (String.IsNullOrEmpty(line) || line.StartsWith("#") || line.StartsWith("$"))
                {
                    continue;
                }

                result.AppendLine(line);
            }

            this.Result = result.ToString().Trim();
        }

        public String Result { get; private set; }

        public string[] ResultLines
        {
            get
            {
                return lines.ToArray();
            }
        }

    }
}
