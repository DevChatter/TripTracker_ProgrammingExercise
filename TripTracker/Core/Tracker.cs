using Core.IO;
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
            var theThingItReturns = inputParser.ParseAll(allLines);

            foreach (var record in theThingItReturns.Records)
            {
                console.WriteLine(record.ToString());
            }
        }
    }
}
