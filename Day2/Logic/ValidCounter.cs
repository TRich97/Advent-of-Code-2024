using Day2.Data;

namespace Day2.Logic
{
    public static class ValidCounter
    {
        public static int CountValidReports()
        {
            const string FILEPATH = "C:\\Users\\efcto\\source\\repos\\Advent of Code 2024\\Day2\\Data\\Input.txt";
            var reports = InputData.reports(FILEPATH);
            int count = 0;
            foreach (var report in reports)
            {
                if (report.isSafe())
                {
                    count++;
                }
            }
            return count;
        }
    }
}
