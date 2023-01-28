using System;
using System.Linq;

namespace GuideCSharp.LINQ.Quantifiers.AnyOperator
{
	public class AnyOperator
	{
		public AnyOperator()
		{
            int[] numbers = { 1, 3, 5 };

            var notEmpty = numbers.Any();
            //notEmpty is True

            var contains3 = numbers.Any(n => n == 3);
            //contains3 is True

            var contains7 = numbers.Any(n => n == 7);
            //contains7 is False

            var lessThan10 = numbers.Any(n => n < 10);
            //lessThan10 is True

            var moreThan10 = numbers.Any(n => n > 10);
            //moreThan10 is False

            Console.WriteLine(notEmpty);
            Console.WriteLine(contains3);
            Console.WriteLine(contains7);
            Console.WriteLine(lessThan10);
            Console.WriteLine(moreThan10);
        }
	}
}

