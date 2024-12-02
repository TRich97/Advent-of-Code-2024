using Day2.Data;
using Day2.Data.Part1;

namespace Day2.Logic
{
    public static class ValidCounter
    {
        public static int CountValidReports()
        {
            const string FILEPATH = "C:\\Users\\efcto\\source\\repos\\Advent of Code 2024\\Day2\\Data\\Input.txt";
            var reports = InputData.GetRawReports(FILEPATH);
            int count = 0;
            foreach (var report in reports)
            {
                if (report.IsSafe())
                {
                    count++;
                }
            }
            return count;
        }

        public static int CountValidDampReports()
        {
            const string TEST = "C:\\Users\\efcto\\source\\repos\\Advent of Code 2024\\Day2\\Data\\Example\\reports.txt";
            const string FILEPATH = "C:\\Users\\efcto\\source\\repos\\Advent of Code 2024\\Day2\\Data\\Input.txt";
            var reports = InputData.GetDampReports(FILEPATH);
            int count = 0;
            foreach (var report in reports)
            {
                if (report.IsSafe())
                {
                    count++;
                }
            }
            return count;
        }
    }
}
