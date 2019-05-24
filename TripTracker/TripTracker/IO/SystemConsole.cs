using Core.IO;
using System;

namespace TripTracker.IO
{
    public class SystemConsole : IConsole
    {
        public void WriteLine(string text) => Console.WriteLine(text);
    }
}
