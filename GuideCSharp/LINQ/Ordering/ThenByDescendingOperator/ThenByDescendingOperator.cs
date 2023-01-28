using System;
using System.Text.Json;

namespace GuideCSharp.LINQ.Ordering.ThenByDescendingOperator
{
	public class ThenByDescendingOperator
	{
		public ThenByDescendingOperator()
		{
            var names = new[] {
                "Max", "Boris", "Alex", "Tom"
            };

            //first method
            var names1 = names.OrderBy(s => s.Length).ThenByDescending(s => s);
            //names1 is {Tom, Max, Alex, Boris}  

            //second method
            var names2 =
                from s in names
                orderby s.Length, s descending
                select s;
            //names2 is {Tom, Max, Alex, Boris}  

            Console.WriteLine(JsonSerializer.Serialize(names1));
            Console.WriteLine(JsonSerializer.Serialize(names2));
        }
	}
}

