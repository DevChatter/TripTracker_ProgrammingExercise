using Core.Model;
using System;

namespace Core.Parsing
{
    public class TripRecordParser : IRecordParser
    {
        public string Identifier => "Trip";

        public DrivingRecord ParseRecord(string line)
        {
            string[] pieces = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var record = CreateDrivingRecord(pieces);
            return record;
        }

        private static DrivingRecord CreateDrivingRecord(string[] pieces)
        {
            TimeSpan time = GetTimeSpan(pieces[2], pieces[3]);
            if (decimal.TryParse(pieces[4], out decimal miles))
            {
                return new DrivingRecord(pieces[1], time, miles);

            }
            return DrivingRecord.Empty;
        }

        private static TimeSpan GetTimeSpan(string startTime, string endTime)
            => endTime.ParseTime() - startTime.ParseTime();
    }
}
