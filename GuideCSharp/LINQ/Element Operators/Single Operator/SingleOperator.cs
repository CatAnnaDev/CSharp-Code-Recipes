using System;
namespace GuideCSharp.LINQ.ElementOperators.SingleOperator
{
	public class SingleOperator
	{
		public SingleOperator()
		{
            int[] numbers = { 1, 2, 3, 4, 5 };

            //int single = numbers.Single();
            //Error, more than one item

            //int singleEven = numbers.Single(n => n % 2 == 0);
            //Error, more than one item

            int singleDiv3 = numbers.Single(n => n % 3 == 0);
            //singleDiv3 is 3

            //int singleMore10 = numbers.Single(n => n > 10);
            //Error, there are no items

            int singleDefaultMore10 = numbers.SingleOrDefault(n => n > 10);
            //singleDefaultMore10 is 0

            Console.WriteLine(singleDiv3);
            Console.WriteLine(singleDefaultMore10);
        }
	}
}

