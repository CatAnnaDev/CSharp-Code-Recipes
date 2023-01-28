using System;
using System.Text.Json;
using System.Collections.Generic;
using System.Linq;

namespace GuideCSharp.ArraysandCollections.Dictionary.Sortdictionarybyvalues
{
	public class Sortvalue
	{
		public Sortvalue()
		{
            var dic = new Dictionary<int, string> { { 3, "B" }, { 1, "C" }, { 2, "A" } };

            var list = dic.ToList();
            list.Sort((pair1, pair2) => string.Compare(pair1.Value, pair2.Value, StringComparison.Ordinal));
            //list is  {{2, "A"}, {3, "B"}, {1, "C"}}

            Console.WriteLine(JsonSerializer.Serialize(list));
        }
	}
}

