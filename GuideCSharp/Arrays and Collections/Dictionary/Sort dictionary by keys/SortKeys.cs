using System;
using System.Text.Json;

namespace GuideCSharp.ArraysandCollections.Dictionary.Sortdictionarybykeys
{
	public class SortKeys
	{
		public SortKeys()
		{
            var dic = new Dictionary<int, string> {{3, "three"}, {1, "one"}, {2, "two"}};

            var list = dic.ToList();
            list.Sort((pair1, pair2) =>
                pair1.Key.CompareTo(pair2.Key));
            //list is {{1, "one"}, {2, "two"}, {3, "tree"}}

            Console.WriteLine(JsonSerializer.Serialize(list));
        }
	}
}

