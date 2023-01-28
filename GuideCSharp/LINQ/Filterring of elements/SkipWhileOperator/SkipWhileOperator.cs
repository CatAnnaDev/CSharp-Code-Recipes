using System;
using System.Text.Json;
using System.Linq;

namespace GuideCSharp.LINQ.Filterringofelements.SkipWhileOperator
{
	public class SkipWhileOperator
	{
		public SkipWhileOperator()
		{
            int[] numbers = { 1, 2, 3, 11, 4, 5 };
            var fNumbers = numbers.SkipWhile(n => n < 10);
            //fNumbers is {11, 4, 5}

            Console.WriteLine(JsonSerializer.Serialize(fNumbers));

        }
    }
}

