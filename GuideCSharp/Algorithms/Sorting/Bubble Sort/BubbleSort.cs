using System;
using System.Text.Json;
using System.Linq;

namespace GuideCSharp.Algorithms.Sorting.BubbleSort
{
    public class BubbleSort
    {
        public BubbleSort()
        {
            static int[] Sort(int[] arr)
            {
                var items = new int[arr.Length];
                arr.CopyTo(items, 0);
                for (int i = 0; i < items.Length; i++)
                {
                    for (int j = i + 1; j < items.Length; j++)
                    {
                        if (items[j] < items[i])
                        {
                            var tmp = items[j];
                            items[j] = items[i];
                            items[i] = tmp;
                        }
                    }
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
            // about 1466 milliseconds
        }
    }
}

