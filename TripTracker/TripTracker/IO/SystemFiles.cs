using Core.IO;
using System.IO;

namespace TripTracker.IO
{
    public class SystemFiles : IFileSystem
    {
        public bool Exists(string filePath) => File.Exists(filePath);

        public string[] ReadAllLines(string filePath) => File.ReadAllLines(filePath);
    }
}
