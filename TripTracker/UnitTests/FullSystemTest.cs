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

            Assert.Single(fakeConsole.WrittenLines);
        }

        private static (FakeConsole, FakeFiles) SetUpFakes()
        {
            FakeConsole fakeConsole = new FakeConsole();
            FakeFiles fakeFiles = new FakeFiles { ExistsReturns = true };
            Program.console = fakeConsole;
            Program.files = fakeFiles;
            return (fakeConsole, fakeFiles);
        }
    }
}
