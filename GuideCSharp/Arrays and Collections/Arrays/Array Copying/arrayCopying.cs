using System;
namespace GuideCSharp.ArraysandCollections.Arrays.ArrayCopying
{
    public class arrayCopying
    {
        public arrayCopying()
        {
            int[] numbers1 = { 1, 2, 3, 4, 5 };
            int[] numbers2 = new int[5];
            numbers1.CopyTo(numbers2, 0);

            foreach (var number in numbers2)
            {
                Console.WriteLine("{0} ", number);
            }
        }
    }
}

