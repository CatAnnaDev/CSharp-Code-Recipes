using System;
namespace GuideCSharp.ArraysandCollections.Arrays.Iteratingoveranarray
{
    public class Iterating
    {
        public Iterating()
        {
            int[] numbers = { 2, 3, 5, 7, 11, 13, 17 };
            var str = "";
            foreach (var number in numbers)
            {
                str += (str == "" ? "" : "; ") + number;
            }
            //str is "2; 3; 5; 7; 11; 13; 17"

            Console.WriteLine(str);
        }
    }
}

