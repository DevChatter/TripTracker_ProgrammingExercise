using Core.Model;
using System;
using System.Linq;

namespace Core.Parsing
{
    public class DriverRecordParser : IRecordParser
    {
        public string Identifier => "Driver";

        public DrivingRecord ParseRecord(string line)
        {
            string name = line.Split(' ', StringSplitOptions.RemoveEmptyEntries).ElementAtOrDefault(1);
            if (string.IsNullOrWhiteSpace(name))
            {
                return DrivingRecord.Empty;
            }
            return new DrivingRecord(name, true);
        }
    }
}
