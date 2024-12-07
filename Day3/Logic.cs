using Day3.Handlers;
using Day3.Part2;

namespace Day3
{
    public static class Logic
    {
        public static int ProcessInput(string path)
        {
            string input = File.ReadAllText(path);
            var calcs = RegexHandler.GetMuls(input);
            int answer = MultHandler.ProcessInput(calcs);
            return answer;
        }

        public static int ProcessPart2Input(string path)
        {
            string input = File.ReadAllText(path);
            var funcs = RegexHandler.GetFuncs(input);
            int answer = ProcessLogic.GetAnswer(funcs);
            return answer;
        }
    }
}
