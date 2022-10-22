using System;
namespace GuideCSharp.ArraysandCollections.Dictionary.Getofalistofvalue
{
	public class GetOf
	{
		public GetOf()
		{
            var dic = new Dictionary<int, string>{{ 1, "one" }, { 2, "two" } };
            var values = dic.Values;
            //values is {"one", "two"}
            Console.WriteLine(string.Join(", ", values));
        }
	}
}

