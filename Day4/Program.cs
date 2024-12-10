// See https://aka.ms/new-console-template for more information
using Day4.Input;
using Day4.Process;

Console.WriteLine("Hello, World!");
WordSearch wordSearch= new WordSearch();
var file = wordSearch.GetWordSearch();
int answer = Search.FindString(file);
Console.WriteLine($"Merry christmas, your answer is: {answer}");


int part2Answer  = MasSearch.FindString(file);
Console.WriteLine($"Merry christmas again, your second answer is: {part2Answer}");
Console.ReadLine();