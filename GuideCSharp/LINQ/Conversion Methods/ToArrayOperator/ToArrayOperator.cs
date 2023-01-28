using System;
using System.Text.Json;
using System.Linq;

namespace GuideCSharp.LINQ.ConversionMethods.ToArrayOperator
{
	public class ToArrayOperator
	{
		public ToArrayOperator()
		{
            int[] numbers = { 1, 2, 3, 4, 5 };
            int[] even = numbers.Where(i => i % 2 == 0).ToArray();
            //even is {2, 4}

            Console.WriteLine(JsonSerializer.Serialize(even));
        }
	}
}

