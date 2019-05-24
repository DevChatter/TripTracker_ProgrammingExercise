using System.Collections.Generic;
using System.Linq;

namespace Core.Model
{
    public class Report
    {
        private Dictionary<string, DrivingRecord> _records 
            = new Dictionary<string, DrivingRecord>();
        public List<DrivingRecord> Records
            => _records.Values.OrderByDescending(x => x.Miles).ToList();

        public void ProcessRecord(DrivingRecord record)
        {
            if (record.IsRegistration)
            {
                _records.Add(record.Name, record);
            }
            else if (_records.TryGetValue(record.Name, out DrivingRecord existing))
            {
                existing.AddTrip(record);
            }
        }
    }
}
