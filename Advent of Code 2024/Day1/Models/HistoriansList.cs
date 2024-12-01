using System.Collections.Generic;
using System.IO;

namespace AdventofCode2024.Day1.Models
{
    public class HistoriansList
    {
        private List<int> numbers;

        public HistoriansList(string path) 
        {
            PopulateList(path); 
            SortList();
        }

        private void PopulateList(string path)
        {
            var list = File.ReadAllLines(path);
            this.numbers = new List<int>();
            foreach (var line in list)
            {
                this.numbers.Add(int.Parse(line));
            }
        }

        private void SortList() { numbers.Sort(); }

        public List<int> GetNumbers() { return this.numbers; }

    }
}
