using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solution.Task1;
using Solution.Task3;
using System.Threading;
using System.Diagnostics;

namespace Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure F;
            int k;
            double a, b, c, r;
            #region(Task 1)
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Task 1");
            Console.ResetColor();

            Console.WriteLine("What's figure? 1 - Rectangle, 2 - Circle, 3 - Triangle");
            k = Convert.ToInt16(Console.ReadLine());
            switch (k)
            {
                #region(Rectangle)
                case 1:
                    Console.WriteLine("Rectangle selected");
                    Console.WriteLine("Enter Rectangle's sides: ");
                    Console.Write("Length: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Width: ");
                    b = Convert.ToDouble(Console.ReadLine());
                    F = new Rectangle(a, b);
                    F.Perimeter();
                    F.Area();
                    F.Show();
                    break;
                #endregion
                #region(Circle)
                case 2:
                    Console.WriteLine("Circle selected");
                    Console.Write("Enter Circle's radius: ");
                    r = Convert.ToDouble(Console.ReadLine());
                    F = new Circle(r);
                    F.Perimeter();
                    F.Area();
                    F.Show();
                    break;
                #endregion
                #region(Triangle)
                case 3:
                    Console.WriteLine("Triangle selected");
                    Console.WriteLine("Enter Triangle's sides: ");
                    Console.Write("Side А: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Side В: ");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Side C: ");
                    c = Convert.ToDouble(Console.ReadLine());
                    F = new Triangle(a, b, c);
                    F.Perimeter();
                    F.Area();
                    F.Show();
                    break;
                #endregion
                default: break;
            }
            #endregion
            #region(Task 2)
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Task 2");
            Console.ResetColor();

            int i = 123;
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            object o = i;
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedTicks);

            stopwatch.Start();
            i = (int)o;
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedTicks);
            #endregion
            #region(Task 3)
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Task 3");
            Console.ResetColor();

            Car[] cars = new Car[3]
            {
                new Car("Passenger car"),
                new Car("Truck car"),
                new Car("Racing car"),
            };

            AutoPark ap = new AutoPark(cars);
            foreach (Car car in ap)
                Console.WriteLine(car.type);
            #endregion
        }
    }
}

