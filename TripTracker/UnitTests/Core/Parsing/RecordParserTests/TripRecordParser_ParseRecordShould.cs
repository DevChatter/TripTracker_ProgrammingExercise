using Core.Parsing;
using FluentAssertions;
using System;
using Xunit;

namespace UnitTests.Core.Parsing.RecordParserTests
{
    public class TripRecordParser_ParseRecordShould
    {
        [Theory]
        [InlineData("Trip Sarah 09:15 09:45 17.3", "Sarah", 30, 17.3)]
        [InlineData("Trip Brendan 12:11 13:26 42.0", "Brendan", 75, 42)]
        public void ReturnRecord_GivenValidInput(
            string input, string name, int minutes, decimal miles)
        {
            var parser = new TripRecordParser();

            var result = parser.ParseRecord(input);

            result.Name.Should().Be(name);
            result.Time.Should().Be(TimeSpan.FromMinutes(minutes));
            result.Miles.Should().Be(miles);
        }
    }
}
