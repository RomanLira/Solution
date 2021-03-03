using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Task3
{
    public class Rectangle : Figure
    {
        public double A { get; set; }
        public double B { get; set; }

        public Rectangle(double a, double b)
        {
            A = a;
            B = b;
        }

        public override double Perimeter()
        {
            return 2 * (A + B);
        }

        public override double Area()
        {
            return A * B;
        }

        public override void Show()
        {
            Console.WriteLine("Rectangle's Perimeter = {0}", Perimeter());
            Console.WriteLine("Rectangle's Area = {0}", Area());
        }
    }
}
