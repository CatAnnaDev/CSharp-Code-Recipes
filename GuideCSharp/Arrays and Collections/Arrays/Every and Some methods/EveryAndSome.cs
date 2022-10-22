using System;
namespace GuideCSharp.ArraysandCollections.Arrays.EveryandSomemethods
{
    public class EveryAndSome
    {
        public EveryAndSome()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            var allLess10 = numbers.All(i => i < 10);
            //allLess10 is true

            var someMore3 = numbers.Any(i => i > 3);
            //someMore3 is true

            var allOdd = numbers.All(i => i % 2 == 1);
            //allOdd is false

            Console.WriteLine(allLess10);
            Console.WriteLine(someMore3);
            Console.WriteLine(allOdd);
        }
    }
}

