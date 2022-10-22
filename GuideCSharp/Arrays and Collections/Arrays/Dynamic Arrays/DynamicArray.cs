using System;
namespace GuideCSharp.ArraysandCollections.Arrays.DynamicArrays
{
    public class DynamicArray
    {
        public DynamicArray()
        {
            int count = 15;
            int[] arInt = new int[count];
            arInt[0] = 1;

            Console.WriteLine(arInt[0]);
        }
    }
}

