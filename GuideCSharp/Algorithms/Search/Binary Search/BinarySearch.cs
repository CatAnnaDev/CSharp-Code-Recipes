using System;
namespace GuideCSharp.Algorithms.Search.BinarySearch
{
    public class BinarySearch
    {
        public BinarySearch()
        {
            int Search(int[] arr, int x)
            {
                var i = 0;
                var j = arr.Length;
                while (i != j)
                {
                    var m = (i + j) / 2;
                    if (x == arr[m])
                        return m;
                    if (x < arr[m])
                        j = m;
                    else
                        i = m + 1;
                }

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

