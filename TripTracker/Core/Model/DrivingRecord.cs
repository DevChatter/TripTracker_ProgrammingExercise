namespace Core.Model
{
    public class DrivingRecord
    {
        public static DrivingRecord Empty { get; } = new DrivingRecord("", false);

        public bool IsRegistration { get; }
        public string Name { get; set; }

        public DrivingRecord(string name, bool isRegistration)
        {
            Name = name;
            IsRegistration = isRegistration;
        }
    }
}
