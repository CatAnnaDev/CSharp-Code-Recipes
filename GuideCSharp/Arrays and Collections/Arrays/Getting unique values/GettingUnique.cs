using System;
namespace GuideCSharp.ArraysandCollections.Arrays.Gettinguniquevalues
{
    public class GettingUnique
    {
        public GettingUnique()
        {
            int[] numbers = { 1, 3, 2, 1, 3 };
            var unique = numbers.Distinct().ToArray();
            //unique is {1, 3, 2}

            foreach (var number in unique)
            {
                Console.WriteLine("{0}", number);
            }
        }
    }
}

