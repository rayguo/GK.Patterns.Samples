using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            Console.WriteLine("Divisor:");
            int divisor = int.Parse(Console.ReadLine());
            Console.WriteLine();

            // When will iteration take place?
            // Will iteration be repeated twice?

            IEnumerable<int> sequence1 = GetInts(ints, divisor);
            IEnumerable<int> sequence2 = sequence1.Where
                (i => i % (divisor * 2) == 0);
            IEnumerable<int> sequence3 = sequence2.Reverse();

            foreach (var i in sequence3)
            {
                Console.WriteLine(i);
            }
        }

        static IEnumerable<int> GetInts(int[] ints, int divisor)
        {
            foreach (var i in ints)
            {
                if (i % divisor == 0)
                {
                    Console.WriteLine("int: {0}", i);
                    yield return i;
                }
            }
        }
    }
}
