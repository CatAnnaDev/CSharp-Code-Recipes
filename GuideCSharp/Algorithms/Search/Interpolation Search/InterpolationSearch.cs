using System;
using System.Linq;

namespace GuideCSharp.Algorithms.Search.InterpolationSearch
{
    public class InterpolationSearch
    {
        public InterpolationSearch()
        {
            long Search(int[] arr, long x)
            {
                long low = 0;
                long high = arr.Length - 1;

                while ((arr[low] < x) && (x < arr[high]))
                {
                    var mid = low + ((x - arr[low]) * (high - low)) / (arr[high] - arr[low]);

                    if (arr[mid] < x)
                        low = mid + 1;
                    else if (arr[mid] > x)
                        high = mid - 1;
                    else
                        return mid;
                }

                if (arr[low] == x)
                    return low;
                if (arr[high] == x)
                    return high;
                return -1;
            }

            var items = new[] { 2, 3, 5, 7, 11, 13, 17 };

            Console.WriteLine(Search(items, 1));
            //print -1
            Console.WriteLine(Search(items, 7));
            //print 3
            Console.WriteLine(Search(items, 19));
            //print -1

            // *** simplified speed test ***

            items = (new int[10000000]).Select((_, i) => i).ToArray();
            var count = 100;

            var start = DateTime.Now;

            for (int i = 0; i < count; i++)
                Search(items, 7777777);

            var delta = DateTime.Now - start;
            var milliseconds = delta.TotalMilliseconds / count;

            Console.WriteLine(milliseconds);
            // less than one millisecond
        }
    }
}

