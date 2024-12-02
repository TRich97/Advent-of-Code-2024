using Day2.Logic;
//TODO: this isn't the cleanest / most efficient, come back again another day
int answer = ValidCounter.CountValidReports();

Console.WriteLine($"Merry Christmas, the answer is {answer}");

int dampAnswer = ValidCounter.CountValidDampReports();

Console.WriteLine($"Merry Christmas, the damper answer is {dampAnswer}");