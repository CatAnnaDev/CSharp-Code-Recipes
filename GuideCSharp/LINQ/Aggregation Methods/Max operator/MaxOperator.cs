using System;
namespace GuideCSharp.LINQ.AggregationMethods.Maxoperator
{
	public class MaxOperator
	{
		public MaxOperator()
		{
            int[] numbers = { 1, 2, 3, 4, 5 };

            var max = numbers.Max();
            //max is 5

            var max5 = numbers.Max(n => n * 5);
            //max5 is 25

            var names = new[] {"Max", "Boris", "Alex"};
            var maxLength = names.Max(s => s.Length);
            //maxLength is 6

            Console.WriteLine(max);
            Console.WriteLine(max5);
            Console.WriteLine(maxLength);
        }
	}
}

