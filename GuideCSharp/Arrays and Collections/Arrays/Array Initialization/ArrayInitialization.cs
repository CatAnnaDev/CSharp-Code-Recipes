using System;
namespace GuideCSharp.ArraysandCollections.Arrays.ArrayInitialization
{
    public class ArrayInitialization
    {
        public ArrayInitialization()
        {
            //Empty array
            var n1 = new int[] { };
            int[] n2 = { };

            // Single-dimensional array
            int[] n3 = new int[] { 1, 2, 3 };
            int[] n4 = { 1, 2, 3 };
            var n5 = new[] { 1, 2, 3 };
            var s1 = new[] { "1", "2", "3" };

            // Multidimensional array.
            int[,] n6 = { { 1, 2 }, { 3, 4 } };
            var n7 = new[,] { { 1, 2, 3 }, { 3, 4, 5 } };
            n7[1, 2] = 7;

            // Jagged array
            int[][] n8 = { new[] { 1, 2 }, new[] { 3, 4, 5 } };
            n8[1][2] = 7;
        }
    }
}

