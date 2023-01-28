using System;
using System.Collections.Generic;
using System.Linq;

namespace GuideCSharp.ArraysandCollections.sets.Setscomparison
{
	public class compare
	{
		public compare()
		{
            var first = new HashSet<int> { 1, 2 };
            var second = new HashSet<int> { 1, 2 };
            var third = new HashSet<int> { 1, 2, 3 };

            var isEqual = first.IsSubsetOf(second) && second.IsSubsetOf(first);
            //isEqual is true

            var isIntersects = first.Intersect(third).Any();
            //isIntersects is true

            var isSubset = third.IsSubsetOf(first);
            //isSubset is false

            Console.WriteLine(isEqual);
            Console.WriteLine(isIntersects);
            Console.WriteLine(isSubset);
        }
	}
}

