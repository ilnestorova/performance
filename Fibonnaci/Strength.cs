using System;

namespace Fibonnaci
{
    public class Strength
    {
        public TimeSpan Elapsed { get; private set; }
        public long ElapsedTicks { get; private set; }
        public long Sequence { get; private set; }

        public Strength(TimeSpan elapsed, long elapsedTicks, long sequence)
        {
            Elapsed = elapsed;
            ElapsedTicks = elapsedTicks;
            Sequence = sequence;
        }
    }
}