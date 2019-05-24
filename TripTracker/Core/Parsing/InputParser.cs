using Core.Model;
using System;
using System.Collections.Generic;

namespace Core.Parsing
{
    public class InputParser
    {
        private IRecordParser[] RecordParsers { get; }

        public InputParser(params IRecordParser[] recordParsers)
        {
            RecordParsers = recordParsers;
        }

        public Report ParseAll(IList<string> lines)
        {
            throw new NotImplementedException();
        }
    }
}
