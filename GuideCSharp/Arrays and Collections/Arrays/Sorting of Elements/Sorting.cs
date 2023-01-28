using System;
using System.Linq;

namespace GuideCSharp.ArraysandCollections.Arrays.SortingofElements
{
    public class Sorting
    {
        public Sorting()
        {
            int[] numbers = { 11, 2, 5, 7, 3 };

            //the first method
            Array.Sort(numbers);
            //numbers is { 2, 3, 5, 7, 11 }
            Console.WriteLine(string.Join(", ", numbers));

            //the second method using System.Linq
            numbers = numbers.OrderBy(i => i).ToArray();
            //numbers is { 2, 3, 5, 7, 11 }
            Console.WriteLine(string.Join(", ", numbers));

            //descending
            numbers = numbers.OrderByDescending(i => i).ToArray();
            //numbers is { 11, 7, 5, 3, 2 }
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}

