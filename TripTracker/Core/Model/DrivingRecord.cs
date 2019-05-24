using System;

namespace Core.Model
{
    public class DrivingRecord
    {
        public static DrivingRecord Empty { get; } = new DrivingRecord("", false);

        public bool IsRegistration { get; }
        public string Name { get; set; }
        public TimeSpan Time { get; set; }
        public decimal Miles { get; set; }
        public decimal Mph
        {
            get
            {
                var totalHours = Time.Hours + Time.Minutes / 60m;
                return totalHours > 0 ? Miles / totalHours : 0m;
            }
        }

        public DrivingRecord(string name, bool isRegistration)
        {
            Name = name;
            IsRegistration = isRegistration;
        }

        public DrivingRecord(string name, TimeSpan time, decimal miles)
        {
            Name = name;
            Time = time;
            Miles = miles;
        }
    }
}
