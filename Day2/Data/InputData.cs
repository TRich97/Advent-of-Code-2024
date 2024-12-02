using Day2.Data.Part1;
using Day2.Data.Part2;

namespace Day2.Data
{
    public static class InputData
    {
        public static IEnumerable<DampReports> GetDampReports(string fileName)
        {
            List<DampReports> reports = new List<DampReports>();
            var fileStream = File.OpenRead(fileName);
            using (var streamReader = new StreamReader(fileStream))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    List<string> numbers = line.Split(' ').ToList();
                    reports.Add(AddDampReport(numbers));
                }
            }
            return reports;
        }
        public static IEnumerable<Reports> GetRawReports(string fileName)
        {
            List<Reports> reports = new List<Reports>();
            var fileStream = File.OpenRead(fileName);
            using (var streamReader = new StreamReader(fileStream))
            {
                string line;
                while((line  = streamReader.ReadLine()) != null) 
                {
                    List<string> numbers = line.Split(' ').ToList();
                    reports.Add(AddReport(numbers));
                }
            }
            return reports;
        }

        private static Reports AddReport (List<string> numbers)
        {
            List<int> ints = new List<int>();
            foreach (var number in numbers)
            {
                ints.Add(Convert.ToInt32(number));
            }
            return new Reports(ints);
        }

        private static DampReports AddDampReport(List<string> numbers)
        {
            List<int> ints = new List<int>();
            foreach (var number in numbers)
            {
                ints.Add(Convert.ToInt32(number));
            }
            return new DampReports(ints);
        }
    }
}
