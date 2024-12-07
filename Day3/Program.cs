using Day3;
const string testPath = "C:\\Users\\efcto\\source\\repos\\Advent of Code 2024\\Day3\\input\\Test.txt";
const string path = "C:\\Users\\efcto\\source\\repos\\Advent of Code 2024\\Day3\\input\\forReal.txt";
var answer = Logic.ProcessInput(path);

Console.WriteLine($"Merry Christmas! your answer is: {answer}");


var part2Answer = Logic.ProcessPart2Input(path);
Console.WriteLine($"Merry Christmas! your second answer is: {part2Answer}");
Console.ReadLine();
//Part 2
//new regex
//add new logic handlers to determine if you run or don't
//magic