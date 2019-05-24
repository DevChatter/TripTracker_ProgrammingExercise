﻿using Core.IO;
using TripTracker.IO;
using System.Linq;

namespace TripTracker
{
    public class Program
    {
        public static IFileSystem files { get; set; } = new SystemFiles();
        public static IConsole console { get; set; } = new SystemConsole();

        public static void Main(string[] args)
        {
            string fileName = args.FirstOrDefault();

            if (files.Exists(fileName))
            {
                string[] lines = files.ReadAllLines(fileName);
                foreach (string line in lines)
                {
                    console.WriteLine(line);
                }
            }
        }
    }

    // Ignore Trips less than 5 MPH.
    // Ignore Trips faster than 100 MPH.

    //Sample input:

    //Driver Sarah
    //Driver Brendan
    //Driver Michael
    //Trip Sarah 09:15 09:45 17.3
    //Trip Sarah 06:22 06:42 21.8
    //Trip Brendan 12:11 13:26 42.0


    //Sample output:

    //Brendan: 42 miles @ 34 mph
    //Sarah: 39 miles @ 47 mph
    //Michael: 0 miles
}
