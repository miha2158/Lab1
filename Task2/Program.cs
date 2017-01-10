using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;

            Console.WriteLine("Number X?");
            while (!double.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Wrong number, try again");
            }
            Console.WriteLine();

            Console.WriteLine("Number Y?");
            while (!double.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine("Wrong number, try again");
            }
            Console.WriteLine();


            bool ok = (Math.Pow(x, 2) + Math.Pow(y, 2) >= 1 && x * y <= 0);
            Console.WriteLine(ok);
            
            Console.ReadKey(true);
        }
    }
}
