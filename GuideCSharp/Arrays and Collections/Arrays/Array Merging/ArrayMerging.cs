using System;
namespace GuideCSharp.ArraysandCollections.Arrays.ArrayMerging
{
    public class ArrayMerging
    {
        public ArrayMerging()
        {
            int[] firstNumbers = { 2, 3, 5 };
            int[] secondNumbers = { 7, 11, 13 };

            int[] allNumbers = firstNumbers.Union(secondNumbers).ToArray();
            //allNumbers is { 2, 3, 5, 7, 11, 13 }

            foreach (var number in allNumbers)
            {
                Console.WriteLine("{0}", number);
            }
        }
    }
}

