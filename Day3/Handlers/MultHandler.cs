namespace Day3.Handlers
{
    public static class MultHandler
    {
        public static int ProcessInput(List<string> input)
        {
            int output = 0;
            foreach (var mul in input)
            {
                int[] ints = Translate(mul);
                output += Multiply(ints);
            }
            return output;
        }
        //This class will handle the parsing of the Mult values
        //will read in the two numbers, and multiply them

        private static int[] Translate(string match)
        {
            int openParenthesesIndex = match.IndexOf('(');
            int commaIndex = match.IndexOf(',');
            int closedParenthesesIndex = match.IndexOf(')');
            string firstNumber = match.Substring(openParenthesesIndex + 1, commaIndex - openParenthesesIndex - 1);
            string secondNumber = match.Substring(commaIndex + 1, closedParenthesesIndex - commaIndex - 1);
            int[] ints = new int[2];
            ints[0] = int.Parse(firstNumber);
            ints[1] = int.Parse(secondNumber);
            return ints;
        }

        private static int Multiply(int[] input)
        {
            return input[0] * input[1];
        }
    }
}
