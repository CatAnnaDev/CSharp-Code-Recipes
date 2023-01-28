using System;
using System.Collections.Generic;

namespace GuideCSharp.Initializingoftypes.Collections.set
{
	public class CollHashSet
	{
		public CollHashSet()
		{
            //HashSet 
            var intSet = new HashSet<int> { 2, 3, 5, 7, 11, 13, 17, 19 };

            Console.WriteLine(intSet);
        }
	}
}

