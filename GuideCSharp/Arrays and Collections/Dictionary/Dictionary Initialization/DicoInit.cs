using System;
using System.Text.Json;
using System.Collections.Generic;

namespace GuideCSharp.ArraysandCollections.Dictionary.DictionaryInitialization
{
	public class DicoInit
	{
		public DicoInit()
		{
            //Empty dictionary
            var d1 = new Dictionary<int, string>();
            Console.WriteLine(d1.Count);

            //init with some data
            var d2 = new Dictionary<int, string> {{1, "one"}, {2, "two"}};

            Console.WriteLine(JsonSerializer.Serialize(d2));
        }
	}
}

