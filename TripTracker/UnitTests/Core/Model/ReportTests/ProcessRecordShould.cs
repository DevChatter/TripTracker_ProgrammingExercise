using Core.Model;
using FluentAssertions;
using System;
using System.Linq;
using Xunit;

namespace UnitTests.Core.Model.ReportTests
{
    public class ProcessRecordShould
    {
        [Fact]
        public void KeepRecord_GivenIsRegistration()
        {
            const string name = "Ed";
            var report = new Report();
            var record = new DrivingRecord(name, true);

            report.ProcessRecord(record);

            report.Records.Should().ContainSingle();
            report.Records.Single().Name.Should().Be(name);
        }

        [Fact]
        public void DoNothing_GivenNonRegistration()
        {
            var report = new Report();
            var record = new DrivingRecord("Simon", TimeSpan.Zero, 0m);

            report.ProcessRecord(record);

            report.Records.Should().BeEmpty();
        }

        [Fact]
        public void AddToExistingRecord_GivenNewTrips()
        {
            var (name, time, miles) = ("Nick", TimeSpan.FromHours(1), 35m);
            var report = new Report();
            var reg = new DrivingRecord(name, true);
            var trip = new DrivingRecord(name, time, miles);

            report.ProcessRecord(reg);
            report.ProcessRecord(trip);
            report.ProcessRecord(trip);

            var result = report.Records.Single();
            result.Name.Should().Be(name);
            result.Time.Should().Be(time * 2);
            result.Miles.Should().Be(miles * 2);
        }
    }
}
