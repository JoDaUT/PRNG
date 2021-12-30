using System;
using PRNG;
namespace PRNG
{
    internal class Program
    {
        static void Main(string[] args)
        {
       
            LCG rnd = new(seed:0,multiplier:1,increment:1,modulus:0);
            //double[] array = rnd.RandomArray(size: 20, min: 1, max: 20);
            //foreach (double n in array)
            //{
            //    Console.WriteLine(n);
            //}
            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine(rnd.NextNumber());
            }

        }
    }
}
