using System;
using System.Text.Json;
using System.Linq;

namespace GuideCSharp.Algorithms.Sorting.Countingsort
{
    public class CountingSort
    {
        public CountingSort()
        {
            int[] Sort(int[] arr)
            {
                var items = new int[arr.Length];

                var min = int.MaxValue;
                var max = int.MinValue;
                foreach (var x in arr)
                {
                    if (x > max) max = x;
                    if (x < min) min = x;
                }

                var counts = new int[max - min + 1];

                foreach (var x in arr)
                {
                    counts[x - min]++;
                }

                int total = 0;
                for (int i = min; i <= max; i++)
                {
                    var oldCount = counts[i - min];
                    counts[i - min] = total;
                    total += oldCount;
                }

                foreach (var x in arr)
                {
                    items[counts[x - min]] = x;
                    counts[x - min]++;
                }
                return items;
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
            // about 66 milliseconds
        }
    }
}

