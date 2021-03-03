using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solution.Task1;
using Solution.Task3;
using Solution.Task8;
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

            int y = 123;
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            object o = y;
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedTicks);

            stopwatch.Start();
            y = (int)o;
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedTicks);
            #endregion
            #region(Task 3)
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Task 3");
            Console.ResetColor();

            Car[] cars = new Car[3] // массив машин с разными типами
            {
                new Car("Passenger car"),
                new Car("Truck car"),
                new Car("Racing car"),
            };

            AutoPark ap = new AutoPark(cars); // отправляем в AutoPark для перечисления
            foreach (Car car in ap)
                Console.WriteLine(car.type); // вывод типов машин

            var getenum = ap.GetEnumerator();
            while (getenum.MoveNext())
            {
                Console.WriteLine(getenum.Current.type);
            }
            #endregion

            #region(Task 8)
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Task 8");
            Console.ResetColor();

            Random rand = new Random();
            Storage[] products = new Storage[100];
            for (int i = 0; i < 100; i++)
            {
                products[i] = new Storage(GenerateString(rand, 7), rand.Next(0, 100));
                //Console.WriteLine(products[i]);
            }

            var Availability1 = products.All(product => product.Number > 0);
            var Availability2 = products.Any(product => product.Number == 0);
            if (Availability1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("All products are in Storage");
                Console.ResetColor();
            }
            if (Availability2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Missing in Storage: ");
                Console.ResetColor();

                var MissingProducts = from product in products
                                      where product.Number == 0
                                      select product;

                foreach (var product in MissingProducts)
                {
                    Console.WriteLine(product.ToString());
                }
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Sort by quantity: ");
            Console.ResetColor();
            var SortProducts = from product in products
                               orderby product.Number
                               group product by product.Number;
            foreach (IGrouping<int, Storage> product in SortProducts)
            {
                Console.Write(product.Key + ": ");
                foreach (var p in product)
                    Console.Write("{0} ", p.Text);
                Console.WriteLine();
            }

            var SumProducts = products.Sum(product => product.Number);
            Console.WriteLine("\nSum of all products in Storage: {0}", SumProducts);

            var MinProducts = products.Min(product => product.Number);
            Console.WriteLine("\nMinimum number of product: {0}", MinProducts);

            var MaxProducts = products.Max(product => product.Number);
            Console.WriteLine("\nMaximum number of product: {0}", MaxProducts);
        }
        #endregion

        public static char GenerateChar(Random rand)
        {
            return (char)(rand.Next('a', 'z' + 1));
        }

        public static string GenerateString(Random rand, int n)
        {
            char[] names = new char[n];
            for (int i = 0; i < n; i++)
            {
                names[i] = GenerateChar(rand);
            }
            return new string(names);
        }
    }
}

