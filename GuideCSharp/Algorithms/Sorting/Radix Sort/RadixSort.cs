using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Linq;

namespace GuideCSharp.Algorithms.Sorting.RadixSort
{
    public class RadixSort
    {
        public RadixSort()
        {
            List<int>[] ListToBuckets(int[] items, int cBase, int i)
            {
                var buckets = new bool[cBase]
                    .Select(e => new List<int>()).ToArray();

                var pBase = (int)Math.Pow(cBase, i);
                foreach (var x in items)
                {
                    //Isolate the base-digit from the number
                    var digit = (x / pBase) % cBase;
                    //Drop the number into the correct bucket
                    buckets[digit].Add(x);
                }

                return buckets;
            }

            int[] BucketsToList(List<int>[] buckets)
            {
                var result = new List<int>();

                foreach (var bucket in buckets)
                {
                    //add the numbers in a bucket
                    //sequentially to the returned array
                    result.AddRange(bucket);
                }

                return result.ToArray();
            }

            int[] Sort(int[] arr, int cBase = 10)
            {
                var maxVal = arr.Max();
                int i = 0;

                while (Math.Pow(cBase, i) <= maxVal)
                {
                    arr = BucketsToList(ListToBuckets(arr, cBase, i));
                    i++;
                }

                return arr;
            }

            var items = new[] { 4, 1, 5, 3, 2 };

            var sortItems = Sort(items);
            // sortItems is {1, 2, 3, 4, 5}
            Console.WriteLine(JsonSerializer.Serialize(sortItems));

            // *** simplified speed test ***
            items = (new int[200]).Select((_, i) => i).ToArray();
            var tmp = items[5];
            items[5] = items[6];
            items[6] = tmp;
            var count = 10000;
            var start = DateTime.Now;

            for (int i = 0; i < count; i++)
                Sort(items);

            var delta = DateTime.Now - start;
            var milliseconds = delta.TotalMilliseconds;

            Console.WriteLine(milliseconds);
            // about 312 milliseconds
        }
    }
}

