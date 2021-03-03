using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Task9
{
    class Team
    {
        public string Name { get; set; }
        public int Points { get; set; }

        public Team (string name, int points)
        {
            this.Name = name;
            this.Points = points;
        }

        public override string ToString()
        {
            return string.Format("{0} have {1} points now.", Name, Points);
        }
    }
}
