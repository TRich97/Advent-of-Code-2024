using Day2.Data.Part1;
using System.Collections.Generic;

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
            int counter = 1;

            while( counter < _reports.Count)
            {
                difference = Math.Abs(_reports[counter] - _reports[counter - 1]);

                if (difference > 3 || difference < 1)
                {
                    return Dampener(counter);                   
                }

                if (_reports[counter - 1] < _reports[counter] != increasing)
                {
                    return Dampener(counter);                   
                }
                counter++;
            }
            return true;
        }

        private bool Dampener(int pos1)
        {
            int pos2 = pos1 - 1;
            List<int> test1 = new List<int>(_reports);
            
            test1.RemoveAt(pos1);
            List<int> test2 = new List<int>(_reports);
            test2.RemoveAt(pos2);

            Reports possibility1 = new Reports(test1);
            Reports possibility2 = new Reports(test2);

            if (possibility1.IsSafe())
            {
                _reports.RemoveAt(pos1);
                return true;
            }
            else if (possibility2.IsSafe())
            {
                _reports.RemoveAt(pos2);
                return true;
            }
            else
            {
                //all hope is lost
                return false;
            }

        }

        private bool IsIncreasing(int start, int second)
        {
            return start < second;
        }
    }
}
