namespace Day2.Data.Part1
{
    public class Reports
    {
        private List<int> _reports;

        public Reports(List<int> reports)
        {
            _reports = reports;
        }

        public bool IsSafe()
        {
            bool increasing = _reports[0] < _reports[1];
            int difference = 0;
            for (int count = 1; count < _reports.Count; count++)
            {
                difference = Math.Abs(_reports[count] - _reports[count - 1]);

                if (difference > 3 || difference < 1) { return false; }

                if (_reports[count - 1] < _reports[count] != increasing)
                {
                    return false;
                }
            }
            return true;
        }

    }
}
