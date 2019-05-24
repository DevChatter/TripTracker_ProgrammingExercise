using Core.Model;
using System.Linq;
using System.Collections.Generic;

namespace Core.Parsing
{
    public class InputParser
    {
        private IRecordParser[] RecordParsers { get; }

        public InputParser(params IRecordParser[] recordParsers)
        {
            RecordParsers = recordParsers;
        }

        public Report ParseAll(IList<string> lines)
        {
            var report = new Report();

            foreach (string line in lines)
            {
                var parser = RecordParsers.SingleOrDefault(p => p.CanParse(line));

                var record = parser?.ParseRecord(line.Trim()) ?? DrivingRecord.Empty;

                report.ProcessRecord(record);
            }

            return report;
        }
    }
}
