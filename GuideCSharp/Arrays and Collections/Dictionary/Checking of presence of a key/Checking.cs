using System;
using System.Collections.Generic;

namespace GuideCSharp.ArraysandCollections.Dictionary.Checkingofpresenceofakey
{
	public class Checking
	{
		public Checking()
		{
            var dic = new Dictionary<int, string> {{ 1, "one" }, { 2, null }};
            var exists1 = dic.ContainsKey(1);
            //exists1 is True

            var exists2 = dic.ContainsKey(2);
            //exists2 is True

            var exists3 = dic.ContainsKey(3);
            //exists3 is False

            Console.WriteLine("{0}, {1}, {2}", exists1, exists2, exists3);
        }
	}
}

