using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Task3
{
    class Triangle : Figure
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public override double Perimeter()
        {
            return A+B+C;
        }

        public override double Area()
        {
            double p = Perimeter() / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        public override void Show()
        {
            Console.WriteLine("Triangle's Perimeter = {0}", Perimeter());
            Console.WriteLine("Triangle's Area = {0:0.##}", Area());
        }
    }
}
