using System;
using System.Collections.Generic;

namespace GuideCSharp.ArraysandCollections.sets.searchforaelement
{
	public class Search
	{
		public Search()
		{
            var chars = new HashSet<Char> { 'A', 'B', 'C', 'D' };
            var containA = chars.Contains('A');
            //containA is True

            var containE = chars.Contains('E');
            //containE is False

            var chars2 = new HashSet<Char> { 'A', 'B' };
            var containAll = chars.IsSupersetOf(chars2);
            //containAll is True

            Console.WriteLine("{0} - {1} - {2}", containA, containE, containAll);
        }
	}
}

