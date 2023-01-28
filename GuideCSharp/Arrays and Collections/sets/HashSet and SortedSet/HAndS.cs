using System;
using System.Collections.Generic;

namespace GuideCSharp.ArraysandCollections.sets.HashSetandSortedSet
{
	public class HAndS
	{
		public HAndS()
		{
            var chars = new HashSet<char> { 'B', 'A', 'D', 'C' };
            var str = "";
            foreach (var c in chars)
            {
                str += (str == "" ? "" : "; ") + c;
            }
            //str is "B; A; D; C"
            Console.WriteLine(str);

            var sortedChars = new SortedSet<char> { 'B', 'A', 'D', 'C' };
            str = "";
            foreach (var c in sortedChars)
            {
                str += (str == "" ? "" : "; ") + c;
            }
            //str is "A; B; C; D"
            Console.WriteLine(str);

            var maxValue = sortedChars.Max;
            //maxValue is 'D'

            var minValue = sortedChars.Min;
            //maxValue is 'A'

            Console.WriteLine("{0}, {1}", maxValue, minValue);
        }
	}
}

