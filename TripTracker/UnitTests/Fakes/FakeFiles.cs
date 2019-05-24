using Core.IO;

namespace UnitTests.Fakes
{
    public class FakeFiles : IFileSystem
    {
        public bool ExistsReturns { get; set; }
        public bool Exists(string filePath) => ExistsReturns;
    }
}
