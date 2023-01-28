using System;
using System.Linq;

namespace GuideCSharp.LINQ.AggregationMethods.Aggregateoperator
{
	public class AggregateOperator
	{
		public AggregateOperator()
		{
            int[] numbers = { 1, 2, 3, 4, 5 };

            int sum = numbers.Aggregate(0, (seed, n) => seed + n);
            //sum is 15

            int sumFrom10 = numbers.Aggregate(10, (seed, n) => seed + n);
            //sum is 25

            var str = numbers.Aggregate("", (seed, n) => seed + n + "; ");
            //str is "1; 2; 3; 4; 5;"

            Console.WriteLine(sum);
            Console.WriteLine(sumFrom10);
            Console.WriteLine(str);
        }
	}
}

