using System;
using System.Collections.Generic;
using System.Collections.Generic.RedBlack;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Console.Benchmark.Find
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack<string>();
            var tree = new RedBlackTree<string, string>();
            var dict = new Dictionary<string, string>();

            for (int i = 0; i < 1000000; i++)
            {
                stack.Push(Guid.NewGuid().ToString());
            }

            var sw = new Stopwatch();
            sw.Start();
            foreach (string item in stack)
            {
                tree.Add(item, item);
            }
            sw.Stop();
            System.Console.WriteLine("{0}", sw.Elapsed);

            sw.Reset();
            sw.Start();
            foreach (string item in stack)
            {
                dict.Add(item, item);
            }
            sw.Stop();
            System.Console.WriteLine("{0}", sw.Elapsed);

            sw.Reset();
            sw.Start();
            foreach (string item in stack)
            {
                tree.ContainsKey(item);
            }
            sw.Stop();
            System.Console.WriteLine("{0}", sw.Elapsed);

            sw.Reset();
            sw.Start();
            foreach (string item in stack)
            {
                dict.ContainsKey(item);
            }
            sw.Stop();
            System.Console.WriteLine("{0}", sw.Elapsed);

            System.Console.ReadKey();
        }
    }
}
