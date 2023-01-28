using System;
using System.Linq;

namespace GuideCSharp.LINQ.Quantifiers.AllOperator
{
	public class AllOperator
	{
		public AllOperator()
		{
            int[] numbers = { 1, 3, 5 };

            var all3 = numbers.All(n => n == 3);
            //all3 is False

            var allOdd = numbers.All(n => n % 2 == 1);
            //allOdd is True

            Console.WriteLine(all3);
            Console.WriteLine(allOdd);
        }
	}
}

