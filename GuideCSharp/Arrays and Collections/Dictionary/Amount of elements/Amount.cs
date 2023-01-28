using System;
using System.Collections.Generic;

namespace GuideCSharp.ArraysandCollections.Dictionary.Amountofelements
{
	public class Amount
	{
		public Amount()
		{
            var dic = new Dictionary<int, string> {{ 1, "one" }, { 2, null } };

            var count = dic.Count;
            //count is 2
            Console.WriteLine(count);
        }
	}
}

