using Core.Parsing;
using FluentAssertions;
using Xunit;

namespace UnitTests.Core.Parsing.RecordParserTests
{
    public class CanParseShould
    {
        [Theory]
        [InlineData("Driver Brendan")]
        [InlineData("Driver Sarah")]
        public void ReturnTrue_GivenDriverRecordParserAndData(string line)
        {
            IRecordParser parser = new DriverRecordParser();

            bool result = parser.CanParse(line);

            result.Should().BeTrue();
        }

        [Theory]
        [InlineData("Trip Sarah 09:15 09:45 17.3")]
        [InlineData("Trip Brendan 12:11 13:26 42.0")]
        public void ReturnFalse_GivenDriverRecordParserAndOtherData(string line)
        {
            IRecordParser parser = new DriverRecordParser();

            bool result = parser.CanParse(line);

            result.Should().BeFalse();
        }

        [Theory]
        [InlineData("Trip Sarah 09:15 09:45 17.3")]
        [InlineData("Trip Brendan 12:11 13:26 42.0")]
        public void ReturnTrue_GivenTripRecordParserAndData(string line)
        {
            IRecordParser parser = new TripRecordParser();

            bool result = parser.CanParse(line);

            result.Should().BeTrue();
        }

        [Theory]
        [InlineData("Driver Brendan")]
        [InlineData("Driver Sarah")]
        public void ReturnFalse_GivenTripRecordParserAndOtherData(string line)
        {
            IRecordParser parser = new TripRecordParser();

            bool result = parser.CanParse(line);

            result.Should().BeFalse();
        }
    }
}
