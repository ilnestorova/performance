using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fibonnaci.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            const long start = 25;
            const long number = 25;

            for (long i = start; i < start + number; i++)
            {
                System.Console.WriteLine("Run {0} - {1}", i, Fibonnaci.CalculateTime(i));
            }
            System.Console.ReadKey();
        }
    }
}
