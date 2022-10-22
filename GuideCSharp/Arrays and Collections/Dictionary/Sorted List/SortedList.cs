using System;
namespace GuideCSharp.ArraysandCollections.Dictionary.SortedList
{
	public class SortedList
	{
		public SortedList()
		{
            var dic = new SortedList<int, string> {{ 3, "three" }, { 1, "one" }, { 2, "two" }};

            var str = "";
            foreach (var key in dic.Keys)
            {
                var value = dic[key];
                str += (str == "" ? "" : ", ") +
                $"{{ {key}, \"{value}\" }}";
            }
            //str is "{ 1, "one" }, { 2, "two" }, { 3, "three" }"
            //sorted by key

            Console.WriteLine(str);
        }
	}
}

