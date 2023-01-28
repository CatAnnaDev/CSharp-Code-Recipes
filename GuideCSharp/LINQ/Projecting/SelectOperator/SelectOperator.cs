using System;
using System.Text.Json;

namespace GuideCSharp.LINQ.Projecting.SelectOperator
{
	public class SelectOperator
	{
		public SelectOperator()
		{
            int[] numbers = { 1, 2, 3 };
            //first method
            var sNumbers = numbers.Select(n => Math.Pow(n, 2));
            //sNumbers is {1, 4, 9}

            Console.WriteLine(JsonSerializer.Serialize(sNumbers));

            //second method
            sNumbers =
                from n in numbers
                select Math.Pow(n, 2);
            //sNumbers is {1, 4, 9}

            Console.WriteLine(JsonSerializer.Serialize(sNumbers));
        }
	}
}

