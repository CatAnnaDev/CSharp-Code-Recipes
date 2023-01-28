using System;
using System.Text.Json;

namespace GuideCSharp.LINQ.ElementOperators.DefaultIfEmptyOperator
{
	public class DefaultIfEmptyOperator
	{
		public DefaultIfEmptyOperator()
		{
            int[] numbers = { 1, 2, 3, 4, 5 };

            var evens = numbers.Where(n => n % 2 == 0).DefaultIfEmpty();
            //evens is {2, 4}

            var moreThen10 = numbers.Where(n => n > 10).DefaultIfEmpty();
            //moreThen10 is {0}

            Console.WriteLine(JsonSerializer.Serialize(evens));
            Console.WriteLine(JsonSerializer.Serialize(moreThen10));
        }
	}
}

