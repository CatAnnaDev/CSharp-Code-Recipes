using System;
using System.Collections.Generic;

namespace GuideCSharp.ArraysandCollections.Dictionary.GetValuebykey
{
	public class GetValue
	{
		public GetValue()
		{
            var dic = new Dictionary<int, string> {{ 1, "one" }, { 2, null }};

            string one = dic[1];
            //one is "one"

            string two = dic[2];
            //two is null

            string three = dic[3]; //<-Error

            Console.WriteLine("{0}, {1}, {2}", one, two, three);
        }
	}
}

