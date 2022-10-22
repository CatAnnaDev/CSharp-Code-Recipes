using System;
namespace GuideCSharp.ArraysandCollections.Dictionary.Getkeybyvalue
{
	public class getKey
	{
		public getKey()
		{
            var dic = new Dictionary<int, string> {{1, "A"}, {2, "B"}, {3, "A"}};
            var valueTwo = "A";

            var keys = dic.Where(r => r.Value == valueTwo).Select(r => r.Key).ToArray();
            // keys is [1, 3]

            Console.WriteLine(string.Join("; ", keys));
        }
	}
}

