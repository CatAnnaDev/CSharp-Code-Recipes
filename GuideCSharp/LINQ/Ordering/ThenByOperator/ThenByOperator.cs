using System;
using System.Text.Json;
using System.Linq;

namespace GuideCSharp.LINQ.Ordering.ThenByOperator
{
	public class ThenByOperator
	{
		public ThenByOperator()
		{
            var names = new[] {
                "Max", "Boris", "Alex", "Tom"
            };

            //first method
            var names1 = names.OrderBy(s => s.Length).ThenBy(s => s);
            //names1 is {Max, Tom, Alex, Boris}  

            //second method
            var names2 =
                from s in names
                orderby s.Length, s
                select s;
            //names2 is {Max, Tom, Alex, Boris}  

            Console.WriteLine(JsonSerializer.Serialize(names1));
            Console.WriteLine(JsonSerializer.Serialize(names2));
        }
	}
}

