using Day3.Handlers;
using System;

namespace Day3.Part2
{
    public static class ProcessLogic
    {
        public static int GetAnswer(List<string> inputs)
        {
            bool doMul = true;
            const string doFunc = "do()";
            const string dontFunc = "don't()";
            List<string> processed = new List<string>();
            foreach (var input in inputs)
            {
                switch (input)
                {
                    case doFunc:
                        doMul = true;
                        break;
                    case dontFunc:
                        doMul = false;
                        break;
                    default:
                        if (doMul)
                        {
                            processed.Add(input);
                        }
                        break;
                }
            }
            return MultHandler.ProcessInput(processed);
        }
    }
}
