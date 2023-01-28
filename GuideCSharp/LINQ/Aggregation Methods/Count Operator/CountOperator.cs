using System;
namespace GuideCSharp.LINQ.AggregationMethods.CountOperator
{
	public class CountOperator
	{
		public CountOperator()
		{
            int[] numbers = { 1, 2, 3, 4, 5 };

            var count = numbers.Count();
            //count is 5

            var evenCount = numbers.Count(n => n % 2 == 0);
            //evenCount is 2

            var digitCount = "7a7a7".Count(char.IsDigit);
            //digitCount is 3

            Console.WriteLine(count);
            Console.WriteLine(evenCount);
            Console.WriteLine(digitCount);
        }
	}
}

