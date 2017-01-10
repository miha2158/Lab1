using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n;

            Console.WriteLine("Number M?");
            while (!int.TryParse(Console.ReadLine(), out m))
            {
                Console.WriteLine("Wrong number, try again");
            }
            Console.WriteLine();

            Console.WriteLine("Number N?");
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Wrong number, try again");
            }
            Console.WriteLine();

                                    
            Console.WriteLine("n={0}, m={1}, n++*m={2}", n, m, n++ * m);

            Console.WriteLine("m={0}, n={1}, m--<n = {2}", m, n, m-- < n);

            Console.WriteLine("m={0}, n={1}, ++m>n = {2}", m, n, ++m > n);


            double x;

            Console.WriteLine();
            Console.WriteLine("Number X?");
            while (!double.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Wrong number, try again");
            }
            Console.WriteLine();
            if (x >= -1)
                Console.WriteLine(Math.Pow((x + Math.Pow(Math.Abs(x), 0.25)), 0.5) + Math.Abs(x));
            else Console.WriteLine("This is not a number");
            

            Console.ReadKey(true);
        }
    }
}
