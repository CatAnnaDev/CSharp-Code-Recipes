using System;
using System.Text.Json;

namespace GuideCSharp.LINQ.Projecting.UnionWithSelectMany
{
	public class UnionWithSelectMany
	{
		public UnionWithSelectMany()
		{
            string[] names = { "Max", "Tom", "Anna" };
            var teams =
                from name1 in names
                from name2 in names
                where name1.CompareTo(name2) > 0
                select name1 + " and " + name2;
            //teams is { "Max and Anna",
            //           "Tom and Max",
            //           "Tom and Anna" }

            Console.WriteLine(JsonSerializer.Serialize(teams));
        }
	}
}

