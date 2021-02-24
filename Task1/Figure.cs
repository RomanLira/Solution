using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Task1
{
    public abstract class Figure
    {
        public abstract string Name { get; }

        public abstract double Perimeter();

        public abstract double Area();

        public abstract void Show();
    }
}
