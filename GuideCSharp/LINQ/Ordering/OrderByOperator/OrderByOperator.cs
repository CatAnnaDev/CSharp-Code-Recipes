using System;
using System.Text.Json;
using System.Linq;

namespace GuideCSharp.LINQ.Ordering.OrderByOperator
{
	public class OrderByOperator
	{
		public OrderByOperator()
		{
            var names = new[] {
                "Max", "Boris",
                "Alex", "Tom"
            };

            //first method
            var names1 = names.OrderBy(s => s);
            //names1 is {Alex, Boris, Max, Tom} 

            //second method
            var names2 =
                from s in names
                orderby s
                select s;
            //names2 is {Alex, Boris, Max, Tom} 

            Console.WriteLine(JsonSerializer.Serialize(names1));
            Console.WriteLine(JsonSerializer.Serialize(names2));
        }
	}
}

