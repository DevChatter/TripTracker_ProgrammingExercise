using Core.Model;
using Core.Parsing;
using FluentAssertions;
using Xunit;

namespace UnitTests.Core.Parsing.RecordParserTests
{
    public class DriverRecordParser_ParseRecordShould
    {
        [Fact]
        public void ReturnEmpty_GivenInvalidInput()
        {
            var parser = new DriverRecordParser();

            var record = parser.ParseRecord("Driver");

            record.Should().Be(DrivingRecord.Empty);
        }

        [Theory]
        [InlineData("Driver Brendan", "Brendan")]
        [InlineData("Driver Mike", "Mike")]
        [InlineData("Driver Dan", "Dan")]
        public void ReturnRegistrationRecord_GivenValidInput(string line, string name)
        {
            var parser = new DriverRecordParser();

            var record = parser.ParseRecord(line);

            record.Name.Should().Be(name);
            record.IsRegistration.Should().BeTrue();
        }
    }
}
