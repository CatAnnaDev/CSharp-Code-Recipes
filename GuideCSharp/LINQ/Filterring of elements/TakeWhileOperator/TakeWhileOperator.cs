using System;
using System.Text.Json;
using System.Linq;

namespace GuideCSharp.LINQ.Filterringofelements.TakeWhileOperator
{
	public class TakeWhileOperator
	{
		public TakeWhileOperator()
		{
            int[] numbers = { 1, 2, 3, 11, 4, 5 };
            var fNumbers = numbers.TakeWhile(n => n < 10);
            //fNumbers is {1, 2, 3}

            Console.WriteLine(JsonSerializer.Serialize(fNumbers));
        }
	}
}

