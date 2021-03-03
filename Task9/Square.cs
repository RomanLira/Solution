using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Task9
{
    class Square:IComparable
    {
        public int Side { get; set;}
        public int Area { get; set; }

        public Square (int side)
        {
            this.Side = side;
            Area = side * side;
        }

        public int CompareTo(object obj)
        {
            if (obj == null)
                return 1;
            Square otherSquare = obj as Square;
            if (otherSquare != null)
                return otherSquare.Area.CompareTo(this.Area);
            else
                throw new ArgumentException("aaa");
        }

        public override string ToString()
        {
            return string.Format("Square with side {0} has Area: {1}", Side, Area);
        }
    }
}
