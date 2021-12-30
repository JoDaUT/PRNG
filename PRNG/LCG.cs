using System;

namespace PRNG
{
    //Linear Congruential Generator implementation
    public class LCG
    {
        double seed;
        private readonly double multiplier;
        private readonly double increment;
        private readonly double modulus;

        public LCG()
        {
            this.seed = DateTime.Now.Ticks;
            this.multiplier = 83939;
            this.increment = 30911;
            this.modulus = int.MaxValue;
        }
        public LCG(double seed, double multiplier, double increment, double modulus)
        {
            this.seed = seed;
            this.multiplier = multiplier;
            this.increment = increment;
            this.modulus = modulus;
        }
        public double NextNumber()
        {
            double number = (this.multiplier * this.seed + this.increment) % this.modulus;

            this.seed = number;
            return number;
        }
        public double NextNumber(int min, int max)
        {
            return this.NextNumber() % (max-min+1) + min;
        }
        public double[] RandomArray(int size)
        {
            double[] array = new double[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = this.NextNumber();
            }
            return array;
        }
        public double[] RandomArray(int size, int min, int max)
        {
            double[] array = new double[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = this.NextNumber(min, max);
            }
            return array;
        }

    }
}
