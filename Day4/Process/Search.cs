namespace Day4.Process
{
    public static class Search
    {
        private static char[] MAS = { 'M', 'A', 'S' };

        public static int FindString(char[,] wordSearch)
        {
            int count = 0;
            for (int rowCount = 0; rowCount < wordSearch.GetLength(0); rowCount++)
            {
                for (int columnCount = 0; columnCount < wordSearch.GetLength(1); columnCount++)
                {
                    if (wordSearch[rowCount, columnCount] == 'X')
                    {
                        count = HorizontalSearch(rowCount, columnCount, wordSearch)  ? count + 1 : count;
                        count = VerticalSearch(rowCount, columnCount, wordSearch) ? count + 1 : count;
                        count = DiagonalSearch(rowCount, columnCount, wordSearch) ? count + 1 : count;
                        count = ReverseHorizontalSearch(rowCount, columnCount, wordSearch) ? count + 1 : count;
                        count = ReverseVerticalSearch(rowCount, columnCount, wordSearch) ? count + 1 : count;
                        count = ReverseDiagonalSearch(rowCount, columnCount, wordSearch) ? count + 1 : count;
                        count = DLDiagonalSearch(rowCount, columnCount, wordSearch) ? count + 1 : count;
                        count = URDiagonalSearch(rowCount, columnCount, wordSearch) ? count + 1 : count;
                    }
                }
            }
            return count;
        }

        private static bool HorizontalSearch(int row, int column, char[,] wordSearch)
        {
            int count = 1;
            bool found = true;
            int columnLength = wordSearch.GetLength(1);
            if ( columnLength <= column + 3)
            {
                //can't fit
                return false;
            }
            foreach (char c in MAS)
            {
                if (wordSearch[row, column + count] == c)
                {
                    count++;
                    continue;
                }
                else 
                { 
                    return false;
                }
            }
            return found;
        }

        private static bool VerticalSearch(int row, int column, char[,] wordSearch)
        {
            int count = 1;
            int rowLength = wordSearch.GetLength(0);
            bool found = true;
            if (rowLength <= row + 3)
            {
                //can't fit
                return false;
            }
            foreach (char c in MAS)
            {
                if (wordSearch[row + count, column] == c)
                {
                    count++;
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return found;
        }

        private static bool DiagonalSearch(int row, int column, char[,] wordSearch)
        {
            bool found = true;
            int rowLength = wordSearch.GetLength(0);
            int columnLength = wordSearch.GetLength(1);
            int count = 1;
            if (row + 3 >= rowLength || column + 3 >= columnLength)
            {
                return false;
            }
            foreach (char c in MAS)
            {
                if (wordSearch[row + count, column + count] == c)
                {
                    count++;
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return found;
        }

        private static bool ReverseHorizontalSearch(int row, int column, char[,] wordSearch)
        {
            int count = 1;
            bool found = true;
            if (column - 3 < 0)
            {
                //can't fit
                return false;
            }
            foreach (char c in MAS)
            {
                if (wordSearch[row, column - count] == c)
                {
                    count++;
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return found;
        }

        private static bool ReverseVerticalSearch(int row, int column, char[,] wordSearch)
        {
            int count = 1;
            bool found = true;
            if (row - 3 < 0)
            {
                //can't fit
                return false;
            }
            foreach (char c in MAS)
            {
                if (wordSearch[row - count, column] == c)
                {
                    count++;
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return found;
        }

        private static bool ReverseDiagonalSearch(int row, int column, char[,] wordSearch)
        {
            bool found = true;
            int count = 1;
            if (row - 3 < 0 || column - 3 < 0)
            {
                return false;
            }
            foreach (char c in MAS)
            {
                if (wordSearch[row - count, column - count] == c)
                {
                    count++;
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return found;
        }

        private static bool DLDiagonalSearch(int row, int column, char[,] wordSearch)
        {
            bool found = true;
            int rowLength = wordSearch.GetLength(0);
            int columnLength = wordSearch.GetLength(1);
            int count = 1;
            if (row + 3 >= rowLength || column - 3 < 0)
            {
                return false;
            }
            foreach (char c in MAS)
            {
                if (wordSearch[row + count, column - count] == c)
                {
                    count++;
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return found;
        }

        private static bool URDiagonalSearch(int row, int column, char[,] wordSearch)
        {
            bool found = true;
            int rowLength = wordSearch.GetLength(0);
            int columnLength = wordSearch.GetLength(1);
            int count = 1;
            if (row - 3 < 0 || column + 3 >= columnLength)
            {
                return false;
            }
            foreach (char c in MAS)
            {
                if (wordSearch[row - count, column + count] == c)
                {
                    count++;
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return found;
        }
    }
}
