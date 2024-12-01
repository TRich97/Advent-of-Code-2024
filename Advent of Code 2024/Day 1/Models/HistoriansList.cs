using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_of_Code_2024.Day_1.Models
{
    public class HistoriansList
    {
        private const string Path = "C:\\Users\\efcto\\source\\repos\\Advent of Code 2024\\Advent of Code 2024\\Day 1\\Input\\Input.txt";
        private IEnumerable<int> numbers;

        public IEnumerable<int> PopulateList(string path)
        {
            var list = File.ReadAllLines(path);
            List<int> numbers = new List<int>();
            foreach (var line in list)
            {
                numbers.Add(int.Parse(line));
            }
        }
    }
}
