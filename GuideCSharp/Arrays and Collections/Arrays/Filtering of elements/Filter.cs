using System;
namespace GuideCSharp.ArraysandCollections.Arrays.Filteringofelements
{
    public class Filter
    {
        public Filter()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            var oddItems = numbers.Where(i => i % 2 == 1).ToArray();
            //oddItems is { 1, 3, 5 }

            foreach (var i in oddItems)
            {
                Console.WriteLine(i);
            }
        }
    }
}

