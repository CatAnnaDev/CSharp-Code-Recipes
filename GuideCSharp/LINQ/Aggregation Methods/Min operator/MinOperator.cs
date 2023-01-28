using System;
using System.Linq;

namespace GuideCSharp.LINQ.AggregationMethods.Minoperator
{
	public class MinOperator
	{
		public MinOperator()
		{
            int[] numbers = { 1, 2, 3, 4, 5 };

            var min = numbers.Min();
            //min is 1

            var min5 = numbers.Min(n => n * 5);
            //min5 is 5

            var names = new[] {"Max", "Boris", "Alex"};
            var minLength = names.Min(s => s.Length);
            //minLength is 3

            Console.WriteLine(min);
            Console.WriteLine(min5);
            Console.WriteLine(minLength);
        }
	}
}

