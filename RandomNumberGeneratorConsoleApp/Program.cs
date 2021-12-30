using System;
using PRNG;
namespace PRNG
{
    internal class Program
    {
        static void Main(string[] args)
        {
       
            LCG rnd = new();
            double[] array = rnd.RandomArray(size: 20, min: 1, max: 20);
            foreach (double n in array)
            {
                Console.WriteLine(n);
            }

        }
    }
}
