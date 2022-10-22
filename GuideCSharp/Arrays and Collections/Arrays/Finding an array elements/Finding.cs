using System;
namespace GuideCSharp.ArraysandCollections.Arrays.Findinganarrayelements
{
    public class Finding
    {
        public Finding()
        {
            int[] numbers = { 2, 3, 5, 7, 11, 13, 17 };
            var contain5 = numbers.Contains(5);
            //contain5 is True

            var index5 = numbers.ToList().IndexOf(5);
            //index5 is 2

            var contain10 = numbers.Contains(10);
            //contain10 is False

            Console.WriteLine("{0}, {1}, {2}", contain5, index5, contain10);
        }
    }
}

