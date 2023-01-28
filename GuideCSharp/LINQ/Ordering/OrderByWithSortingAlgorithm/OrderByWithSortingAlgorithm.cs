using System;
using System.Text.Json;
using System.Linq;

namespace GuideCSharp.LINQ.Ordering.OrderByWithSortingAlgorithm
{
	public class OrderByWithSortingAlgorithm
	{
		public OrderByWithSortingAlgorithm()
		{
            var chars = new[] {
                "a", "A", "b", "B"
            };

            var chars1 = chars.OrderBy(s => s);
            //names1 is {a, A, b, B} 

            var chars2 = chars.OrderBy(s => s, StringComparer.Ordinal);
            //names2 is {A, B, a, b} 

            var chars3 =
                from s in chars
                orderby s.ToUpper()
                select s;
            //names3 is {a, A, b, B} 

            Console.WriteLine(JsonSerializer.Serialize(chars1));
            Console.WriteLine(JsonSerializer.Serialize(chars2));
            Console.WriteLine(JsonSerializer.Serialize(chars3));
        }
	}
}

