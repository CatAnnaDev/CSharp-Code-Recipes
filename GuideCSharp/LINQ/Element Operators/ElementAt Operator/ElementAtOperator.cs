using System;
using System.Linq;

namespace GuideCSharp.LINQ.ElementOperators.ElementAtOperator
{
	public class ElementAtOperator
	{
		public ElementAtOperator()
		{
            int[] numbers = { 1, 2, 3, 4, 5 };

            int second = numbers.ElementAt(1);
            //second is 2

            //int seventh = numbers.ElementAt(6); //<-Error

            int seventhDefault = numbers.ElementAtOrDefault(6);
            //seventhDefault is 0

            Console.WriteLine(second);
            Console.WriteLine(seventhDefault);
        }
	}
}

