namespace Day4.Input
{
    public class WordSearch
    {
        private char[,] wordSearch;

        public WordSearch()
        {
            const string testPath = "C:\\Users\\efcto\\source\\repos\\Advent of Code 2024\\Day4\\Input\\Test.txt";
            const string path = "C:\\Users\\efcto\\source\\repos\\Advent of Code 2024\\Day4\\Input\\TheBigOne.txt";
            PopulateWordSearch(path);
        }

        public char[,] GetWordSearch() { return wordSearch; }

        private void PopulateWordSearch(string path)
        {
            string[] lines = File.ReadAllLines(path);
            wordSearch = new char[lines.First().Length, lines.Count()];
            int rowCount = 0;
            foreach (string line in lines)
            {
                int colCount = 0;
                char[] chars = line.ToCharArray();
                foreach (char c in chars)
                {
                    wordSearch[rowCount, colCount] = c;
                    colCount++;
                }
                rowCount++;
            }
        }
    }
}
