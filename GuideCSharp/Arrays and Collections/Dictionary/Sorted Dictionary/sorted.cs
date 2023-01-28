using System;
using System.Collections.Generic;

namespace GuideCSharp.ArraysandCollections.Dictionary.SortedDictionary
{
	public class sorted
	{
		public sorted()
		{
            var dic = new SortedDictionary<int, string> {{ 3, "three" }, { 1, "one" }, { 2, "two" } };

            var str = "";
            foreach (var key in dic.Keys)
            {
                var value = dic[key];
                str += (str == "" ? "" : ", ") + $"{{ {key}, \"{value}\" }}";
            }
            //str is "{ 1, "one" }, { 2, "two" }, { 3, "three" }"
            //sorted by key

            Console.WriteLine(str);
        }
	}
}

