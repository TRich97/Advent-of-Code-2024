namespace Day2.Data
{
    public static class InputData
    {
        public static IEnumerable<Reports> reports(string fileName)
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
    }
}
