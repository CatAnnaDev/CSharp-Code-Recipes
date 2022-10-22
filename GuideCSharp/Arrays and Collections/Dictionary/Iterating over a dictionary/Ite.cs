using System;
namespace GuideCSharp.ArraysandCollections.Dictionary.Iteratingoveradictionary
{
	public class Ite
	{
		public Ite()
		{
            var dic = new Dictionary<int, string>{ { 1, "one" }, { 2, "two" } };

            var str = "";
            foreach (var key in dic.Keys)
            {
                var value = dic[key];
                str += (str == "" ? "" : ", ") +
                $"{{ {key}, \"{value}\" }}";
            }
            //str is "{ 1, "one" }, { 2, "two" }"
            Console.WriteLine(str);

            str = "";
            foreach (var value in dic.Values)
            {
                str += (str == "" ? "" : ", ") + value;
            }
            //str is "one, two"
            Console.WriteLine(str);
        }
	}
}

