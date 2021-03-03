using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Task9
{
    class CompareTeams<T> : IComparer<T>
        where T : Team
    {
        public int Compare(T x, T y)
        {
            if (x.Points < y.Points)
                return 1;
            if (x.Points > y.Points)
                return -1;
            else
                return 0;
        }
    }
}
