using Core.Model;

namespace Core.Parsing
{
    public interface IRecordParser
    {
        public string Identifier { get; }
        public bool CanParse(string line) => line[..Identifier.Length].EqualsIgnoreCase(Identifier);
        Record ParseRecord(string line);
    }
}
