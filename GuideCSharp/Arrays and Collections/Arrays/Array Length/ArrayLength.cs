using System;
namespace GuideCSharp.ArraysandCollections.Arrays.ArrayLength
{
    public class ArrayLength
    {
        public ArrayLength()
        {
            int[] array = { 1, 2, 3, 4 };
            var arLength = array.Length;
            //arLength is 4

            var list = new List<int> { 1, 2, 3 };
            var listLength = list.Count;
            //listLength is 3

            Console.WriteLine(arLength);
            Console.WriteLine(listLength);
        }
    }
}

