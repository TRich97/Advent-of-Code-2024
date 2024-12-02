﻿using AdventofCode2024.Day1.Logic;
using System;
using System.Diagnostics;

namespace AdventofCode2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var watch = Stopwatch.StartNew();
            int answer = Comparer.Solve();
            watch.Stop();
            Console.WriteLine($"Merry christmas, your answer is: {answer}");
            Console.WriteLine($"complete in {watch.Elapsed} milliseconds");
            Console.ReadLine();
        }
    }
}
