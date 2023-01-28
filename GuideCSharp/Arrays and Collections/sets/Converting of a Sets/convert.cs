using System;
using System.Collections.Generic;
using System.Linq;

namespace GuideCSharp.ArraysandCollections.sets.ConvertingofaSets
{
	public class convert
	{
		public convert()
		{
            var set = new HashSet<int> { 1, 2, 3 };
            var set3 = set.Select(i => i * 3).ToHashSet();

            Console.WriteLine(string.Join(", ", set3));
        }
	}
}

