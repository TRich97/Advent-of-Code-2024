namespace Day4.Process
{
    public static class MasSearch
    {
        public static int FindString(char[,] wordSearch)
        {
            int count = 0;
            const char A = 'A';
            for (int rowCount = 0; rowCount < wordSearch.GetLength(0); rowCount++)
            {
                for (int columnCount = 0; columnCount < wordSearch.GetLength(1); columnCount++)
                {
                    if (wordSearch[rowCount, columnCount] == A)
                    {
                        count = XSearch(wordSearch, rowCount, columnCount) ? count + 1 : count;
                    }
                }
            }
            return count;
        }

        private static bool XSearch(char[,] wordSearch, int row, int column)
        {
            const char M = 'M';
            const char S = 'S';
            int columnLength = wordSearch.GetLength(1);
            int rowLength = wordSearch.GetLength(0);
            int count = 0;
            if (column > 0 && row > 0 && column + 1 < columnLength && row + 1 < rowLength)
            { 
                // ^>
                if (wordSearch[row + 1, column - 1] == M && wordSearch[row - 1, column + 1] == S)
                {
                    count++;
                }
                // v< 
                if (wordSearch[row - 1, column + 1] == M && wordSearch[row + 1, column - 1] == S)
                {
                    count++;
                }
                // ^< 
                if (wordSearch[row + 1, column + 1] == M && wordSearch[row - 1, column - 1] == S)
                {
                    count++;
                }
                // v>
                if (wordSearch[row - 1, column - 1] == M && wordSearch[row + 1, column + 1] == S)
                {
                    count++;
                }
            }
            return count == 2;

        }

    }
}
