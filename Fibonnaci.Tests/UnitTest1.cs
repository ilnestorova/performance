using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fibonnaci.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            for (int i = 50; i < 100; i++)
            {
                RunSequence(i);
            }
        }

        private static void RunSequence(long x)
        {
            long result1 = Fibonnaci.CalculateTime(x).ElapsedTicks;
            Debug.WriteLine("Time: {0} - {1}", x, result1);
        }

        [TestMethod]
        public void TestStrength()
        {
            var str = Fibonnaci.GetStrength();
            Debug.WriteLine("Elapsed {0} Ticks {1} Sequence {2}", str.Elapsed, str.ElapsedTicks, str.Sequence);
        }
    }
}
