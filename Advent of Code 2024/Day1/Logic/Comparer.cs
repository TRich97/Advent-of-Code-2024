using AdventofCode2024.Day1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace AdventofCode2024.Day1.Logic
{
    public static class Comparer
    {
        private const string PATH1 = "C:\\Users\\efcto\\source\\repos\\Advent of Code 2024\\Advent of Code 2024\\Day1\\Input\\Input1.txt";
        private const string PATH2 = "C:\\Users\\efcto\\source\\repos\\Advent of Code 2024\\Advent of Code 2024\\Day1\\Input\\Input2.txt";

        public static int Solve()
        {
            HistoriansList input1 = new HistoriansList(PATH1);
            HistoriansList input2 = new HistoriansList(PATH2);
            List<int> list1 = input1.GetNumbers();
            List<int> list2 = input2.GetNumbers();
            int output = 0;
            int count = 0;
            do
            {
                output += CompareList(list1[count], list2[count]);
                count++;
            } while (count < list1.Count);
            return output;
        }

        private static int CompareList(int num1, int num2)
        {
            return Math.Abs(num1 - num2);
        }
    }
}
