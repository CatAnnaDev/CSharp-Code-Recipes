using System;
using System.Linq;

namespace GuideCSharp.ArraysandCollections.Arrays.GettingMinandMaxvalue
{
    public class Getting
    {
        public Getting()
        {
            int[] numbers = { 2, 3, 5, 7, 11 };
            var min = numbers.Min();
            //min is 2
            var max = numbers.Max();
            //max is 11

            Console.WriteLine(min);
            Console.WriteLine(max);
        }
    }
}

