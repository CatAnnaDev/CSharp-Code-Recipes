using System;
namespace GuideCSharp.ArraysandCollections.Arrays.Checkingequalityofarrays
{
    public class Checking
    {
        public Checking()
        {
            int[] n1 = { 1, 2, 3 };
            int[] n2 = { 1, 2, 3 };
            int[] n3 = { 3, 2, 1 };

            var equal1 = n1.SequenceEqual(n2);
            //equal1 is True

            var equal2 = n1.SequenceEqual(n3);
            //equal2 is False

            Console.WriteLine("{0}, {1}", equal1, equal2);
        }
    }
}

