using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Task1
{
    class Triangle : Figure
    {
        public double a;
        public double b;
        public double c;
        string name = "triangle";

        public double A
        {
            get
            {
                return a;
            }
            set
            {
                if (value <= 0)
                    Console.WriteLine("Invalid value ");
                else
                    a = value;
            }
        }

        public double B
        {
            get
            {
                return b;
            }
            set
            {
                if (value <= 0)
                    Console.WriteLine("Invalid value ");
                else
                    b = value;
            }
        }

        public double C
        {
            get
            {
                return c;
            }
            set
            {
                if (value <= 0)
                    Console.WriteLine("Invalid value ");
                else
                    c = value;
            }
        }

        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public override string Name
        {
            get { return name; }
        }

        public override double Perimeter()
        {
            return a + b + c;
        }

        public override double Area()
        {
            double p = Perimeter() / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public override void Show()
        {
            Console.WriteLine("Triangle's Perimeter = {0}", Perimeter());
            Console.WriteLine("Triangle's Area = {0:0.##}", Area());
        }
    }
}
