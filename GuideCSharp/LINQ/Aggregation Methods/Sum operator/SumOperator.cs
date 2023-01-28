using System;
using System.Linq;

namespace GuideCSharp.LINQ.AggregationMethods.Sumoperator
{
	public class SumOperator
	{
		public SumOperator()
		{
            int[] numbers = { 1, 2, 3, 4, 5 };

            var sum = numbers.Sum();
            //sum is 15

            var sum5 = numbers.Sum(n => n * 5);
            //sum5 is 75

            var names = new[] {"Max", "Boris", "Alex"};
            var sumOfLengths = names.Sum(s => s.Length);
            //sumOfLengths is 14

            Console.WriteLine(sum);
            Console.WriteLine(sum5);
            Console.WriteLine(sumOfLengths);
        }
	}
}

