using System;
using Core.IO;
using Core.Model;
using Core.Parsing;

namespace Core
{
    public class Tracker
    {
        private readonly IConsole console;
        private readonly InputParser inputParser;

        public Tracker(IConsole console, InputParser inputParser)
        {
            this.console = console;
            this.inputParser = inputParser;
        }

        public void ProcessAllInput(string[] allLines)
        {
            var report = inputParser.ParseAll(allLines);

            foreach (var record in report.Records)
            {
                PrintRecord(record.Name, record.Miles.RoundToInt(), record.Mph.RoundToInt());
            }
        }

        private void PrintRecord(string name, int miles, int mph)
        {
            string mphPart = miles > 0 ? $" @ {mph} mph" : "";
            console.WriteLine($"{name}: {miles} miles{mphPart}");
        }
    }
}
