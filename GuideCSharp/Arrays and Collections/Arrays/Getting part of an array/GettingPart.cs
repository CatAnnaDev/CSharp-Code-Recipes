using System;
namespace GuideCSharp.ArraysandCollections.Arrays.Gettingpartofanarray
{
    public class GettingPart
    {
        public GettingPart()
        {
            int[] numbers = { 2, 3, 5, 7, 11 };
            var first2 = numbers.Take(2).ToArray();
            //first2 is [ 2, 3 ] 
            var last3 = numbers.Skip(2).Take(3);
            //last3 is [ 5, 7, 11 ]

            var last2 = new int[2];
            Array.Copy(numbers, 3, last2, 0, 2);
            //last2 is [ 7, 11 ]

            //C# 8 feature
            var first3 = numbers[..3];
            //first3 is [ 2, 3, 5 ]

            var last4 = numbers[^4..];
            //last4 is [ 3, 5, 7, 11 ]

            Console.WriteLine("first2: " + string.Join(", ", first2));
            Console.WriteLine("last3: " + string.Join(", ", last3));
            Console.WriteLine("last2: " + string.Join(", ", last2));
            Console.WriteLine("first3: " + string.Join(", ", first3));
            Console.WriteLine("last4: " + string.Join(", ", last4));
        }
    }
}

