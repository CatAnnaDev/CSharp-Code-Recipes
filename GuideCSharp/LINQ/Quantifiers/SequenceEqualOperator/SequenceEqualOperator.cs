using System;
namespace GuideCSharp.LINQ.Quantifiers.SequenceEqualOperator
{
	public class SequenceEqualOperator
	{
		public SequenceEqualOperator()
		{
            int[] numbers1 = { 1, 3, 5 };
            int[] numbers2 = { 1, 3, 5 };
            int[] numbers3 = { 5, 3, 1 };
            var list1 = new List<int> { 1, 3, 5 };

            var equal1 = numbers1.SequenceEqual(numbers2);
            //equal1 is True

            var equal2 = numbers1.SequenceEqual(numbers3);
            //equal2 is False

            var equal3 = numbers1.SequenceEqual(list1);
            //equal2 is True

            Console.WriteLine(equal1);
            Console.WriteLine(equal2);
            Console.WriteLine(equal3);
        }
	}
}

