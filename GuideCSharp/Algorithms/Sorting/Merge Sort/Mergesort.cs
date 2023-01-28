using System;
using System.Text.Json;
using System.Linq;

namespace GuideCSharp.Algorithms.Sorting.MergeSort
{
    public class Mergesort
    {
        public Mergesort()
        {
            int[] Sort(int[] arr)
            {
                var items = new int[arr.Length];
                arr.CopyTo(items, 0);
                DoSort(items);
                return items;
            }

            void DoSort(int[] items)
            {
                if (items.Length == 1)
                    return;

                var lLeft = items.Length / 2;
                var left = new int[lLeft];
                Array.Copy(items, left, lLeft);
                var lRight = items.Length - lLeft;
                var right = new int[lRight];
                Array.Copy(items, lLeft, right, 0, lRight);

                DoSort(left);
                DoSort(right);

                Merge(left, right, items);
            }

            void Merge(int[] left, int[] right, int[] result)
            {
                int l = 0;
                int r = 0;
                int i = 0;

                while (l < left.Length && r < right.Length)
                {
                    if (left[l] < right[r])
                    {
                        result[i] = left[l];
                        l++;
                    }
                    else
                    {
                        result[i] = right[r];
                        r++;
                    }
                    i++;
                }
                var len = left.Length - l;
                Array.Copy(left, l, result, i, len);
                Array.Copy(right, r, result,
                    i + len, right.Length - r);
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
            // about 670 milliseconds
        }
    }
}

