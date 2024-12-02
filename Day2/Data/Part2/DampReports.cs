namespace Day2.Data.Part2
{
    public class DampReports
    {
        private List<int> _reports;
        public DampReports(List<int> reports) 
        { 
            _reports = reports;
        }

        public bool IsSafe()
        {
            bool increasing = IsIncreasing(_reports[0], _reports[1]);
            int difference = 0;
            int strikeLimit = 2;
            int strikeCount = 0;
            int counter = 1;

            while( counter < _reports.Count && strikeCount < strikeLimit)
            {
                difference = Math.Abs(_reports[counter] - _reports[counter - 1]);

                if (difference > 3 || difference < 1) 
                { 
                    _reports.RemoveAt(counter);
                    if (counter == 1)
                    {
                        increasing = IsIncreasing(_reports[0], _reports[1]);
                    }
                    strikeCount ++;
                    continue;
                }

                if (_reports[counter - 1] < _reports[counter] != increasing)
                {
                    _reports.RemoveAt(counter);
                    if (counter == 1)
                    {
                        increasing = IsIncreasing(_reports[0], _reports[1]);
                    }
                    strikeCount ++;
                    continue;
                }
                counter++;
            }
            return strikeCount < 2;
        }

        private bool IsIncreasing(int start, int second)
        {
            return start < second;
        }
    }
}
