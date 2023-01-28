using System;
namespace GuideCSharp.LINQ.AggregationMethods.averageoperator
{
	public class AverageOperator
	{
		public AverageOperator()
		{
            int[] numbers = { 1, 2, 3, 4, 5 };

            var avg = numbers.Average();
            //avg is 3

            var avg5 = numbers.Average(n => n * 5);
            //avg5 is 15

            var names = new[] {"Ivan", "Boris", "Alexey"};
            var avgLength = names
                .Average(s => s.Length);
            //avgLength is 5

            Console.WriteLine(avg);
            Console.WriteLine(avg5);
            Console.WriteLine(avgLength);

        }
    }
}

