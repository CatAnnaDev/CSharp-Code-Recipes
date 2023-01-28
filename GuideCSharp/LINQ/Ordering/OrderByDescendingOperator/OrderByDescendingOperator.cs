using System;
using System.Text.Json;
using System.Linq;

namespace GuideCSharp.LINQ.Ordering.OrderByDescendingOperator
{
	public class OrderByDescendingOperator
	{
		public OrderByDescendingOperator()
		{
            var names = new[] {
                "Max", "Boris",
                "Alex", "Tom"
            };

            //first method
            var names1 = names.OrderByDescending(s => s);
            //names1 is {Tom, Max, Boris, Alex}

            //second method
            var names2 =
                from s in names
                orderby s.Length, s descending
                select s;
            //names2 is {Tom, Max, Alex, Boris} 

            Console.WriteLine(JsonSerializer.Serialize(names1));
        }
	}
}

