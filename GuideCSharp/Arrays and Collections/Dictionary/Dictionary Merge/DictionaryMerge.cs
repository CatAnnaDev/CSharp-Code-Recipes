using System;
using System.Text.Json;

namespace GuideCSharp.ArraysandCollections.Dictionary.DictionaryMerge
{
	public class DictionaryMerge
	{
		public DictionaryMerge()
		{
            var d1 = new Dictionary<int, string> { { 1, "one" } };
            var d2 = new Dictionary<int, string> { { 2, "two" } };
            var d3 = new Dictionary<int, string> { { 3, "three" } };

            var dAll = d1.Concat(d2).Concat(d3).ToDictionary(p => p.Key, p => p.Value);

            Console.WriteLine(JsonSerializer.Serialize(dAll));
        }
	}
}

