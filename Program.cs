using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double h = 0.2;
            for (double x = 0; x <= 2; x += h)
            {
                Console.WriteLine($"y={Math.Sqrt(x) / (x + 1):f2}");
            }
            
























            Console.ReadKey();
        }
    }
}
