using FluentAssertions;
using System.Collections.Generic;
using TripTracker;
using UnitTests.Fakes;
using Xunit;

namespace UnitTests
{
    public class FullSystemTest
    {
        [Fact]
        public void HandlesSampleInputOutput()
        {
            var (fakeConsole, fakeFiles) = SetUpFakes();

            Program.Main(new[] { "fileName" });

            for (int i = 0; i < expectedOutput.Count; i++)
            {
                fakeConsole.WrittenLines[i].Should().Be(expectedOutput[i]);
            }
        }

        private const string sampleInput =
@"Driver Sarah
Driver Brendan
Driver Michael
Trip Sarah 09:15 09:45 17.3
Trip Sarah 06:22 06:42 21.8
Trip Brendan 12:11 13:26 42.0";

        private readonly List<string> expectedOutput = new List<string>
        {
            "Brendan: 42 miles @ 34 mph",
            "Sarah: 39 miles @ 47 mph",
            "Michael: 0 miles"
        };

        private static (FakeConsole, FakeFiles) SetUpFakes()
        {
            FakeConsole fakeConsole = new FakeConsole();
            FakeFiles fakeFiles = new FakeFiles
            {
                ExistsReturns = true,
                TextInFile = sampleInput
            };
            Program.console = fakeConsole;
            Program.files = fakeFiles;
            return (fakeConsole, fakeFiles);
        }
    }
}
