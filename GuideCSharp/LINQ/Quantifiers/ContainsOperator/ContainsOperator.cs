using System;
namespace GuideCSharp.LINQ.Quantifiers.ContainsOperator
{
	public class ContainsOperator
	{
		public ContainsOperator()
		{
            int[] numbers = { 1, 3, 5 };

            var contains3 = numbers.Contains(3);
            //contains3 is True

            var contains7 = numbers.Contains(7);
            //contains7 is False

            Console.WriteLine(contains3);
            Console.WriteLine(contains7);
        }
	}
}

