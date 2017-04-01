using System;

namespace Exercise1
{
    using System.Diagnostics.Contracts;

    public class Randomizer
    {
        private int min, max;
        [ContractInvariantMethod]
        private void MinShouldBeLessThanMax()
        {
            Contract.Invariant(min < max);
        }

        public Randomizer(int min, int max)
        {
            this.min = min;
            this.max = max;
        }

        public int GetRandomFromRangeContracted(int localMin, int localMax)
        {
            Contract.Requires<ArgumentOutOfRangeException>(
                localMin < localMax,
                "Min must be less than localMax"
            );

            Contract.Ensures(
                Contract.Result<int>() >= localMin &&
                Contract.Result<int>() <= localMax,
                "Return value is out of range"
            );

            var rnd = new Random();
            return rnd.Next(localMin, localMax);
        }

        public int GetRandomFromRange()
        {
            var rnd = new Random();
            return rnd.Next(min, max);
        }
    }
}
