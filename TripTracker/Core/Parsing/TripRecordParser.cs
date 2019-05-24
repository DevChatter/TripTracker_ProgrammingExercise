using Core.Model;

namespace Core.Parsing
{
    public class TripRecordParser : IRecordParser
    {
        public string Identifier => "Trip";

        public DrivingRecord ParseRecord(string line)
        {
            throw new System.NotImplementedException();
        }
    }
}
