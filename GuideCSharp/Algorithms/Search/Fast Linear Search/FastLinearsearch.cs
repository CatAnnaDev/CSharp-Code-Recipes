using System;
using System.Collections.Generic;
using System.Linq;

namespace GuideCSharp.Algorithms.Search.FastLinearSearch
{
    public class FastLinearsearch
    {
        public FastLinearsearch()
        {
            int Search(List<int> list, int x)
            {
                var i = 0;
                var count = list.Count;
                list.Add(x);
                while (true)
                {
                    if (list[i] == x)
                        return i < count ? i : -1;
                    i++;
                }
            }

            var items = new List<int> { 2, 3, 5, 7, 11, 13, 17 };

            Console.WriteLine(Search(items, 1));
            //print -1
            Console.WriteLine(Search(items, 7));
            //print 3
            Console.WriteLine(Search(items, 19));
            //print -1

            // *** simplified speed test ***

            items = (new int[10000000]).Select((_, i) => i).ToList();
            var count = 100;

            var start = DateTime.Now;

            for (int i = 0; i < count; i++)
                Search(items, 7777777);

            var delta = DateTime.Now - start;
            var milliseconds = delta.TotalMilliseconds / count;

            Console.WriteLine(milliseconds);
            // about 60 milliseconds
        }
    }
}

