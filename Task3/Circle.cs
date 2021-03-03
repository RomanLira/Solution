﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Task3
{
    class Circle : Figure
    {
        private double r;

        public double R
        {
            get
            {
                return r;
            }
            set
            {
                if (value <= 0)
                    Console.WriteLine("Invalid value ");
                else
                    r = value;
            }
        }

        public Circle(double r)
        {
            R = r;
        }

        public override string Name
        {
            get { return nameof(Circle); }
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * r;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(r, 2);
        }

        public override void Show()
        {
            Console.WriteLine("Circle's Length {0:0.##}", Perimeter());
            Console.WriteLine("Circle's Area = {0:0.##}", Area());
        }
    }
}
