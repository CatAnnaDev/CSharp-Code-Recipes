using System;
namespace GuideCSharp.ArraysandCollections.Dictionary.getalistofkey
{
	public class GetList
	{
		public GetList()
		{
            var dic = new Dictionary<int, string> {{ 1, "one" }, { 2, "two" } };
            var keys = dic.Keys;
            //keys is {1, 2}
            Console.WriteLine(string.Join(", ", keys));
        }
	}
}

