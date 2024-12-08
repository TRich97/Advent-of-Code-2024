// See https://aka.ms/new-console-template for more information
using Day4.Input;
using Day4.Process;

Console.WriteLine("Hello, World!");
WordSearch wordSearch= new WordSearch();
var file = wordSearch.GetWordSearch();
int answer = Search.FindString(file);
Console.WriteLine($"Merry christmas again, your answer is: {answer}");
Console.ReadLine();