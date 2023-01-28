using System;
using System.Text.Json;
using System.Linq;

namespace GuideCSharp.LINQ.Filterringofelements.DistinctOperator
{
	public class DistinctOperator
	{
		public DistinctOperator()
		{
            int[] numbers = { 1, 2, 3, 2, 1, 0 };
            var fNumbers = numbers.Distinct();
            //fNumbers is {1, 2, 3, 0}

            Console.WriteLine(JsonSerializer.Serialize(fNumbers));
        }
	}
}

