using System.Diagnostics;

namespace Fibonnaci
{
    public class Fibonnaci
    {
        public static Stopwatch CalculateTime(long term)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            CalculateSequence(term);
            sw.Stop();
            return sw;
        }

        private static long Calculate(long term)
        {
            long n1 = 1;
            long n2 = 1;

            if (term > 0)
            {
                if (term <= 2) return 1;
                for (int i = 3; i < term; i++)
                {
                    if ((i & 1) == 0) n1 += n2;
                    else n2 += n1;
                }
                return n1 + n2;
            }
            return -1;
        }

        private static void CalculateSequence(long term)
        {
            for (long i = term; i >= 1; i--)
            {
                Calculate(i);
            }
        }

        public static Strength GetStrength()
        {
            long i = 1;
            while (CalculateTime(i).Elapsed.Milliseconds <= 10)
            {
                i++;
            }
            var sw = CalculateTime(i);
            return new Strength(sw.Elapsed, sw.ElapsedTicks, i);
        }
    }
}
