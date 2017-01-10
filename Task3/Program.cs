using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Double
            double a = 10, b = 0.01;


            double r1 = Math.Pow((a + b), 4) - Math.Pow(a, 4);
            double r2 = 6 * Math.Pow((a * b), 2) + 4 * a * Math.Pow(b, 3) + Math.Pow(b, 4) + 4 * b * Math.Pow(a, 3);                        
            double res1 = r1 / r2;

            Console.WriteLine("double - {0}",res1);
            #endregion Double

            #region Float
            float fa = 10, fb = 0.01f;

            float fr1 = (float)Math.Pow((fa + fb), 4) - (float)Math.Pow(fa, 4);
            float fr2 = 6 * (float)Math.Pow((fa * fb), 2) + 4 * fa * (float)Math.Pow(fb, 3) + (float)Math.Pow(fb, 4) + 4 * fb * (float)Math.Pow(fa, 3);
            float res2 = fr1 / fr2;

            Console.WriteLine("float - {0}", res2);
            #endregion Float

            Console.ReadKey(true);
        }
    }
}