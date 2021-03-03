using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Task3
{
    class Circle : Figure
    {
        public double R { get; set; }

        public Circle(double r)
        {
            R = r;
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * R;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(R, 2);
        }

        public override void Show()
        {
            Console.WriteLine("Circle's Length {0:0.##}", Perimeter());
            Console.WriteLine("Circle's Area = {0:0.##}", Area());
        }
    }
}
