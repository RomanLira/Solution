using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Task1
{
    public class Rectangle : Figure
    {//Поля не должны быть public, и лучше,если они начинаются с _
        public double a;
        public double b;
        string name = "rectangle";

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

        public Rectangle(double a, double b)
        {
            A = a;
            B = b;
        }

        public override string Name
        {
            get { return name; }
        }

        public override double Perimeter()
        {
            return 2 * (a + b);
        }

        public override double Area()
        {
            return a * b;
        }

        public override void Show()
        {
            Console.WriteLine("Rectangle's Perimeter = {0}", Perimeter());
            Console.WriteLine("Rectangle's Area = {0}", Area());
        }
    }
}
