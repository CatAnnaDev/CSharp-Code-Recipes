using System;
namespace GuideCSharp.ArraysandCollections.Arrays.Iteratingoveranarraywithindex
{
    public class IteratingwithIndex
    {
        public IteratingwithIndex()
        {
            int[] numbers = { 2, 3, 5, 7, 11, 13, 17 };
            var str = "";
            for (int i = 0; i < numbers.Length; i++)
            {
                str += numbers[i];
                if (i < numbers.Length - 1)
                {
                    str += "; ";
                }
            }
            //str is "2; 3; 5; 7; 11; 13; 17"

            Console.WriteLine(str);
        }
    }
}

