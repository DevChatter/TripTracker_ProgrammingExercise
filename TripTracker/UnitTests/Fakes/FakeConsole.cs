using Core.IO;
using System.Collections.Generic;

namespace UnitTests.Fakes
{
    public class FakeConsole : IConsole
    {
        public List<string> WrittenLines { get; } = new List<string>();

        public void WriteLine(string text) => WrittenLines.Add(text);
    }
}
