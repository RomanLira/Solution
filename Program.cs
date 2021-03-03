using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Solution.Task3;
using Solution.Task7;
using Solution.Task8;
using Solution.Task9;
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
            #region(Task 3)
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Task 3");
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
            #region(Task 6)
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Task 6");
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
            #region(Task 7)
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Task 7");
            Console.ResetColor();

            Car[] cars = new Car[3]
            {
                new Car("Passenger car"),
                new Car("Truck car"),
                new Car("Racing car"),
            };

            AutoPark ap = new AutoPark(cars);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("'Foreach': ");
            Console.ResetColor();
            foreach (Car car in ap)
                Console.WriteLine(car.type);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("'While': ");
            Console.ResetColor();
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
            Console.WriteLine();
            #endregion
            #region(Task 9)
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Task 9");
            Console.ResetColor();

            ArrayList squares = new ArrayList();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Current ArrayList:");
            Console.ResetColor();
            for (int i = 0; i < 10; i++)
            {
                int side = rand.Next(1, 11);
                Square square = new Square(side);
                squares.Add(square);
                Console.WriteLine(squares[i]);
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Sort ArrayList:");
            Console.ResetColor();
            squares.Sort();
            foreach (var square in squares)
                Console.WriteLine(square.ToString());

            CompareTeams<Team> comparerteams = new CompareTeams<Team>();
            List<Team> teams = new List<Team>();

            teams.Add(new Team("FC Barcelona", 45));
            teams.Add(new Team("Real Madrid CF", 47));
            teams.Add(new Team("Sevilla FC", 38));
            teams.Add(new Team("Valencia CF", 25));
            teams.Add(new Team("Atletico Madrid", 52));
            teams.Add(new Team("Real Sociedad", 40));

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Current TeamList");
            Console.ResetColor();
            foreach (var t in teams)
            {
                Console.WriteLine(t.ToString());
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Sort TeamList by points:");
            Console.ResetColor();
            teams.Sort(comparerteams);
            foreach (var t in teams)
                Console.WriteLine(t.ToString());
            #endregion
        }

        #region(Generations)
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
        #endregion
    }
}

