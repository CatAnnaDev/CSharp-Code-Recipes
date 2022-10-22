using System;
namespace GuideCSharp.ArraysandCollections.Arrays.Convertingofanarray
{
    public class Convert
    {
        public Convert()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            numbers = numbers.Select(i => i * 3).ToArray();
            //numbers is { 3, 6, 9, 12, 15 }

            foreach (var number in numbers)
            {
                Console.WriteLine("{0}", number);
            }
        }
    }
}

